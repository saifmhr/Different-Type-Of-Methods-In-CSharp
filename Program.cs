using System;

namespace Different_Type_Of_Methods
{
    class Program
    {
        static void Main()
        {

            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            //paramsmethod();
            paramsmethod(Numbers);

            paramsmethod(1,2,3,4,5);

            int Total = 0;
            int Product =0;

            Calculator(20, 10, out Total, out Product);

            Console.WriteLine("Sum = {0} Product ={1}",Total,Product);

            int i=0;
            PasssingByValue(0);
            Console.WriteLine("Passsing By value {0}", i);

            int a = 0;
            PassingValueByReference(ref a);
            Console.WriteLine("Passing Value By Reference {0}",a);
        }

        //forth type of method (Parameters Arrays)
        public static void paramsmethod(params int[] Numbers)
        {
            Console.WriteLine("there are {0} elements",Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }


        //Third type of Method
        //if you want to return more than one value then use out keyword
        public static void Calculator(int FN,int SN,out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN*SN;
        }


        //Second type of method, Passing Value By Reference
        public static void PassingValueByReference(ref int k)
        {
            k = 102;
        }


        //First type of method,  Passsing By value
        public static void PasssingByValue(int j)
        {
            j = 101;
        }


    }
}
