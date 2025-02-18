using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ÖDEV 1 */
            Console.Write("Bir sayı giriniz: ");
            double sayi;

            if (double.TryParse(Console.ReadLine(), out sayi))
            {
                if (sayi > 0)
                {
                    Console.WriteLine("Girilen sayı pozitif.");
                }
                else if (sayi < 0)
                {
                    Console.WriteLine("Girilen sayı negatif.");
                }
                else
                {
                    Console.WriteLine("Girilen sayı sıfırdır.");
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı girmediniz!");
            }

            /* ÖDEV 2 */
            Console.WriteLine("-----------------------------------------------");
            Console.Write("Haftanın kaçıncı günündesiniz: ");
            int sayi2;

            if (int.TryParse(Console.ReadLine(), out sayi2))
            {
                switch (sayi2)
                {
                    case 1:
                        Console.WriteLine("Pazartesi");
                        break;
                    case 2:
                        Console.WriteLine("Salı");
                        break;
                    case 3:
                        Console.WriteLine("Çarşamba");
                        break;
                    case 4:
                        Console.WriteLine("Perşembe");
                        break;
                    case 5:
                        Console.WriteLine("Cuma");
                        break;
                    case 6:
                        Console.WriteLine("Cumartesi");
                        break;
                    case 7:
                        Console.WriteLine("Pazar");
                        break;
                    default:
                        Console.WriteLine("Lütfen 1 - 7 arasında bir sayı seçiniz.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
            }

            /* ÖDEV 3 */
            Console.WriteLine("-----------------------------------------------");

            Console.Write("İşlem yapmak istediğiniz 1. sayıyı giriniz: ");
            float sayi3 = Convert.ToSingle(Console.ReadLine());

            Console.Write("İşlem yapmak istediğiniz 2. sayıyı giriniz: ");
            float sayi4 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Yapmak istediğiniz işlemin işaretini giriniz (+, -, *, /): ");
            char islem = Convert.ToChar(Console.ReadLine());

            switch (islem)
            {
                case '+':
                    Console.WriteLine("İki sayının toplamı: " + (sayi3 + sayi4) );
                    break;
                case '-':
                    Console.WriteLine("İki sayının çıkartma sonucu: " + (sayi3 - sayi4));
                    break;
                case '*':
                    Console.WriteLine("İki sayının çarpımı: " + (sayi3 * sayi4));
                    break;
                case '/':
                    Console.WriteLine("İki sayının bölümü: " + (sayi3 / sayi4));
                    break;
                default:
                    Console.WriteLine("Lütfen (+, -, *, /) bu işlemlerden birini seçiniz.");
                    break;
            }

            /* ÖDEV 4 */
            Console.WriteLine("-----------------------------------------------");

            Console.Write("1. sayıyı giriniz: ");
            int sayi5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı giriniz: ");
            int sayi6 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. sayıyı giriniz: ");
            int sayi7 = Convert.ToInt32(Console.ReadLine());

            if((sayi5 >= sayi6) && (sayi5 >= sayi7)) 
            {
                Console.WriteLine("Üç sayıdan en büyüğü : " + sayi5);
            }
            else if((sayi6 >= sayi5) && (sayi6 >= sayi7)) 
            {
                Console.WriteLine("Üç sayıdan en büyüğü : " + sayi6);
            }
            else if ((sayi7 >= sayi5) && (sayi7 >= sayi6)) 
            {
                Console.WriteLine("Üç sayıdan en büyüğü : " + sayi7);
            }

            /* ÖDEV 5 */
            Console.WriteLine("-----------------------------------------------");

            Console.Write("Lütfen bir şifre giriniz: ");
            string sifre = Console.ReadLine();

            if(sifre.Length >= 8) 
            {
               if(sifre.Contains("@") || sifre.Contains("#") || sifre.Contains("$") || sifre.Contains("%")) 
                {
                    if(sifre != sifre.ToLower()) 
                    {
                        Console.WriteLine("Güçlü Şifre...");
                    }
                    else
                    {
                        Console.WriteLine("Şifreniz en az bir büyük harf içersin!");
                    }
                }
                else
                {
                    Console.WriteLine("Şifreniz bir özel karakter (@,#,$,%) içersin!");
                }
            }
            else 
            {
                Console.WriteLine("Şifreniz en az 8 karakter olsun!");
            }
        }  
    }
}