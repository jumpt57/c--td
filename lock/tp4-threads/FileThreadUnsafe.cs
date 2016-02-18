using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4_threads
{
    public class FileThreadUnsafe<T>
    {
        private T[] tab;
        private int tete, queue;

        private Object lock1 = new Object();
        private Object lock2 = new Object();

        public FileThreadUnsafe(int taille)
        {
            tab = new T[taille];
            Init();
        }

        private int Suivant(int i)
        {
            return (i + 1) % tab.Length;           
        }

        private void Init() {
            tete = queue = -1;
        }

        public void Enfiler(T element)
        {
            lock (lock1)
            {
                if (Pleine())
                {
                    throw new ExceptionFilePleine();
                }
                else if (Vide())
                {
                    tab[queue = tete = 0] = element;
                }
                else {
                    tab[queue = Suivant(queue)] = element;
                }
            }                       
        }

        public void Defiler()
        {
            if (Vide())
            {
                throw new ExceptionFileVide();
            }            
            else {
                tab[queue] = default(T);
                queue--;
            }
        }

        public bool Vide()
        {            
            return tab.Count(s => s != null) == 0;
        }
        public bool Pleine()
        {
            return tab.Count(s => s != null) == tab.Length;
        }
        public int NbElements()
        {
            lock (lock2)
            {        
                if (Vide())
                {
                    return 0;
                }
                else if (tete <= queue)
                {
                    return queue - tete + 1;
                }
                else {
                    return tab.Length + queue - tete + 1;
                }
            }                              
        }

        public T Premier()
        {
            return tab[tete];
        }
    }
    public class ExceptionFileVide : Exception { }
    public class ExceptionFilePleine : Exception { }
}
