using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public class TechnologyRepository
{
    private List<Technology> _technologies = new();

    public void Add(Technology technology)
    {
        _technologies.Add(technology);
    }

    public void Delete(int id)
    {
        var technology = _technologies.FirstOrDefault(t => t.Id == id);
        if (technology != null)
            _technologies.Remove(technology);
    }

    public void Update(Technology technology)
    {
        var existing = _technologies.FirstOrDefault(t => t.Id == technology.Id);
        if (existing != null) 
        {
            existing.Name = technology.Name;
            existing.ProgrammingLanguage = technology.ProgrammingLanguage;
        }      
    }

    public Technology GetById(int id)
    {
        return _technologies.FirstOrDefault(t => t.Id == id);
    }

    public List<Technology> GetAll()
    {
        return _technologies;
    }
}
