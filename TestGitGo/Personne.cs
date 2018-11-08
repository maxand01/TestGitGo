using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitGo
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Personne()
        {

        }
        public Personne(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public override string ToString()
        {
            return base.ToString() + $"Pokemon GO {Nom} {Prenom}";
        }
    }
}
