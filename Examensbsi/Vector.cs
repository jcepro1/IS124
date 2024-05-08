﻿using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examensb
{
    class Vector
    {
        const int MAX = 50;
        private int[] v;
        private int n;

        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }

        public void Cargar(int n1, int a, int b)
        {
            Random r = new Random();
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }

        public void Cargar(int ele)
        {
            n++;
            v[n] = ele;
        }

        public void cargardato(int nele)
        {
            n = nele;
            int num = n;
            for (int i = 1; i <= num; i++)
            {
                v[i] = Conversions.ToInteger(Interaction.InputBox(" ", " "));
            }
        }

        public string Descargar()
        {
            string s = "";
            int i;
            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + " | ";
            }
            return s;
        }

        //EXAMEN

        //PREGUNTA 1

        public void examen1(Vector v2, Vector vr)
        {
            //Vector vr = new Vector();
            for (int i = 1; i <= n; i++)
            {
                int ele = v[i];
                if (v2.frecuencia(ele) == 0 && vr.frecuencia(ele) == 0)
                {
                    vr.insertar(ele);
                }

            }
            for (int i = 1; i <= v2.n; i++)
            {
                int ele = v2.v[i];
                if (frecuencia(ele) == 0 && vr.frecuencia(ele) == 0)
                {
                    vr.insertar(ele);
                }

            }
            
        }


        public int frecuencia(int ele)
        {
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (v[i] == ele)
                {
                    c++;
                }
            }
            return c;
        }
        private void insertar(int ele)
        {
            n++;
            v[n] = ele;
        }


        public String examen1(Vector v2)
        {
            Vector vr = new Vector();
            for (int i = 1; i <= n; i++)
            {
                int ele = v[i];
                if (v2.frecuencia(ele) == 0 && vr.frecuencia(ele) == 0)
                {
                    vr.insertar(ele);
                }

            }
            for (int i = 1; i <= v2.n; i++)
            {
                int ele = v2.v[i];
                if (frecuencia(ele) == 0 && vr.frecuencia(ele) == 0)
                {
                    vr.insertar(ele);
                }

            }
            return vr.Descargar();
        }




        //PREGUNTA 2
      
    }
}
