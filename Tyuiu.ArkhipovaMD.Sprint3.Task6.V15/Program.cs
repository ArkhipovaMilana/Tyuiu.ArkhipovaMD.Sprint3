using Tyuiu.ArkhipovaMD.Sprint3.Task6.V15.Lib;
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
DataService ds = new DataService();
Console.WriteLine(ds.GetSumTheDivisors(a, b));