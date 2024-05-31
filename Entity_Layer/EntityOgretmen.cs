using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    internal class EntityOgretmen
    {
        private int id;
        private string teacher_name;
        private string teacher_branch;

        public int Id { get => id; set => id = value; }
        public string Teacher_name { get => teacher_name; set => teacher_name = value; }
        public string Teacher_branch { get => teacher_branch; set => teacher_branch = value; }
    }
}
