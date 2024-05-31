using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityBasvuruForm
    {
        private int basid;
        private int basdersid;
        private int basogrid;

        public int Basid { get => basid; set => basid = value; }
        public int Basdersid { get => basdersid; set => basdersid = value; }
        public int Basogrid { get => basogrid; set => basogrid = value; }
    }
}
