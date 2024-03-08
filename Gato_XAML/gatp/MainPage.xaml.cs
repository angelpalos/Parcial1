namespace gatp
{
    public partial class MainPage : ContentPage
    {
        int turno = 0;
        int PtoX=0;
        int PtoO=0;
        public MainPage()
        {
            InitializeComponent();
        }

        async void BtnClick(object sender, EventArgs e)
        {
             
            Button? btn = sender as Button;


            if (turno == 1)
            {
                btn.Text = "O";
                btn.IsEnabled = false;
                turno=0;

            }
            else if (turno == 0)
            {
                btn.Text = "X";
                btn.IsEnabled = false;
                turno = 1;
            }

            if (Block1.Text == "X" && Block2.Text == "X" && Block3.Text == "X" ||
                Block4.Text == "X" && Block5.Text == "X" && Block6.Text == "X" ||
                Block7.Text == "X" && Block8.Text == "X" && Block9.Text == "X" ||
                Block1.Text == "X" && Block4.Text == "X" && Block7.Text == "X" ||
                Block2.Text == "X" && Block5.Text == "X" && Block8.Text == "X" ||
                Block3.Text == "X" && Block6.Text == "X" && Block9.Text == "X" ||
                Block1.Text == "X" && Block5.Text == "X" && Block9.Text == "X" ||
                Block3.Text == "X" && Block5.Text == "X" && Block7.Text == "X" )
            {
                PtoX++;
                PtX.Text = "X - " + Convert.ToString(PtoX);
                await DisplayAlert("Ganador","Gano el Jugador X","Ok");

            } else if (Block1.Text == "O" && Block2.Text == "O" && Block3.Text == "O" ||
                Block4.Text == "O" && Block5.Text == "O" && Block6.Text == "O" ||
                Block7.Text == "O" && Block8.Text == "O" && Block9.Text == "O" ||
                Block1.Text == "O" && Block4.Text == "O" && Block7.Text == "O" ||
                Block2.Text == "O" && Block5.Text == "O" && Block8.Text == "O" ||
                Block3.Text == "O" && Block6.Text == "O" && Block9.Text == "O" ||
                Block1.Text == "O" && Block5.Text == "O" && Block9.Text == "O" ||
                Block3.Text == "O" && Block5.Text == "O" && Block7.Text == "O")
            {
                PtoO++;
                PtO.Text = "O - " + Convert.ToString(PtoO);
                await DisplayAlert("Ganador", "Gano el Jugador O", "Ok");
            }

        }

        private void Restart (object sender, EventArgs e) {
            Block1.Text = "";
            Block2.Text = "";
            Block3.Text = "";
            Block4.Text = "";
            Block5.Text = "";
            Block6.Text = "";
            Block7.Text = "";
            Block8.Text = "";
            Block9.Text = "";

            Block1.IsEnabled = true;
            Block2.IsEnabled = true;
            Block3.IsEnabled = true;
            Block4.IsEnabled = true;
            Block5.IsEnabled = true;
            Block6.IsEnabled = true;
            Block7.IsEnabled = true;
            Block8.IsEnabled = true;
            Block9.IsEnabled = true;
        }
    }

}
