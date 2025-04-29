namespace switchCaseHesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci sayısı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("ikinci sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("YAPMAK İSTEDİGİNİZ İSLEMİ SECİN");
            string islem = Console.ReadLine();

            switch (islem)
            {
                case "+":
                    Console.WriteLine("toplam : " + (sayi1 + sayi2));
                    break;


                    case "-":   
                    Console.WriteLine("fark : " + (sayi1 - sayi2));
                    break;

                case "*":
                    Console.WriteLine("çarpım : " + (sayi1 * sayi2));
                    break;


                case "/":

                    if (sayi2 != 0)
                        Console.WriteLine("bölüm : " + (sayi1 - sayi2));

                    else
                        Console.WriteLine("sıfıra bölünemez");
                    break;

                    default:
                    Console.WriteLine("geçersiz işlem");
                    break;

            }

        }
    }
}
