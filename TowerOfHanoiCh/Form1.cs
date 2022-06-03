using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoiCh
{
    public partial class Form1 : Form
    {

        private List<string> moves = new List<string>();
        private List<Disks> TowerDisks = new List<Disks>();

        int _DiskCount = 3;
        int diskHeight = 30;
        int baseHeight = 20;
        public Form1()
        {
            InitializeComponent();
            resetPanel();
        }

        private void bPlay_Click(object sender, EventArgs e)
        {


            resetPanel();
            bPlay.Enabled = false;
            moves.Clear();
            listMoves.Items.Clear();                            // Очистить список ходов
            int NumberOfDisks = _DiskCount;                     // Объявить количество дисков
            //solveTower(NumberOfDisks);
            listMoves.DataSource = null;
            listMoves.DataSource = moves;                            // Решить башню
            bPlay.Enabled = true;
        }
        private void populateDisks()
        {
            int ii = 1;
            foreach (Disks disk in TowerDisks)
            {
                PictureBox panelBox = disk.box;
                panelBox.BackColor = colorSelector(disk);
                disk.width = 200 - (20 * ii);
                panelBox.Width = disk.width;
                panelBox.Height = diskHeight;
                panelBox.Tag = disk.DiskNo;
                panelBox.BorderStyle = BorderStyle.FixedSingle;
                Point boxLocation = new Point(getDiskX(disk), (panel1.Height - baseHeight) - (diskHeight * ii++));
                panelBox.Location = boxLocation;
                disk.box = panelBox;
                panel1.Controls.Add(disk.box);

            }
        }

        private int getDiskX(Disks disk)
        {
            int X = 0;
            int Peg = 0;
            switch (disk.peg)
            {
                case 'A': Peg = 1; break;
                case 'B': Peg = 2; break;
                case 'C': Peg = 3; break;
            }
            X = ((panel1.Width / 4) * Peg) - (int)(disk.width / 2);

            return X;
        }
        private Color colorSelector(Disks disk)
        {
            switch (disk.DiskNo)
            {
                case 1: return Color.Red;
                case 2: return Color.OrangeRed;
                case 3: return Color.Yellow;
                case 4: return Color.Green;
                case 5: return Color.Blue;
                case 6: return Color.Purple;
                case 7: return Color.LightBlue;
                default: return Color.Black;
            }
        }
        /// <summary>
        /// Button click event to solve tower
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static int GetMoveCount(int numberOfDisks)
        {
            double numberOfDisks_Double = numberOfDisks;
            return (int)Math.Pow(2, numberOfDisks_Double) - 1;
        }
        private void resetPanel()
        {
            //Создать стержни 
            setupTower();
            panel1.Controls.Clear();
            TowerDisks = Enumerable.Range(1, _DiskCount).Select(i => new Disks() { DiskNo = i, peg = 'A', box = new PictureBox() }).OrderByDescending(i => i.DiskNo).ToList();
            //Поместите диски на панель
            populateDisks();
            //Установка начального текстового значения для наименьших возможных ходов
            lblCounter.Text = string.Format("Минимальное количество ходов {0}", GetMoveCount(_DiskCount));

        }
        private void setBase()
        {
            SolidBrush sb = new SolidBrush(Color.RosyBrown);
            Graphics g = panel1.CreateGraphics();
            int topSpacing = 100;
            int width = 20;
            //Рисует нижнюю полосу
            g.FillRectangle(sb, 0, panel1.Height - baseHeight, panel1.Width, baseHeight);
            //Рисует 1 стержень
            drawPeg(panel1, g, sb, 1, width, topSpacing);
            //Рисует 2 стержень
            drawPeg(panel1, g, sb, 2, width, topSpacing);
            //Рисует 3 стержень
            drawPeg(panel1, g, sb, 3, width, topSpacing);
        }

        private void setupTower()
        {
            panel1.Paint += delegate
            {
                setBase();
            };
        }

        private void drawPeg(Panel canvas, Graphics g, SolidBrush sb, int pegNo, int pegWidth, int topSpacing)
        {
            g.FillRectangle(sb, ((int)(canvas.Width / 4) * pegNo) - (pegWidth / 2), topSpacing, pegWidth, canvas.Height - topSpacing);
        }

        private void DiskCount_ValueChanged(object sender, EventArgs e)
        {
            _DiskCount = (int)DiskCount.Value;
            resetPanel();
        }


    }
}
