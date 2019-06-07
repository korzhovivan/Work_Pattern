using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    internal class Camera
    {
        public static int counter { get; set; } = 0;
        private static Dictionary<int, Camera> dict = new Dictionary<int, Camera>();

        public Camera() {}

        public static void Add(int ip, Camera cam)
        {
            counter++;
            if (counter > 3)
            {
                throw new ArgumentException("So much cameras...");
            }
            else
            {
                dict.Add(ip, cam);
            }

        }
        public static Camera GetInstance(int ipadress)
        {
            if (dict.ContainsKey(ipadress))
            {
                return dict[ipadress];
            }
            else
            {
                if (counter < 3)
                {
                    dict.Add(counter, new Camera());
                    counter++;
                    return new Camera();
                }
                else
                {
                    throw new ArgumentException("So much cameras...");
                }
            }
        }
    }
}