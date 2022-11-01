

namespace SlotMachineStartingPoint
{
    
    public partial class Form1 : Form
    {
        decimal MoneyWon;
        decimal MoneyLost;
        decimal MoneyNet;
        decimal Bet;
        decimal Winnings;

        Bitmap bar = new Bitmap("../../../resources/bar.png");
        Bitmap bell = new Bitmap("../../../resources/bell.png");
        Bitmap cherry = new Bitmap("../../../resources/cherry.png");
        Bitmap grape = new Bitmap("../../../resources/grape.png");
        Bitmap lemon = new Bitmap("../../../resources/lemon.png");
        Bitmap melon = new Bitmap("../../../resources/melon.png");
        Bitmap orange = new Bitmap("../../../resources/orange.png");
        Bitmap plum = new Bitmap("../../../resources/plum.png");
        Bitmap seven = new Bitmap("../../../resources/seven.png");
        Bitmap spinning = new Bitmap("../../../resources/spinning.gif");
        Bitmap mousedown = new Bitmap("../../../resources/handle_compressed.png");
        Bitmap mouseup = new Bitmap("../../../resources/handle.png");


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblLoss_Click(object sender, EventArgs e)
        {

        }

        private void btn0100_Click(object sender, EventArgs e)
        {
            Bet = 1.00m;
            btn0100.BackColor = Color.Aqua;
            btn0025.BackColor = Color.Gray;
            btn0010.BackColor = Color.Gray;
            btn0005.BackColor = Color.Gray;
        }

        private void btn0005_Click(object sender, EventArgs e)
        {
            Bet = 0.05m;
            btn0100.BackColor = Color.Gray;
            btn0025.BackColor = Color.Gray;
            btn0010.BackColor = Color.Gray;
            btn0005.BackColor = Color.Aqua;
        }

        private void btn0010_Click(object sender, EventArgs e)
        {
            Bet = 0.10m;
            btn0100.BackColor = Color.Gray;
            btn0025.BackColor = Color.Gray;
            btn0010.BackColor = Color.Aqua;
            btn0005.BackColor = Color.Gray;
        }

        private void btn0025_Click(object sender, EventArgs e)
        {
            Bet = 0.25m;
            btn0100.BackColor = Color.Gray;
            btn0025.BackColor = Color.Aqua;
            btn0010.BackColor = Color.Gray;
            btn0005.BackColor = Color.Gray;
        }

        private void btnSpin_MouseDown(object sender, MouseEventArgs e)
        {
            btnSpin.BackgroundImage = mousedown;        //Changes btnSpins background image to the compressed handle.
            Random rnd1 = new Random();                 //Random instances for each spinner
            Random rnd2 = new Random();
            Random rnd3 = new Random();
            int count;
            int intSpin1, intSpin2, intSpin3;           //Spin variables


            intSpin1 = rnd1.Next(1, 7);                 //Assigning random numbers to spinner variable
            intSpin2 = rnd2.Next(1, 7);
            intSpin3 = rnd3.Next(1, 7);

            /*lblintSpin1.Text = intSpin1.ToString();             //Assigns numbers to the spinners text value.
            lblintSpin2.Text = intSpin2.ToString();
            lblintSpin3.Text = intSpin3.ToString();*/
            Thread.Sleep(300);
            picSlot1.Image = spinning;                      //assigns spinning gif before calculating image.

            for (count = 0; count < 175; count++)            //Loops to refresh the gifs to give the illusion of spinning slots.
            {
                Refresh();
                Thread.Sleep(5);
                if (count == 50)
                {
                    picSlot2.Image = spinning;
                }
                if (count == 100)
                {
                    picSlot3.Image = spinning;
                }
            }







            switch (intSpin1)                                   //assigns pictures to each image
            {
                case 1:
                    picSlot1.Image = bar;
                    break;
                case 2:
                    picSlot1.Image = bell;
                    break;
                case 3:
                    picSlot1.Image = cherry;
                    break;
                case 4:
                    picSlot1.Image = grape;
                    break;
                case 5:
                    picSlot1.Image = lemon;
                    break;
                case 6:
                    picSlot1.Image = seven;
                    break;
            }
            switch (intSpin2)
            {
                case 1:
                    picSlot2.Image = bar;
                    break;
                case 2:
                    picSlot2.Image = bell;
                    break;
                case 3:
                    picSlot2.Image = cherry;
                    break;
                case 4:
                    picSlot2.Image = grape;
                    break;
                case 5:
                    picSlot2.Image = lemon;
                    break;
                case 6:
                    picSlot2.Image = seven;
                    break;
            }
            switch (intSpin3)
            {
                case 1:
                    picSlot3.Image = bar;
                    break;
                case 2:
                    picSlot3.Image = bell;
                    break;
                case 3:
                    picSlot3.Image = cherry;
                    break;
                case 4:
                    picSlot3.Image = grape;
                    break;
                case 5:
                    picSlot3.Image = lemon;
                    break;
                case 6:
                    picSlot3.Image = seven;
                    break;
            }

            if (intSpin1 == intSpin2 && intSpin1 == intSpin3)            //Statement to check that all spinners are equal
            {
                switch (intSpin1)
                {
                    case 1:
                        MoneyWon = 2.00m * Bet;                 //Payout multiplier if you somehow win.
                        break;
                    case 2:
                        MoneyWon = 3.25m * Bet;
                        break;
                    case 3:
                        MoneyWon = 4.5m * Bet;
                        break;
                    case 4:
                        MoneyWon = 5.75m * Bet;
                        break;
                    case 5:
                        MoneyWon = 8.25m * Bet;
                        break;
                    case 6:
                        MoneyWon = 16.00m * Bet;
                        break;
                }
                Winnings = MoneyWon + Winnings;                 //Works out winnings
                lblWin.Text = Winnings.ToString("C");           //Assigns winnings variable to the win text label

            }
            else
            {
                MoneyLost = MoneyLost + Bet;                    //Works out money lost
            }
            lblLoss.Text = MoneyLost.ToString("C");                 //Assigns variables to text values
            MoneyNet = MoneyWon - MoneyLost;
            lblNet.Text = MoneyNet.ToString("C");
        }

        private void btnSpin_MouseUp(object sender, MouseEventArgs e)
        {
            btnSpin.BackgroundImage = mouseup;              //Changes btnSpins background image back to the handle once the mouse button is let go/ mouse down is finshed.
        }
    }
}