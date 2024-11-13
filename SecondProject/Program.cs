using AccessModifierDemo;

namespace SecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyExternalDerivedClass myExternalDerrivedInstance = new MyExternalDerivedClass();
            myExternalDerrivedInstance.ShowValues();

            new Program().ShowValues();
        }

        public void ShowValues()
        {
            MyClass myInstance = new MyClass();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("In a different assembly");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tpublicVariable = " + myInstance.publicVariable);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tprotectedInternalVariable is inaccessible!");
            Console.WriteLine("\tinternalVariable is inaccessible!");
            Console.WriteLine("\tprotectedVariable is inaccessible!");
            Console.WriteLine("\tprivateProtectedVariable is inaccessible!");
            Console.WriteLine("\tprivateVariable is inaccessible!");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}