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
        void DIÁK_ROBOTJAI()
        {
            Robot karesz = Robot.Get("Karesz");
            Robot dr_janesz = Robot.Get("dr_janesz");

            karesz.Feladat = delegate ()
            {
               for(int i = 0; i < 9; i++)
               {
                    karesz.Lépj();
               }
               karesz.Fordulj(balra);
               for(int i = 0; i < 15; i++)
               {
                    karesz.Lépj();
               }
               karesz.Fordulj(balra);
               for(int i = 0; i < 12; i++)
               {
                    karesz.Lépj();
               }
               karesz.Fordulj(balra);
               karesz.Lőjj();
               for(int i = 0; i < 13; i++)
               {
                    karesz.Lépj();
               }
               karesz.Mondd("HEHEHE EZ NOOB!");
               for(int i = 0; i < 3; i++)
               {
                    for(int j = 0; j < 4; j++)
                    {
                        karesz.Fordulj(balra);
                    }
                    for(int k = 0; k < 4; k++)
                    {
                        karesz.Fordulj(jobbra);
                    }
               }
               karesz.Fordulj(jobbra);
               while(karesz.Alatt_ez_van() != hó)
               {
                    karesz.Lépj();
               }
               karesz.Vegyél_fel_egy_kavicsot();
               karesz.Fordulj(balra);
               karesz.Fordulj(balra);
               karesz.Lépj();
               karesz.Fordulj(jobbra);
               karesz.Lépj();
               karesz.Lépj();
               for(int i = 0; i < 4; i++)
               {
                   if(karesz.Alatt_ez_van() == sárga)
                   {
                       karesz.Vegyél_fel_egy_kavicsot();
                   }
                   karesz.Fordulj(jobbra);
                   karesz.Fordulj(jobbra);
                   karesz.Lépj();
                   karesz.Fordulj(jobbra);
                   karesz.Lépj();
                   karesz.Lépj();
                   karesz.Fordulj(jobbra);
                   karesz.Lépj();
               }
               if(karesz.Alatt_ez_van() == sárga)
               {
                   karesz.Vegyél_fel_egy_kavicsot();
               }
               karesz.Mondd("Megvannak az aranyak! Megyek és megölöm ezt a másik piroskát is!");
               karesz.Lépj();
               karesz.Fordulj(jobbra);
               for(int i = 0;i < 9; i++)
               {
                    karesz.Lépj();
               }
               karesz.Fordulj(balra);
               karesz.Lőjj();
               karesz.Lépj();
               karesz.Mondd("HEHEHE EZ NOOB!");
               for(int i = 0; i < 3; i++)
               {
                    for(int j = 0; j < 4; j++)
                    {
                        karesz.Fordulj(balra);
                    }
                    for(int k = 0; k < 4; k++)
                    {
                        karesz.Fordulj(jobbra);
                    }
               }

               
            };

            dr_janesz.Feladat = delegate ()
            {
                //nem kötelező :) (doktor pihenne miután egyhuzamban elkéazített 1000 darab hógolyót, egyet pedig karcsi barátunknak is csinált)(elvileg ennek a résznek is működnie kell)
            };
        }
    }
}

/* LEGFONTOSABB PARANCSOK

MOZGÁSOK

karesz.Lépj();                          -------- Karesz előre lép egyet.
karesz.Fordulj(jobbra);                 -------- Karesz jobbra fordul.
karesz.Fordulj(balra);                  -------- Karesz balra fordul.
karesz.Vegyél_fel_egy_kavicsot();       -------- Karesz felvesz egy kavicsot.
karesz.Tegyél_le_egy_kavicsot();        -------- Karesz letesz egy fekete kavicsot
karesz.Tegyél_le_egy_kavicsot(piros);   -------- Karesz letesz egy piros kavicsot.

Minden mozgás után a robot köre véget ér és a következő robot jön. 



SZENZOROK

karesz.Előtt_fal_van();                 -------- igaz, ha Karesz fal előtt áll, egyébként hamis.
karesz.Ki_fog_lépni_a_pályáról();       -------- igaz, ha Karesz a pálya szélén kifele néz, egyébként hamis.
karesz.Alatt_van_kavics();              -------- igaz, ha Karesz épp kavicson áll, egyébként hamis.
karesz.Köveinek_száma_ebből(piros)      -------- Karesz piros köveinek a száma.
karesz.Alatt_ez_van();                  -------- a kavics színe, amin Karesz áll. (Ez igazából egy szám!)
karesz.UltrahangSzenzor();              -------- a Karesz előtt található tárgy távolsága. Ez a tárgy lehet fal vagy másik robot is. 
karesz.SzélesUltrahangSzenzor();        -------- ugyanaz, mint az ultrahangszenzor, de ez nem csak a Karesz előtti mezőket pásztázza, hanem a szomszédos mezőket is. Egy számhármast ad vissza. 
karesz.Hőmérő();                        -------- a Karesz által mért hőmérséklet. A láva forrása 1000 fok, amitől lépésenként távolodva a hőmérséklet 200 fokonként hűl. Az alapértelmezett hőmérséklet 0 fok.

A szenzorokat bármennyiszer használhatja a robot a saját körén belül.

*/