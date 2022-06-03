namespace TowerOfHanoiCh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCounter = new System.Windows.Forms.Label();
            this.bPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DiskCount = new System.Windows.Forms.NumericUpDown();
            this.lblMoves = new System.Windows.Forms.Label();
            this.listMoves = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DiskCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 411);
            this.panel1.TabIndex = 8;
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(375, 23);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(171, 13);
            this.lblCounter.TabIndex = 12;
            this.lblCounter.Text = "Минимальное количество ходов";
            // 
            // bPlay
            // 
            this.bPlay.Location = new System.Drawing.Point(240, 12);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(113, 41);
            this.bPlay.TabIndex = 11;
            this.bPlay.Text = "Играть";
            this.bPlay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Количество дисков";
            // 
            // DiskCount
            // 
            this.DiskCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiskCount.Location = new System.Drawing.Point(161, 19);
            this.DiskCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.DiskCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.DiskCount.Name = "DiskCount";
            this.DiskCount.Size = new System.Drawing.Size(48, 22);
            this.DiskCount.TabIndex = 9;
            this.DiskCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.DiskCount.ValueChanged += new System.EventHandler(this.DiskCount_ValueChanged);
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Location = new System.Drawing.Point(902, 40);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(34, 13);
            this.lblMoves.TabIndex = 14;
            this.lblMoves.Text = "Ходы";
            // 
            // listMoves
            // 
            this.listMoves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMoves.FormattingEnabled = true;
            this.listMoves.Location = new System.Drawing.Point(905, 63);
            this.listMoves.Name = "listMoves";
            this.listMoves.Size = new System.Drawing.Size(196, 433);
            this.listMoves.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 15;
            this.button1.Text = "A -->> B";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 43);
            this.button2.TabIndex = 16;
            this.button2.Text = "A -->> C";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(364, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 43);
            this.button3.TabIndex = 18;
            this.button3.Text = "B -->> C";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(364, 487);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 43);
            this.button4.TabIndex = 17;
            this.button4.Text = "B -->> A";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(629, 547);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 43);
            this.button5.TabIndex = 20;
            this.button5.Text = "C -->> B";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(629, 487);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 43);
            this.button6.TabIndex = 19;
            this.button6.Text = "C -->> A";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 602);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.listMoves);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiskCount);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DiskCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DiskCount;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.ListBox listMoves;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

