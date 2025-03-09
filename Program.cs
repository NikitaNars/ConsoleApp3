namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(10, 10, 10);
            point.Print();
            point.MoveBy(1, 2, 3);
            point.Print();

            PC pc = new PC("MSI", 1700, 32, 1000);
            pc.Info();

            User user = new User("Влад", "Евстропов", "Динисович");
            user.SNP();

            
        }
    }
}
