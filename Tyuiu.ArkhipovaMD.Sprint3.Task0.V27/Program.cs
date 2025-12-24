using Tyuiu.ArkhipovaMD.Sprint3.Task0.V27.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #27                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");

int value = 2;
int startValue = 1;
int stopValue = 5;

Console.WriteLine("Переменная n: " + value);
Console.WriteLine("Старт шага: " + startValue);
Console.WriteLine("Конец шага: " + stopValue);

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

Console.WriteLine(ds.GetSumSeries(value, startValue, stopValue));