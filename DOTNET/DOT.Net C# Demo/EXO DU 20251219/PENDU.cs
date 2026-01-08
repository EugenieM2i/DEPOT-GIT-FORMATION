using System;
using System.Collections.Generic;
using System.Text;

namespace EXO_DU_20251219
{
    public class PENDU
    {
        private string[] mots =
        {
            "ordinateur",
            "chaise",
            "programme",
            "pendu",
            "clavier",
            "internet"

        };

        public string GenererMot()
        {
            Random random = new Random();
            int index = random.Next(mots.Length);
            return mots[index];

        }

        class Pendu
        {
            private string? motATrouver;
            private char[]? masque;
            private int nombreEssais;

            public Pendu(string mot)
            {
                motATrouver = mot.ToLower();
                nombreEssais = 10;
                GenererMasque();
            }

            public void GenererMasque()
            {
                masque = new char[motATrouver.Length];
                for (int i = 0; i < masque.Length; i++)
                {
                    masque[i] = '_';
                }

            }

            public void TestChar(char lettre)
            {
                bool trouve = false;
                for (int i = 0; i < motATrouver.Length; i++)
                {
                    if (motATrouver[i] == lettre)
                    {
                        masque[i] = lettre;
                        trouve = true;
                    }
                }
                if (!trouve)
                {
                    nombreEssais--;
                }
            }
        public bool TestWin()
            {
                return !masque.Contains('_');

            }
            public string GetMasque()
            { return string.Join(" ", masque);

            }
            public int GetEssais()
            { return nombreEssais;
            }
            public bool EstPerdu()
            { return nombreEssais <= 0;
            }
            // EXO RATE A REFAIRE