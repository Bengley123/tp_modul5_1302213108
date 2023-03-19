// See https://aka.ms/new-console-template for more information
internal class Program
{
    public class HaloGeneric
    {
        public static void sapaUser<T>(T inputuser)
        {
            Console.WriteLine("Hai user " + inputuser);
        }
    }
    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang disimpan antara lain: " + data);
        }
    }
    private static void Main(string[] args)
    {
        HaloGeneric.sapaUser<string>("Yesa Krisanto Sihombing");
        DataGeneric<string> nim = new DataGeneric<string>("1302213108");
        nim.PrintData();
    }
}
