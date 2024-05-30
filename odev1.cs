using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Seçenekler:");
            Console.WriteLine("1. Çift olan sayıları yazdırma");
            Console.WriteLine("2. Belirli koşullara uygun sayıları yazdırma");
            Console.WriteLine("3. Kelimeleri ters yazdırma");
            Console.WriteLine("4. Cümledeki toplam kelime ve harf sayısını yazdırma");
            Console.WriteLine("0. Çıkış");
            Console.Write("Bir seçenek girin: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    EvenNumbers();
                    break;
                case 2:
                    DivisibleNumbers();
                    break;
                case 3:
                    ReverseWords();
                    break;
                case 4:
                    SentenceAnalysis();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Geçersiz seçenek. Tekrar deneyin.");
                    break;
            }
        }
    }

    static void EvenNumbers()
    {
        Console.Write("Pozitif bir sayı girin (n): ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("{0} adet pozitif sayı girin:", n);
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Çift sayılar:");
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
        }
    }

    static void DivisibleNumbers()
    {
        Console.Write("Pozitif bir sayı girin (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Pozitif bir sayı girin (m): ");
        int m = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("{0} adet pozitif sayı girin:", n);
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("{0} sayısına eşit veya tam bölünen sayılar:", m);
        foreach (int num in numbers)
        {
            if (num == m || num % m == 0)
            {
                Console.WriteLine(num);
            }
        }
    }

    static void ReverseWords()
    {
        Console.Write("Pozitif bir sayı girin (n): ");
        int n = int.Parse(Console.ReadLine());

        string[] words = new string[n];

        Console.WriteLine("{0} adet kelime girin:", n);
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }

        Console.WriteLine("Kelimelerin tersten sıralanmış hali:");
        Array.Reverse(words);
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }

    static void SentenceAnalysis()
    {
        Console.Write("Bir cümle yazın: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;
        int letterCount = 0;

        foreach (string word in words)
        {
            letterCount += word.Length;
        }

        Console.WriteLine("Toplam kelime sayısı: {0}", wordCount);
        Console.WriteLine("Toplam harf sayısı: {0}", letterCount);
    }
}
