using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDD
{
    class Cooker
    {
        private int? Id { get; }
        private string nom { get; }
        private string tel { get; }
        private string MDP { get; }

        public Cooker(int id, string nom, string tel, string MDP)
        {
            this.Id = id;
            this.nom = nom;
            this.tel = tel;
            this.MDP = MDP;
        }
    }
}
