using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{
    public partial class Form1 : Form
    {
        string betöltendő_pálya = "palya69.txt";

        void TANÁR_ROBOTJAI()
        {
            new Robot("Karesz", 10, 10, 10, 10, 1, 20, 11, 0);


            Robot dr_janesz = new Robot("dr_janesz", 0, 0, 0, 0, 1000, 1, 29, 0);

            dr_janesz.Feladat = delegate ()
            {
                
            };

            /*Robot agent_janesz = new Robot("agent_janesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 10000, 31, 27, 3);

            agent_janesz.Feladat = delegate ()
            {
                while (true)
                {
                    Random random = new Random();
                    int a = random.Next(0, 7);
                    for (int i = 0; i < a; i++)
                    {
                        agent_janesz.Várj();
                    }
                    agent_janesz.Lőjj();
                }
                
            };*/

            /*Robot dr_lilesz = new Robot("dr_lilesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 10000, 9, 27, 1);

            dr_lilesz.Feladat = delegate ()
            {
                while (true)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        dr_lilesz.Várj();
                    }
                    dr_lilesz.Lőjj();
                }
            };*/




            Robot mégtöbb1 = new Robot("mégtöbb1", Robot.képkészlet_lilesz, 0, 0, 0, 0, 10000, 18, 14, 2);

            mégtöbb1.Feladat = delegate ()
            {
                while (true)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        mégtöbb1.Várj();
                    }
                    mégtöbb1.Lőjj();
                }
            };

            Robot mégtöbb2 = new Robot("mégtöbb2", Robot.képkészlet_lilesz, 0, 0, 0, 0, 10000, 22, 24, 0);

            mégtöbb2.Feladat = delegate ()
            {
                while (true)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        mégtöbb2.Várj();
                    }
                    mégtöbb2.Lőjj();
                }
            };
        }
    }
}