using Tyuiu.ArkhipovaMD.Sprint3.Task3.V23.Lib;
Console.Title = "Спринт #3 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #23                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");
string a ="fdsst siu vsrs";
char b = 's';
char c = '8';
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

DataService ds = new DataService();
Console.WriteLine(ds.ReplaceCharOnNum(a, b, c));