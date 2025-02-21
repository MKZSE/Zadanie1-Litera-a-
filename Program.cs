namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wiersz;
            int powtorzeniaa = 0;
            const string sciezka = "C:\\test/test_mat_kos.txt";
            if (!File.Exists(sciezka)) return;
            StreamReader reader = new StreamReader(sciezka);

            wiersz = reader.ReadLine();
            while (wiersz != null)
            {
                foreach (char znak in wiersz)
                {
                    if (znak == 'a')
                    {
                        powtorzeniaa++;
                    }
                }
                wiersz = reader.ReadLine();
            }
            reader.Close();
            Console.Write("Litera \'a\' występuje:" + powtorzeniaa);
            Console.WriteLine();
        }
    }
}
