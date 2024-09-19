using System.Diagnostics;

namespace _16_C_IntroductionBitirmeProjesi
{
    internal class Program
    {
        static double stepLength;
        static List<double> stepPerMinute = new List<double>();
        static List<int> runningTime = new List<int>();
        static List<int> avgRunningDistance = new List<int>();
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
                    CalculateRunningTime();
                    break;
                case "2":
                    if (stepLength > 0) { 
                        stepLength = 0;
                    }
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
        /// Kullanıcıdan adım boyu almak için kullanılır. Rakam girişi, sıfır ve sıfırdan küçük sayı girişi kontrolü yapılır; hatalı girişlerde uygun hata mesajını gösterir. Alınan değeri konsolda yazdırır ve değişkene atar.
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
        /// <summary>
        /// Kullanıcıdan dakika başına kaç adım attığını almak için kullanılır. Rakam girişi, sıfır ve sıfırdan küçük sayı girişi kontrolü yapılır; hatalı girişlerde uygun hata mesajını gösterir. Alınan değeri konsola yazdırır ve list öğesine kaydeder.
        /// </summary>
        static void GetStepPerMinute()
        {
            Console.WriteLine("Lütfen dakikada kaç adım attığınızı girin: ");
            if (double.TryParse(Console.ReadLine(), out double _stepPerMinute))
            {
                if (_stepPerMinute > 0)
                {
                    stepPerMinute.Add(_stepPerMinute);
                    Console.WriteLine($"Dakika başına atılan adımız kaydedildi... {_stepPerMinute}");
                }
                else
                {
                    ShowZeroError();
                    GetStepPerMinute();
                }
            }
            else
            {
                ShowDigitError();
                GetStepPerMinute();
            }
        }
        /// <summary>
        /// Kullanıcının koşu süresini önce saat sonra dakika olarak almak ve toplam süresini dakika olarak hesaplamak için kullanılır. Rakam girişi, sıfır veya sıfırdan küçük girişi kontrolü yapılır; hatalı girişlerde uygun hata mesajını gösterir. Alınan değeri konsola yazdırır ve list öğesine kaydeder.
        /// </summary>
        static void GetRunningTime()
        {
            Console.WriteLine("Lütfen koşu sürenizin saatini girin: ");
            if (int.TryParse(Console.ReadLine(), out int _runningTimeHours))
            {
                if (_runningTimeHours >= 0)
                {
                    Console.WriteLine("Lütfen koşu sürenizin dakikasını girin: ");
                    if (int.TryParse(Console.ReadLine(), out int _runningTimeMinutes))
                    {
                        if (_runningTimeMinutes > 0)
                        {
                            int _runningTime = (_runningTimeHours * 60) + _runningTimeMinutes;
                            runningTime.Add(_runningTime);
                            Console.WriteLine($"Koşu süreniz kaydedildi... {_runningTime} dakika");
                        }
                    }
                    else
                    {
                        ShowDigitError();
                        GetRunningTime();
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Bir hata oldu! Girilen değer sıfırdan küçük olamaz.\n");
                    Console.ResetColor();
                }
            }
            else
            {
                ShowDigitError();
                GetRunningTime();
            }
        }

        // Hesaplama
        static void CalculateRunningTime()
        {
            do
            {
                if (stepLength <= 0)
                    GetStepLength();
                GetStepPerMinute();
                GetRunningTime();
                Console.WriteLine("Yeni bir koşu periyodu eklemek istiyor musunuz? 1 - Evet | 2 - Hayır");
            } while (Console.ReadLine() == "1" ? true : false);
            if (stepPerMinute.Count == runningTime.Count)
            {
                for (int i = 0; i < stepPerMinute.Count; i++)
                {
                    Console.WriteLine($"Adım boyu: {stepLength}\t| Dakika başı adım: {stepPerMinute[i]}\t| Koşu süresi: {runningTime[i]}");
                }
            }
        }
    }
}
