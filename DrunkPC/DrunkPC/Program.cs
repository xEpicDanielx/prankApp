using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

/// <summary>
/// Drunk PC 
/// 
/// Just to mess with everyone
/// 
/// Learning threads
/// forms
/// and all that good stuff
/// as well ad hidden application
/// 
/// </summary>
namespace DrunkPC
{
    class Program
    {
        //Underscore indicates global
        public static Random _random = new Random();

        /// <summary>
        /// Entry Point For Prank App
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("DRUNK PC");

            Thread sampleThread1 = new Thread(new ThreadStart(SampleThread1));
            sampleThread1.Start();

            Thread sampleThread2 = new Thread(new ThreadStart(SampleThread2));
            sampleThread2.Start();

            Console.ReadKey();
            sampleThread1.Abort();
            sampleThread2.Abort();

        }
        /// <summary>
        /// This is a sample thread
        /// </summary>
        static void SampleThread1() {
            while (true) {
                Console.WriteLine("HELLO THREAD!");
                Thread.Sleep(1000);
            }
        }

        static void SampleThread2()
        {
            while (true)
            {
                Console.WriteLine("HELLO THREAD2!");
                Thread.Sleep(2000);
            }
        }
    }
}
