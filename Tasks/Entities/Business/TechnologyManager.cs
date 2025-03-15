using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business;

public class TechnologyManager : TechnologyService
{
    private readonly TechnologyRepository _repository;

    public TechnologyManager()
    {
        _repository = new TechnologyRepository();
    }

    public override void Add(Technology technology)
    {
        if (!string.IsNullOrWhiteSpace(technology.Name) && technology.ProgrammingLanguage.Id > 0)
        {
            _repository.Add(technology);
        }
        else
        {
            Console.WriteLine("Hata: Teknoloji adı boş olamaz ve geçerli bir programlama dili ID'si girilmelidir!");
        }
    }

    public override void Delete(int id)
    {
        var technology = _repository.GetById(id);
        if (technology != null)
        {
            _repository.Delete(id);
        }
        else
        {
            Console.WriteLine("Hata: Silinecek teknoloji bulunamadı!");
        }
    }

    public override void Update(Technology technology)
    {
        var existing = _repository.GetById(technology.Id);
        if (existing != null)
        {
            _repository.Update(technology);
        }
        else
        {
            Console.WriteLine("Hata: Güncellenecek teknoloji bulunamadı!");
        }
    }

    public override Technology GetById(int id)
    {
        return _repository.GetById(id);
    }

    public override List<Technology> GetAll()
    {
        return _repository.GetAll();
    }
}
