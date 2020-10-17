using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenI
{
    public partial class UserControl1 : UserControl
    {
        char[] code, code2;
        string colors = "ARBNVM";
        int attempts;

        public UserControl1()
        {
            InitializeComponent();
            code = new char[4];
            code2 = new char[4];
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            attempts = 8;
            RandomizeStart();
            attemptsRemaining.Text = attempts.ToString();
            btnSubmit.Enabled = true;
            userGuess.Enabled = true;
        }

        private void RandomizeStart()
        {
            var random = new Random();
            for (var i = 0; i < code.Length; i++)
            {
                code[i] = colors[random.Next(0, colors.Length)];
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (attempts > 1)
            {
                code2Refill();
                char[] userGuessArray = userGuess.Text.ToCharArray();
                int total = getTotalResults(userGuessArray);
                int partial = getPartialResults(userGuessArray);
                partialResults.Text = partial.ToString();
                totalResults.Text = total.ToString();
                checkWin(total);
        
            }
            else
            {
                gameLost();
            }
            attempts--;
            attemptsRemaining.Text = attempts.ToString();
        }

        private int getPartialResults(char[] userGuess)
        {
            int cont =0;
            for (var i = 0; i < code.Length; i++)
            {
                if(userGuess[i] == code[i])
                {
                    break;
                } else
                {
                    for (var j = 0; j < code.Length; j++)
                    {
                        if (userGuess[i] == code2[j])
                        {
                            cont++;
                            code2[j] = 'X';
                            break;
                        }
                    }
                }
            }
            return cont;
        }

        private int getTotalResults(char[] userGuess)
        {
            int cont = 0;
            for (var i = 0; i < code.Length; i++)
            {
                if (userGuess[i] == code2[i])
                {
                    cont++;
                    code2[i]='X';
                }
            }
            return cont;
        }


        private void code2Refill()
        {
            for (int i = 0; i < code.Length; i++)
            {
                code2[i] = code[i];
            }
        }

        private void checkWin(int results)
        {
            if(results == 4)
            {
                attempts--;
                endGame.Text = "You have win the game! With remaining attempts: " + attempts.ToString();
                btnSubmit.Enabled = false;
                userGuess.Enabled = false;
            }
        }

        private void gameLost()
        {
            string resul = "";
            for (var i = 0; i < code.Length; i++)
            {
                resul += code[i];
            }
            endGame.Text = "You have lost the game! The solution was: " + resul;

            btnSubmit.Enabled = false;
            userGuess.Enabled = false;
        }

    }
}
