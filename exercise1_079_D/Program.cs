using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1_079_D
{
    class Program
    {
        //Deklarasi array int dengan ukuran 2 angka terakhir NIM 79 + 10 +20 + 20 - 2 x 15
        //Lis = arr
        private int[] Lis = new int[99];

        //Deklarasi variable int untuk menyimpan banyaknya data pada array
        private int n;

        //fungsi / method untuk menerima masukkan
        public void read()
        {
            //menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.WriteLine("Masukkan banyaknya elemen pada Array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 99)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 99 elemen. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("----------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                Lis[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("----------------------------");
            for (int KS = 0; KS < n; KS++) // KS = j
            {
                Console.WriteLine(Lis[KS]);
            }
            Console.WriteLine("");

        }

        public void Exercise()
        {
            for (int i = 1; i < n; i++) //for n - 1
            {
                //pada pass i; bandingkan n - 1 elemen pertama dengan elemen selanjutnya
                //KS = j
                for (int KS = 0; KS < n - 1; KS++)
                {
                    if (Lis[KS] > Lis[KS + 1]) //jika elemen tidak dalam urutan yang benar
                    {
                        // tukar elemen
                        int temp;
                        temp = Lis[KS];
                        Lis[KS] = Lis[KS + 1];
                        Lis[KS - 1] = temp;
                    }
                }
            }
        }
        internal class program
        {
            static void Main(string[] args)
            {
                // membuat objek program
                Program myList = new Program();

                //pemanggilan funsi untuk menerima elemen array
                myList.read();

                //pemanggilan fungsi untuk mengurutkan array
                myList.Exercise();

                //pemanggilan fungsi untuk menampilkan array yg tersusun
                myList.display();

                //Keluar
                Console.WriteLine("\n\n Tekanlah tombol Apa saja untuk keluar");
                Console.Read();
            }
        }
    }
}
