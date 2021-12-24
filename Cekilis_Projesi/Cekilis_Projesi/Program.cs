using System;

namespace Cekilis_Projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            string user;
            int balance = 50000;
            Console.Write("Çekilişe Katılacak Kişi : ");
            user = Console.ReadLine();
            Console.WriteLine("Toplam 7 sayı tahmin ediniz. Tahmin ediceğiniz sayılar arasında bir boşluk bırakınız lütfen..");
            string num, continues;
            bool control=true;
            while (control)
            {
                Console.Write("Sayıları Giriniz : => ");
                num = Console.ReadLine();
                balance -= 1000;
                string[] numbers = num.Split(" ");

                Random randomNum = new Random();
                int count = 0;
                Console.Write("Çekiliş Sonucu   : => ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    int sayi = randomNum.Next(0, 9);
                    Console.Write(sayi + " ");
                    if (numbers[i] == sayi.ToString())
                    {
                        count++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Doğru tahmin sayısı : => " + count);
                switch (count)
                {
                    case 1:
                        balance += 100;
                        break;
                    case 2:
                        balance += 1000;
                        break;
                    case 3:
                        balance += 10000;
                        break;
                    case 4:
                        balance += 100000;
                        break;
                    case 5:
                        balance += 2500000;
                        break;
                    case 6:
                        balance += 5000000;
                        break;
                    case 7:
                        balance += 10000000;
                        break;
                    default:
                        break;

                }
                
                Console.WriteLine("Bakiyeniz : " + balance);
                Console.Write("Devam mı (E/H) : ");
                continues = Console.ReadLine();
                Console.WriteLine("---------------------------------------------");
                if (!continues.Equals("E"))
                {
                    control = false;
                    Console.WriteLine("Oyunu Bitti.");
                }

            }
            
           


        }
    }
}
