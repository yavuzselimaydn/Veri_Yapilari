internal class Program
{
    private static void Main(string[] args)
    {
        var array = new Array.Array();
        array.Add("ahmet");   //  0   4
        array.Add("mehmet");  //  1   4 
        array.Add("Can");     //  2   4
        array.Add("filiz");   //  3   4 
        array.Add("furkan");  //  4   8

        Console.WriteLine(array.GetItem(array.Find("Can")));

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(array.Count);
        Console.Read();
    }
}