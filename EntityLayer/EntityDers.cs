using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityDers
    {
        private string lesson_name;
        private int min;
        private int max;
        private int id;

        public string Lesson_name { get => lesson_name; set => lesson_name = value; }
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }
        public int Id { get => id; set => id = value; }
    }
}
