namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] Exceptions = new Exception[] 
            { 
                new ArgumentNullException("Исключение ArgumentNullException"),
                new ArithmeticException("Исключение ArithmeticException"),
                new InvalidDataException("Исключение InvalidDataException"),
                new InvalidProgramException("Исключение InvalidProgramException"),
                new MyException("Собственное исключение MyException")
            };

            foreach (var Ex in Exceptions)
            {
                try
                {
                    throw Ex;
                }
                catch (MyException MyEx)
                {
                    Console.WriteLine(MyEx.Message);
                }
                catch (ArgumentNullException ANEx)
                {
                    Console.WriteLine(ANEx.Message);
                }
                catch (ArithmeticException AEx)
                {
                    Console.WriteLine(AEx.Message);
                }
                catch (InvalidDataException IDEx)
                {
                    Console.WriteLine(IDEx.Message);
                }
                catch (InvalidProgramException IPEx)
                {
                    Console.WriteLine(IPEx.Message);
                }
                finally
                {
                    Console.WriteLine("Finally выполнен");
                }



            }
        }
    }
}
