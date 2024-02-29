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
            gomb.Size = new Size(100, 50); // Méret beállítása
            gomb.Left = (this.ClientSize.Width - gomb.Width) / 2; // Gomb pozíciójának beállítása középre
            gomb.Top = (this.ClientSize.Height - gomb.Height) / 2;
            this.Controls.Add(gomb);

            // 10 gomb elhelyezése egymás mellé
            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Text = $"Button {i + 1}";
                button.Size = new Size(50, 30);
                button.Left = 50 * i + 20; // 20 pixeles távolság a gombok között
                button.Top = 100;
                this.Controls.Add(button);
            }

            // 10x10 szorzótábla gombjai
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
                    button.Left = startX + (col - 1) * (buttonSize + 5); // 5 pixeles távolság a gombok között
                    button.Top = startY + (row - 1) * (buttonSize + 5);
                    this.Controls.Add(button);
                }
            }
        }
    }

    // VillogóGomb osztály származtatása a Button osztályból
    public class VillogoGomb : Button
    {
        // Konstruktor létrehozása
        public VillogoGomb()
        {
            // Eseménykiszolgálók hozzárendelése
            this.MouseEnter += VillogoGomb_MouseEnter;
            this.MouseLeave += VillogoGomb_MouseLeave;
        }

        // MouseEnter eseménykiszolgáló
        private void VillogoGomb_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red; // Háttérszín beállítása pirosra
        }

        // MouseLeave eseménykiszolgáló
        private void VillogoGomb_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control; // Alapértelmezett háttérszín visszaállítása
        }
    }
}