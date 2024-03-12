using tpmodul4_1302220105;

namespace tpmodul4_1302220105
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Soal 3");
                KodePos myKodepos = new KodePos();
                Console.Write("Masukkan nama kelurahan untuk mendapatkan kode pos: ");
                string kelurahan = Console.ReadLine();
                string KodePos = myKodepos.GetKodepos(kelurahan);
                Console.WriteLine($"Kode pos untuk '{kelurahan}' adalah: {KodePos}");
            }

            Console.WriteLine("Soal 5");
            DoorMachine doorMachine = new DoorMachine();
            // Simulasi perubahan state
            doorMachine.ChangeState(); // Pintu tidak terkunci
            doorMachine.ChangeState(); // Pintu terkunci
        }
    }
}
