﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentemp
{
    internal class Attendance_uc1
    {
        public static void Attendance()
        {
            Console.WriteLine();
            Console.WriteLine("Uc1 Begin here *****************");

            int Is_Full_Time = 1;
            Random obj = new Random();
            int num = obj.Next(0, 2);
            if (num == Is_Full_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }
    }
}
    

