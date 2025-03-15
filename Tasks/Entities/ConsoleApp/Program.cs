using Business;
using Entities;

class Program 
{
    static void Main(string[] args)
    {
        ProgrammingLanguageManager languageManager = new ProgrammingLanguageManager();
        TechnologyManager technologyManager = new TechnologyManager();

        while (true)
        {
            Console.WriteLine("\n1- Programlama Dili Ekle");
            Console.WriteLine("2- Programlama Dili Güncelle");
            Console.WriteLine("3- Programlama Dili Sil");
            Console.WriteLine("4- Tüm Programlama Dillerini Listele");
            Console.WriteLine("5- ID'ye Göre Programlama Dili Getir");
            Console.WriteLine("6- Teknoloji Ekle");
            Console.WriteLine("7- Teknoloji Güncelle");
            Console.WriteLine("8- Teknoloji Sil");
            Console.WriteLine("9- Tüm Teknolojileri Listele");
            Console.WriteLine("10- ID'ye Göre Teknoloji Getir");
            Console.WriteLine("11- Çıkış");
            Console.Write("Seçiminizi yapın: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Programlama dili adı: ");
                    string langName = Console.ReadLine();
                    languageManager.Add(new ProgrammingLanguage { Id = new Random().Next(1, 1000), Name = langName });
                    Console.WriteLine("Programlama dili eklendi!");
                    break;

                case "2":
                    Console.Write("Güncellenecek programlama dili ID: ");
                    int updateLangId = int.Parse(Console.ReadLine());

                    var existingLang = languageManager.GetById(updateLangId);
                    if (existingLang != null)
                    {
                        Console.Write("Yeni programlama dili adı: ");
                        string newLangName = Console.ReadLine();
                        existingLang.Name = newLangName;
                        languageManager.Update(existingLang);
                        Console.WriteLine("Programlama dili başarıyla güncellendi!");
                    }
                    else
                    {
                        Console.WriteLine("Hata: Güncellenecek programlama dili bulunamadı!");
                    }
                    break;

                case "3":
                    Console.Write("Silinecek programlama dili ID: ");
                    int langId = int.Parse(Console.ReadLine());
                    languageManager.Delete(langId);
                    Console.WriteLine("Programlama dili silindi!");
                    break;

                case "4":
                    var languages = languageManager.GetAll();
                    if (languages.Count == 0)
                        Console.WriteLine("Henüz eklenen programlama dili yok.");
                    else
                        foreach (var lang in languages)
                            Console.WriteLine($"ID: {lang.Id}, Name: {lang.Name}");
                    break;

                case "5":
                    Console.Write("ID'yi girin: ");
                    int searchLangId = int.Parse(Console.ReadLine());
                    var foundLang = languageManager.GetById(searchLangId);
                    if (foundLang != null)
                        Console.WriteLine($"Bulunan Dil -> ID: {foundLang.Id}, Name: {foundLang.Name}");
                    else
                        Console.WriteLine("Belirtilen ID'ye sahip programlama dili bulunamadı.");
                    break;

                case "6":
                    Console.Write("Teknoloji adı: ");
                    string techName = Console.ReadLine();
                    Console.Write("Bu teknoloji hangi programlama diline ait: ");
                    int techLangId;
                    if (int.TryParse(Console.ReadLine(), out techLangId))
                    {
                        technologyManager.Add(new Technology { Id = new Random().Next(1, 1000), Name = techName, ProgrammingLanguage = languageManager.GetById(techLangId) });
                        Console.WriteLine("Teknoloji eklendi!");
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş! Programlama dili ID'si sayı olmalıdır.");
                    }
                    break;

                case "7":
                    Console.Write("Güncellenecek teknoloji ID: ");
                    int updateTechId = int.Parse(Console.ReadLine());

                    var existingTech = technologyManager.GetById(updateTechId);
                    if (existingTech != null)
                    {
                        Console.Write("Yeni teknoloji adı: ");
                        string newTechName = Console.ReadLine();
                        Console.Write("Yeni programlama dili ID: ");
                        int newTechLangId = int.Parse(Console.ReadLine());

                        existingTech.Name = newTechName;
                        existingTech.ProgrammingLanguage.Id = newTechLangId;
                        technologyManager.Update(existingTech);
                        Console.WriteLine("Teknoloji başarıyla güncellendi!");
                    }
                    else
                    {
                        Console.WriteLine("Hata: Güncellenecek teknoloji bulunamadı!");
                    }
                    break;

                case "8":
                    Console.Write("Silinecek teknoloji ID: ");
                    int techId = int.Parse(Console.ReadLine());
                    technologyManager.Delete(techId);
                    Console.WriteLine("Teknoloji silindi!");
                    break;

                case "9":
                    var technologies = technologyManager.GetAll();
                    if (technologies.Count == 0)
                        Console.WriteLine("Henüz eklenen teknoloji yok.");
                    else
                        foreach (var tech in technologies)
                            Console.WriteLine($"ID: {tech.Id}, Name: {tech.Name}, Programming Language ID: {tech.ProgrammingLanguage.Id}");
                    break;

                case "10":
                    Console.Write("ID'yi girin: ");
                    int searchTechId = int.Parse(Console.ReadLine());
                    var foundTech = technologyManager.GetById(searchTechId);
                    if (foundTech != null)
                        Console.WriteLine($"Bulunan Teknoloji -> ID: {foundTech.Id}, Name: {foundTech.Name}, Programming Language ID: {foundTech.ProgrammingLanguage.Id}");
                    else
                        Console.WriteLine("Belirtilen ID'ye sahip teknoloji bulunamadı.");
                    break;

                case "11":
                    return;

                default:
                    Console.WriteLine("Geçersiz seçim! Lütfen 1-11 arasında bir sayı girin.");
                    break;
            }
        }
    }
}