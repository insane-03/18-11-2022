namespace Check
{
    internal class Program :Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Class1  c1 = new Class1();
            Program c2 = new Program();
            Class3 c3= new Class3();
            Class4 c4 = new Class4();
            try
            {
                c1.Class11();
                c2.Class22();
                c3.Class33();
                c4.Class44();
                

            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}