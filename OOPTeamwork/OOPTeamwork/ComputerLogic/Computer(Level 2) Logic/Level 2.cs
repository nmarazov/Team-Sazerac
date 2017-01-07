using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Level_2__Logic
{        
    /*
cnt: is a counter to track the number of moves played.
val: is a value corresponding to the letter. 1 for X and 4 for O. In array, the values are used instead of letters.
a, b, c, d: are the integers to hold the co-ordinates of second last and last move respectively, used by computer player logic.
diff and vs: are used to identify difficulty level and game mode selected by the user.
rnd & turn: are used to generate random number and to toggle comp player mode.
*/
    class Level_2
    {

     public int[,] pos = new int[3, 3]; //the board
     public static Label label1, label2, label3, label4,label5,label6, label7, label8, label9,labelText;
     public Label[,] board =
        { {label1,label2,label3 },
          {label4,label5, label6},
          { label7, label8, label9}
        };
     public int cnt, val, a, b, c = 1, d = 1, diff = 1, vs = 1;
     public char letter; //X or 0
     public String pl1 = "You", pl2 = "Computer";
     public Random rnd = new Random(); //used to generate random number and to toggle comp player mode.
     public bool turn = true; // toggle comp player mode.

    public void reset()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                { pos[i, j] = 0; }  //Fill array with zeros
            }
            
            cnt = 0;
            val = 1;  // X->1 and O->4
            letter = 'X';
            labelText.Text = pl1 + " to Play NOW.";  //Setting status label.
        }


        bool play(int l, int m)
        {
            if (pos[l, m] == 0)// Check to avoid overplays.
            {
                a = c; b = d; c = l; d = m;  //Hold the coordinates of 2nd last and last moves.
                Label ctrl = link(l, m);  //Link the coordinates to the label.
                                          // (used for computer player)
                                        
                //!!!!!!!!!!!! TODO: Reflecting move to screen.

                pos[l, m] = val;   //Reflecting move in array
                flip();  //Toggling between X and O
                checkwin(l, m, pos[l, m]);  // Check for win or Draw situation.
                return true;
            }
            else
                return false;  //Useful if move is to be replayed.
        }
        Label link(int l, int m)  //Returning appropriate label for the passed coordinates.
        {
            if (l == 0)
            {
                if (m == 0)
                    return label1;
                if (m == 1)
                    return label2;
                if (m == 2)
                    return label3;
            }
            if (l == 1)
            {
                if (m == 0)
                    return label4;
                if (m == 1)
                    return label5;
                if (m == 2)
                    return label6;
            }
            if (l == 2)
            {
                if (m == 0)
                    return label7;
                if (m == 1)
                    return label8;
                if (m == 2)
                    return label9;
            }
            return null;
        }
        void flip()   //Logic for toggle
        {
            if (letter == 'X')
            {
                letter= 'O';
                val = 4;
                cnt++;
            }
            else
            {
                letter = 'X';
                val = 1;
                cnt++;
            }
        }
        void checkwin(int l, int m, int n)
        {
            if (cnt == 1)
                if (vs == 1)
                    turn = true;
            if (cnt > 4)
            {   // Check for corresponding row first.
                if ((pos[l, 0] + pos[l, 1] + pos[l, 2] == n * 3) ||
                (pos[0, m] + pos[1, m] + pos[2, m] == n * 3))
                {
                    cnt = n;
                }
                else
                {   //Checking for corresponding column.
                    if ((pos[0, 0] + pos[1, 1] + pos[2, 2] == n * 3) ||
                (pos[2, 0] + pos[1, 1] + pos[0, 2] == n * 3))
                    {
                        cnt = n;
                    }
                    else
                    {
                        if (cnt == 9)
                        {   //In a draw situation.
                            cnt = 0;
                        }
                    }
                }
                if (cnt == 1 || cnt == 0)
                {  // If the first player wins or Draw occurs.
                    if (cnt == 1)
                        Console.WriteLine(pl1 + " (Playing X) Wins!");
                    if (cnt == 0)
                        Console.WriteLine("The Game is a Draw!");
                    reset();
                    if (vs == 1)
                        if (pl1 == "Computer")
                        {
                            turn = false;
                            compplay(val);      //If the First player happens
                                                //to be computer we need to call it.
                        }
                        else
                            turn = false;

                }
                else
                if (cnt == 4)
                {
                    Console.WriteLine(pl2 + " (Playing O) Wins!");
                    String temp = pl1;
                    pl1 = pl2;
                    pl2 = temp;
                    reset();
                    if (vs == 1)
                        if (pl1 == "Computer")
                            compplay(val);      // If the first palyer is computer,
                                                // we need to call this.
                        else
                            turn = false;
                }
            }
        }

        void compplay(int n)
        {
            bool carry = true;      // Is used so that multiple moves are not played 
                                    // by computer.
            if (diff == 3)      //Is called only if Hard difficulty is set.
                carry = winorstop(a, b, n); // a & b are used so that check 
                                            // is performed only at last computers move.
            if ((diff == 2 || diff == 3) && carry)  //Is called if Hard or Medium 
                                                    // difficulty is set.
            {// For stop require to check for opponents pieces using c & d
                if (n == 1)
                    carry = winorstop(c, d, 4);
                else
                    carry = winorstop(c, d, 1);
            }
            if (carry)
                doany();  // Executed in all three difficulty levels
        }
        bool winorstop(int l, int m, int n)
        {
            if (pos[l, 0] + pos[l, 1] + pos[l, 2] == n * 2) //check for row, 
                                                            // if two of three are filled.
            {
                for (int i = 0; i < 3; i++)
                {
                    if (play(l, i))
                        return false;
                }
            }
            else
                if (pos[0, m] + pos[1, m] + pos[2, m] == n * 2) //Check for column for 2/3
            {
                for (int i = 0; i < 3; i++)
                {
                    if (play(i, m))
                        return false;
                }
            }
            else
                    if (pos[0, 0] + pos[1, 1] + pos[2, 2] == n * 2) //Check for diagonal 
                                                                    //for 2/3 situation.
            {
                for (int i = 0; i < 3; i++)
                {
                    if (play(i, i))
                        return false;
                }
            }
            else
                        if (pos[2, 0] + pos[1, 1] + pos[0, 2] == n * 2) //Check for 
                                                                        //other diagonal for 2/3 situation.

            {
                for (int i = 0, j = 2; i < 3; i++, j--)
                {
                    if (play(i, j))
                        return false;
                }
            }

            return true;
        }
        void doany()
        {
            int l = 2, m = 0;
            switch (cnt)
            {
                case 0:
                    play(0, 0);   //First two moves are certainly played.
                    break;
                case 1:
                    if (!(play(1, 1)))
                        play(0, 0);
                    break;
                case 2:
                    if (!(play(2, 2)))
                        play(0, 2);
                    break;
                case 3:
                    if ((pos[0, 1] + pos[1, 1] + pos[2, 1]) == val)
                        play(0, 1);
                    else
                        if ((pos[1, 0] + pos[1, 1] + pos[1, 2]) == val)
                        play(1, 0);
                    else
                            if (pos[0, 1] != 0)
                        play(0, 2);
                    else
                        play(2, 0);

                    break;
                default:
                    while (!(play(l, m)))
                    {
                        l = rnd.Next(3);  // Random moves are played
                        m = rnd.Next(3);  //Until at least one is successful
                    }
                    break;
            }
        }
        void Label1Click(object sender, EventArgs e)
        {
            if (play(0, 0) && turn == true)
                compplay(val); // Is executed only if Players move 
                               //was successful and the game is in Vs computer mod.
        }
    }
}
