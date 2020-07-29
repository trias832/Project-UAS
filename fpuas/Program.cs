using System;

namespace fpuas
{
    public abstract class Negara
    {
   
        public abstract void Bahasa();
        public abstract void Lagu();
        public abstract void Matauang();


    }

    public class Singapura : Negara
    {
        public override void Bahasa()
        {
            Console.WriteLine("\nBahasa \t\t\t: Bahasa Melayu");
        }
        public override void Lagu()
        { Console.WriteLine("Lagu Kebangsaan \t: Majulah Singapura"); }
        public override void Matauang()
        {
            Console.WriteLine("Mata Uang \t\t: Dollar Singapura");
        }
    }

    public class Malaysia : Negara
    {
        public override void Bahasa()
        {
            Console.WriteLine("\nBahasa \t\t\t: Bahasa Melayu");
        }
        public override void Lagu()
        { Console.WriteLine("Lagu Kebangsaan \t: Negaraku"); }
        public override void Matauang()
        {
            Console.WriteLine("Mata Uang \t\t: Ringgit");
        }


    }

    public class TimorLeste : Negara
    {
        public override void Bahasa()
        {
            Console.WriteLine("\nBahasa \t\t\t: Bahasa Portugis");
        }
        public override void Lagu()
        { Console.WriteLine("Lagu Kebangsaan \t: Patria"); }
        public override void Matauang()
        {
            Console.WriteLine("Mata Uang \t\t: US Dollar");
        }
    }

    class Program
    {
        static void Main()
        {
            bool status = true;

            do
            {
                Negara negara;

                Console.WriteLine("=================================================");
                Console.WriteLine("\tDaftar Negara Tetangga Indonesia");
                Console.WriteLine("=================================================");
                Console.WriteLine();

                Console.WriteLine("\n1. TimorLeste\n2. Malaysia\n3. Singapura\n4. Keluar");
                Console.WriteLine("\nUntuk Melihat Informasi Negara");
                Console.WriteLine();
            Pilihan:
                Console.WriteLine("\nSilahkan Masukan Pilihan :");
                int Pil = Convert.ToInt32(Console.ReadLine());

                if (Pil == 1)
                {
                    Console.Clear();
                    negara = new TimorLeste();
                    Console.WriteLine("\n\t\tTimor Leste");
                    Console.WriteLine("=================================================");
                    negara.Bahasa();
                    negara.Lagu();
                    negara.Matauang();
                    Console.WriteLine("\n\n\n");
                }
                else if (Pil == 2)
                {
                    Console.Clear();
                    negara = new Malaysia();
                    Console.WriteLine("\n\t\tMalaysia");
                    Console.WriteLine("=================================================");
                    negara.Bahasa();
                    negara.Lagu();
                    negara.Matauang();
                    Console.WriteLine("\n\n\n");
                }
                else if (Pil == 3)
                {
                    Console.Clear();
                    negara = new Singapura();
                    Console.WriteLine("\n\t\tSingapura");
                    Console.WriteLine("=================================================");
                    negara.Bahasa();
                    negara.Lagu();
                    negara.Matauang();
                    Console.WriteLine("\n\n\n");
                }
                else if (Pil == 4)
                {
                    status = false;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nPilihan Tidak Tersedia");
                    goto Pilihan;
                }
            } while (status);


        }
    }
}

 
