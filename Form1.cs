using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicEditor
{
    public partial class Form1 : Form
    {
        int pointCounter = 0;
        int angle = 0;
        int size = 5;
        Plex plex = new Plex();
        CustomPoint a;
        CustomPoint b;
        Color color = Color.Black;
        ShapeType shapeType = ShapeType.Line;
        public Form1()
        {
            InitializeComponent();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }

        private void прямаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Line;
            typeLabel.Text = "Тип: Линия";
        }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Rectangle;
            typeLabel.Text = "Тип: Прямоугольник";
        }

        private void дугаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Arc;
            typeLabel.Text = "Тип: Дуга";
        }

        private void angleTextBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(angleTextBox.Text, out angle);
        }

        private void sizeTextBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(sizeTextBox.Text, out size);
        }

        private void AddLine(CustomPoint left, CustomPoint right)
        {
            CustomLine customLine = new CustomLine(left,right,size);
            customLine.FillColor = color;
            plex.Add(customLine);
        }

        private void Update(Graphics graphics)
        {
            graphics.Clear(Color.White);
            plex.Draw(graphics);
        }

        private void AddRectangle(CustomPoint left, CustomPoint right)
        {
            CustomRectangle customRectangle = new CustomRectangle(left,right,size,angle);
            customRectangle.FillColor = color;
            plex.Add(customRectangle);
        }

        private void GraphicPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                a = new CustomPoint($"A{pointCounter++}", e.X, e.Y, size);
                a.FillColor = color;
            }
        }

            private void GraphicPanel_MouseUp(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                Graphics graphics = GraphicPanel.CreateGraphics();
                b = new CustomPoint($"A{pointCounter++}", e.X, e.Y, size);
                if (a != null)
                {
                    switch (shapeType)
                    {
                        case ShapeType.Line:
                            AddLine(a, b);
                            Update(graphics);
                            break;
                        case ShapeType.Rectangle:
                            AddRectangle(a, b);
                            Update(graphics);
                            break;
                    }
                }
                }
            }

        private void clearButton_Click(object sender, EventArgs e)
        {
            plex = new Plex();
            pointCounter = 0;
            Graphics graphics = GraphicPanel.CreateGraphics();
            graphics.Clear(Color.White);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                string textPlex = plex.SaveToString();
                File.WriteAllText(filePath, textPlex);
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                plex = new Plex(File.ReadAllText(filePath));
                Graphics graphics = GraphicPanel.CreateGraphics();
                Update(graphics);
                a = null;
            }
        }
    }
}
