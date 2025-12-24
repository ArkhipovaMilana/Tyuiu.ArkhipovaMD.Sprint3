using Tyuiu.ArkhipovaMD.Sprint3.Task2.V4.Lib;

DataService ds=new DataService();

Console.Title = "Спринт #3 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");

int startValue = 1;
int stopValue = 5;

Console.WriteLine("Старт шага: " + startValue);
Console.WriteLine("Конец шага: " + stopValue);

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

Console.WriteLine(ds.GetMultiplySeries(startValue, stopValue));