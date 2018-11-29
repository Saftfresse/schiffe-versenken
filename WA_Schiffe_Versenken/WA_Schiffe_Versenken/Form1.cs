using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA_Schiffe_Versenken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct shipType
        {
            string name;
            int length;
            int amount;
            int id;

            public string Name { get => name; set => name = value; }
            public int Length { get => length; set => length = value; }
            public int Amount { get => amount; set => amount = value; }
            public int Id { get => id; set => id = value; }
        }

        /// Grid Variablen
        shipType[] ships = new shipType[4];
        List<Ship> enemyShips = new List<Ship>();
        List<Ship> userShips = new List<Ship>();
        shipType pickedShip = new shipType();

        /// Grafik Variablen
        Bitmap userSide;
        Point MLoc = new Point();

        enum CellType
        {
            Wasser,
            Schlachtschiff,
            Kreuzer,
            Zerstörer,
            UBoot
        }

        int züge = 0;
        int[,] enemyHits = new int[10,10];
        int[,] userHits = new int[10, 10];
        CellType[,] userCells = new CellType[10,10];
        CellType[,] enemyCells = new CellType[10,10];

        List<Point> locationValid(Point p, int length, int dir)
        {
            bool ret = true;
            List<Point> points = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(dir + " - " + length + " + " + p);
                switch (dir)
                {
                    case 1:
                        try
                        {
                            if (enemyCells[p.X, p.Y + i] == CellType.Wasser)
                            {
                                Point pt = new Point(p.X, p.Y + i);
                                points.Add(pt);
                            }
                            else
                            {
                                points.Clear(); break;
                            }
                        }  catch (Exception)  { points.Clear(); break;  }
                        break;
                    case 2:
                        try
                        {
                            if (enemyCells[p.X - i, p.Y] == CellType.Wasser)
                            {
                                Point pt = new Point(p.X - i, p.Y);
                                points.Add(pt);
                            }
                            else
                            {
                                points.Clear(); break;
                            }
                        }  catch (Exception) { points.Clear(); break; }
                break;
                    case 3:
                        try
                        {
                            if (enemyCells[p.X, p.Y - i] == CellType.Wasser)
                            {
                                Point pt = new Point(p.X, p.Y - i);
                                points.Add(pt);
                            }
                            else
                            {
                                points.Clear(); break;
                            }
                        }  catch (Exception) { points.Clear(); break; }
                break;
                    case 4:
                        try
                        {
                            if (enemyCells[p.X + i, p.Y] == CellType.Wasser)
                            {
                                Point pt = new Point(p.X + i, p.Y);
                                points.Add(pt);
                            }
                            else
                            {
                                points.Clear(); break;
                            }
                        }  catch (Exception) { points.Clear(); break; }
                        break;
                }
            }
            if (points.Count < length)
            {
                points.Clear();
            }
            return points;
        }
        
        void redrawBitmap()
        {
            using (var g = Graphics.FromImage(userSide))
            {
                int currX = 0, currY = 0;
                int length = canvas_player.Size.Width / userCells.GetLength(0);
                for (int i = 0; i < userCells.GetLength(0); i++)
                {
                    for (int j = 0; j < userCells.GetLength(1); j++)
                    {
                        Color water = Color.MediumTurquoise;
                        Color c = Color.MediumTurquoise;
                        Color hitColor = Color.White;
                        if (userHits[i, j] == 2) hitColor = Color.Red;
                        if (userCells[i, j] == CellType.Schlachtschiff) c = Color.FromArgb(40, 40, 40);
                        if (userCells[i, j] == CellType.Kreuzer) c = Color.IndianRed;
                        if (userCells[i, j] == CellType.Zerstörer) c = Color.PaleGreen;
                        if (userCells[i, j] == CellType.UBoot) c = Color.DarkOrange;
                        if (!getShipAtPoint(new Point(i, j)).Destroyed)
                        {
                            g.FillRectangle(new SolidBrush(water), currX, currY, length, length);
                            g.DrawRectangle(new Pen(Color.Gray), currX, currY, length, length);
                        }
                        else
                        {
                            g.DrawRectangle(new Pen(Color.Gray), currX, currY, length, length);
                            g.FillRectangle(new SolidBrush(c), currX + 1, currY + 1, length + 2, length + 2);
                        }

                        if (userHits[i, j] > 0) g.DrawEllipse(new Pen(hitColor, 2), currX + 5, currY + 5, length - 10, length - 10);

                        currX += length;

                    }
                    currX = 0;
                    currY += length;
                }
                g.DrawEllipse(new Pen(Color.Red, 5), new Rectangle(new Point(MLoc.X - 5, MLoc.Y- 5), new Size(10,10)));
            }
        }

        Ship getShipAtPoint(Point p)
        {
            Ship s = new Ship();
            foreach (var item in enemyShips)
            {
                if (item.Points.Contains(p))
                {
                    s = item;
                }
            }
            return s;
        }

        void generateEnemy()
        {
            Random r = new Random();
            foreach (var item in ships)
            {
                for (int i = 0; i < item.Amount; i++)
                {
                    Point newP = new Point(r.Next(0, 11), r.Next(0, 11));
                    List<Point> points = new List<Point>();
                    while (points.Count <= 0)
                    {
                        points = locationValid(newP, item.Length, r.Next(1, 5));
                        if (points.Count <= 0) newP = new Point(r.Next(0, 11), r.Next(0, 11));
                    }
                    Ship newShip = new Ship() { Name = item.Name, ShipId = item.Id, Length = item.Length };
                    for (int j = 0; j < points.Count; j++)
                    {
                        enemyCells[points[j].X, points[j].Y] = (CellType)item.Id;
                        newShip.Points[j] = new Point(points[j].X, points[j].Y);
                    }
                    enemyShips.Add(newShip);
                }
            }
            canvas_enemy.Invalidate();
        }

        Point locationToCell(Point mouseLoc)
        {
            Point ret = new Point();
            int length = canvas_enemy.Size.Width / enemyCells.GetLength(1);
            int currX = 0, currY = 0;
            for (int i = 0; i < enemyCells.GetLength(0); i++)
            {
                for (int j = 0; j < enemyCells.GetLength(1); j++)
                {
                    if ((new Rectangle(currX, currY, length, length)).Contains(mouseLoc))
                    {
                        ret = new Point(i, j);
                    }
                    currX += length;
                }
                currX = 0;
                currY += length;
            }
            return ret;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ships[0] = new shipType() { Name = "Schlachtschiff", Amount = 1, Length = 5, Id = 1,  };
            ships[1] = new shipType() { Name = "Kreuzer", Amount = 2, Length = 4, Id = 2,  };
            ships[2] = new shipType() { Name = "Zerstörer", Amount = 3, Length = 3, Id = 3,  };
            ships[3] = new shipType() { Name = "UBoot", Amount = 4, Length = 2, Id = 4,  };

            userSide = new Bitmap(canvas_player.Size.Width, canvas_player.Size.Height);
            generateEnemy();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            int currX = 0, currY = 0;
            int length = canvas_enemy.Size.Width / enemyCells.GetLength(0);
            for (int i = 0; i < enemyCells.GetLength(0); i++)
            {
                for (int j  = 0; j < enemyCells.GetLength(1); j++)
                {
                    Color water = Color.MediumTurquoise;
                    Color c = Color.MediumTurquoise;
                    Color hitColor = Color.White;
                    if (enemyHits[i, j] == 2) hitColor = Color.Red;
                    if (enemyCells[i, j] == CellType.Schlachtschiff) c = Color.FromArgb(40,40,40);
                    if (enemyCells[i, j] == CellType.Kreuzer) c = Color.IndianRed;
                    if (enemyCells[i, j] == CellType.Zerstörer) c = Color.PaleGreen;
                    if (enemyCells[i, j] == CellType.UBoot) c = Color.DarkOrange;
                    if (!getShipAtPoint(new Point(i, j)).Destroyed)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(water), currX, currY, length, length);
                        e.Graphics.DrawRectangle(new Pen(Color.Gray), currX, currY, length, length);
                    }
                    else
                    {
                        e.Graphics.DrawRectangle(new Pen(Color.Gray), currX, currY, length, length);
                        e.Graphics.FillRectangle(new SolidBrush(c), currX + 1, currY + 1, length + 2, length + 2);
                    }
                    
                    if (enemyHits[i, j] > 0) e.Graphics.DrawEllipse(new Pen(hitColor, 2), currX + 5, currY + 5, length - 10, length - 10);

                    currX += length;

                }
                currX = 0;
                currY += length;
            }
            int[] ships = new int[4];
            int count = 0;
            foreach (var item in enemyShips)
            {
                if (!item.Destroyed)
                {
                    ships[item.ShipId - 1]++;
                    count++;
                }
            }
            label_enemy.Text = string.Format("Schlachtschiffe:{0}\nKreuzer:{1}\nZerstörer:{2}\nU-Boote:{3}", ships[0], ships[1], ships[2], ships[3]);
            if (count <= 0)
            {
                label_enemy.Text = "Gewonnen!";
            }
        }

        private void canvas_player_Paint(object sender, PaintEventArgs e)
        {
            redrawBitmap();
            e.Graphics.DrawImage(userSide, 0, 0);
        }

        private void canvas_enemy_MouseClick(object sender, MouseEventArgs e)
        {
            Point cellLoc = locationToCell(e.Location);
            if (enemyHits[cellLoc.X, cellLoc.Y] == 0)
            {
                Ship s = getShipAtPoint(new Point(cellLoc.X, cellLoc.Y));
                if (enemyCells[cellLoc.X, cellLoc.Y] == CellType.Wasser)
                {
                    enemyHits[cellLoc.X, cellLoc.Y] = 1;
                }
                else
                {
                    enemyHits[cellLoc.X, cellLoc.Y] = 2;
                    if (s.Hits + 1 >= s.Length)
                    {
                        s.Destroyed = true;
                    }
                    else
                    {
                        s.Hits++;
                    }
                }
                Console.WriteLine(s.Name + "  -  " + s.Uid.ToString("N") + "  -  " + s.Hits);
                züge++;
                label3.Text = "Züge\n" + züge;
                canvas_enemy.Invalidate();
            }
        }

        private void pb_enemy_top_Paint(object sender, PaintEventArgs e)
        {
            int currX = 9;
            int length = canvas_enemy.Size.Width / enemyCells.GetLength(0);

            for (int i = 0; i < enemyCells.GetLength(0); i++)
            {
                e.Graphics.DrawString((i + 1).ToString(), new Font("Arial Black", 14), new SolidBrush(Color.Black), new Point(i == 9 ? currX - 7 : currX, 2));
                currX += length;
            }
        }

        private void pb_enemy_left_Paint(object sender, PaintEventArgs e)
        {
            int currY = 6;
            int length = canvas_enemy.Size.Width / enemyCells.GetLength(0);

            for (int i = 0; i < enemyCells.GetLength(0); i++)
            {
                e.Graphics.DrawString(((char)(65 + i)).ToString(), new Font("Arial Black", 14), new SolidBrush(Color.Black), new Point(3, currY));
                currY += length;
            }
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            int currX = 9;
            int length = canvas_enemy.Size.Width / enemyCells.GetLength(0);

            for (int i = 0; i < enemyCells.GetLength(0); i++)
            {
                e.Graphics.DrawString((i + 1).ToString(), new Font("Arial Black", 14), new SolidBrush(Color.Black), new Point(i == 9 ? currX - 7 : currX, 2));
                currX += length;
            }
        }

        private void pictureBox2_Paint_1(object sender, PaintEventArgs e)
        {
            int currY = 6;
            int length = canvas_enemy.Size.Width / enemyCells.GetLength(0);

            for (int i = 0; i < enemyCells.GetLength(0); i++)
            {
                e.Graphics.DrawString(((char)(65 + i)).ToString(), new Font("Arial Black", 14), new SolidBrush(Color.Black), new Point(3, currY));
                currY += length;
            }
        }

        private void canvas_player_MouseClick(object sender, MouseEventArgs e)
        {
            MLoc = e.Location;
        }

        private void btn_newRound_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_pick_1_Click(object sender, EventArgs e)
        {
            pickedShip = ships[0];
        }

        private void btn_pick_2_Click(object sender, EventArgs e)
        {
            pickedShip = ships[1];
        }

        private void btn_pick_3_Click(object sender, EventArgs e)
        {
            pickedShip = ships[2];
        }

        private void btn_pick_4_Click(object sender, EventArgs e)
        {
            pickedShip = ships[3];
        }

        private void canvas_player_MouseMove(object sender, MouseEventArgs e)
        {
            MLoc = e.Location;
            canvas_player.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (canvas_player.Bounds.Contains(PointToClient(MousePosition)))
            {
                Console.WriteLine(e.KeyCode);
            }
        }
    }
}
