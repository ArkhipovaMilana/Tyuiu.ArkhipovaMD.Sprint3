using Tyuiu.ArkhipovaMD.Sprint3.Task1.V4.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");

int a = 2;
int b = 1;

Console.WriteLine("Переменная 1 : " + a);
Console.WriteLine("Переменная 2 : " + b);

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

Console.WriteLine(ds.GetSumSeries(a, b));