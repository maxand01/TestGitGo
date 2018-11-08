using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitGo
{
  public class Salarie : Personne
  {
    public Salarie(string nom, string prenom, int salaire) : base(nom, prenom)
    {
      Sal = salaire;
    }

    public Salarie(Personne p1, int salaire)
    {
      Sal = salaire;
    }

    public int Sal { get; set; }
  }
}
