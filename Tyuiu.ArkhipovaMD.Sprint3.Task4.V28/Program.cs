using Tyuiu.ArkhipovaMD.Sprint3.Task4.V28.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #28                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");

int startValue = 1;
int stopValue = 5;


Console.WriteLine("Старт шага: " + startValue);
Console.WriteLine("Конец шага: " + stopValue);

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

Console.WriteLine(ds.Calculate( startValue, stopValue));