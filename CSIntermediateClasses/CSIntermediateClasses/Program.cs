namespace CSIntermediateClasses
{

    partial class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Jim";

            System.Console.WriteLine(cookie["name"]);
        }
    }
}
