namespace Modul2HW5
{
    internal class Program
    {
        internal static void Main()
        {
            new Starter().Run();
            Console.WriteLine(Logger.GetInstance().DispLog());
            Logger.GetInstance().SaveToFile();
        }
    }
}