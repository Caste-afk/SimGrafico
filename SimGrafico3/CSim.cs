﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimGrafico
{
   public class CSim
    {
        public int numero { get; set; }
        public double credito { get; set; }
        public List<Ctelefonata> registrochiamate { get; private set; }
        double ptelefonata = 0.004; 
        public CSim(int numero, double credito)
        {
            this.numero = numero;
            this.credito = credito;
            registrochiamate = new List<Ctelefonata>();
        }

        public void AggiungiChiamata(int numero, TimeSpan durata)
        {
            registrochiamate.Add(new Ctelefonata(numero, durata));
            credito -= ptelefonata * durata.Minutes + ptelefonata * (durata.Hours * 60); 
        }

        public TimeSpan MinutiTotali()
        {
            TimeSpan totale = TimeSpan.Zero;

            foreach (var chiamata in registrochiamate)
            {
                totale += chiamata.durata;
            }

            return totale;
        }

        public int NumeroTelefonateNumero(int numero)
        {
            int tot = 0;

            for (int i = 0; i < registrochiamate.Count; i++)
            {
                if (numero == registrochiamate[i].numero)
                {
                    tot++;
                }
            }
            return tot;
        }

        public string Info()
        {
            string tot =
                $"numero: {numero}\n" +
                $"credito: {credito}\n" +
                $"registro chiamate: \n" +
                ChiamateTot();
            return tot;
        }

        public string ChiamateTot()
        {
            string testo = "";

            for (int i = 0; i < registrochiamate.Count; i++)
            {
                testo += $"{registrochiamate[i].numero}   {registrochiamate[i].durata}\n";
            }
            return testo;
        }
    }
}
