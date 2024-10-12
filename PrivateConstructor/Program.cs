// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
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


    // You cannot do that as the class object is private that can 
        // only be accessed from the class
        // it will give you error like 
        // 'SingleClass.SingleClass()' is inaccessible due to its protection level
        // SingleClass classObject = new SingleClass()
        //doing 
        //SingleClass classObject = SingleClass.SingleClassObjectCreation()
        // will give below error
        // Cannot implicitly convert type 'string' to 'SingleClass'
        
        // So now we know that the single class is a static class and the reason for 
        // not letting us do like simple access is based on the protection it have
        // let's see what we can do to gain access