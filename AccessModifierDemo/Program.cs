namespace AccessModifierDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myInstance = new MyClass();
            myInstance.ShowValues();

            MyDerivedClass myDerrivedInstance = new MyDerivedClass();
            myDerrivedInstance.ShowValues();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("In the same assembly");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tpublicVariable = " + myInstance.publicVariable);
            Console.WriteLine("\tprotectedInternalVariable = " + myInstance.protectedInternalVariable);
            Console.WriteLine("\tinternalVariable = " + myInstance.internalVariable);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tprotectedVariable is inaccessible!");
            Console.WriteLine("\tprivateProtectedVariable is inaccessible!");
            Console.WriteLine("\tprivateVariable is inaccessible!");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}