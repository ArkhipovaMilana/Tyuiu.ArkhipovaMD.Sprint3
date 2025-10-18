using Tyuiu.ArkhipovaMD.Sprint3.Task0.V27.Lib;
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
DataService ds  = new DataService();
Console.WriteLine(ds.GetSumSeries(a, b, c));