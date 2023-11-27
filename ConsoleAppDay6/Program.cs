namespace ConsoleAppDay6
{
    internal class Program


       
    {


        //static void printline(int n , string pattern)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write(pattern);
        //    }
        //    Console.WriteLine();
        //}


        //static void Main(string[] args) // starup function
        //{
        //    Console.WriteLine("Hello, World!");
        //    printline(6 , "*");
        //    printline(5, "*");
        //    printline(4, "*");
        //    printline(3, "*");
        //    printline(2, "*");
        //    printline(1, "*");
        //    //printline();
        //    //printline();
        //}




        //static void function(int length , string patern , bool flage) {

        //    for (int i = 0; i < length; i++)
        //    {
        //        if (flage == true) {
        //            Console.Write(patern);


        //        }
        //          else
        //        {
        //            Console.WriteLine(patern);
        //        }  
        //    }

        //}

        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("enter length :");
        //    //int length = Convert.ToInt32(Console.ReadLine());
        //    //Console.WriteLine("enter patren :");
        //    //string patren = Console.ReadLine();
        //    function(4, "***", true);
        //    function(4, "***", false);










        //}




        //static int Sum1 (int x, int y)
        //{

        //    return x + y;

        //}

        //static int multiplication (int x, int y)
        //{
        //    return x * y;
        //}
        //static void Main(string[] args)
        //{



        //   int result =  Sum1 (1, 2);
        //    int result2 = multiplication (Sum1(1, 2),2);
        //    Console.WriteLine(result);
        //    Console.WriteLine(result2);







        //}








        static void fswap (int x, int y)
        {
            int temp = x; // take the x value into emp
            x = y;/// replace x value with y value
            y = temp;    // 
            Console.WriteLine($"swapped successfuly {x}, {y}");


        }






        static void Main (string[] args)
        {

            int x = 3;
            int y = 10;
            fswap(x, y);
            Console.WriteLine($"swapped successfuly {x}, {y}");
            int a = 11;
            int b = 13;
            fswapref(ref a, ref b);
            Console.WriteLine($"A value is {a}, b value is {b}");
            


        }
        //===========================================================================================================

        static void fswapref(ref int a,ref  int b)
        {
            int temp = a; // take the x value into emp
            a = b ;/// replace x value with y value
            b = temp;    // 
            

        }





        static int calculaion (int x , int y)
        {
            int sum1 = x + y;
            int multiply = x * y;
            return
        }
        








    }
}