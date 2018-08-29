using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    abstract class SpaceStation
    {
        abstract public object Firelaser { get; }
        abstract protected object Lasersound(string sound);
    }
}
