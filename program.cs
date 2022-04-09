using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ormanOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region İnt
            int Fx = 0, Fy = 0;
            char selection;
            int direction = 1;
            int[,] map = new int[21, 21];
            #endregion

            #region placement
            for (int i1 = 0; i1 < 21; i1++)
            {
                for (int i2 = 0; i2 < 21; i2++)
                {
                    map[i1, i2] = 0;
                }
            }

            #endregion

            #region forward

            for (int i1 = 1; i1 != 0;)
            {
                #region direction keys
                if (direction == 1)
                {
                    Console.Write(" \t\n\t/ \\\n\t |\n\t |\n\t |\n");
                }
                else if (direction == 2)
                {
                    Console.Write("<-----\n");
                }
                else if (direction == 3)
                {
                    Console.Write("        ----->\n");
                }
                else if (direction == 4)
                {
                    Console.Write(" \t |\n\t |\n\t |\n\t |\n\t\\ /\n");
                }


                #endregion

                #region direction

                Console.Write("up w\ndown s\nright d\nleft a\nback b\nwhat do you want to do : ");
                selection = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(map[(20 - Fy), (10 + Fx)]);
                if (direction == 1)
                {
                    if (selection == 'w' || selection == 'W')
                    {
                        Fy++;
                        if (Fy >= -1 || Fy < 19)
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 1;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }

                    }
                    else if (selection == 'd' || selection == 'D')
                    {
                        Fx++;
                        if (Fx < 9 || Fx > (-9))
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 2;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 'a' || selection == 'A')
                    {
                        Fx--;
                        if (Fx < 9 || Fx > (-9))
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 3;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 's' || selection == 'S')
                    {
                        Fy--;
                        if (Fy >= -1 || Fy < 19)
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 4;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 'g' || selection == 'G')
                    {
                        Console.WriteLine("back to the way");
                        i1 = 0;
                    }
                    else
                    {
                        Console.WriteLine("try again");
                    }

                }
                else if (direction == 2)
                {
                    if (selection == 'w' || selection == 'W')
                    {
                        Fx++;
                        if (Fx < 9 || Fx > (-9))
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 2;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }

                    }
                    else if (selection == 'd' || selection == 'D')
                    {
                        Fy--;
                        if (Fy >= -1 || Fy < 19)
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 4;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 'a' || selection == 'A')
                    {
                        Fy++;
                        if (Fy >= -1 || Fy < 19)
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 1;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 's' || selection == 'S')
                    {
                        Fx--;
                        if (Fx < 9 || Fx > (-9))
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 3;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 'g' || selection == 'G')
                    {
                        Console.WriteLine("back to the way");
                        i1 = 0;
                    }
                    else
                    {
                        Console.WriteLine("try again");
                    }

                }
                else if (direction == 3)
                {
                    if (selection == 'w' || selection == 'W')
                    {
                        Fx--;
                        if (Fx < 9 || Fx > (-9))
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 3;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }

                    }
                    else if (selection == 'd' || selection == 'D')
                    {
                        Fy++;
                        if (Fy >= -1 || Fy < 19)
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 1;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 'a' || selection == 'A')
                    {
                        Fy--;
                        if (Fy >= -1 || Fy < 19)
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 4;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 's' || selection == 'S')
                    {
                        Fx++;
                        if (Fx < 9 || Fx > (-9))
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 2;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 'g' || selection == 'G')
                    {
                        Console.WriteLine("back to the way");
                        i1 = 0;
                    }
                    else
                    {
                        Console.WriteLine("try again");
                    }

                }
                else if (direction == 4)
                {

                    if (selection == 'w' || selection == 'W')
                    {
                        Fy--;
                        if (Fy >= -1 || Fy < 19)
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 4;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }

                    }
                    else if (selection == 'd' || selection == 'D')
                    {
                        Fx--;
                        if (Fx < 9 || Fx > (-9))
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 3;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 'a' || selection == 'A')
                    {
                        Fx++;
                        if (Fx < 9 || Fx > (-9))
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 2;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 's' || selection == 'S')
                    {
                        Fy++;
                        if (Fy >= -1 || Fy < 19)
                        {
                            if (map[(20 - Fy), (10 + Fx)] == 1)
                            {
                                Console.WriteLine("visited");
                            }
                            else
                            {
                                Console.WriteLine("discovery");
                            }
                            map[(20 - Fy), (10 + Fx)] = 1;
                            direction = 1;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 'g' || selection == 'G')
                    {
                        Console.WriteLine("back to the way");
                        i1 = 0;
                    }
                    else
                    {
                        Console.WriteLine("try again");
                    }
                }
                else
                {
                    Console.WriteLine("try again");
                }
                #endregion

                #region map
                for (int s1 = 0; s1 < 21; s1++)
                {
                    for (int s2 = 0; s2 < 21; s2++)
                    {
                        Console.Write(map[s1, s2]);
                    }
                    Console.Write("\n");
                }

                #endregion

            }
            Console.WriteLine("kapandı1");
            #endregion

            #region backward

            for (int i1 = 1; i1 != 0;)
            {
                #region direction keys
                if (direction == 1)
                {
                    Console.Write(" \t\n\t/ \\\n\t |\n\t |\n\t |\n");
                }
                else if (direction == 2)
                {
                    Console.Write("<-----\n");
                }
                else if (direction == 3)
                {
                    Console.Write("        ----->\n");
                }
                else if (direction == 4)
                {
                    Console.Write(" \t |\n\t |\n\t |\n\t |\n\t\\ /\n");
                }


                #endregion

                #region direction

                Console.Write("up w\n down s\nright d\nleft a\nback b\nwhat do you want to do : ");
                selection = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(map[(20 - Fy), (10 + Fx)]);
                if (direction == 1)
                {
                    if (selection == 'w' || selection == 'W')
                    {
                        Fy++;
                        if (Fy >= -1 || Fy < 19)
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 1;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }

                    }
                    else if (selection == 'd' || selection == 'D')
                    {
                        Fx++;
                        if (Fx < 9 || Fx > (-9))
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 2;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 'a' || selection == 'A')
                    {
                        Fx--;
                        if (Fx < 9 || Fx > (-9))
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 3;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 's' || selection == 'S')
                    {
                        Fy--;
                        if (Fy >= -1 || Fy < 19)
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 4;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else
                    {
                        Console.WriteLine("try again");
                    }

                }
                else if (direction == 2)
                {
                    if (selection == 'w' || selection == 'W')
                    {
                        Fx++;
                        if (Fx < 9 || Fx > (-9))
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 2;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }

                    }

                    else if (selection == 'd' || selection == 'D')
                    {
                        Fy--;
                        if (Fy >= -1 || Fy < 19)
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 4;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 'a' || selection == 'A')
                    {
                        Fy++;
                        if (Fy >= -1 || Fy < 19)
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 1;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 's' || selection == 'S')
                    {
                        Fx--;
                        if (Fx < 9 || Fx > (-9))
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 3;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else
                    {
                        Console.WriteLine("try again");
                    }

                }
                else if (direction == 3)
                {
                    if (selection == 'w' || selection == 'W')
                    {
                        Fx--;
                        if (Fx < 9 || Fx > (-9))
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 3;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }

                    }

                    else if (selection == 'd' || selection == 'D')
                    {
                        Fy++;
                        if (Fy >= -1 || Fy < 19)
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 1;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 'a' || selection == 'A')
                    {
                        Fy--;
                        if (Fy >= -1 || Fy < 19)
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 4;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 's' || selection == 'S')
                    {
                        Fx++;
                        if (Fx < 9 || Fx > (-9))
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 2;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else
                    {
                        Console.WriteLine("try again");
                    }

                }
                else if (direction == 4)
                {

                    if (selection == 'w' || selection == 'W')
                    {
                        Fy--;
                        if (Fy >= -1 || Fy < 19)
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 4;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }

                    }

                    else if (selection == 'd' || selection == 'D')
                    {
                        Fx--;
                        if (Fx < 9 || Fx > (-9))
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 3;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 'a' || selection == 'A')
                    {
                        Fx++;
                        if (Fx < 9 || Fx > (-9))
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 2;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else if (selection == 's' || selection == 'S')
                    {
                        Fy++;
                        if (Fy >= -1 || Fy < 19)
                        {
                            map[(20 - Fy), (10 + Fx)] = 2;
                            direction = 1;
                        }
                        else
                        {
                            Console.WriteLine("you left the safe zone");
                            i1 = 0;
                        }
                    }

                    else
                    {
                        Console.WriteLine("try again");
                    }
                }
                else
                {
                    Console.WriteLine("try again");
                }
                #endregion

                #region map
                for (int s1 = 0; s1 < 21; s1++)
                {
                    for (int s2 = 0; s2 < 21; s2++)
                    {
                        Console.Write(map[s1, s2]);
                    }
                    Console.Write("\n");
                }

                #endregion

                if (Fx == 9 || Fx == (-9) || Fy == 20 || Fy == 0)
                {
                    i1 = 0;
                }

            }
                #region exit

                
                if (map[20, 10] == 2)
                {
                    Console.WriteLine("mission completed");
                }
                else
                {
                    Console.WriteLine("mission failed");
                }

            #endregion

            #endregion
            Console.ReadLine();
        }
}
}
