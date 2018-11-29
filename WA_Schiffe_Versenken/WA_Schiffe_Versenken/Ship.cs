using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA_Schiffe_Versenken
{
    public class Ship
    {
        public Ship()
        {
            uid = Guid.NewGuid();
        }

        public Ship(string _name, int _length, int _shipId)
        {
            uid = Guid.NewGuid();
            ShipId = _shipId;
            name = _name;
            length = _length;
        }

        string name;
        bool destroyed = false;
        int length;
        int hits = 0;
        int shipId;
        Guid uid;
        Point[] points = new Point[0];

        public string Name { get => name; set => name = value; }
        public int Length { get => length; set { length = value; points = new Point[value]; } }
        public int ShipId { get => shipId; set => shipId = value; }
        public Guid Uid { get => uid; set => uid = value; }
        public Point[] Points { get => points; set => points = value; }
        public int Hits { get => hits; set => hits = value; }
        public bool Destroyed { get => destroyed; set => destroyed = value; }
    }
}
