using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierDemo
{
    internal class MyDerivedClass : MyClass
    {
        public override void ShowValues()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Within a derived class in the same assembly");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tpublicVariable = " + this.publicVariable);
            Console.WriteLine("\tprotectedInternalVariable = " + this.protectedInternalVariable);
            Console.WriteLine("\tprotectedVariable = " + this.protectedVariable);
            Console.WriteLine("\tinternalVariable = " + this.internalVariable);
            Console.WriteLine("\tprivateProtectedVariable = " + this.privateProtectedVariable);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tprivateVariable is inaccessible!");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
