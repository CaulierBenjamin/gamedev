namespace gamedev.Properties
{
    public class Humain
    {
        private int id;
        private string nom;
        private string prenom;
        private int age;

        public Humain(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.age = 18;
        }

        public int getId()
        {
            return this.id;
        }
        public string getNom()
        {
            return this.nom;
        }
        public string getPrenom()
        {
            return this.prenom;
        }
        public int getAge()
        {
            return this.age;
        }

        public void setId(int prmId)
        {
            this.id = prmId;
        }

        public void setAge(int p)
        {
            this.age = p;
        }

        public string afficher()
        {
            return (this.id + " / " + this.nom + " / " + this.prenom + " / " + this.age);
        }
    }
}