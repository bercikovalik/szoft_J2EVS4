namespace Gyak3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Button gomb = new Button();
            gomb.Text = "Gomb";
            gomb.Size = new Size(100, 50); // M�ret be�ll�t�sa
            gomb.Left = (this.ClientSize.Width - gomb.Width) / 2; // Gomb poz�ci�j�nak be�ll�t�sa k�z�pre
            gomb.Top = (this.ClientSize.Height - gomb.Height) / 2;
            this.Controls.Add(gomb);

            // 10 gomb elhelyez�se egym�s mell�
            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Text = $"Button {i + 1}";
                button.Size = new Size(50, 30);
                button.Left = 50 * i + 20; // 20 pixeles t�vols�g a gombok k�z�tt
                button.Top = 100;
                this.Controls.Add(button);
            }

            // 10x10 szorz�t�bla gombjai
            const int buttonSize = 30;
            const int startX = 20;
            const int startY = 150;
            for (int row = 1; row <= 10; row++)
            {
                for (int col = 1; col <= 10; col++)
                {
                    Button button = new Button();
                    button.Text = (row * col).ToString();
                    button.Size = new Size(buttonSize, buttonSize);
                    button.Left = startX + (col - 1) * (buttonSize + 5); // 5 pixeles t�vols�g a gombok k�z�tt
                    button.Top = startY + (row - 1) * (buttonSize + 5);
                    this.Controls.Add(button);
                }
            }
        }
    }

    // Villog�Gomb oszt�ly sz�rmaztat�sa a Button oszt�lyb�l
    public class VillogoGomb : Button
    {
        // Konstruktor l�trehoz�sa
        public VillogoGomb()
        {
            // Esem�nykiszolg�l�k hozz�rendel�se
            this.MouseEnter += VillogoGomb_MouseEnter;
            this.MouseLeave += VillogoGomb_MouseLeave;
        }

        // MouseEnter esem�nykiszolg�l�
        private void VillogoGomb_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red; // H�tt�rsz�n be�ll�t�sa pirosra
        }

        // MouseLeave esem�nykiszolg�l�
        private void VillogoGomb_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control; // Alap�rtelmezett h�tt�rsz�n vissza�ll�t�sa
        }
    }
}