namespace RunnerLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0,1920);
            int y = random.Next(0,1080);

            label1.Location = new Point(x,y);

            this.Controls.Add(label1);
        }
    }
}