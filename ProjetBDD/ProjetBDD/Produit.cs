using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDD
{
    class Produit
    {
        private int? Id { get; }
        private string Nom { get; }
        private string Categorie { get; }
        private float UQA { get; }
        private int Quantite { get; }
        private int Quantite_Minimal { get; }
        private int Quantite_Maximal { get; }
        private string Fournisseur { get; }


        public Produit(int id, string nom, string categorie, float UQA, int quantite, int quantite_minimal, int quantite_maximal, string fournisseur)
        {
            this.Id = id;
            this.Nom = nom;
            this.Categorie = categorie;
            this.UQA = UQA;
            this.Quantite = quantite;
            this.Quantite_Minimal = quantite_minimal;
            this.Quantite_Maximal = quantite_maximal;
            this.Fournisseur = fournisseur;
        }
    }
}
