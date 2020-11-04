using System;


namespace LatihanInheritance
{
    public class Hewan
    {
        public Hewan()
        {

        }
        public class Kucing : Hewan
        {
            public Kucing()
            {

            }
            public void Nama()
            {
                Console.WriteLine("Kucing");
            }
            public void Jenis()
            {
                Console.WriteLine("Anggora");
            }
            public void Kaki()
            {
                Console.WriteLine("Empat");
            }
        }
    }
}