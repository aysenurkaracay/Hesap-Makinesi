namespace _08_HesapMakinasi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler-Operatorler-TipDönüşümleri-KararYapıları

            Console.WriteLine("Basit Bir C# Hesap Makinası");
            Console.WriteLine("İşlem Seçiniz: [ + | - | * | / ] Çıkış yapmak için boş geçiniz.");

            //Değişkenler
            double firstNum=0, secondNum=0, result = 0;
            string mathOp=null;

            Basla:

            try
            {
                //TipDönüşümleri
                Console.WriteLine("Sayi 1: ");
                firstNum = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Sayi 2: ");
                secondNum = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("İşlem: ");
                mathOp = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Basla;
            }

            //KararYapıları
            //If ile kullanıcının çıkış yapıp yapmadığını kontrol et.
            if (mathOp != string.Empty)
            {
                //Swicth kullanicinin hangi işlemi yaptığını kontrol et.
                switch (mathOp)
                {
                    case "+":
                        result = firstNum + secondNum;
                        Console.WriteLine("Toplam: " + result);
                        break;
                    case "-":
                        result = firstNum - secondNum;
                        Console.WriteLine("Fark: {0}", result);
                        break;
                    case "*":
                        result = firstNum * secondNum;
                        Console.WriteLine($"Çarpım: {result}");
                        break;
                    case "/":
                        try
                        {
                            result = firstNum / secondNum;
                            Console.WriteLine($"Bölüm: {result}");
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Sayı sıfıra bölünemez.");
                        }

                        break;
                    default:
                        throw new Exception("Yanlış bir işlem seçildi.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("İşlem yapılmadı!!!");
            }


        }
    }
}