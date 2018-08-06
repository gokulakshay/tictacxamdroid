using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Tictactoe.Droid
{
    [Activity(Label = "Tictactoe.Droid", MainLauncher = true, Theme = "@style/AppTheme")]
    public class MainActivity : Activity
    {
        Button b1, b2, b3, b4, b5, b6, b7, b8, b9, reset;
        TextView turn,player1Score,player2Score;
        int currentTurn = 1;
        int[] click = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int player1 = 0, player2 = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            //Boiler Plate
            b1 = FindViewById<Button>(Resource.Id.button1);
            b2 = FindViewById<Button>(Resource.Id.button2);
            b3 = FindViewById<Button>(Resource.Id.button3);
            b4 = FindViewById<Button>(Resource.Id.button4);
            b5 = FindViewById<Button>(Resource.Id.button5);
            b6 = FindViewById<Button>(Resource.Id.button6);
            b7 = FindViewById<Button>(Resource.Id.button7);
            b8 = FindViewById<Button>(Resource.Id.button8);
            b9 = FindViewById<Button>(Resource.Id.button9);
            turn = FindViewById<TextView>(Resource.Id.turn);
            player1Score = FindViewById<TextView>(Resource.Id.player1wins);
            player2Score = FindViewById<TextView>(Resource.Id.player2wins);
            reset = FindViewById<Button>(Resource.Id.reset);

            b1.Click += B1_Click;
            b2.Click += B2_Click;
            b3.Click += B3_Click;
            b4.Click += B4_Click;
            b5.Click += B5_Click;
            b6.Click += B6_Click;
            b7.Click += B7_Click;
            b8.Click += B8_Click;
            b9.Click += B9_Click;
            reset.Click += Reset_Click;

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ClearGame();
        }

        protected override void OnDestroy()
        {
            b1.Click -= B1_Click;
            b2.Click -= B2_Click;
            b3.Click -= B3_Click;
            b4.Click -= B4_Click;
            b5.Click -= B5_Click;
            b6.Click -= B6_Click;
            b7.Click -= B7_Click;
            b8.Click -= B8_Click;
            b9.Click -= B9_Click;
            base.OnDestroy();
        }

        private void B9_Click(object sender, System.EventArgs e)
        {
            Play(8, sender as Button);
        }

        private void B8_Click(object sender, System.EventArgs e)
        {
            Play(7, sender as Button);
        }

        private void B7_Click(object sender, System.EventArgs e)
        {
            Play(6, sender as Button);
        }

        private void B6_Click(object sender, System.EventArgs e)
        {
            Play(5, sender as Button);
        }

        private void B5_Click(object sender, System.EventArgs e)
        {
            Play(4, sender as Button);
        }

        private void B4_Click(object sender, System.EventArgs e)
        {
            Play(3, sender as Button);
        }

        private void B3_Click(object sender, System.EventArgs e)
        {
            Play(2, sender as Button);
        }

        private void B2_Click(object sender, System.EventArgs e)
        {
            Play(1, sender as Button);
        }

        private void B1_Click(object sender, System.EventArgs e)
        {
            Play(0, sender as Button);
        }

        public void CheckforWin()
        {
            if (b1.Text != string.Empty && b2.Text != string.Empty && b3.Text != string.Empty)
            {
                if (b1.Text == b2.Text && b1.Text == b3.Text)
                {
                    if (b1.Text == "X")
                    {
                        Toast.MakeText(this, "Player 1 Wins!",ToastLength.Long).Show();
                        player1++;
                        player1Score.Text = "Player 1 Wins: " + player1.ToString();
                    }
                    else
                    {
                        Toast.MakeText(this, "Player 2 Wins!",ToastLength.Long).Show();
                        player2++;
                        player2Score.Text = "Player 2 Wins: " + player2.ToString();
                    }
                    ClearGame();

                }
            }
            if (b4.Text != string.Empty && b5.Text != string.Empty && b6.Text != string.Empty)
            {
                if (b4.Text == b5.Text && b4.Text == b6.Text)
                {
                    if (b4.Text == "X")
                    {
                        Toast.MakeText(this, "Player 1 Wins!",ToastLength.Long).Show();
                        player1++;
                        player1Score.Text = "Player 1 Wins: " + player1.ToString();

                    }
                    else
                    {
                        Toast.MakeText(this, "Player 2 Wins!",ToastLength.Long).Show();
                        player2++;
                        player2Score.Text = "Player 2 Wins: " + player2.ToString();

                    }
                    ClearGame();
                }
            }
            if (b7.Text != string.Empty && b8.Text != string.Empty && b9.Text != string.Empty)
            {
                if (b7.Text == b8.Text && b7.Text == b9.Text)
                {
                    if (b7.Text == "X")
                    {
                        Toast.MakeText(this, "Player 1 Wins!",ToastLength.Long).Show();
                        player1++;
                        player1Score.Text = "Player 1 Wins: " + player1.ToString();

                    }
                    else
                    {
                        Toast.MakeText(this, "Player 2 Wins!",ToastLength.Long).Show();
                        player2++;
                        player2Score.Text = "Player 2 Wins: " + player2.ToString();

                    }
                    ClearGame();
                }
            }
            if (b1.Text != string.Empty && b4.Text != string.Empty && b7.Text != string.Empty)
            {
                if (b1.Text == b4.Text && b1.Text == b7.Text)
                {
                    if (b1.Text == "X")
                    {
                        Toast.MakeText(this, "Player 1 Wins!",ToastLength.Long).Show();
                        player1++;
                        player1Score.Text = "Player 1 Wins: " + player1.ToString();

                    }
                    else
                    {
                        Toast.MakeText(this, "Player 2 Wins!",ToastLength.Long).Show();
                        player2++;
                        player2Score.Text = "Player 2 Wins: " + player2.ToString();

                    }
                    ClearGame();
                }
            }
            if (b2.Text != string.Empty && b5.Text != string.Empty && b8.Text != string.Empty)
            {
                if (b2.Text == b5.Text && b2.Text == b8.Text)
                {
                    if (b2.Text == "X")
                    {
                        Toast.MakeText(this, "Player 1 Wins!",ToastLength.Long).Show();
                        player1++;
                        player1Score.Text = "Player 1 Wins: " + player1.ToString();

                    }
                    else
                    {
                        Toast.MakeText(this, "Player 2 Wins!",ToastLength.Long).Show();
                        player2++;
                        player2Score.Text = "Player 2 Wins: " + player2.ToString();

                    }
                    ClearGame();
                }
            }
            if (b3.Text != string.Empty && b6.Text != string.Empty && b9.Text != string.Empty)
            {
                if (b3.Text == b6.Text && b3.Text == b9.Text)
                {
                    if (b3.Text == "X")
                    {
                        Toast.MakeText(this, "Player 1 Wins!",ToastLength.Long).Show();
                        player1++;
                        player1Score.Text = "Player 1 Wins: " + player1.ToString();

                    }
                    else
                    {
                        Toast.MakeText(this, "Player 2 Wins!",ToastLength.Long).Show();
                        player2++;
                        player2Score.Text = "Player 2 Wins: " + player2.ToString();

                    }
                    ClearGame();
                }
            }
            if (b1.Text != string.Empty && b5.Text != string.Empty && b9.Text != string.Empty)
            {
                if (b1.Text == b5.Text && b1.Text == b9.Text)
                {
                    if (b1.Text == "X")
                    {
                        Toast.MakeText(this, "Player 1 Wins!",ToastLength.Long).Show();
                        player1++;
                        player1Score.Text = "Player 1 Wins: " + player1.ToString();

                    }
                    else
                    {
                        Toast.MakeText(this, "Player 2 Wins!",ToastLength.Long).Show();
                        player2++;
                        player2Score.Text = "Player 2 Wins: " + player2.ToString();

                    }
                    ClearGame();
                }
            }
            if (b3.Text != string.Empty && b5.Text != string.Empty && b7.Text != string.Empty)
            {
                if (b3.Text == b5.Text && b3.Text == b7.Text)
                {
                    if (b3.Text == "X")
                    {
                        Toast.MakeText(this, "Player 1 Wins!",ToastLength.Long).Show();
                        player1++;
                        player1Score.Text = "Player 1 Wins: " + player1.ToString();
                    }
                    else
                    {
                        Toast.MakeText(this, "Player 2 Wins!",ToastLength.Long).Show();
                        player2++;
                        player2Score.Text = "Player 2 Wins: " + player2.ToString();
                    }
                    ClearGame();
                }
            }
        }

        private void ClearGame()
        {
            turn.Text = string.Empty;
            currentTurn = 1;
            click = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            b1.Text = string.Empty;
            b2.Text = string.Empty;
            b3.Text = string.Empty;
            b4.Text = string.Empty;
            b5.Text = string.Empty;
            b6.Text = string.Empty;
            b7.Text = string.Empty;
            b8.Text = string.Empty;
            b9.Text = string.Empty;
        }

        void Play(int index, Button pressedButton)
        {
            if (click[index] == 0)
            {
                if (currentTurn % 2 != 0)
                {
                    pressedButton.Text = "X";
                    click[index]++;
                }
                else
                {
                    pressedButton.Text = "O";
                    click[index]++;
                }
                currentTurn++;
            }
            else
            {
                pressedButton.Text = pressedButton.Text;
            }

            if (currentTurn % 2 != 0)
            {
                turn.Text = "Player 1";
            }
            else
            {
                turn.Text = "Player 2";
            }

            CheckforWin();
        }
    }
}

