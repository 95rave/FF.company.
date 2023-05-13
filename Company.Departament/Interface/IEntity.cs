using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Departament.Interface1
{
    public interface IEntity
    {
        int Id { get; }
        string Name { get; set; }
        string ToString();
    }
}
