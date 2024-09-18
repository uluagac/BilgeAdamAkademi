using System.Diagnostics;

namespace _16_C_IntroductionBitirmeProjesi
{
    internal class Program
    {
        static double stepLength;
        static void Main(string[] args)
        {
            #region Ödev & Açıklama
            // Boost Proje: Günlük Koşu Mesafesi Ölçer
            /*
             * Yeni akıllı saatler olmadan günlük koşu mesafemizi ölçebilir miyiz? Sizden günlük koşu mesafemizi ölçen bir yazılım yapmanızı istiyorum. Yapacağınız yazılıma; sizin adım boyunuzu, bir dakikada kaç adım attığınızı ve toplam koşu sürenizi belirtiğinizde size metre cinsinden toplam koşu mesafenizi söyleyecek.
             * Yapacağınız çözümü modüllere bölmeyi unutmayın.
             * Veriyi 4 adımda alacağız:
                1. Ortalama bir adımınızın kaç santimetre olduğunu gireceksiniz
                2. Bir dakikada kaç adım koştuğunuzu gireceksiniz.
                3. Koşu süresini
                    3.1. Önce saat
                    3.2. Ve dakika olarak gireceksiniz.
             * Lütfen her adımda verilerin doğruluğunu kontrol etmeyi unutmayın.
             // EK Soru:
             * Koşuyu aynı hızda koşmam mümkün olmayacağından koşunun belli bölümlerinde dakikada kaç adım attığımı girebileceğim bir farklı tasarım yapabilir misiniz?
            */
            #endregion
            while (true)
            {
                Start();
            }
        }
        // Başlangıç Metodu
        static void Start()
        {
            // Hesaplama işlemi ilk kez yapılmıyorsa işlem "Yeniden Hesapla" olarak değişir ve adım boyu sıfırlama seçeneği eklenir.
            string processName = "Hesapla";
            string? secondProcess = null;
            if (stepLength > 0)
            { 
                processName = "Yeniden Hesapla";
                secondProcess = "2 - Adım Boyunu Sıfırla\n";
            }

            // Program başlangıc ekranı.
            Console.Title = "Günlük Koşu Mesafesi Ölçer";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(new string('*', 10) + " Günlük Koşu Mesafesi Ölçer " + new string('*', 10));
            Console.ResetColor();
            Console.WriteLine($"1 - {processName}\t{secondProcess}0 - Çıkış\t");
            string start = Console.ReadLine().Trim();
            switch (start)
            {
                case "1":
                    // Hesaplama İşlemleri
                    GetStepLength();
                    break;
                case "2":
                    if (stepLength > 0)
                        stepLength = 0;
                    else
                    {
                        ShowChoiceError();
                    }
                    break;
                case "0":
                    // Çıkış
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nProgramdan çıkılıyor...");
                    Console.ResetColor();
                    break;
                default:
                    // İşlem Seçim Hatası
                    ShowChoiceError();
                    break;
            }
        }

        // Hata Mesajları
        /// <summary>
        /// Konsolda, menüde seçilen işlemin hatalı olması durumundaki hata mesajını gösterir.
        /// </summary>
        static void ShowChoiceError()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Hatalı bir işlem seçildi! Lütfen yapmak istediğiniz işlemin kodunu seçin.");
            Console.ResetColor();
            Start();
        }
        /// <summary>
        /// Konsolda, değerlerin rakam ile girilmemesi durumundaki hata mesajını gösterir.
        /// </summary>
        static void ShowDigitError()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bir hata oldu! Lütfen değeri rakamlarla giriniz.\n");
            Console.ResetColor();
        }
        /// <summary>
        /// Konsolda, girilen değerin "sıfır" olması durumundaki hata mesajını gösterir.
        /// </summary>
        static void ShowZeroError()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bir hata oldu! Girilen değer sıfır veya sıfırdan küçük olamaz.\n");
            Console.ResetColor();
        }

        // Değerlerin Alınması
        /// <summary>
        /// Kullanıcıdan adım boyu almak için kullanılır. Rakam girişi kontrolü, sıfır ve sıfırdan küçük sayı girişi kontrolü yapılır; hatalı girişlerde uygun hata mesajını gösterir. Alınan değeri konsolda yazdırır.
        /// </summary>
        static void GetStepLength()
        {
            Console.Write("Lütfen santimetre cinsinden adım boyunuzu girin: ");
            if (double.TryParse(Console.ReadLine(), out stepLength))
            {
                if (stepLength > 0)
                {
                    Console.WriteLine($"Adım boyunuz kaydedildi... {stepLength}cm");
                }
                else
                {
                    ShowZeroError();
                    GetStepLength();
                }
            }
            else
            {
                ShowDigitError();
                GetStepLength();
            }
        }
    }
}
