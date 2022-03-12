// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        KodeBuah table_KodeBuah = new KodeBuah();
        Console.WriteLine("Kode Buah : ");
        table_KodeBuah.getAllKodeBuah();

        Console.WriteLine("Posisi Karakter Game");
        PosisiKarakterGame posisi = new PosisiKarakterGame();
        posisi.kunci();
    }
}

class KodeBuah
{
    Dictionary<string, string> dic = new Dictionary<string, string>()
    {
        {"Apel"         ,"A00"},
        {"Aprikot"      ,"B00"},
        {"Alpukat"      ,"C00"},
        {"Pisang"       ,"D00"},
        {"Paprika"      ,"E00"},
        {"Blackberry"   ,"F00"},
        {"Ceri"         ,"H00"},
        {"Kelapa"       ,"I00"},
        {"Jagung"       ,"J00"},
        {"Kurma"        ,"K00"},
        {"Durian"       ,"L00"},
        {"Anggur",      "M00" },
        {"Melon",       "N00"},
        {"Semangka",    "O00"}
    };

    public void getKodeBuah(string kel)
    {
        if (dic.ContainsKey(kel))
        {
            Console.WriteLine(kel + " : " + dic[kel]);
        }
        else
        {
            Console.WriteLine(kel + " tidak ditemukan");
        }
    }

    public void getAllKodeBuah()
    {
        foreach (KeyValuePair<string, string> ele1 in dic)
        {
            Console.WriteLine("{0} \t\t {1}", ele1.Key, ele1.Value);
        }
    }
}

class PosisiKarakterGame
{
    enum State { TERBANG, BERDIRI };
    public void kunci()
    {
        State state = State.TERBANG;

        String[] screenName = { "Take Off", "Landing" };
        do
        {
            Console.WriteLine("Posisi " + screenName[(int)state]);
            Console.Write("Enter Command : ");
            String command = Console.ReadLine();
            switch (state)
            {
                case State.TERBANG:
                    if (command == "W")
                    {
                        state = State.TERBANG;
                    }
                    break;
                case State.BERDIRI:
                    if (command == "X")
                    {
                        state = State.BERDIRI;
                    }
                    break;


            }
        } while (state != State.BERDIRI);
    }
}