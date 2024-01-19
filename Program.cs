using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f;
            Console.WriteLine("Introduceti functia");
            f = int.Parse(Console.ReadLine());
            if (f == 1)
                P1();//cate numere sunt pare
            if (f == 2)
                P2();//cate numere sunt pozitive, negative sau 0
            if (f == 3)
                P3();//suma si produsul de la 1 la n
            if (f == 4)
                P4();  //Determinati pe ce pozitie se afla in secventa un numar a
            if (f == 5)
                P5();//Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa
            if (f == 6)
                P6();//sa se determine daca numerele sunt in ordine crescatoare
            if (f == 7)
                P7();//sa se determine cea mai mare si cea mai mica valoare din secventa
            if (f == 8)
                P8();//determinati al n-lea numar din sirul lui Fibonacci
            if (f == 9)
                P9();//secventa monotona
            if (f == 10)
                P10();//numarul maxim de numere egale consecutive
            if (f == 11)
                P11();//sa se calculeze suma inverselor numerelor dintr o secventa
            if (f == 12)
                P12();//cate grupuri de numere diferite de 0 sunt intr-o secventa 
            if (f == 13)
                P13();//secventa crescatoare rotita
            if (f == 14)
                P14();//secventa monotona rotita
            if (f == 15)
                P15();//secventa bitonica
            if (f == 16)
                P16();//secventa bitonica rotita
            if (f == 17)
                P17();
        }
        static void P1()
        {
            Console.WriteLine("Introduceti lungimea secventei:");
            int n = int.Parse(Console.ReadLine());
            int[] secventa = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                secventa[i] = int.Parse(Console.ReadLine());
            }
            int k = NumarulNumerelorPare(secventa);
            Console.WriteLine($"Numere pare în secvență: {k}");
        }
        static int NumarulNumerelorPare(int[] secventa)
        {
            int k = 0;
            foreach (int numar in secventa)
            {
                if (numar % 2 == 0)
                    k++;
            }
            return k;
        }
        private static void P2()
        {
            int n, negativ = 0, pozitiv = 0, nul = 0;
            Console.WriteLine("Introduceti lungimea secventei:");
            n = int.Parse(Console.ReadLine());
            int[] secventa = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1}:");
                secventa[i] = int.Parse(Console.ReadLine());
            }
            foreach (int numar in secventa)
            {
                if (numar < 0)
                    negativ++;
                if (numar > 0)
                    pozitiv++;
                if (numar == 0)
                    nul++;
            }
            Console.WriteLine($"In secventa data sunt {negativ} numere negative, {pozitiv} numere poztive si {nul} numere egale cu 0");
        }
        private static void P3()
        {
            int n, s = 0, p = 1;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s = s + i;
                p = p * i;
            }
            Console.WriteLine($"Suma de la 1 la {n} este {s}, iar produsul e {p}");
        }
        private static void P4()
        {
            Console.WriteLine("Introduceti lungimea secventei:");
            int n = int.Parse(Console.ReadLine());
            int[] secv = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}: ");
                secv[i] = int.Parse(Console.ReadLine());
            }
            int k = pozitie(secv);
            Console.WriteLine(k);
        }
        static int pozitie(int[] secv)
        {
            int a;
            Console.WriteLine("Introduceti a:");
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < secv.Length; i++)
            {
                if (a == secv[i])
                    Console.WriteLine($"Numarul {a} se afla pe pozitia {i}.");
            }
            return -1;
        }
        private static void P5()
        {
            int n;
            Console.WriteLine("Introduceti lungimea secventei: ");
            n = int.Parse(Console.ReadLine());
            int[] secventa = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}: ");
                secventa[i] = int.Parse(Console.ReadLine());
            }
            int var = Kpoz(secventa);
            Console.WriteLine(var);

        }
        static int Kpoz(int[] secventa)
        {
            int k = 1;
            for (int i = 0; i < secventa.Length; i++)
            {
                if (secventa[i] == i)
                    k++;
            }
            return k;
        }//eroare la afisare
        private static void P6()
        {
            Console.Write("Introduceți lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int[] secventa = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                secventa[i] = int.Parse(Console.ReadLine());
            }
            if (verifCrescatoare(secventa))
                Console.WriteLine("Numerele sunt în ordine crescătoare.");
            else
                Console.WriteLine("Numerele nu sunt în ordine crescătoare.");
        }
        static bool verifCrescatoare(int[] secventa)
        {
            for (int i = 1; i < secventa.Length; i++)
            {
                if (secventa[i] < secventa[i - 1])
                    return false;
            }
            return true;
        }
        private static void P7()
        {
            int n;
            Console.WriteLine("Introduceti lungimea secventei: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];//a-secventa
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}:");
                a[i] = int.Parse(Console.ReadLine());
            }
            int kmax = max(a);
            int kmin = min(a);
            Console.WriteLine($"Valoarea cea mai mare este {kmax}, iar cea mai mica este {kmin}");

        }
        static int min(int[] a)
        {
            int min = 10000;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min) min = a[i];
            }
            return min;
        }
        static int max(int[] a)
        {
            int max = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }
        private static void P8()///fibonacci
        {
            int n;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            if (n < 1)
                Console.WriteLine("Numarul trebuie sa fie cel putin 1.");
            else
            {
                int rezultat = Fibonacci(n);
                Console.WriteLine($"Al {n}-lea numarul din sir este {rezultat}");
            }
        }
        static int Fibonacci(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                int a = 1, b = 1, aux = 0;
                for (int i = 3; i <= n; i++)
                {
                    aux = a + b;
                    a = b;
                    b = aux;
                }
                return aux;
            }
        }
        private static void P9()
        {
            int n;
            Console.WriteLine("Introduceti lungimea secventei: ");
            n = int.Parse(Console.ReadLine());
            int[] secventa = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}: ");
                secventa[i] = int.Parse(Console.ReadLine());
            }
            bool k = verifMonoton(secventa);
            Console.WriteLine(k);
        }
        static bool verifMonoton(int[] secventa)
        {
            bool crescatoare = true;
            bool descrescatoare = true;
            for (int i = 1; i < secventa.Length; i++)
            {
                if (secventa[i] > secventa[i - 1])
                    crescatoare = false;
                else
                    if (secventa[i] < secventa[i - 1])
                    descrescatoare = false;
            }
            bool monotona = crescatoare || descrescatoare;
            return monotona;
        }

        private static void P10()
        {
            Console.WriteLine("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int[] secventa = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}: ");
                secventa[i] = int.Parse(Console.ReadLine());
            }
            int nrmax = NumereEgaleConsecutive(secventa);
            Console.WriteLine($"Numar maxim de numere egale consecutive este {nrmax}");

        }
        static int NumereEgaleConsecutive(int[] secventa)
        {
            if (secventa.Length == 0)
                return 0;
            int k = 1;
            int kmax = 1;
            for (int i = 1; i < secventa.Length; i++)
            {
                if (secventa[i] == secventa[i - 1])
                    k++;
                else
                    k = 1;
            }
            kmax = Math.Max(kmax, k);
            return kmax;
        }
        private static void P11()
        {
            int n, sum = 0;
            Console.WriteLine("Introduceti lungimea secventei:");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}:");
                a[i] = int.Parse(Console.ReadLine());
            }
            foreach (int numar in a)
            {
                sum = sum + (-numar);
            }
            Console.WriteLine($"Suma este {sum}.");
        }
        private static void P12()
        {
            int n;
            Console.WriteLine("Introduceti lungimea secventei: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            int rez = NumarGrupuri(a);
            Console.WriteLine($"Rezultatul este {rez}.");
        }
        static int NumarGrupuri(int[] a)
        {
            int k = 0;
            bool var = false;
            foreach (int numar in a)
            {
                if (numar != 0)
                {
                    if (!var)
                    {
                        k++;
                        var = true;
                    }
                }
                else
                    var = false;
            }
            return k;
        }
        private static void P13()
        {
            int n;
            Console.WriteLine("Introduceti lungimea secventei: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());

            }
            bool k = EsteRotita(a);
            if (k)
                Console.WriteLine("Secventa este crescatoare rotita.");
            else
                Console.WriteLine("Secventa nu este o secventa crescatoare rotita.");
        }
        static bool EsteRotita(int[] a)
        {
            int l = a.Length;
            int pozMin = GasestePozitieMin(a, 0, l - 1);
            return VerifCrescatoareRotita(a, pozMin);
        }
        static bool VerifCrescatoareRotita(int[] a, int pozMin)
        {
            int l = a.Length;
            for (int i = 1; i < a.Length - 1; i++)
            {
                int indexCurent = (pozMin + i) % l;
                int indexUrmator = (pozMin + i + 1) % l;//pozitia urmatoare
                if (a[indexCurent] > a[indexUrmator])
                    return false;
            }
            return true;
        }
        static int GasestePozitieMin(int[] a, int stanga, int dreapta)
        {
            while (stanga < dreapta)
            {
                int mijloc = stanga + (dreapta - stanga) / 2;//dreapta-ultimul el, stanga-primul el

                if (a[mijloc] > a[dreapta])
                {
                    stanga = mijloc + 1;
                }
                else if (a[mijloc] < a[dreapta])
                {
                    dreapta = mijloc;
                }
                else
                {
                    dreapta--;
                }
            }
            return stanga;
        }
        private static void P14()
        {
            int n;
            Console.WriteLine("Introduceti lungimea secventei: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            bool k = EsteMonotonaRotita(a);
            if (k)
                Console.WriteLine("Secventa este o secventa monotona rotita.");
            else
                Console.WriteLine("Secventa nu este o secventa monotona rotita.");
        }
        static bool EsteMonotonaRotita(int[] a)
        {
            int lungime = a.Length;
            // Găsește index-ul minim
            int pozitieMinima = GasestePozitieMinima(a, 0, lungime - 1);
            // Verificare dacă secvența este monotona sau rotită monotona
            return VerificaMonotonaRotita(a, pozitieMinima);
        }
        static int GasestePozitieMinima(int[] a, int st, int dr)
        {
            while (st < dr)
            {
                int mijloc = st + (dr - st) / 2;
                if (a[mijloc] > a[dr])
                {
                    st = mijloc + 1;
                }
                else if (a[mijloc] < a[dr])
                {
                    dr = mijloc;
                }
                else
                {
                    dr--;
                }
            }
            return st;
        }
        static bool VerificaMonotonaRotita(int[] a, int pozitieMinima)
        {
            int lungime = a.Length;
            for (int i = 0; i < lungime - 1; i++)
            {
                int indexCurent = (pozitieMinima + i) % lungime;
                int indexUrmator = (pozitieMinima + i + 1) % lungime;

                if (a[indexCurent] > a[indexUrmator])
                {
                    return false;
                }
            }
            return true;
        }
        private static void P15()
        {
            int n;
            Console.WriteLine("Introduceti lungimea secventei: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            bool k = EsteSecventaBitonica(a);
            if (k)
                Console.WriteLine("Secventa este bitonica.");
            else
                Console.WriteLine("Secventa nu este bitonica.");
        }
        static bool EsteSecventaBitonica(int[] a)
        {
            int lungime = a.Length;
            // Găsește punctul maxim din secvență
            int indexMaxim = GasesteIndexMaxim(a, 0, lungime - 1);
            // Verificare dacă secvența este bitonică
            return indexMaxim != -1 && indexMaxim != 0 && indexMaxim != lungime - 1;
        }
        static int GasesteIndexMaxim(int[] a, int stanga, int dreapta)
        {
            while (stanga <= dreapta)
            {
                int mijloc = stanga + (dreapta - stanga) / 2;
                if (a[mijloc] > a[mijloc - 1] && a[mijloc] > a[mijloc + 1])
                {
                    return mijloc; // Găsește punctul maxim din secvență
                }
                else if (a[mijloc] > a[mijloc - 1])
                {
                    stanga = mijloc + 1;
                }
                else
                {
                    dreapta = mijloc - 1;
                }
            }
            return -1; // Secvența nu este bitonică
        }
        private static void P16()
        {
            int n;
            Console.WriteLine("Introduceti lungimea secventei: ");
            n = int.Parse(Console.ReadLine());
            int[] secventa = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}: ");
                secventa[i] = int.Parse(Console.ReadLine());
            }
            bool k = EsteSecventaBitonica(secventa);
            if (k)
                Console.WriteLine("Secventa este bitonica rotita.");
            else
                Console.WriteLine("Secventa nu este bitonica rotita.");
        }
        static bool EsteSecventaBitonicaRotita(int[] secventa)
        {
            int lungime = secventa.Length;
            // Găsește index-ul maxim din secvență
            int indexMaxim = GasesteMaxim(secventa, 0, lungime - 1);
            // Verificare dacă secvența este bitonică rotită
            return indexMaxim != -1 && indexMaxim != 0 && indexMaxim != lungime - 1;
        }

        static int GasesteMaxim(int[] secventa, int stanga, int dreapta)
        {
            while (stanga <= dreapta)
            {
                int mijloc = stanga + (dreapta - stanga) / 2;
                if (secventa[mijloc] > secventa[mijloc - 1] && secventa[mijloc] > secventa[mijloc + 1])
                {
                    return mijloc; // Găsește punctul maxim din secvență
                }
                else if (secventa[mijloc] > secventa[mijloc - 1])
                {
                    stanga = mijloc + 1;
                }
                else
                {
                    dreapta = mijloc - 1;
                }
            }
            return -1; // Secvența nu este bitonică
        }
        private static void P17()
        {
            int n;
            Console.WriteLine("Introduceti lungimea secventei: ");
            n = int.Parse(Console.ReadLine());
            int[] secventa = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}: ");
                secventa[i] = int.Parse(Console.ReadLine());
            }
            // Verificare dacă este o secvență corectă și determinare nivel maxim de încuibare
            bool esteCorecta = EsteSecventaCorecta(secventa, out int nivelMaxim);
            // Afisare rezultat
            if (esteCorecta)
            {
                Console.WriteLine($"Secventa este corecta și are nivelul maxim de încuibare: {nivelMaxim}");
            }
            else
            {
                Console.WriteLine("Secventa nu este corecta.");
            }
        }
        static bool EsteSecventaCorecta(int[] secventa, out int nivelMaxim)
        {
            int nivelCurent = 0;
            nivelMaxim = 0;

            foreach (int paranteza in secventa)
            {
                if (paranteza == 0)
                {
                    // Deschidere paranteza, crește nivelul curent
                    nivelCurent++;
                    nivelMaxim = Math.Max(nivelMaxim, nivelCurent);
                }
                else if (paranteza == 1)
                {
                    // Închidere paranteza, scade nivelul curent
                    nivelCurent--;
                    if (nivelCurent < 0)
                    {
                        // Dacă nivelul curent devine negativ, secvența este incorectă
                        return false;
                    }
                }
                else
                {
                    // Valoare incorectă (nu este 0 sau 1)
                    return false;
                }
            }

            // Verificare dacă toate parantezele au fost închise corect
            return nivelCurent == 0;
        }
    }
}
