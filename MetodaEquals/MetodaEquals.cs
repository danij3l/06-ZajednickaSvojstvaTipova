﻿using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
    }

    struct MojaStruktura
    {
    }

    public class MetodaEquals
    {
        public static void UsporedbaKlasa()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = null;

            // TODO: Usporediti objekte mk1 i mk2 korištenjem statičke metode MojaKlasa.Equals te ispisati rezultat


            // TODO: Usporediti reference na objekte mk1 i mk2 korištenjem statičke metode MojaKlasa.ReferenceEquals te ispisati rezultat


            // TODO: Usporediti objekte mk1 i mk2 pozivom metode mk1.Equals te ispisati rezultat

            
            // TODO: Usporediti objekte mk1 i mk2 pozivom metode mk2.Equals te ispisati rezultat


        }

        public static void UsporedbaStruktura()
        {
            // TODO: Storiti dvije strukture ms1 i ms2 na isti način kao i za gornje instance klasa mk1 i mk2


            // TODO: Usporediti objekte ms1 i ms2 korištenjem statičke metode MojaStruktura.Equals te ispisati rezultat


            // TODO: Usporediti objekte ms1 i ms2 pozivom metode ms1.Equals te ispisati rezultat


            // TODO: Usporediti objekte ms1 i ms2 pozivom metode ms2.Equals te ispisati rezultat

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Usporedba klasa");
            UsporedbaKlasa();

            Console.WriteLine("Usporedba struktura");
            UsporedbaStruktura();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
