using System;

namespace MidTerm_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("จำนวนของที่อยู่ในกล่อง 1,2,3 : ");
            int NumBox1 = int.Parse(Console.ReadLine());
            int NumBox2 = int.Parse(Console.ReadLine());
            int NumBox3 = int.Parse(Console.ReadLine());

            int a = 1;

            while (NumBox1>0 || NumBox2>0 || NumBox3>0)
            {

                if (a == 1)
                {

                    Console.WriteLine("ผู้เล่น A");

                }
                else
                {

                    Console.WriteLine("ผู้เล่น B");

                }


                Console.WriteLine("เลือกกล่อง : ");
                int BoxA = int.Parse(Console.ReadLine());
                Console.WriteLine("หยิบของออก : ");
                int A = int.Parse(Console.ReadLine());


                if (BoxA == 1)
                {
                    NumBox1 = NumBox1 - A;
                    Console.WriteLine("กล่องที่ 1 เหลือ : {0} " ,NumBox1);
                    a = a * -1;
                    
                }
                else if (BoxA == 2)
                {
                    NumBox2 = NumBox2 - A;
                    Console.WriteLine("กล่องที่ 2 เหลือ : {0} " ,NumBox2);
                    a = a * -1;

                }
                else if (BoxA == 3)
                {
                    NumBox3 = NumBox3 - A;
                    Console.WriteLine("กล่องที่ 3 เหลือ : {0} ", NumBox3);
                    a = a * -1;

                }

            }

            if (a == 1)
            {
                Console.WriteLine("ผู้เล่น A ชนะ");
            }
            else
            {
                Console.WriteLine("ผู้เล่น B ชนะ");
            }

        }
    }
}
