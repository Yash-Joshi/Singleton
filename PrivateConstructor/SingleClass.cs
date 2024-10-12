
public class SingleClass
{
    
    private static string classVariableOne = "Default Value";

    private SingleClass()
    {
       classVariableOne = "This is the assigned value from SingleClassObjectCreation method but this is declared in SingleClass constructor";
    }

    public static string  SingleClassObjectCreation()
    {
        if(classVariableOne.Equals("Default Value"))
        {
            Console.WriteLine(classVariableOne);
            new SingleClass();
            Console.WriteLine(classVariableOne);
        }

        return classVariableOne;
    }
}


// Console.WriteLine("Exiting from SingleClassObjectCreation method");
//Console.WriteLine("Entering inside SingleClassObjectCreation method");