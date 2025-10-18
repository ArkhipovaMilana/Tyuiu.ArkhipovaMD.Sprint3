using Tyuiu.ArkhipovaMD.Sprint3.Task2.V4.Lib;

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
DataService ds = new DataService();
Console.WriteLine(ds.GetMultiplySeries(a,b));