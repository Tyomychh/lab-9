using CSVRead;

namespace CSVRead
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\НАВЧАННЯЯЯЯЯЯ\Visual Studio\Gitlab9\Lab9OOP2kurs\CSVRead\textD.csv";
            CSV cSVReadering = new CSV();
            cSVReadering.Reader(path);
        }

    }
}