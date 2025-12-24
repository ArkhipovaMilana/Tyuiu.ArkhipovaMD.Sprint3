using Tyuiu.ArkhipovaMD.Sprint3.Task7.V13.Lib;


DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #13                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");

int startValue = 1;
int stopValue = 5;

Console.WriteLine("Старт шага: " + startValue);
Console.WriteLine("Конец шага: " + stopValue);

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

Console.WriteLine(ds.GetMassFunction( startValue, stopValue));
foreach (double i in ds.GetMassFunction(startValue,stopValue))
{
    Console.Write(i+"\t");
}