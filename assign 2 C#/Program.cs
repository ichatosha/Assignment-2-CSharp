namespace Assign_2_C_
{
    class MyClass
    {
        public int Number { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            /////////////////////////////////// 1 //////////////////////////////
            #region task number 1 : 
            Console.WriteLine("-------------------1-------------------");

            Console.WriteLine("Enter number :");

            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                Console.WriteLine("You entered the number : " + number);
            }

            else
                Console.WriteLine("You entered invalid number !");


            #endregion


            ///////////////////////////////// 2 //////////////////////////////
            #region task number 2 :

            Console.WriteLine("-------------------2-------------------");
            int OriginalNumber = 10;

            
            int CopiedNumber = OriginalNumber;

            // Before modification
            Console.WriteLine("\nBefore modification:\n");
            Console.WriteLine("OriginalNumber: " + OriginalNumber + "\n");
            Console.WriteLine("CopiedNumber: " + CopiedNumber + "\n");



            // Modifying
            OriginalNumber = 20;

            // After modification
            Console.WriteLine("After modification:");
            Console.WriteLine("OriginalNumber: " + OriginalNumber);
            Console.WriteLine("CopiedNumber: " + CopiedNumber);


            // Explanation
            Console.WriteLine("\nExplanation:\n");
            Console.WriteLine("When a value type variable is assigned to another, the value is copied");
            Console.WriteLine("Modifying the original variable does not affect the copied variable");

            #endregion


            ///////////////////////////////// 3 //////////////////////////////


            #region task number 3 : 

            Console.WriteLine("-------------------3-------------------");



            
            MyClass OriginalObject = new MyClass { Number = 10 };

            
            MyClass CopiedObject = OriginalObject;

            // Before modification
            Console.WriteLine("Before modification:");
            Console.WriteLine("OriginalObject.Number: " + OriginalObject.Number);
            Console.WriteLine("CopiedObject.Number: " + CopiedObject.Number);

            // Modifying
            OriginalObject.Number = 20;

            // after modification
            Console.WriteLine("After modification:");
            Console.WriteLine("OriginalObject.Number: " + OriginalObject.Number);
            Console.WriteLine("CopiedObject.Number: " + CopiedObject.Number);

            // Explanation
            Console.WriteLine("\nExplanation:");
            Console.WriteLine("When a reference type variable is assigned to another, both variables reference the same object in memory.");
            Console.WriteLine("Modifying the object through one variable affects the object referenced by the other variable.");

            #endregion
        }
    }



    
};
