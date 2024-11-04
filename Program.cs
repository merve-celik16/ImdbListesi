using System;
using System.Collections.Generic;

class Film
{
    public double ImdbPuanı { get; set; }
    public string İsmi { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Film> filmler = new List<Film>();

        while (true)
        {
            Film film = new Film();
            Console.Write("Film ismi: ");
            film.İsmi = Console.ReadLine();
            Console.Write("IMDB puanı: ");
            film.ImdbPuanı = Convert.ToDouble(Console.ReadLine());
            filmler.Add(film);

            Console.Write("Yeni bir film eklemek ister misiniz? (e/h): ");
            string cevap = Console.ReadLine().ToLower();
            if (cevap != "e")
            { }
        }

        // Tüm filmleri listeleme
        Console.WriteLine("\nTüm filmler:");
        foreach (var film in filmler)
        {
            Console.WriteLine($"İsim: {film.İsmi}, IMDB Puanı: {film.ImdbPuanı}");
        }

        // IMDB puanı 4 ile 9 arasında olan filmler
        Console.WriteLine("\nIMDB puanı 4 ile 9 arasında olan filmler:");
        foreach (var film in filmler)
        {
            if (film.ImdbPuanı >= 4 && film.ImdbPuanı <= 9)
            {
                Console.WriteLine($"İsim: {film.İsmi}, IMDB Puanı: {film.ImdbPuanı}");
            }
        }

        // İsmi 'A' ile başlayan filmler
        Console.WriteLine("\nİsmi 'A' ile başlayan filmler:");
        foreach (var film in filmler)
        {
            if (film.İsmi.StartsWith("A"))
            {
                Console.WriteLine($"İsim: {film.İsmi}, IMDB Puanı: {film.ImdbPuanı}");
            }
        }
    }
}