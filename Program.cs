using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_objek
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari class Mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            // mengeset nilai properties objek saya dan kamu
            saya.Nim = "18.11.2372";
            saya.Nama = "Dina Rahma Novita";
            saya.Ipk = 3.75f;

            kamu.Nim = "18.11.2342";
            kamu.Nama = "Vicka Rizki sunflora";
            kamu.Ipk = 3.92f;

            // memanggil method registrasi dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
