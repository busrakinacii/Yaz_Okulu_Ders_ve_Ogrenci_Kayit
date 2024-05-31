namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string name;
        private string surname;
        private int id;
        private string number;
        private string photo;
        private double balance;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Id { get => id; set => id = value; }
        public string Number { get => number; set => number = value; }
        public string Photo { get => photo; set => photo = value; }
        public double Balance { get => balance; set => balance = value; }
    }
}
