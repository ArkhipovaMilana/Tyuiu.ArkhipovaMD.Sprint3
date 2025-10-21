using Tyuiu.ArkhipovaMD.Sprint3.Task5.V16.Lib;
int x = Convert.ToInt32(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
DataService ds = new DataService();
Console.WriteLine(ds.GetSumSumSeries(x,a,b,c,d));