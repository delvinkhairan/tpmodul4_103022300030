using System;
using System.Collections.Generic;

namespace TPModul4
{
    // Class untuk Table-Driven mengembalikan kode pos berdasarkan kelurahan
    class KodePos
    {
        private static Dictionary<string, string> kodePosTable = new Dictionary<string, string>
        {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijagra", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };

        // Method untuk mendapatkan code pos dari kelurahan
        public static string GetKodePos(string kelurahan)
        {
            return kodePosTable.ContainsKey(kelurahan) ? kodePosTable[kelurahan] : "Kode pos tidak ditemukan";
        }
    }

    // Class untuk State-Based Construction yaitu untuk mensimulasikan perubahan state pintu
    class DoorMachine
    {
        private enum State { Terkunci, Terbuka } // Enum untuk state pintu
        private State currentState;

        // Constructor
        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        // Method untuk mengunci pintu
        public void KunciPintu()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        // Method untuk membuka pintu
        public void BukaPintu()
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Menggunakan teknik Table-Driven
            Console.WriteLine("Masukkan nama kelurahan: ");
            string kelurahan = Console.ReadLine();
            Console.WriteLine("Kode Pos: " + KodePos.GetKodePos(kelurahan));

            // Menggunakan teknik State-Based Construction
            DoorMachine pintu = new DoorMachine();
            Console.WriteLine("Ketik 'buka' untuk membuka pintu atau 'kunci' untuk mengunci pintu: ");
            string perintah = Console.ReadLine();

            // Mengubah state pintu berdasarkan input user
            if (perintah.ToLower() == "buka")
            {
                pintu.BukaPintu();
            }
            else if (perintah.ToLower() == "kunci")
            {
                pintu.KunciPintu();
            }
            else
            {
                Console.WriteLine("Perintah tidak dikenali");
            }
        }
    }
}
