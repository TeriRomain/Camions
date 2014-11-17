using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetCamion
{
    class Palette
    {
        /*****en metre*****/
        private float longueur;
        private float largeur;
        private float hauteur;
        /*******************/

        public float Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public float Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }

        public float Hauteur
        {
            get { return hauteur; }
            set { hauteur = value; }
        }
        
    }
}
