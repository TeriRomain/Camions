using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.IO;

//consulter : http: //www.6ma.fr/tuto/csharp+dessiner+avec+gdi+partie+1-74

namespace ProjetCamion
{
    public partial class Form1 : Form
    {
        Camion monCamion;
        System.IO.StreamWriter fichierTexte;


        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(1200, 600);
            this.SetStyle(ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer, true);

            this.monCamion = new Camion();
            this.fichierTexte = new System.IO.StreamWriter(@"C:\Users\Romain\Documents\cle USB sauvegarde\Projet perso\ProjetCamion\mespts.txt", true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //this.DrawCamion(400, 150);
            this.monCamion.DrawCamionLeft(400, 50, this);
            this.monCamion.DrawCamionRight(400, 300, this);
            this.richTextBox1.Text = this.monCamion.PointsR.Count.ToString()+"\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.fichierTexte.WriteLine("stop : "+this.monCamion.PointsR.Count.ToString());
        }

        private void clicsouris(object sender, MouseEventArgs e)
        {
            this.richTextBox1.Text += "X : "+e.X+"  Y : "+e.Y+"\n";
            this.fichierTexte.WriteLine("this.PointsR.Add(new Point(x + "+(e.X-400).ToString()+", y + "+(e.Y-300).ToString()+"));");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.fichierTexte.Dispose();
        }

        private void clicsouris()
        {

        }
    }

}
