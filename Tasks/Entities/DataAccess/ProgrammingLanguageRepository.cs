using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public class ProgrammingLanguageRepository
{
    private List<ProgrammingLanguage> _programmingLanguages = new();

    public void Add(ProgrammingLanguage language)
    {
        _programmingLanguages.Add(language);
    }

    public void Delete(int id)
    {
        var language = _programmingLanguages.FirstOrDefault(l => l.Id == id);
        if (language != null)
            _programmingLanguages.Remove(language);
    }

    public void Update(ProgrammingLanguage language)
    {
        var existing = _programmingLanguages.FirstOrDefault(l => l.Id == language.Id);
        if (existing != null)
            existing.Name = language.Name;
    }

    public ProgrammingLanguage GetById(int id)
    {
        return _programmingLanguages.FirstOrDefault(l => l.Id == id);
    }

    public List<ProgrammingLanguage> GetAll()
    {
        return _programmingLanguages;
    }
}

