namespace gamedev.Properties
{
    public class Enfant : Humain
    {
        private Humain parent1;
        private Humain parent2;

        public Enfant(int id, string nom, string prenom, Humain prmParent1, Humain prmParent2) : base(id , nom , prenom)
        {
            this.parent1 = prmParent1;
            this.parent2 = prmParent2;
        }

        public Humain getparent1()
        {
            return this.parent1;
        }
        public Humain getparent2()
        {
            return this.parent2;
        }

        public string afficher()
        {
            return base.afficher() + " E/ " + this.parent1.getPrenom() + " / " + this.parent2.getPrenom();
        }
    }
}