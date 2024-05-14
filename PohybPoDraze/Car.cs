using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PohybPoDraze
{
    public class Car
    {
        public Point Position { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public Color Color { get; set; }
        public int Speed { get; set; }
        public int MaxSpeed { get; set; }
        public string Destination { get; set; }
        private bool _arc;
        private readonly int _r;
        private int _degree;
        private Random _random = new();

        public Car(Point position, int maxSpeed, string destination)
        {
            Position = position;
            _r = 50;
            _degree = 180;
            new Thread(Move).Start();
            Color = Color.FromArgb(255, _random.Next(0,255), _random.Next(0, 255), _random.Next(0, 255));
            Speed = maxSpeed > 20 ? 20 : maxSpeed;
            MaxSpeed = maxSpeed > 20 ? 20 : maxSpeed;
            X = 100; Y = 144;
            Destination = destination;
        }
        private void Move()
        {
            while (true)
            {
                while (_arc)
                {
                    _degree -= 2;
                    var cos = Math.Cos(_degree * Math.PI / 180);
                    var sin = Math.Sin(_degree * Math.PI / 180);
                    X = (float)(250 + _r * cos) - 10;
                    Y = (float)(144 - _r * sin);
                    Thread.Sleep(Math.Abs(50 - Speed * 2));
                    if (_degree<=0) _arc = false;
                }
                while (!_arc)
                {
                    X++;
                    if (Destination == "C" && X >= 200) Y += 1.5f;
                    Thread.Sleep(Math.Abs(50-Speed*2));
                    if (X == 190 && Y == 144 && Destination == "B") _arc = true;
                    if (X >= 400) return;
                    if(X>=265 && Destination == "C") return;
                }
            }

        }
    }
}
