using Tyuiu.ArkhipovaMD.Sprint3.Task1.V4.Lib;
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
DataService ds = new DataService();
Console.WriteLine(ds.GetSumSeries(a, b));