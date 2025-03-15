using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business;

public class ProgrammingLanguageManager : ProgrammingLanguageService
{
    private readonly ProgrammingLanguageRepository _repository;

    public ProgrammingLanguageManager()
    {
        _repository = new ProgrammingLanguageRepository();
    }

    public override void Add(ProgrammingLanguage language)
    {
        if (!string.IsNullOrWhiteSpace(language.Name))
        {
            _repository.Add(language);
            Console.WriteLine($"Programlama dili eklendi! -> ID: {language.Id}, Name: {language.Name}");
        }
        else
        {
            Console.WriteLine("Programlama dili adı boş olamaz!");
        }
    }

    public override void Delete(int id)
    {
        var language = _repository.GetById(id);
        if (language != null)
        {
            _repository.Delete(id);
        }
        else
        {
            Console.WriteLine("Hata: Programlama dili bulunamadı!");
        }
    }

    public override void Update(ProgrammingLanguage language)
    {
        var existing = _repository.GetById(language.Id);
        if (existing != null)
        {
            _repository.Update(language);
        }
        else
        {
            Console.WriteLine("Hata: Güncellenecek programlama dili bulunamadı!");
        }
    }

    public override ProgrammingLanguage GetById(int id)
    {
        return _repository.GetById(id);
    }

    public override List<ProgrammingLanguage> GetAll()
    {
        return _repository.GetAll();
    }
}
