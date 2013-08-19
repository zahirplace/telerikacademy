using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleSurface
{
    class TriangleSurface
    {
        static void Main(string[] args)
        {
            /*
             04. Write methods that calculate the surface of a triangle by given:
                - Side and an altitude to it; 
                - Three sides; 
                - Two sides and an angle between them. 
             Use System.Math.
             */

            int sideA;
            int sideB;
            int sideC;
            int altitude;
            int angle;

            Console.WriteLine("Calculate the surface of a triangle by given:");
            Console.WriteLine("1 - Side and an altitude to it;");
            Console.WriteLine("2 - Three sides;");
            Console.WriteLine("3 - Two sides and an angle between them.");
            Console.WriteLine("Choose an action and press ENTER!");
            Console.WriteLine();
            int menuChoice = int.Parse(Console.ReadLine());

            try
            {
                switch (menuChoice)
                {
                    case 1:
                        {
                            Console.Write("Side = ");
                            sideA = int.Parse(Console.ReadLine());
                            Console.Write("Altitude = ");
                            altitude = int.Parse(Console.ReadLine());

                            if (sideA > 0 && altitude > 0)
                            {
                                Console.WriteLine("Triangle with side {0} and altitude {1} has a surface: {2:F2}", sideA, altitude, GetTriangleSurface(sideA, altitude));
                            }
                            else
                                Console.WriteLine("Incorrect input data!");
                        } break;
                    case 2:
                        {
                            Console.Write("Side 1 = ");
                            sideA = int.Parse(Console.ReadLine());
                            Console.Write("Side 2 = ");
                            sideB = int.Parse(Console.ReadLine());
                            Console.Write("Side 3 = ");
                            sideC = int.Parse(Console.ReadLine());

                            if (sideA > 0 && sideB > 0 && sideC > 0)
                            {
                                Console.WriteLine("Triangle with sides {0}, {1} and {2} has a surface: {3:F2}", sideA, sideB, sideC, GetTriangleSurface(sideA, sideB, sideC));
                            }
                            else
                                Console.WriteLine("Incorrect input data!");
                        }; break;
                    case 3:
                        {
                            Console.Write("Side 1 = ");
                            sideA = int.Parse(Console.ReadLine());
                            Console.Write("Side 2 = ");
                            sideB = int.Parse(Console.ReadLine());
                            Console.Write("Angle[degrees] = ");
                            angle = int.Parse(Console.ReadLine());

                            if (sideA > 0 && sideB > 0 && angle > 0)
                            {
                                Console.WriteLine("Triangle with sides {0} and {1} and an angle between them {2} has a surface: {3:F2}", sideA, sideB, angle, GetTriangleSurfaceAngle(sideA, sideB, angle));
                            }
                            else
                                Console.WriteLine("Incorrect input data!");
                        }; break;
                    default: Console.WriteLine("Choose a correct action from the menu!"); break;
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static float GetTriangleSurface(float side, float altitude)
        {
            return (side * altitude) / 2;
        }

        static double GetTriangleSurface(float sideA, float sideB, float sideC)
        {
            float p = (sideA + sideB + sideC) / 2;
            return (double)Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

        }

        static double GetTriangleSurfaceAngle(float sideA, float sideB, double angle)
        {
            return (sideA * sideB * Math.Sin(Math.PI * angle / 180));
        }
    }
}
