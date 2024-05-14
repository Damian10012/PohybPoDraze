namespace PohybPoDraze
{
    public partial class Form1 : Form
    {
        public List<Car> Cars = new();
        public Form1()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            CarAdd car = new(this);
            car.ShowDialog();
        }
        public void AddCar(Car car) => Cars.Add(car);
        private void Check()
        {
            foreach (Car car in Cars)
            {
                foreach (Car car2 in Cars)
                {
                    if (car != car2)
                    {
                        if (Math.Abs(car.X - car2.X) < 20 && Math.Abs(car.Y - car2.Y) < 20)
                        {
                            car.Speed = car.Speed > car2.Speed ? car2.Speed : car.Speed;
                            car2.Speed = car.Speed > car2.Speed ? car2.Speed : car.Speed;
                        }
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e) => pictureBox1.Invalidate();

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Draw track
            Pen pen = new(Color.Black, 2);
            //A -> Cross
            g.DrawLine(pen, 100, 150, 200, 150);
            //Cross -> Arc
            g.DrawArc(pen, 200, 100, 100, 100, 180, 180);
            //Arc -> B
            g.DrawLine(pen, 300, 150, 400, 150);
            //Cross -> C
            g.DrawLine(pen, 200, 150, 275, 250);
            //Draw all cars
            foreach (Car car in Cars)
            {
                g.FillEllipse(new SolidBrush(car.Color), car.X, car.Y, 15, 15);
                Check();
            }
        }

        private void Form1_Load(object sender, EventArgs e) => timer1.Start();
    }
}