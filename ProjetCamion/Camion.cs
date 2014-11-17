using System;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.IO;

namespace ProjetCamion
{
    class Camion
    {
        //*******************//
        //*****en metre*****//
        private Double Hauteur;
        private Double Longueur;
        private Double largeur;
        //*******************//
        private Pen unStylo;
        private Pen UnStyloFin;
        private Collection<Int32> NbrInterdit;
        private Rectangle[] rects = new Rectangle[200];
        private Collection<Point> PointsL = new Collection<Point>();
        public Collection<Point> PointsR = new Collection<Point>();
        private Collection<Palette> PalettesCharge;

        public Camion()
        {
            this.PalettesCharge = new Collection<Palette>();
            this.unStylo = new Pen(Color.Black, 2);
            this.UnStyloFin = new Pen(Color.Black, 1);
            this.Hauteur = 1.8;
            this.Longueur = 13.6;
            this.largeur = 1.20*2;

            this.NbrInterdit = new Collection<Int32>();
            this.NbrInterdit.Add(10);
            this.NbrInterdit.Add(14);
            this.NbrInterdit.Add(18);
            this.NbrInterdit.Add(21);
            this.NbrInterdit.Add(23);
            this.NbrInterdit.Add(27);
            this.NbrInterdit.Add(33);
            this.NbrInterdit.Add(42);
            this.NbrInterdit.Add(44);
            this.NbrInterdit.Add(48);
            this.NbrInterdit.Add(51);
            this.NbrInterdit.Add(59);
            this.NbrInterdit.Add(61);
            this.NbrInterdit.Add(66);
            this.NbrInterdit.Add(68);
        }

        private Boolean VerifInd(Int32 i)
        {
            foreach (Int32 chiffre in this.NbrInterdit)
            {
                if (i == chiffre)
                {
                    return false;
                }
            }
            return true;
        }

        public void DrawCamionLeft(int x, int y, Form uneFenetre)
        {
                uneFenetre.Invalidate();

                if (this.PointsL.Count == 0)
                {
                    this.PointsL.Add(new Point(x - 12, y + 44));
                    this.PointsL.Add(new Point(x - 94, y + 44));
                    this.PointsL.Add(new Point(x - 95, y + 52));
                    this.PointsL.Add(new Point(x - 99, y + 93));
                    this.PointsL.Add(new Point(x - 103, y + 94));
                    this.PointsL.Add(new Point(x - 103, y + 127));
                    this.PointsL.Add(new Point(x - 94, y + 128));
                    this.PointsL.Add(new Point(x - 93, y + 70));
                    this.PointsL.Add(new Point(x - 89, y + 53));
                    this.PointsL.Add(new Point(x - 12, y + 53));
                    this.PointsL.Add(new Point(x - 12, y + 163));
                    this.PointsL.Add(new Point(x - 14, y + 42));
                    this.PointsL.Add(new Point(x - 14, y + 26));
                    this.PointsL.Add(new Point(x - 80, y + 25));
                    this.PointsL.Add(new Point(x - 91, y + 42));
                    this.PointsL.Add(new Point(x - 11, y + 82));
                    this.PointsL.Add(new Point(x - 93, y + 82));
                    this.PointsL.Add(new Point(x - 92, y + 89));
                    this.PointsL.Add(new Point(x - 11, y + 87));
                    this.PointsL.Add(new Point(x - 42, y + 53));
                    this.PointsL.Add(new Point(x - 42, y + 119));
                    this.PointsL.Add(new Point(x - 9, y + 120));
                    this.PointsL.Add(new Point(x - 15, y + 45));
                    this.PointsL.Add(new Point(x - 14, y + 51));
                    this.PointsL.Add(new Point(x - 94, y + 128));
                    this.PointsL.Add(new Point(x - 94, y + 165));
                    this.PointsL.Add(new Point(x - 102, y + 164));
                    this.PointsL.Add(new Point(x - 103, y + 127));
                    this.PointsL.Add(new Point(x - 103, y + 141));
                    this.PointsL.Add(new Point(x - 71, y + 140));
                    this.PointsL.Add(new Point(x - 66, y + 127));
                    this.PointsL.Add(new Point(x - 62, y + 121));
                    this.PointsL.Add(new Point(x - 59, y + 120));
                    this.PointsL.Add(new Point(x - 42, y + 119));
                    this.PointsL.Add(new Point(x - 94, y + 165));
                    this.PointsL.Add(new Point(x - 94, y + 168));
                    this.PointsL.Add(new Point(x - 70, y + 167));
                    this.PointsL.Add(new Point(x - 67, y + 163));
                    this.PointsL.Add(new Point(x - 65, y + 150));
                    this.PointsL.Add(new Point(x - 62, y + 141));
                    this.PointsL.Add(new Point(x - 61, y + 130));
                    this.PointsL.Add(new Point(x - 60, y + 128));
                    this.PointsL.Add(new Point(x - 11, y + 127));
                    this.PointsL.Add(new Point(x - 99, y + 93));
                    this.PointsL.Add(new Point(x - 99, y + 164));
                    this.PointsL.Add(new Point(x - 99, y + 156));
                    this.PointsL.Add(new Point(x - 66, y + 157));
                    this.PointsL.Add(new Point(x - 66, y + 153));
                    this.PointsL.Add(new Point(x - 98, y + 154));
                    this.PointsL.Add(new Point(x - 36, y + 128));
                    this.PointsL.Add(new Point(x - 16, y + 134));
                    this.PointsL.Add(new Point(x - 12, y + 133));
                    this.PointsL.Add(new Point(x - 12, y + 135));
                    this.PointsL.Add(new Point(x - 13, y + 145));
                    this.PointsL.Add(new Point(x - -84, y + 145));
                    this.PointsL.Add(new Point(x - -84, y + 139));
                    this.PointsL.Add(new Point(x - -87, y + 135));
                    this.PointsL.Add(new Point(x - -90, y + 131));
                    this.PointsL.Add(new Point(x - -94, y + 127));
                    this.PointsL.Add(new Point(x - 10, y + 128));
                    this.PointsL.Add(new Point(x - 10, y + 121));
                    this.PointsL.Add(new Point(x - 0, y + 120));
                    this.PointsL.Add(new Point(x - 2, y + 128));
                    this.PointsL.Add(new Point(x - 2, y + 144));
                    this.PointsL.Add(new Point(x - -43, y + 144));
                    this.PointsL.Add(new Point(x - -42, y + 128));
                    this.PointsL.Add(new Point(x - 1, y + 128));
                    this.PointsL.Add(new Point(x, y));
                    this.PointsL.Add(new Point(x, y + 120));
                }

                uneFenetre.Paint += delegate(object sd, PaintEventArgs args)
                {
                    Graphics g = args.Graphics;
                    g.DrawRectangles(Pens.Black, rects);

                    for (int j = 0; j < this.PointsL.Count - 1; j++)
                    {

                        if (this.VerifInd(j))
                        {
                            g.DrawLine(this.unStylo, this.PointsL[j], this.PointsL[j + 1]);
                        }
                    }
                    g.DrawEllipse(this.unStylo, new Rectangle(x - 63, y + 130, 45, 45));
                    g.DrawEllipse(this.unStylo, new Rectangle(x + 81, y + 127, 48, 48));
                    g.DrawEllipse(this.unStylo, new Rectangle(x + 310, y + 127, 48, 48));
                    g.DrawEllipse(this.unStylo, new Rectangle(x + 360, y + 127, 48, 48));
                    g.DrawLine(new Pen(Color.Black, 6), new Point(x, y + 124), new Point(x + 450, y + 124));
                    
                };
                
        }

        public void DrawCamionRight(int x, int y, Form uneFenetre)
        {
            uneFenetre.Invalidate();
            x += 380;

            if (this.PointsR.Count == 0)
            {
                this.PointsR.Add(new Point(x + 12, y + 44));
                this.PointsR.Add(new Point(x + 94, y + 44));
                this.PointsR.Add(new Point(x + 95, y + 52));
                this.PointsR.Add(new Point(x + 99, y + 93));
                this.PointsR.Add(new Point(x + 103, y + 94));
                this.PointsR.Add(new Point(x + 103, y + 127));
                this.PointsR.Add(new Point(x + 94, y + 128));
                this.PointsR.Add(new Point(x + 93, y + 70));
                this.PointsR.Add(new Point(x + 89, y + 53));
                this.PointsR.Add(new Point(x + 12, y + 53));
                this.PointsR.Add(new Point(x + 12, y + 163));
                this.PointsR.Add(new Point(x + 14, y + 42));
                this.PointsR.Add(new Point(x + 14, y + 26));
                this.PointsR.Add(new Point(x + 80, y + 25));
                this.PointsR.Add(new Point(x + 91, y + 42));
                this.PointsR.Add(new Point(x + 11, y + 82));
                this.PointsR.Add(new Point(x + 93, y + 82));
                this.PointsR.Add(new Point(x + 92, y + 89));
                this.PointsR.Add(new Point(x + 11, y + 87));
                this.PointsR.Add(new Point(x + 42, y + 53));
                this.PointsR.Add(new Point(x + 42, y + 119));
                this.PointsR.Add(new Point(x + 9, y + 120));
                this.PointsR.Add(new Point(x + 15, y + 45));
                this.PointsR.Add(new Point(x + 14, y + 51));
                this.PointsR.Add(new Point(x + 94, y + 128));
                this.PointsR.Add(new Point(x + 94, y + 165));
                this.PointsR.Add(new Point(x + 102, y + 164));
                this.PointsR.Add(new Point(x + 103, y + 127));
                this.PointsR.Add(new Point(x + 103, y + 141));
                this.PointsR.Add(new Point(x + 71, y + 140));
                this.PointsR.Add(new Point(x + 66, y + 127));
                this.PointsR.Add(new Point(x + 62, y + 121));
                this.PointsR.Add(new Point(x + 59, y + 120));
                this.PointsR.Add(new Point(x + 42, y + 119));
                this.PointsR.Add(new Point(x + 94, y + 165));
                this.PointsR.Add(new Point(x + 94, y + 168));
                this.PointsR.Add(new Point(x + 70, y + 167));
                this.PointsR.Add(new Point(x + 67, y + 163));
                this.PointsR.Add(new Point(x + 65, y + 150));
                this.PointsR.Add(new Point(x + 62, y + 141));
                this.PointsR.Add(new Point(x + 61, y + 130));
                this.PointsR.Add(new Point(x + 60, y + 128));
                this.PointsR.Add(new Point(x + 11, y + 127));
                this.PointsR.Add(new Point(x + 99, y + 93));
                this.PointsR.Add(new Point(x + 99, y + 164));
                this.PointsR.Add(new Point(x + 99, y + 156));
                this.PointsR.Add(new Point(x + 66, y + 157));
                this.PointsR.Add(new Point(x + 66, y + 153));
                this.PointsR.Add(new Point(x + 98, y + 154));
                this.PointsR.Add(new Point(x + 36, y + 128));
                this.PointsR.Add(new Point(x + 16, y + 134));
                this.PointsR.Add(new Point(x + 12, y + 133));
                this.PointsR.Add(new Point(x + 12, y + 135));
                this.PointsR.Add(new Point(x + 12, y + 145));
                this.PointsR.Add(new Point(x + -84, y + 145));
                this.PointsR.Add(new Point(x + -84, y + 139));
                this.PointsR.Add(new Point(x + -87, y + 135));
                this.PointsR.Add(new Point(x + -90, y + 131));
                this.PointsR.Add(new Point(x + -94, y + 127));
                this.PointsR.Add(new Point(x + 11, y + 128));
                this.PointsR.Add(new Point(x + 10, y + 121));
                this.PointsR.Add(new Point(x + 0, y + 120));
                this.PointsR.Add(new Point(x + 2, y + 129));
                this.PointsR.Add(new Point(x + 2, y + 144));
                this.PointsR.Add(new Point(x + -43, y + 144));
                this.PointsR.Add(new Point(x + -42, y + 128));
                this.PointsR.Add(new Point(x + 1, y + 128));
                this.PointsR.Add(new Point(x, y));
                this.PointsR.Add(new Point(x, y + 120));
            }

            uneFenetre.Paint += delegate(object sd, PaintEventArgs args)
            {
                Graphics g = args.Graphics;
                g.DrawRectangles(Pens.Black, rects);
                //g.DrawLine(this.unStylo, new Point(x-20, y), new Point(x-80, y+5));

                for (int j = 0; j < this.PointsR.Count - 1; j++)
                {

                    if (this.VerifInd(j))
                    {
                        g.DrawLine(this.unStylo, this.PointsR[j], this.PointsR[j + 1]);
                    }
                }
                g.DrawEllipse(this.unStylo, new Rectangle(x + 18, y + 130, 45, 45));
                g.DrawEllipse(this.unStylo, new Rectangle(x - 130, y + 126, 48, 48));
                g.DrawEllipse(this.unStylo, new Rectangle(x - 350, y + 127, 48, 48));
                g.DrawEllipse(this.unStylo, new Rectangle(x - 400, y + 127, 48, 48));
                g.DrawLine(new Pen(Color.Black, 6), new Point(x, y + 124), new Point(x - 450, y + 124));
            };
            
        }

    }
}
