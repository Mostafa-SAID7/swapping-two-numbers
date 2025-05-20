namespace IntroMethodsFuncs
{

    class Program
    {
        static void Main(string[] args)
        {
            int a= 1;
            int b= 2;
            Console.WriteLine("Before Swapping---");
            Console.WriteLine($"A value: {a}");
            Console.WriteLine($"B value: {b}");
            
            (a,b)= Swap(a,b);
            Console.WriteLine("After Swapping---");
            Console.WriteLine($"A value: {a}");
            Console.WriteLine($"B value: {b}");

        }
        static (int,int) Swap(int a,int b)
        {
           int temp=a;
            a=b;
            b=temp;
            return (a, b);
        }
    }
}








