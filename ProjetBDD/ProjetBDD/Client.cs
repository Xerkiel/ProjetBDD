using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDD
{
    class Client
    {
        private int? Id { get; }
        private string Nom { get; }
        private string pseudo { get; }
        private string tel { get; }
        private string MDP { get; }
        private int nbCook { get; }
        private bool CDR { get; }

        public Client()
        {
            
            this.Nom = "";
            this.pseudo = "";
            this.MDP = "";
            this.tel = "";
            this.CDR = false;
        }
        public Client(int id,string nom,string pseudo,string tel,string MDP,int nbCook,bool CDR)
        {
            this.Id = id;
            this.Nom = nom;
            this.pseudo = pseudo;
            this.tel = tel;
            this.MDP = MDP;
            this.nbCook = nbCook;
            this.CDR = CDR;
        }
    }
}
