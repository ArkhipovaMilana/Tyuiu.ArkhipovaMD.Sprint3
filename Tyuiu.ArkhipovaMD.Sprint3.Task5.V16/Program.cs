using Tyuiu.ArkhipovaMD.Sprint3.Task5.V16.Lib;
DataService ds = new DataService();



Console.Title = "Спринт #3 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #16                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");

int x = 2;
int startvalue1 = 1;
int startvalue2 = 1;
int stopvalue1 = 3;
int stopvalue2 = 10;

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

Console.WriteLine(ds.GetSumSumSeries(x, startvalue1, startvalue2, stopvalue1, stopvalue2));