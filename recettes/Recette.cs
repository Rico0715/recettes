using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recettes
{
    public class Recette
    {
        public string Nom { get; set; }
        public List<string> Ingredients { get; set; }
        public Recette(string nom, List<string> ingredients)
        {
            Nom = nom;
            Ingredients = ingredients;
        }
    }
}
