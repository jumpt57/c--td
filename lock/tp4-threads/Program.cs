using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using tp4_threads;

namespace tp4_threads
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            Scénario 1 : Deux threads tantent d'ajouter des éléments en même temps
            dans le tableau, erreur => ils essayent d'ajouter au même index
            tous les éléments ne sont pas ajouté comme il faut.

            Premier passage :

            start thread 2 0
            start thread 1 0
            thread 2 1
            thread 1 2
            thread 1 3
            thread 1 4
            thread 1 5
            thread 1 6
            thread 2 2
            thread 2 7
            thread 2 8
            thread 2 9

            Pour rendre les classes thread safe et garantir l'exlusion mutuelle
            il faut utiliser le lock c# celui permet de mettre en attente
            un thread quand il essaye d'accéder à une ressource déjà utilisé
            par un autre thread.

            Avec un lock sur Enfiler il n'y a plus de problème.

            start thread 1 0
            start thread 2 0
            thread 1 1
            thread 2 2
            thread 2 4
            thread 2 5
            thread 2 6
            thread 2 7
            thread 1 3
            thread 1 8
            thread 1 9
            thread 1 10
            */

            FileThreadUnsafe<string> file = new FileThreadUnsafe<string>(10);           

            Thread myNewThread = new Thread(() => play("1", file));
            myNewThread.Start();

            Thread myNewThread2 = new Thread(() => play("2", file));
            myNewThread2.Start();

            Console.ReadLine();
        }

        static void play(string a, FileThreadUnsafe<string> file)
        {
            Console.WriteLine("start thread " + a + " " + file.NbElements());
            file.Enfiler("");
            Console.WriteLine("thread "+ a + " " + file.NbElements());
            file.Enfiler("");
            Console.WriteLine("thread " + a + " " + file.NbElements());
            file.Enfiler("");
            Console.WriteLine("thread " + a + " " + file.NbElements());
            file.Enfiler("");
            Console.WriteLine("thread " + a + " " + file.NbElements());
            file.Enfiler("");
            Console.WriteLine("thread " + a + " " + file.NbElements());

        }
    }
}
