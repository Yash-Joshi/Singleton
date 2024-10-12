
public class SingleClass
{
    
    private static string classVariableOne = "Default Value";

    private SingleClass()
    {
       classVariableOne = "This is the assigned value from SingleClassObjectCreation method but this is declared in SingleClass constructor";
    }

    public static string  SingleClassObjectCreation()
    {
        Console.WriteLine("Entering into the method");
        
            Console.WriteLine("Printing class variable old value");
            Console.WriteLine(classVariableOne);
            
                new SingleClass();
            
            Console.WriteLine("Printing class variable new value");
            Console.WriteLine(classVariableOne);
        
        Console.WriteLine("Exiting from the method");

        return classVariableOne;
    }
}


// Console.WriteLine("Exiting from SingleClassObjectCreation method");
//Console.WriteLine("Entering inside SingleClassObjectCreation method");