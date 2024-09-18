namespace _16_C_IntroductionBitirmeProjesi
{
    internal class Program
    {
        static double stepLength = GetStepLength();
        static double stepPerMinute = GetStepPerMinute();
        static int runningTime = GetRunningTime();
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
            Start();
        }
        /// <summary>
        /// Programı başlatmak için kullanılır.
        /// </summary>
        static void Start()
        {
            Console.Title = "Günlük Koşu Mesafesi Ölçer";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(new string('*', 10) + " Günlük Koşu Mesafesi Ölçer " + new string('*', 10));
            Console.ResetColor();
            Console.Write("1 - Hesapla\t0 - Çıkış:\t");
            string start = Console.ReadLine().Trim();
            switch (start)
            {
                case "1":
                    // Hesaplama İşlemleri
                    CalculateDistance(stepLength, stepPerMinute, runningTime);
                    Start();
                    break;
                case "0":
                    // Çıkış
                    break;
                default:
                    // İşlem Seçim Hatası
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Hatalı bir işlem seçildi! Lütfen yapmak istediğiniz işlemin kodunu seçin.");
                    Console.ResetColor();
                    Start();
                    break;
            }
        }

        /// <summary>
        /// Konsolda giriş hatası uyarısı vermek için kullanılır.
        /// </summary>
        static void ShowDigitError()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bir hata oldu! Lütfen değeri rakamlarla giriniz.\n");
            Console.ResetColor();
        }

        /// <summary>
        /// Konsolda sıfır hatası uyarısı vermek için kullanılır.
        /// </summary>
        static void ShowZeroError()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bir hata oldu! Girilen değer sıfır veya sıfırdan küçük olamaz.\n");
            Console.ResetColor();
        }

        /// <summary>
        /// Kullanıcıdan adım mesafesini santimetre olarak almak için kullanılır. Rakam ile giriş, sıfır ve sıfırdan küçük sayı kontrolü yapılır.
        /// </summary>
        /// <returns>Adım mesafesi.</returns>
        static double GetStepLength()
        {
            Console.Write("Lütfen bir adımınızın santimetre cinsinden mesafesi girin: ");
            if (double.TryParse(Console.ReadLine(), out double stepLength))
            {
                if (stepLength > 0)
                {
                    Console.WriteLine($"Bir adımınızın mesafesi kaydedildi... {stepLength}");
                    return stepLength;
                }
                else
                {
                    ShowZeroError();
                    return GetStepLength();
                }
            }
            else
            {
                ShowDigitError();
                return GetStepLength();
            }
        }

        /// <summary>
        /// Kullanıcıdan dakikada kaç adım attığı bilgisini almak için kullanılır. Rakam ile giriş, sıfır ve sıfırdan küçük sayı kontrolü yapılır.
        /// </summary>
        /// <returns>Dakika başı adım.</returns>
        static double GetStepPerMinute()
        {
            Console.Write("Lütfen dakikada atılan adım sayısını girin: ");
            if (double.TryParse(Console.ReadLine(), out double stepPerMinute))
            {
                if (stepPerMinute > 0)
                {
                    Console.WriteLine($"Bir dakikada atılan adım kaydedildi... {stepPerMinute}");
                    return stepPerMinute;
                }
                else
                {
                    ShowZeroError();
                    return GetStepPerMinute();
                }
            }
            else
            {
                ShowDigitError();
                return GetStepPerMinute();
            }
        }

        /// <summary>
        /// Kullanıcıdan ilk önce koşu saatini sonra koşu dakikasını alarak toplam dakikayı hesaplamak için kullanılır. Rakam ile giriş ve sıfır veya sıfırdan küçük sayı kontrolü yapılır.
        /// </summary>
        /// <returns>Toplam koşu dakikası</returns>
        static int GetRunningTime()
        {
            Console.Write("Lütfen koşu saatinizi girin: ");
            if (int.TryParse(Console.ReadLine(), out int runningTimeHours))
            {
                if (runningTimeHours >= 0)
                {
                    Console.WriteLine($"Koşu saatiniz kaydedildi... {runningTimeHours}");
                    runningTime += runningTimeHours * 60;
                    Console.Write("Lütfen koşu dakikanızı girin: ");
                    if (int.TryParse(Console.ReadLine(), out int runningTimeMinutes))
                    {
                        if (runningTimeMinutes > 0)
                        {
                            Console.WriteLine($"Koşu dakikanız kaydedildi... {runningTimeMinutes}");
                            return runningTime += runningTimeMinutes;
                        }
                        else
                        {
                            ShowZeroError();
                            return GetRunningTime();
                        }
                    }
                    else
                    {
                        ShowDigitError();
                        return GetRunningTime();
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Bir hata oldu! Girilen değer sıfırdan küçük olamaz.\n");
                    Console.ResetColor();
                    return GetRunningTime();
                }
            }
            else
            {
                ShowDigitError();
                return GetRunningTime();
            }
        }

        /// <summary>
        /// Toplam katedilen mesafeyi hesaplamak için kullanılır ve sonuç konsola yazdırılır.
        /// </summary>
        /// <param name="_stepLength">Adım boyu</param>
        /// <param name="_stepPerMinute">Dakika başı adım sayısı</param>
        /// <param name="_runningTime">Toplam koşu süresi</param>
        static void CalculateDistance(double stepLength, double stepPerMinute, int runningTime)
        {
            Console.WriteLine("Günlük koşu süreniz hesaplanıyor...");
            double distanceResult = stepLength * stepPerMinute * runningTime;
            Console.WriteLine($"Günlük koşu mesafeniz: {distanceResult / 100} metredir.");
        }
    }
}
