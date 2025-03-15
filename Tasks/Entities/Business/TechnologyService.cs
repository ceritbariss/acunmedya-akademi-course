using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business;

public class TechnologyService
{
    public virtual void Add(Technology technology) { }
    public virtual void Delete(int id) { }
    public virtual void Update(Technology technology) { }
    public virtual Technology GetById(int id) { return null; }
    public virtual List<Technology> GetAll() { return new List<Technology>(); }
}
