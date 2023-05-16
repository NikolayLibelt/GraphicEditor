namespace GraphicEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фигураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямоугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дугаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphicPanel = new System.Windows.Forms.PictureBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.angleLabel = new System.Windows.Forms.Label();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.clearButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фигураToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // фигураToolStripMenuItem
            // 
            this.фигураToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прямаяToolStripMenuItem,
            this.прямоугольникToolStripMenuItem,
            this.дугаToolStripMenuItem});
            this.фигураToolStripMenuItem.Name = "фигураToolStripMenuItem";
            this.фигураToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.фигураToolStripMenuItem.Text = "Фигура";
            // 
            // прямаяToolStripMenuItem
            // 
            this.прямаяToolStripMenuItem.Name = "прямаяToolStripMenuItem";
            this.прямаяToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.прямаяToolStripMenuItem.Text = "Прямая";
            this.прямаяToolStripMenuItem.Click += new System.EventHandler(this.прямаяToolStripMenuItem_Click);
            // 
            // прямоугольникToolStripMenuItem
            // 
            this.прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            this.прямоугольникToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.прямоугольникToolStripMenuItem.Text = "Прямоугольник";
            this.прямоугольникToolStripMenuItem.Click += new System.EventHandler(this.прямоугольникToolStripMenuItem_Click);
            // 
            // дугаToolStripMenuItem
            // 
            this.дугаToolStripMenuItem.Name = "дугаToolStripMenuItem";
            this.дугаToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.дугаToolStripMenuItem.Text = "Дуга";
            this.дугаToolStripMenuItem.Click += new System.EventHandler(this.дугаToolStripMenuItem_Click);
            // 
            // GraphicPanel
            // 
            this.GraphicPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GraphicPanel.Location = new System.Drawing.Point(0, 27);
            this.GraphicPanel.Name = "GraphicPanel";
            this.GraphicPanel.Size = new System.Drawing.Size(1063, 634);
            this.GraphicPanel.TabIndex = 1;
            this.GraphicPanel.TabStop = false;
            this.GraphicPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraphicPanel_MouseDown);
            this.GraphicPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GraphicPanel_MouseUp);
            // 
            // colorButton
            // 
            this.colorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorButton.Location = new System.Drawing.Point(1115, 167);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(194, 76);
            this.colorButton.TabIndex = 2;
            this.colorButton.Text = "Выбрать цвет";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeLabel.Location = new System.Drawing.Point(1070, 121);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(118, 31);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Размер:";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeTextBox.Location = new System.Drawing.Point(1194, 114);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(136, 38);
            this.sizeTextBox.TabIndex = 4;
            this.sizeTextBox.Text = "5";
            this.sizeTextBox.TextChanged += new System.EventHandler(this.sizeTextBox_TextChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(1069, 27);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(155, 31);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Тип: Линия";
            // 
            // angleLabel
            // 
            this.angleLabel.AutoSize = true;
            this.angleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angleLabel.Location = new System.Drawing.Point(1109, 81);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(79, 31);
            this.angleLabel.TabIndex = 6;
            this.angleLabel.Text = "Угол:";
            // 
            // angleTextBox
            // 
            this.angleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angleTextBox.Location = new System.Drawing.Point(1194, 70);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(136, 38);
            this.angleTextBox.TabIndex = 7;
            this.angleTextBox.Text = "0";
            this.angleTextBox.TextChanged += new System.EventHandler(this.angleTextBox_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(1115, 566);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(183, 68);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "plex";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Plex";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 673);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.angleTextBox);
            this.Controls.Add(this.angleLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.GraphicPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фигураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прямаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прямоугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дугаToolStripMenuItem;
        private System.Windows.Forms.PictureBox GraphicPanel;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label angleLabel;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

