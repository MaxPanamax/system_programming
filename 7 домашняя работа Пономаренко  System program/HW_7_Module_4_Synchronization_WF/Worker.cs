using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW_7_Module_4_Synchronization_WF
{
    public class Worker
    {
        public struct Report
        {
            public int countNumber;
            public long sizeFile;
            public string fileСontent;
        }

        private static string[] fileNames = { "Thread1.txt", "Thread2.txt", "Thread3.txt" };
        Random random = new Random();
        private Mutex mutex1;
        private Mutex mutex2;
        private Mutex mutex3;

        public Worker()
        {
            mutex1 = new Mutex();
            mutex2 = new Mutex();
            mutex3 = new Mutex();
        }

        public void Start(object numberOperation)
        {
            switch ((int)numberOperation)
            {
                case 0:
                    mutex1.WaitOne();
                    Work1();
                    mutex1.ReleaseMutex();
                    break;
                case 1:
                    mutex2.WaitOne();
                    Work2();
                    mutex2.ReleaseMutex();
                    break;
                case 2:
                    mutex3.WaitOne();
                    Work3();
                    mutex3.ReleaseMutex();
                    break;
            }
        }
        //Поток 1. 
        private void Work1()
        {
            WorkBegin(Thread.CurrentThread.Name + " начал свою работу");
            Thread.Sleep(3000);
            using (StreamWriter writer = new StreamWriter(fileNames[0], false))
            {
                for (int i = 0; i < 100000; i++)
                {
                    int number1 = random.Next(0, 1000);
                    int number2 = random.Next(0, 1000);
                    string line = String.Concat(number1, ';', number2);
                    writer.WriteLine(line);
                }
            }
            WorkBegin(Thread.CurrentThread.Name + " завершил свою работу");
        }

        //Поток 2.
        private void Work2()
        {
            mutex1.WaitOne();
            WorkBegin(Thread.CurrentThread.Name + " начал свою работу");
            Thread.Sleep(3000);
            using (StreamWriter writer = new StreamWriter(fileNames[1], false))
            {
                using (StreamReader reader = new StreamReader(fileNames[0]))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] arr = line.Split(';');
                        writer.WriteLine(Summ(arr));
                    }
                }
            }
        }
        //Поток 3.
        public void Work3()
        {
            mutex2.WaitOne();
            WorkBegin(Thread.CurrentThread.Name + " начал свою работу");
            Thread.Sleep(3000);
            using (StreamWriter writer = new StreamWriter(fileNames[2], false))
            {
                using (StreamReader reader = new StreamReader(fileNames[0]))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] arr = line.Split(';');
                        ulong number = ulong.Parse(arr[0]) * ulong.Parse(arr[1]);
                        writer.WriteLine(number.ToString());
                     
                    }
                }
            }
            WorkEnd(Thread.CurrentThread.Name + " завершил свою работу");
            WorkEnd("Happy end");
        }

        public static List<Report> ShowStatistic()
        {
            List<Report> reports = new List<Report>();
            if (File.Exists(fileNames[0]) && File.Exists(fileNames[1]) && File.Exists(fileNames[2]))
            {
                for (int i = 0; i < fileNames.Length; i++)
                {
                    FileInfo fileInfo = new FileInfo(fileNames[i]);
                    reports.Add(new Report
                    {
                        countNumber = File.ReadAllLines(fileNames[i]).Length,
                        sizeFile = fileInfo.Length,
                        fileСontent = File.ReadAllText(fileNames[i])
                    });
                }
                return reports;
            }
            else
                throw new FileNotFoundException("Нет необходимые файлов для генерации отчета");
        }

        //Функция проверки является ли число простым
        private bool checkPrimeNumber(ulong number)
        {
            if (number < 2)
                return false;
            for (ulong i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //функция суммы

        private string Summ(string[] str)
        {      
            int s;
            s=Convert.ToInt32(str[0]) +Convert.ToInt32(str[1]);
            return  s.ToString();
        }
        public event Action<string> WorkBegin;
        public event Action<string> WorkEnd;
    }

}
