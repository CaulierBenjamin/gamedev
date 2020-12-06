using System;
using gamedev.Properties;

namespace gamedev
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Humain objet1 = new Humain(1 , "Caulier","Benjamin");
            Humain objet2 = new Humain(2 , "Paque","Sanddy");
            Enfant objet3 = new Enfant(3, "truc", "machin", objet1, objet2);

            Console.WriteLine(objet3.getId());
            Console.WriteLine(objet3.getNom());
            Console.WriteLine(objet3.getPrenom());
            Console.WriteLine(objet3.getAge());
            
            Humain parent  = objet3.getparent1();
            Console.WriteLine(parent.afficher());
            parent  = objet3.getparent2();
            Console.WriteLine(parent.afficher());
            
            
            objet1.setId(5);
            Console.WriteLine(objet1.afficher());
            //test
            Console.WriteLine("debut");
            Console.WriteLine(objet1.afficher());
            Console.WriteLine(objet3.afficher());
            Console.WriteLine("fin");
            //fin
            
            
            
            
            
            Console.WriteLine("--|modification|--");
            Console.WriteLine(objet1.getId());
            Console.WriteLine(objet1.getNom());
            Console.WriteLine(objet1.getPrenom());
            Console.WriteLine(objet1.getAge());
            
        }
    }
}