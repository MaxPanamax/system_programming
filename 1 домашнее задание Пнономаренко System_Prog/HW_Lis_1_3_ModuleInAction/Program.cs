!!!!!!!!!!!!! Неработает!!!!!!!!!!!!!!
//загружаем сборку
using System.Reflection;

Assembly asm = Assembly.Load(AssemblyName.
GetAssemblyName("HW_Lis_1_3_Bibliotek.dll"));
//получаем необходимый модуль этой сборки
Module mod = asm.GetModule("HW_Lis_1_3_Bibliotek.dll");
//выводим список типов данных, объявленный в текущем модуле
Console.WriteLine("Объявленные типы данных:");
foreach (Type t in mod.GetTypes())
    Console.WriteLine(t.FullName);
//получаем тип данных из сборки
Type Person = mod.GetType("HW_Lis_1_3_Bibliotek.Person") as  Type;
//создаём объект полученного типа данных
object person = Activator.CreateInstance(Person,new object[] { "Иван", "Иванов", 30 });
//вызываем метод Print от созданного объекта
Person.GetMethod("Print").Invoke(person, null);