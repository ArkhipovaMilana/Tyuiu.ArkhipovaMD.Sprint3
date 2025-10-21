using Tyuiu.ArkhipovaMD.Sprint3.Task7.V13.Lib;
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
DataService ds = new DataService();
foreach (double i in ds.GetMassFunction(a,b))
{
    Console.Write(i+"\t");
}