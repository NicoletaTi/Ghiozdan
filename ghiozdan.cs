using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Ghiozdan
{
    public class ArticolInventar
    {
        public int volum;
        public int greutate;
        public bool Adauga()
        {
            bool capacitate = false;
        }
        public void Articol()
        {
            public void Art(int volum, int greutate) //constructor cu parametru 
            { volum=v;
                greutate=g;
            }
        }
    }
    public class Sageata : ArticolInventar { public Sageata(int v, int g) : base(0.1f, 0.05f) { } }
    public class Arc : ArticolInventar { public Arc(int v, int g) : base(1f, 4f) { } }
    public class Franghie : ArticolInventar { public Franghie(int v, int g) : base(1f, 1.5f) { } }
    public class Apa : ArticolInventar { public Apa(int v, int g) : base(2f, 3f) { } }
    public class Mancare : ArticolInventar { public Mancare(int v, int g) : base(1f, 0.5f) { } }
    public class Sabie : ArticolInventar { public Sabie(int v, int g) : base(5f, 3f) { } }
    public class Ruxac : ArticolInventar
    {
        public void Ruxa(int n, int VR, int GR)
        {
            int v = 0;
            int g = 0;
            int nr = 0;
            int t = n;
            bool capacitate = true;
            int[][] rux = new int[3][n];
            int i, j;
            for (i = 0; i<=3; i++)
            {
                for (j = 0; j<=n; j++)
                    if (i==2) rux[i][j]=nr;
                    else if (i==2) rux[i][j]=v;
                    else if (i==3) rux[i][j]=g;
            }
            for (i = 0; i<=3; i++)
            {
                for (j = 0; j<=n; j++)
                    if (v+rux[2][j]<=VR && g+rux[3][j]<=GR && nr+rux[1][j]<=n)
                    {
                        nr=nr+1;
                        g=g+rux[3][j];
                        v=v+rux[2][j];
                    }else Console.WriteLine(capacitate.Adauga());
            }
                
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ruxac ruxac = new Ruxac();
            ruxac.Articol();
            int VR;
            int GR;
            int n;
            Console.WriteLine("Problema ghiozdanului");
            Console.WriteLine("Dati volumul ghiozdanului");
            VR = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati Greutatea suportata de ghiozdan");
            GR = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati numarul de obiecte");
            n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Ruxa(n, VR, GR));
            Console.ReadLine();
        }
    }
}

