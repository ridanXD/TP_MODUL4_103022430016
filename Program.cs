using System;
using System.Collections.Generic;
class KodePos
{
    public string getKodePos(string kelurahan) //ini method buat manggil kode pos berdasarkan nama kelurahan
    {
        //dibawah ini ada kode pos untuk 10 kelurahan di kecamatan Batununggal, Kota Bandung.
        //menggunakan Dictionary untuk menyimpan data kelurahan dan kode posnya, dengan StringComparer.OrdinalIgnoreCase agar pencarian tidak case sensitive
        Dictionary<string, string> tabelKodePos = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                {"Batununggal", "40266"},
                {"Kujangsari", "40287"},
                {"Mengger", "40267"},
                {"Wates", "40256"},
                {"Cijaura", "40287"},
                {"Jatisari", "40286"},
                {"Margasari", "40286"},
                {"Sekejati", "40286"},
                {"Kebonwaru", "40272"},
                {"Maleer", "40274"}
            };
        //ini fungsinya untuk mencari kode pos berdasarkan nama kelurahan yang dimasukkan, jika ditemukan maka akan mengembalikan kode posnya, jika tidak ditemukan maka akan mengembalikan pesan "Kelurahan tidak ditemukan"
        return tabelKodePos.TryGetValue(kelurahan, out string kode) ? kode : "Kelurahan tidak ditemukan";
    }
}



//ini class buat mesin pintu, dengan dua state yaitu terkunci dan terbuka, dan method untuk membuka dan mengunci pintu
class DoorMachine
{

    //ini enum buat ngedefinisiin state dari pintu, yaitu terkunci dan terbuka
    public enum State { Terkunci, Terbuka };
    private State currentState;
    
    //ini constructor untuk menginisialisasi state awal dari pintu, yaitu terkunci, dan menampilkan pesan "Pintu terkunci"
    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }



    //ini method buat buka pintu, dengan ngubah state jadi terbuka dan menampilkan pesan "Pintu tidak terkunci"
    public void BukaPintu()
    {
        currentState = State.Terbuka;
        Console.WriteLine("Pintu tidak terkunci");
    }

    //ini method buat mengunci pintu, dengan ngubah state menjadi terkunci dan menampilkan pesan "Pintu terkunci"
    public void KunciPintu()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }
}

class Program
{
    //ini method utama buat ngejalanin program, nanti user bisa memilih
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();
        Console.Write("Masukkan nama Kelurahan: ");
        string inputKelurahan = Console.ReadLine();
        Console.WriteLine($"Kode Pos: {kodePos.getKodePos(inputKelurahan)}\n");

        DoorMachine pintu = new DoorMachine(); 

        while (true) //loop ini buat terus nungguin input dari user buat buka atau kunci pintu, atau keluar dari program
        {
            Console.Write("Masukkan perintah pintu (Buka/Kunci/Keluar): ");
            string perintah = Console.ReadLine();

            if (perintah.Equals("Keluar", StringComparison.OrdinalIgnoreCase))
                break;
            else if (perintah.Equals("Buka", StringComparison.OrdinalIgnoreCase))
                pintu.BukaPintu();
            else if (perintah.Equals("Kunci", StringComparison.OrdinalIgnoreCase))
                pintu.KunciPintu();
            else
                Console.WriteLine("Perintah tidak valid.");
        }
    }
}










