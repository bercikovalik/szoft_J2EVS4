namespace Fibonacci
{
    public partial class Form1 : Form
    {
        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Button b = new Button();
                b.Top = i * 30;
                b.Text = Fibonacci(i).ToString();
                Controls.Add(b);
            }
        }

        private void GenerateFibonacciSequence(int n)
        {
            List<Elem> elemek = new List<Elem>(); 

            long a = 0;
            long b = 1;
            for (int i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;

                
                elemek.Add(new Elem { Sorszam = i + 1, Ertek = temp });
            }

            
            dataGridView1.DataSource = elemek;
        }
    }

    
    public class Elem
    {
        public int Sorszam { get; set; } 
        public long Ertek { get; set; } 
    }

    
}



