using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            int a = 0, b = 0, i = 120, j = 120, f = 0, k = 0,t =0;
            string [] A1 = new string[45];
            string [] A2 = new string[45];
            string [] A3 = new string[45];
            string[,] number = new string[36, 4 + 5*45];
            string[] DEU = new string[3];
            DEU[0] = "D";
            DEU[1] = "E";
            DEU[2] = "U";
            bool restart = true;
            bool restart0 = true;
            

            do
            {
                
                for (int r = 0; r < 30; r++)
                {
                    Console.SetCursorPosition(0, 0 + f);
                    i = i - 5;
                    Console.WriteLine("Player1:     (P1-" + i + " P2-" + j + ")");
                    Console.Write("A1");
                    Console.Write(" ");
                    for (k = 0; k < A1.Length; k++)
                    {
                        if ((A1[k]) == null)
                            Console.Write(" ");
                        Console.Write(A1[k]);
                    }
                    Console.WriteLine("");
                    Console.Write("A2");
                    Console.Write(" ");
                    for (k = 0; k < A2.Length; k++)
                    {
                        if ((A2[k]) == null)
                            Console.Write(" ");
                        Console.Write(A2[k]);
                    }
                    Console.WriteLine("");
                    Console.Write("A3");
                    Console.Write(" ");
                    for (k = 0; k < A3.Length; k++)
                    {
                        if ((A3[k]) == null)
                            Console.Write(" ");
                        Console.Write(A3[k]);
                    }
                    Console.WriteLine("");

                    Random random = new Random();
                    x = random.Next(0, 3);

                    Random randomx = new Random();
                    a = randomx.Next(0, 15); 
                    b = randomx.Next(0, 3);


                    if (b == 0 && A1[a * 0] == null)
                    {
                        do
                        {
                            a = randomx.Next(0, 15);
                        } while (a != 0);
                        Console.SetCursorPosition(a * 2 + 3, b + 1 + f);
                        Console.Write(DEU[x]);
                    }
                    else if (b == 1 && A2[a * 0] == null)
                    {
                        do
                        {
                            a = randomx.Next(0, 15);
                        } while (a != 0);
                        Console.SetCursorPosition(a * 2 + 3, b + 1 + f);
                        Console.Write(DEU[x]);
                    }
                    else if (b == 2 && A3[a * 0] == null)
                    {
                        do
                        {
                            a = randomx.Next(0, 15);
                        } while (a != 0);
                        Console.SetCursorPosition(a * 2 + 3, b + 1 + f);
                        Console.Write(DEU[x]);
                    }
                    else
                    {
                        do
                        {
                            a = randomx.Next(1, 15);
                            b = randomx.Next(0, 3);

                            if ((b == 0 && A1[a * 2] == null) && (A1[a * 2 - 2] != null))
                            {
                                Console.SetCursorPosition(a * 2 + 3, b + 1 + f);
                                Console.Write(DEU[x]);
                                restart0 = false;
                            }
                            else if ((b == 1 && A2[a * 2] == null) && (A2[a * 2 - 2] != null))
                            {
                                Console.SetCursorPosition(a * 2 + 3, b + 1 + f);
                                Console.Write(DEU[x]);
                                restart0 = false;
                            }
                            else if ((b == 2 && A3[a * 2] == null) && (A3[a * 2 - 2] != null))
                            {
                                Console.SetCursorPosition(a * 2 + 3, b + 1 + f);
                                Console.Write(DEU[x]);
                                restart0 = false;
                            }
                            else
                                restart0 = true;
                        } while (restart0 == true);
                    }

                    if (b == 0)
                        A1[a * 2] = DEU[x];
                    else if (b == 1)
                        A2[a * 2] = DEU[x];
                    else if (b == 2)
                        A3[a * 2] = DEU[x];

                    
                    Console.ReadLine();
                    f = f + 5;
                    break;
                }

                //reverse and horizontally
                if (a > 1 && b == 0 && x == 0 && A1[a * 2 - 2] == "E" && A1[a * 2 - 4] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }

                else if (a > 1 && b == 1 && x == 0 && A2[a * 2 - 2] == "E" && A2[a * 2 - 4] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (a > 1 && b == 2 && x == 0 && A3[a * 2 - 2] == "E" && A3[a * 2 - 4] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }

                //straight and horizontally
                if (a>1 && b == 0 && x == 2 && A1[a * 2 - 2] == "E" && A1[a * 2 - 4] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (a > 1 && b == 1 && x == 2 && A2[a * 2 - 2] == "E" && A2[a * 2 - 4] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (a > 1 && b == 2 && x == 2 && A3[a * 2 - 2] == "E" && A3[a * 2 - 4] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }

                //straigt and vertically
                else if (b == 0 && x == 0 && A2[a * 2] == "E" && A3[a * 2] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (b == 1 && x == 1 && A1[a * 2] == "D" && A3[a * 2] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (b == 2 && x == 2 && A1[a * 2] == "D" && A2[a * 2] == "E")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                //reverse and vertically
                else if (b == 2 && x == 0 && A2[a * 2] == "E" && A1[a * 2] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (b == 1 && x == 1 && A1[a * 2] == "U" && A3[a * 2] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (b == 0 && x == 2 && A2[a * 2] == "E" && A3[a * 2] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                //diagonal for D
                else if (b == 0 && x == 0 && A2[a * 2 + 2] == "E" && A3[a * 2 + 4] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (b == 2 && x == 0 && A2[a * 2 + 2] == "E" && A1[a * 2 + 4] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (a > 1 && b == 0 && x == 0 && A2[a * 2 - 2] == "E" && A3[a * 2 - 4] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (a > 1 && b == 2 && x == 0 && A2[a * 2 - 2] == "E" && A1[a * 2 - 4] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                //diagonal for E
                else if (a > 0 && b == 1 && x == 1 && A1[a * 2 - 2] == "D" && A3[a * 2 + 2] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (a > 0 && b == 1 && x == 1 && A3[a * 2 + 2] == "D" && A1[a * 2 - 2] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (a > 0 && b == 1 && x == 1 && A3[a * 2 - 2] == "D" && A1[a * 2 + 2] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (a > 0 && b == 1 && x == 1 && A1[a * 2 + 2] == "D" && A3[a * 2 - 2] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                //diagonal for U
                else if (b == 0 && x == 2 && A2[a * 2 + 2] == "E" && A3[a * 2 + 4] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (b == 2 && x == 2 && A2[a * 2 + 2] == "E" && A1[a * 2 + 4] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (a > 1 && b == 0 && x == 2 && A2[a * 2 - 2] == "E" && A3[a * 2 - 4] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                else if (a > 1 && b == 2 && x == 2 && A2[a * 2 - 2] == "E" && A1[a * 2 - 4] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player1");
                    break;
                }
                

                for (int r = 0; r < 30; r++)
                {
                    Console.SetCursorPosition(0, 0 + f);
                    j = j - 5;
                    if (j == 5)
                        break;
                    Console.WriteLine("Player2:     (P1-" + i + " P2-" + j + ")");
                    Console.Write("A1");
                    Console.Write(" ");
                    for (k = 0; k < A1.Length; k++)
                    {
                        if ((A1[k]) == null)
                            Console.Write(" ");
                        Console.Write(A1[k]);
                    }
                    Console.WriteLine("");
                    Console.Write("A2");
                    Console.Write(" ");
                    for (k = 0; k < A2.Length; k++)
                    {
                        if ((A2[k]) == null)
                            Console.Write(" ");
                        Console.Write(A2[k]);
                    }
                    Console.WriteLine("");
                    Console.Write("A3");
                    Console.Write(" ");
                    for (k = 0; k < A3.Length; k++)
                    {
                        if ((A3[k]) == null)
                            Console.Write(" ");
                        Console.Write(A3[k]);
                    }
                    Console.WriteLine("");

                    Random random = new Random();
                    x = random.Next(0, 3);

                    Random randomx = new Random();
                    a = randomx.Next(0, 15); 
                    b = randomx.Next(0, 3);

                    if (b == 0 && A1[a * 0] == null)
                    {
                        do
                        {
                            a = randomx.Next(0, 15);
                        } while (a != 0);
                        Console.SetCursorPosition(a * 2 + 3, b + 1 + f);
                        Console.Write(DEU[x]);
                    }
                    else if (b == 1 && A2[a * 0] == null)
                    {
                        do
                        {
                            a = randomx.Next(0, 15);
                        } while (a != 0);
                        Console.SetCursorPosition(a * 2 + 3, b + 1 + f);
                        Console.Write(DEU[x]);
                    }
                    else if (b == 2 && A3[a * 0] == null)
                    {
                        do
                        {
                            a = randomx.Next(0, 15);
                        } while (a != 0);
                        Console.SetCursorPosition(a * 2 + 3, b + 1 + f);
                        Console.Write(DEU[x]);
                    }

                    else
                    {
                        do
                        {
                            a = randomx.Next(1, 15);
                            b = randomx.Next(0, 3);

                            if ((b == 0 && A1[a * 2] == null) && (A1[a * 2 - 2] != null))
                            {
                                Console.SetCursorPosition(a * 2 + 3, b + 1 + f);
                                Console.Write(DEU[x]);
                                restart0 = false;
                            }
                            else if ((b == 1 && A2[a * 2] == null) && (A2[a * 2 - 2] != null))
                            {
                                Console.SetCursorPosition(a * 2 + 3, b + 1 + f);
                                Console.Write(DEU[x]);
                                restart0 = false;
                            }
                            else if ((b == 2 && A3[a * 2] == null) && (A3[a * 2 - 2] != null))
                            {
                                Console.SetCursorPosition(a * 2 + 3, b + 1 + f);
                                Console.Write(DEU[x]);
                                restart0 = false;
                            }
                            else
                                restart0 = true;
                        } while (restart0 == true);
                    }
                    
                    if (b == 0)
                        A1[a * 2] = DEU[x];
                    else if (b == 1)
                        A2[a * 2] = DEU[x];
                    else if (b == 2)
                        A3[a * 2] = DEU[x];

                    
                    Console.ReadLine();
                    f = f + 5;
                    break;
                }

                //reverse and horizontally
                if (a > 1 && b == 0 && x == 0 && A1[a * 2 - 2] == "E" && A1[a * 2 - 4] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }

                else if (a > 1 && b == 1 && x == 0 && A2[a * 2 - 2] == "E" && A2[a * 2 - 4] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (a > 1 && b == 2 && x == 0 && A3[a * 2 - 2] == "E" && A3[a * 2 - 4] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }

                //straight and horizontally
                if (a > 1 && b == 0 && x == 2 && A1[a * 2 - 2] == "E" && A1[a * 2 - 4] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (a > 1 && b == 1 && x == 2 && A2[a * 2 - 2] == "E" && A2[a * 2 - 4] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (a > 1 && b == 2 && x == 2 && A3[a * 2 - 2] == "E" && A3[a * 2 - 4] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }

                //straigt and vertically
                else if (b == 0 && x == 0 && A2[a * 2] == "E" && A3[a * 2] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (b == 1 && x == 1 && A1[a * 2] == "D" && A3[a * 2] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (b == 2 && x == 2 && A1[a * 2] == "D" && A2[a * 2] == "E")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                //reverse and vertically
                else if (b == 2 && x == 0 && A2[a * 2] == "E" && A1[a * 2] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (b == 1 && x == 1 && A1[a * 2] == "U" && A3[a * 2] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (b == 0 && x == 2 && A2[a * 2] == "E" && A3[a * 2] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                //diagonal for D
                else if (b == 0 && x == 0 && A2[a * 2 + 2] == "E" && A3[a * 2 + 4] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (b == 2 && x == 0 && A2[a * 2 + 2] == "E" && A1[a * 2 + 4] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (a > 1 && b == 0 && x == 0 && A2[a * 2 - 2] == "E" && A3[a * 2 - 4] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (a > 1 && b == 2 && x == 0 && A2[a * 2 - 2] == "E" && A1[a * 2 - 4] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                //diagonal for E
                else if (a > 0 && b == 1 && x == 1 && A1[a * 2 - 2] == "D" && A3[a * 2 + 2] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (a > 0 && b == 1 && x == 1 && A3[a * 2 + 2] == "D" && A1[a * 2 - 2] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (a > 0 && b == 1 && x == 1 && A3[a * 2 - 2] == "D" && A1[a * 2 + 2] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (a > 0 && b == 1 && x == 1 && A1[a * 2 + 2] == "D" && A3[a * 2 - 2] == "U")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                //diagonal for U
                else if (b == 0 && x == 2 && A2[a * 2 + 2] == "E" && A3[a * 2 + 4] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (b == 2 && x == 2 && A2[a * 2 + 2] == "E" && A1[a * 2 + 4] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (a > 1 && b == 0 && x == 2 && A2[a * 2 - 2] == "E" && A3[a * 2 - 4] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                else if (a > 1 && b == 2 && x == 2 && A2[a * 2 - 2] == "E" && A1[a * 2 - 4] == "D")
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("winner: Player2");
                    restart = false;
                }
                
                if (j == 5)
                {
                    Console.SetCursorPosition(0, 0 + f + 2);
                    Console.WriteLine("tie");
                    restart = false;
                }

            } while (restart == true);

            if (i < j)
            {
                
                string[] names = new string[13];
                names[0] = "Derya";
                names[1] = "Elife";
                names[2] = "Fatih";
                names[3] = "Ali";
                names[4] = "Azra";
                names[5] = "Sibel";
                names[6] = "Cem";
                names[7] = "Nazan";
                names[8] = "Mehmet";
                names[9] = "Nil";
                names[10] = "Can";
                names[11] = "Tarkan";
                names[12] = "Player1";

                if(i > 100)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = names[8];
                    names[8] = names[7];
                    names[7] = names[6];
                    names[6] = names[5];
                    names[5] = names[4];
                    names[4] = names[3];
                    names[3] = names[2];
                    names[2] = names[1];
                    names[1] = names[0];
                    names[0] = temp1;
                }
                else if (i>95)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = names[8];
                    names[8] = names[7];
                    names[7] = names[6];
                    names[6] = names[5];
                    names[5] = names[4];
                    names[4] = names[3];
                    names[3] = names[2];
                    names[2] = temp1;
                }
                else if (i>90)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = names[8];
                    names[8] = names[7];
                    names[7] = names[6];
                    names[6] = names[5];
                    names[5] = names[4];
                    names[4] = names[3];
                    names[3] = temp1;
                }
                else if (i>85)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = names[8];
                    names[8] = names[7];
                    names[7] = names[6];
                    names[6] = names[5];
                    names[5] = names[4];
                    names[4] = temp1;
                }
                else if (i > 80)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = names[8];
                    names[8] = names[7];
                    names[7] = names[6];
                    names[6] = names[5];
                    names[5] = temp1;
                }
                else if (i > 70)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = names[8];
                    names[8] = names[7];
                    names[7] = temp1;
                }
                else if (i > 55)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = names[8];
                    names[8] = temp1;
                }
                else if (i > 50)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = temp1;
                }
                else if (i > 30)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = temp1;
                }
                else 
                {
                    for (int p = 0; p < names.Length; p++)
                        Console.WriteLine(names[p]);
                }
                Console.SetCursorPosition(0, 0 + f + 5);
                Console.WriteLine("Name");
                for (k = 0; k < names.Length; k++)
                {
                    Console.SetCursorPosition(0, 0 + f + 7);
                    Console.WriteLine(names[k]);
                    f = f + 1;
                }
                t = f - 13;


                int[] scores = new int[13];
                scores[0] = 100;
                scores[1] = 100;
                scores[2] = 95;
                scores[3] = 90;
                scores[4] = 85;
                scores[5] = 80;
                scores[6] = 80;
                scores[7] = 70;
                scores[8] = 55;
                scores[9] = 50;
                scores[10] = 30;
                scores[11] = 30;
                scores[12] = i;

                if (i > 100)
                {
                    int temp1;
                    temp1 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = scores[8];
                    scores[8] = scores[7];
                    scores[7] = scores[6];
                    scores[6] = scores[5];
                    scores[5] = scores[4];
                    scores[4] = scores[3];
                    scores[3] = scores[2];
                    scores[2] = scores[1];
                    scores[1] = scores[0];
                    scores[0] = temp1;
                }
                else if (i > 95)
                {
                    int temp1;
                    temp1 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = scores[8];
                    scores[8] = scores[7];
                    scores[7] = scores[6];
                    scores[6] = scores[5];
                    scores[5] = scores[4];
                    scores[4] = scores[3];
                    scores[3] = scores[2];
                    scores[2] = temp1;
                }
                else if (i > 90)
                {
                    int temp2;
                    temp2 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = scores[8];
                    scores[8] = scores[7];
                    scores[7] = scores[6];
                    scores[6] = scores[5];
                    scores[5] = scores[4];
                    scores[4] = scores[3];
                    scores[3] = temp2;
                }
                else if (i > 85)
                {
                    int temp3;
                    temp3 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = scores[8];
                    scores[8] = scores[7];
                    scores[7] = scores[6];
                    scores[6] = scores[5];
                    scores[5] = scores[4];
                    scores[4] = temp3;
                }
                else if (i > 80)
                {
                    int temp5;
                    temp5 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = scores[8];
                    scores[8] = scores[7];
                    scores[7] = scores[6];
                    scores[6] = scores[5];
                    scores[5] = temp5;
                }
                else if (i > 70)
                {
                    int temp6;
                    temp6 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = scores[8];
                    scores[8] = scores[7];
                    scores[7] = temp6;
                }
                else if (i > 55)
                {
                    int temp7;
                    temp7 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = scores[8];
                    scores[8] = temp7;
                }
                else if (i > 50)
                {
                    int temp8;
                    temp8 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = temp8;
                }
                else if (i > 30)
                {
                    int temp9;
                    temp9 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = temp9;
                }
                else
                {
                    for (int m = 0; m < scores.Length; m++)
                        Console.WriteLine(scores[m]);
                }
                Console.SetCursorPosition(12, 0 + t + 5);
                Console.WriteLine("Score");
                for (k = 0; k < scores.Length; k++)
                {
                    Console.SetCursorPosition(12, 0 + t + 7);
                    Console.WriteLine(scores[k]);
                    t = t + 1;
                }
            }

            if (j == i)
            {

                string[] names = new string[13];
                names[0] = "Derya";
                names[1] = "Elife";
                names[2] = "Fatih";
                names[3] = "Ali";
                names[4] = "Azra";
                names[5] = "Sibel";
                names[6] = "Cem";
                names[7] = "Nazan";
                names[8] = "Mehmet";
                names[9] = "Nil";
                names[10] = "Can";
                names[11] = "Tarkan";
                names[12] = "Player2";

                if (j > 100)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = names[8];
                    names[8] = names[7];
                    names[7] = names[6];
                    names[6] = names[5];
                    names[5] = names[4];
                    names[4] = names[3];
                    names[3] = names[2];
                    names[2] = names[1];
                    names[1] = names[0];
                    names[0] = temp1;
                }
                else if (j > 95)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = names[8];
                    names[8] = names[7];
                    names[7] = names[6];
                    names[6] = names[5];
                    names[5] = names[4];
                    names[4] = names[3];
                    names[3] = names[2];
                    names[2] = temp1;
                }
                else if (j > 90)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = names[8];
                    names[8] = names[7];
                    names[7] = names[6];
                    names[6] = names[5];
                    names[5] = names[4];
                    names[4] = names[3];
                    names[3] = temp1;
                }
                else if (j > 85)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = names[8];
                    names[8] = names[7];
                    names[7] = names[6];
                    names[6] = names[5];
                    names[5] = names[4];
                    names[4] = temp1;
                }
                else if (j > 80)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = names[8];
                    names[8] = names[7];
                    names[7] = names[6];
                    names[6] = names[5];
                    names[5] = temp1;
                }
                else if (j > 70)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = names[8];
                    names[8] = names[7];
                    names[7] = temp1;
                }
                else if (j > 55)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = names[8];
                    names[8] = temp1;
                }
                else if (j > 50)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = names[9];
                    names[9] = temp1;
                }
                else if (j > 30)
                {
                    string temp1;
                    temp1 = names[12];
                    names[12] = names[11];
                    names[11] = names[10];
                    names[10] = temp1;
                }
                else
                {
                    for (int p = 0; p < names.Length; p++)
                        Console.WriteLine(names[p]);
                }


                Console.SetCursorPosition(0, 0 + f + 5);
                Console.WriteLine("Name");
                for (k = 0; k < names.Length; k++)
                {
                    Console.SetCursorPosition(0, 0 + f + 7);
                    Console.WriteLine(names[k]);
                    f = f + 1;
                }
                t = f - 13;

                int[] scores = new int[13];
                scores[0] = 100;
                scores[1] = 100;
                scores[2] = 95;
                scores[3] = 90;
                scores[4] = 85;
                scores[5] = 80;
                scores[6] = 80;
                scores[7] = 70;
                scores[8] = 55;
                scores[9] = 50;
                scores[10] = 30;
                scores[11] = 30;
                scores[12] = j;

                if (j > 100)
                {
                    int temp1;
                    temp1 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = scores[8];
                    scores[8] = scores[7];
                    scores[7] = scores[6];
                    scores[6] = scores[5];
                    scores[5] = scores[4];
                    scores[4] = scores[3];
                    scores[3] = scores[2];
                    scores[2] = scores[1];
                    scores[1] = scores[0];
                    scores[0] = temp1;
                }
                else if (j > 95)
                {
                    int temp1;
                    temp1 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = scores[8];
                    scores[8] = scores[7];
                    scores[7] = scores[6];
                    scores[6] = scores[5];
                    scores[5] = scores[4];
                    scores[4] = scores[3];
                    scores[3] = scores[2];
                    scores[2] = temp1;
                }
                else if (j > 90)
                {
                    int temp2;
                    temp2 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = scores[8];
                    scores[8] = scores[7];
                    scores[7] = scores[6];
                    scores[6] = scores[5];
                    scores[5] = scores[4];
                    scores[4] = scores[3];
                    scores[3] = temp2;
                }
                else if (j > 85)
                {
                    int temp3;
                    temp3 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = scores[8];
                    scores[8] = scores[7];
                    scores[7] = scores[6];
                    scores[6] = scores[5];
                    scores[5] = scores[4];
                    scores[4] = temp3;
                }
                else if (j > 80)
                {
                    int temp5;
                    temp5 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = scores[8];
                    scores[8] = scores[7];
                    scores[7] = scores[6];
                    scores[6] = scores[5];
                    scores[5] = temp5;
                }
                else if (j > 70)
                {
                    int temp6;
                    temp6 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = scores[8];
                    scores[8] = scores[7];
                    scores[7] = temp6;
                }
                else if (j > 55)
                {
                    int temp7;
                    temp7 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = scores[8];
                    scores[8] = temp7;
                }
                else if (j > 50)
                {
                    int temp8;
                    temp8 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = scores[9];
                    scores[9] = temp8;
                }
                else if (j > 30)
                {
                    int temp9;
                    temp9 = scores[12];
                    scores[12] = scores[11];
                    scores[11] = scores[10];
                    scores[10] = temp9;
                }
                else
                {
                    for (int n = 0; n < names.Length; n++)
                        Console.WriteLine(names[n]);
                }

                Console.SetCursorPosition(12, 0 + t + 5);
                Console.WriteLine("Score");
                for (k = 0; k < scores.Length; k++)
                {
                    Console.SetCursorPosition(12, 0 + t + 7);
                    Console.WriteLine(scores[k]);
                    t = t + 1;
                }
            }

            Console.ReadLine();
                
        }
    }
}
