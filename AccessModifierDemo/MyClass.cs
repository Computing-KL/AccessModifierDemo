using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierDemo
{
    public class MyClass
    {
        public string publicVariable = "public";
        protected internal string protectedInternalVariable = "protected internal";
        protected string protectedVariable = "protected";
        internal string internalVariable = "internal";
        private protected string privateProtectedVariable = "private protected";
        private string privateVariable = "private";

        public virtual void ShowValues()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Within the same class");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tpublicVariable = " + this.publicVariable);
            Console.WriteLine("\tprotectedInternalVariable = " + this.protectedInternalVariable);
            Console.WriteLine("\tprotectedVariable = " + this.protectedVariable);
            Console.WriteLine("\tinternalVariable = " + this.internalVariable);
            Console.WriteLine("\tprivateProtectedVariable = " + this.privateProtectedVariable);
            Console.WriteLine("\tprivateVariable = " + this.privateVariable);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
