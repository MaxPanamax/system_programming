//Функции
//манипулирования 
//процессами 



using System.Diagnostics;

//устанавливаем заголовок консоли
Console.Title = "Список процессов";
//изменяем размер буфера консоли и окна на
//необходимые нам
Console.WindowWidth = 40;
Console.BufferWidth = 40;
//получаем список процессов
Process[] processes = Process.GetProcesses();
//выводим заголовок
Console.WriteLine(" {0,-28}{1,-10}", "Имяпроцесса: ","PID: ");
//для каждого процесса выводим имя и PID
foreach (Process p in processes)
    Console.Write(" {0,-28}{1,-10}", p.ProcessName, p.Id);

////Обьевляем обьект класса
//Process proc = new Process();
//proc.StartInfo.FileName = "notepad.exe";
//proc.Start();
//Console.WriteLine("Запущен процесс: " + proc.ProcessName);
//proc.WaitForExit();
////выводим код, с которым завершился процесс
//Console.WriteLine("Процесс завершился с кодом: " +proc.ExitCode);
////выводим имя текущего процесса
//Console.WriteLine("Текущий процесс имеет имя: " +Process.GetCurrentProcess().ProcessName);

