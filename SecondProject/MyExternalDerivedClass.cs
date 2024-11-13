using AccessModifierDemo;

namespace SecondProject
{
    internal class MyExternalDerivedClass : MyClass
    {
        public override void ShowValues()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Within a derived class in a different assembly");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tpublicVariable = " + this.publicVariable);
            Console.WriteLine("\tprotectedInternalVariable = " + this.protectedInternalVariable);
            Console.WriteLine("\tprotectedVariable = " + this.protectedVariable);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tinternalVariable is inaccessible!");
            Console.WriteLine("\tprivateProtectedVariable is inaccessible!");
            Console.WriteLine("\tprivateVariable is inaccessible!");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
