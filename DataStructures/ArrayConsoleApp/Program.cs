internal class Program
{
    private static void Main(string[] args)
    {
        var array = new Array.Array();
        array.Add("ahmet");   //  0   4
        array.Add("mehmet");  //  1   4 
        array.Add("mehmet");  //  2   4
        array.Add("mehmt");   //  3   4 
        array.Add("mehmet");  //  4   8

        Console.WriteLine(array.Count);

        Console.Read();
    }
}