/* SORU 1 */
Console.Write("Bir sayı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
int sayi2 = sayi1;
int toplam = 0;
for(int i = 0; i < sayi1.ToString().Length; i++) 
{
    int rakam = sayi2 % 10;
    toplam += rakam;
    sayi2 /= 10;
}

Console.WriteLine("Rakamların toplamı:" + toplam);


/* SORU 2 */
Console.WriteLine("----------------------------------------------");
int sayi;
while (true) 
{
    Console.Write("Lütfen 10 ile 100 arasında bir sayı girin: ");
    sayi = Convert.ToInt32(Console.ReadLine());

    if(sayi >= 10 && sayi <= 100) 
    {
        Console.WriteLine("Geçerli sayı girdiniz: " + sayi);
        break;
    }
    else
    {
        Console.WriteLine("Hatalı giriş! 10 ile 100 arasında bir sayı giriniz.");
    }
}


/* SORU 3 */
Console.WriteLine("----------------------------------------------");
int[] yaslar = { 3, 15, 25, 70, 10, 18, 40, 65 };

foreach (int yas in yaslar)
{
    string kategori;

    if (yas >= 0 && yas <= 12)
        kategori = "Çocuk";
    else if (yas >= 13 && yas <= 19)
        kategori = "Genç";
    else if (yas >= 20 && yas <= 64)
        kategori = "Yetişkin";
    else
        kategori = "Yaşlı";

    Console.WriteLine($"Yaş: {yas} -> Kategori: {kategori}");
}


/* SORU 4 */
Console.WriteLine("----------------------------------------------");

int[] dizi = { 3, 5, 8, 3, 9, 5, 7, 8, 10, 3 };

Dictionary<int, int> elemanSayilari = new Dictionary<int, int>();

foreach (int eleman in dizi)
{
    if (elemanSayilari.ContainsKey(eleman))
        elemanSayilari[eleman]++;
    else
        elemanSayilari[eleman] = 1;
}

Console.WriteLine("Tekrar edenler:");
foreach (var item in elemanSayilari)
{
    if (item.Value > 1)
        Console.WriteLine($"Eleman: {item.Key}, Tekrar Sayısı: {item.Value}");
}


/* SORU 5 */
Console.WriteLine("----------------------------------------------");
string[] kelimeler = { "Bilgisayar", "Gökkuşağı", "Masa", "Tavuk", "Şehir", "Yıldız"};

string enKisa = kelimeler[0];
string enUzun = kelimeler[0];

for (int i = 1; i < kelimeler.Length; i++)
{
    if (kelimeler[i].Length < enKisa.Length)
        enKisa = kelimeler[i];

    if (kelimeler[i].Length > enUzun.Length)
        enUzun = kelimeler[i];
}

Console.WriteLine("En kısa kelime  " + enKisa);
Console.WriteLine("En uzun kelime  " + enUzun);


/* SORU 6 */
Console.WriteLine("----------------------------------------------");
Console.Write("Bir cümle giriniz:");
string cumle = Console.ReadLine();

string[] kelimeler2 = cumle.Split(' ');

Array.Sort(kelimeler2);

Console.WriteLine("Alfabetik sıralanmış kelimeler:");
foreach (string kelime1 in kelimeler2)
{
    Console.WriteLine(kelime1);
}


/* SORU 7 */
Console.WriteLine("----------------------------------------------");
string[] kelimeler3 = new string[3] { "Elma", "Araba", "Köpek" };
Array.Resize(ref kelimeler3, kelimeler3.Length + 1);

kelimeler3[kelimeler3.Length - 1] = "Ayı";

Console.WriteLine("Dizinin elemanları:");
foreach (var kelime3 in kelimeler3)
{
    Console.WriteLine(kelime3);
}


/* SORU 8 */
Console.WriteLine("----------------------------------------------");
Console.Write("Bir kelime yazınız: (Çıkmak isterseniz çıkış yazınız) ");

List<string> kelimeler4 = new List<string>();

while (true)
{
    string kelime4 = Console.ReadLine();

    if (kelime4.ToLower() == "çıkış")
    {
        break;
    }

    kelimeler4.Add(kelime4);
}

kelimeler4.Reverse();
Console.Write("Tersten yazdırılan dizi: ");
foreach (string kelime4 in kelimeler4)
{
    Console.WriteLine(kelime4);
}


/* SORU 9 */
Console.WriteLine("----------------------------------------------");
Console.Write("Listeye eklemek istediğiniz sayıyı yazınız (Çıkmak isterseniz -1 yazınız): ");
float ort;
int toplam9 = 0;

List<int> sayilar9 = new List<int>();

while (true)
{
    int sayi9 = Convert.ToInt32(Console.ReadLine());

    if (sayi9 == -1)
    {
        break;
    }

    sayilar9.Add(sayi9);
}

for (int i = 0; i < sayilar9.Count(); i++) 
{
    toplam9 += sayilar9[i];
}

ort = toplam9 / sayilar9.Count();

int enKucukSayi = sayilar9[0];

for (int j = 0; j < sayilar9.Count(); j++)
{
    if(enKucukSayi > sayilar9[j]) 
    {
        enKucukSayi = sayilar9[j];
    }
}

Console.WriteLine("Listedeki sayıların ortalaması: " + ort);
Console.WriteLine("Listedeki en küçük sayı: " + enKucukSayi);


/* SORU 10 */
Console.WriteLine("----------------------------------------------");

List<int> sayilar10 = new List<int> { 5, 12, 3, 8, 20, 7, 15, 6 };

sayilar10.RemoveAll(sayi10 => sayi10 < 10);

Console.WriteLine("10'dan küçük olan sayılar silindi:");
foreach (int sayi10 in sayilar10)
{
    Console.WriteLine(sayi10);
}


/* SORU 11 */
Console.WriteLine("----------------------------------------------");
List<int> ogrenciNotlari = new List<int> { 45, 72, 38, 55, 49, 89, 23, 67 };

for (int i = 0; i < ogrenciNotlari.Count; i++)
{
    if (ogrenciNotlari[i] < 50)
    {
        ogrenciNotlari[i] = 50;
    }
}

Console.WriteLine("Güncellenmiş Öğrenci Notları:");
foreach (int not in ogrenciNotlari)
{
    Console.WriteLine(not);
}