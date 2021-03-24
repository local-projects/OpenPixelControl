using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Threading;
using OpenPixelControl;

    internal static class Program
    {
        public static int Main(string[] args)
        {
            try
            {
                var opcClient = new OpcClient();
                opcClient.PixelOrder = PixelOrder.RGB;
                
                //var frame = opcClient.SingleColorFrame(Color.DarkBlue);
                //opcClient.WriteFrame(frame);

                //opcClient.BlinkRandomThenBright();

                //opcClient.BlinkRandomThenBright();
                //RgbyColorTest(opcClient);
                //SingleLedChase(opcClient, 100);
                //opcClient.WriteFrame(opcClient.SingleColorFrame(255, 255, 0), 0);

                //opcClient.SingleLedChase(100);
                //RainbowCycle(opcClient, 50);
                opcClient.RainbowCycle(10);


                //wait for socket to open
                //TODO: there is an open event, wait for the socket to open before sending messages
                //Thread.Sleep(1000);
                //opcWebSocketClient.ListConnectedDevices();
                Console.Read();
                var breakpoint = 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return 0;
        }
    }
