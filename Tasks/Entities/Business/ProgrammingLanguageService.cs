using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business;

public class ProgrammingLanguageService
{
    public virtual void Add(ProgrammingLanguage language) { }
    public virtual void Delete(int id) { }
    public virtual void Update(ProgrammingLanguage language) { }
    public virtual ProgrammingLanguage GetById(int id) { return null; }
    public virtual List<ProgrammingLanguage> GetAll() { return new List<ProgrammingLanguage>(); }
}
