class Program
{
    public static void Main(string[] args)
    {
    
        var  valueReturnedFromSingleClass  = SingleClass.SingleClassObjectCreation();
        Console.WriteLine("Returned value {0}",valueReturnedFromSingleClass);

        var again = SingleClass.SingleClassObjectCreation();
        Console.WriteLine("Returned value {0}",again);
    }
}