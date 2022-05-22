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
            this.listMoves.Size = new System.Drawing.Size(196, 407);
            this.listMoves.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 567);
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
    }
}

