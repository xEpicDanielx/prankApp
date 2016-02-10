using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
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

        public static int _startupDelaySeconds = 10;
        public static int _totalDurationSeconds = 10;
        /// <summary>
        /// Entry Point For Prank App
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("DRUNK PC");

            //checks for comand line args and assigns them to this
            if(args.Length >= 2)
            {
                _startupDelaySeconds = Convert.ToInt32(args[0]);
                _totalDurationSeconds = Convert.ToInt32(args[1]);
            }
            //Creating All Threads
            Thread drunkMouseThread = new Thread(new ThreadStart(DrunkMouseThread));
            Thread drunkKeyboardThread = new Thread(new ThreadStart(DrunkKeyboardThread));
            Thread drunkSoundThread = new Thread(new ThreadStart(DrunkSoundThread));
            Thread drunkPopupThread = new Thread(new ThreadStart(DrunkPopupThread));

            DateTime future = DateTime.Now.AddSeconds(10);
            while (future > DateTime.Now)
            {
                Thread.Sleep(_startupDelaySeconds);
            }

            //Start Thread
            drunkMouseThread.Start();
            drunkKeyboardThread.Start();
            drunkSoundThread.Start();
            drunkPopupThread.Start();

            future = DateTime.Now.AddSeconds(10);
            while (future > DateTime.Now)
            {
                Thread.Sleep(_totalDurationSeconds);
            }

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
            int moveX = 0;
            int moveY = 0;
            while(true)
            {

                //Console.WriteLine(Cursor.Position.ToString());

                //Random Move of Cursor
                if (_random.Next(100) > 80)
                {
                    moveX = _random.Next(20) - 10;
                    moveY = _random.Next(20) - 10;

                    Cursor.Position = new System.Drawing.Point(Cursor.Position.X + moveX, Cursor.Position.Y + moveY);
                }
                Thread.Sleep(_random.Next(500));
            }
        }

        /// <summary>
        /// Random keyboard outpit
        /// </summary>
        public static void DrunkKeyboardThread()
        {
            while (true)
            {
                //aski starts at 64. 24 characters 
                char key = (char)(_random.Next(25) + 65);

                if (_random.Next(2) == 0)
                {
                    key = Char.ToLower(key);
                }

                SendKeys.SendWait(key.ToString());
                Thread.Sleep(_random.Next(1000));
            }
        }

        /// <summary>
        /// Random Sound
        /// </summary>
        public static void DrunkSoundThread()
        {
            while (true)
            {
                if (_random.Next(100) > 70)
                {
                    switch (_random.Next(5))
                    {
                        case 0:
                            SystemSounds.Asterisk.Play();
                            break;
                        case 1:
                            SystemSounds.Beep.Play();
                            break;
                        case 2:

                            SystemSounds.Exclamation.Play();
                            break;
                        case 3:

                            SystemSounds.Question.Play();
                            break;
                        case 4:
                            SystemSounds.Hand.Play();
                            break;
                    }
                }
               
                Thread.Sleep(10000);
            }
        }

        /// <summary>
        /// PopupTread
        /// </summary>
        public static void DrunkPopupThread()
        {
            while (true)
            {
                if (_random.Next(100) > 70)
                {
                    MessageBox.Show("Internet Explorer has stopped Working", "Internet Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Thread.Sleep(10000);
            }
        }
        #endregion
    }
}
