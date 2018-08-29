using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    class Deathstar : SpaceStation
    {
        private string _total;
        public override object Firelaser
        {
            get
            {
                return _total;
            }
        }
        public Deathstar(string sound)
        {
            _total = (string)this.Lasersound(sound);
        }

        protected override object Lasersound(string sound)
        {
            return sound;
        }
    }
}
