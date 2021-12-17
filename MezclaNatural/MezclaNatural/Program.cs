using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezclaNatural
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Objeto = new Program();
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1)Generar");
                Console.WriteLine("2)Intercalar");
                Console.WriteLine("3)Desplegar");
                Console.WriteLine("4)Salir");
                Console.Write("Introduce una opcion:");
                opcion = int.Parse(Console.ReadLine());
                Console.Write("opcion:");
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Objeto.generar();
                        Console.WriteLine("El arreglo ha sido generado");
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Objeto.merger();
                        Console.WriteLine("El arreglo ha sido intercalado");
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Objeto.desplegar();
                        Console.WriteLine("presiona enter  para continuar");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("presiona enter  para salir del programa");
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion invalida,presione enter para continuar");
                        Console.ReadLine();
                        break;

                }
            } while (opcion != 4);
        }
        public int N = 50, P, H, M, K, L, I, J, Q, R, T, r;
        public int[] A = new int[100];
        public bool UP; public Random a = new Random();

      public void generar()
        {
            for(int s = 0; s < A.Length; s++)
            {
                A[s] = a.Next(10210000, 10219999);
            }
        }
        public void desplegar()
        {
            r = 1;
            for (int i = 0; i < N; i++)
            {
                Console.Write("{0}- {1}\t", i + 1, A[i]);
                if (r == 5)
                {
                    Console.WriteLine();
                    r = 0;
                }
                r++;
            }
        }
        public void merger()
        {
            UP = true; P = 1;
            do
            {
                H = 1; M = N;
                if (UP == true)
                {
                    I = 0; J = N - 1; K = N; L = (2 * N) - 1;
                }
                else
                {
                    K = 0; L = N - 1; I = N; J = (2 * N) - 1;
                }
                do
                {
                    if (M >= P)
                    {
                        Q = P;
                    }
                    else
                    {
                        Q = M;
                    }
                    M = M - Q;
                    if (M >= P)
                    {
                        R = P;
                    }
                    else
                    {
                        R = M;
                    }
                    M = M - R;
                    while (Q != 0 && R != 0)
                    {
                        if (A[I] < A[J])
                        {
                            A[K] = A[I];
                            K = K + H;
                            I++; Q--;
                        }
                        else
                        {
                            A[K] = A[J];
                            K = K + H;
                            J--; R--;
                        }
                    }
                    while (R > 0)
                    {
                        A[K] = A[J];
                        K = K + H;
                        J--; R--;
                    }
                    while (Q > 0)
                    {
                        A[K] = A[I];
                        K = K + H;
                        I++; Q--;
                    }
                    H = -H; T = K; K = L; L = T;

                } while (M != 0);
                UP = !UP; P = 2 * P;
            } while (P < N);
            if (UP == false)
            {
                for (I = 0; I <= N - 1; I++)
                {
                    A[I] = A[I + N];
                }
            }

        }
        
        
         

    }
}
