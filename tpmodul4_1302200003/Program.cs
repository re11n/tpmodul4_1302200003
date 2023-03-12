// See https://aka.ms/new-console-template for more information
namespace tpmodul4_1302200003
{
    class Program
    {
        static void Main(string[] args)
        {
            KodePos table_Kodepos = new KodePos();
            Console.WriteLine("Ketik Nama Kelurahan");
            Console.Write("Kelurahan :");
            string command = Console.ReadLine();
            table_Kodepos.getKodepos(command);

            Console.WriteLine("================== KUNCI PINTU ================");
            DoorMachine pintu = new DoorMachine();
            pintu.kunci();

        }

    }
    class KodePos
    {

        Dictionary<string, string> dic = new Dictionary<string, string>() {
            {"Batununggal", "40266"},
            {"Kujangsari","40287" },
            {"Mengger"  ,"40267" },
            {"Wates"    ,"40256" },
            {"Cijaura"  ,"40287"},
            {"Jatisari" ,"40286" },
            {"Margasari","40286"},
            {"Sekejati" ,"40286" },
            {"Kebonwaru","40272"},
            {"Maleer"   ,"40274"},
            {"Samoja"   ,"40273"} };

        public void getKodepos(string kel)
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

        public void getAllkodepos()
        {
            foreach (KeyValuePair<string, string> ele1 in dic)
            {
                Console.WriteLine("{0} \t\t {1}", ele1.Key, ele1.Value);
            }
        }
    }

    class DoorMachine
    {
        enum State { TERKUNCI, TERBUKA };
        public void kunci()
        {
            State state = State.TERKUNCI;

            String[] screenName = { "TERKUNCI", "TERBUKA" };
            do
            {
                Console.WriteLine("PINTU " + screenName[(int)state]);
                Console.Write("Enter Command : ");
                String command = Console.ReadLine();
                switch (state)
                {
                    case State.TERKUNCI:
                        if (command == "BukaPintu")
                        {
                            state = State.TERBUKA;
                        }
                        break;
                    case State.TERBUKA:
                        if (command == "KunciPintu")
                        {
                            state = State.TERKUNCI;
                        }
                        break;
                }
            } while (state != State.TERKUNCI);
        }
    }
}