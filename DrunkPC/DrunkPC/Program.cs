﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Windows.Forms;
using System.Drawing;
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

            //Creating All Threads
            Thread drunkMouseThread = new Thread(new ThreadStart(DrunkMouseThread));
            Thread drunkKeyboardThread = new Thread(new ThreadStart(DrunkKeyboardThread));
            Thread drunkSoundThread = new Thread(new ThreadStart(DrunkSoundThread));
            Thread drunkPopupThread = new Thread(new ThreadStart(DrunkPopupThread));

            //Start Thread
            drunkMouseThread.Start();
            drunkKeyboardThread.Start();
            drunkSoundThread.Start();
            drunkPopupThread.Start();

            //Kill
            Console.Read();
            drunkMouseThread.Abort();
            drunkKeyboardThread.Abort();
            drunkSoundThread.Abort();
            drunkPopupThread.Abort();

        }

        #region Thread Functions
        /// <summary>
        /// Mouse Movements
        /// </summary>
        public static void DrunkMouseThread() {
            Console.WriteLine("Mouse");
            while(true)
            {
                Console.WriteLine(Cursor.Position.ToString());
                Thread.Sleep(500);
            }
        }

        /// <summary>
        /// Random keyboard outpit
        /// </summary>
        public static void DrunkKeyboardThread()
        {
            Console.WriteLine("Keyboard");
            while (true)
            {
                Thread.Sleep(500);
            }
        }

        /// <summary>
        /// Random Sound
        /// </summary>
        public static void DrunkSoundThread()
        {
            Console.WriteLine("Sound");
            while (true)
            {
                Thread.Sleep(500);
            }
        }

        /// <summary>
        /// PopupTread
        /// </summary>
        public static void DrunkPopupThread()
        {
            Console.WriteLine("Popup");
            while (true)
            {
                Thread.Sleep(500);
            }
        }
        #endregion
    }
}
