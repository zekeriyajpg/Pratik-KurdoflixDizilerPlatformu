using Pratik_KürdoflixDizilerPlatformu;

List<Dizi> diziler = new List<Dizi>();
string cevap;

do
{
    Dizi yenidizi = new Dizi();

    Console.WriteLine("Dizi adını giriniz : ");
    yenidizi.DiziAdi = Console.ReadLine();

    Console.WriteLine("Dizi türünü giriniz : ");
    yenidizi.DiziTuru = Console.ReadLine();

    Console.WriteLine("Yönetmen adını giriniz : ");
    yenidizi.Yönetmen = Console.ReadLine();

    Console.WriteLine("Bölüm sayısını giriniz : ");
    yenidizi.Bölümsayisi = int.Parse(Console.ReadLine());

    Console.WriteLine("Yayın kanalını giriniz : ");
    yenidizi.YayınKanalı = Console.ReadLine();

    diziler.Add(yenidizi);

    Console.WriteLine("Yeni bir dizi eklemek ister misiniz (E/H) : ");
    cevap = Console.ReadLine().ToUpper();



} while (cevap == "E");

List<KomediDizisi> komediDizileri = diziler
                .Where(dizi => dizi.DiziTuru.ToLower() == "komedi")
                .Select(dizi => new KomediDizisi
                {
                    DiziAdi = dizi.DiziAdi,
                    DiziTuru = dizi.DiziTuru,
                    Yönetmen = dizi.Yönetmen
                })
                .OrderBy(dizi => dizi.DiziAdi)
                .ThenBy(dizi => dizi.Yönetmen)
                .ToList();

// Komedi dizileri listesi ekrana yazdırılıyor.
Console.WriteLine("\nKomedi Dizileri Listesi:");
foreach (var komediDizi in komediDizileri)
{
    Console.WriteLine($"Dizi Adı: {komediDizi.DiziAdi}, Türü: {komediDizi.DiziTuru}, Yönetmen: {komediDizi.Yönetmen}");
}