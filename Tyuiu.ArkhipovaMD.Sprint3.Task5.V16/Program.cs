using Tyuiu.ArkhipovaMD.Sprint3.Task5.V16.Lib;
DataService ds = new DataService();
int x = 2;
int startvalue1 = 1;
int startvalue2 = 1;
int stopvalue1 = 3;
int stopvalue2 = 10;
Console.WriteLine(ds.GetSumSumSeries(x, startvalue1, startvalue2, stopvalue1, stopvalue2));