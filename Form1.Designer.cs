namespace DoubleOrNothing
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
            this.moneyLbl = new System.Windows.Forms.Label();
            this.jackpotLbl = new System.Windows.Forms.Label();
            this.multiplierLbl = new System.Windows.Forms.Label();
            this.doubleBtn = new System.Windows.Forms.Button();
            this.takeOutBtn = new System.Windows.Forms.Button();
            this.amountLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chanceBox = new System.Windows.Forms.GroupBox();
            this.chanceBar = new System.Windows.Forms.TrackBar();
            this.jackpotAnim = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.chanceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chanceBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jackpotAnim)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // moneyLbl
            // 
            this.moneyLbl.AutoSize = true;
            this.moneyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLbl.Location = new System.Drawing.Point(46, 29);
            this.moneyLbl.Name = "moneyLbl";
            this.moneyLbl.Size = new System.Drawing.Size(98, 20);
            this.moneyLbl.TabIndex = 0;
            this.moneyLbl.Text = "Your money:";
            // 
            // jackpotLbl
            // 
            this.jackpotLbl.AutoSize = true;
            this.jackpotLbl.BackColor = System.Drawing.Color.Transparent;
            this.jackpotLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jackpotLbl.Location = new System.Drawing.Point(29, 17);
            this.jackpotLbl.Name = "jackpotLbl";
            this.jackpotLbl.Size = new System.Drawing.Size(69, 20);
            this.jackpotLbl.TabIndex = 1;
            this.jackpotLbl.Text = "Jackpot:";
            // 
            // multiplierLbl
            // 
            this.multiplierLbl.AutoSize = true;
            this.multiplierLbl.BackColor = System.Drawing.Color.Transparent;
            this.multiplierLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplierLbl.Location = new System.Drawing.Point(86, 72);
            this.multiplierLbl.Name = "multiplierLbl";
            this.multiplierLbl.Size = new System.Drawing.Size(209, 55);
            this.multiplierLbl.TabIndex = 2;
            this.multiplierLbl.Text = "Azazaza";
            // 
            // doubleBtn
            // 
            this.doubleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doubleBtn.Location = new System.Drawing.Point(246, 19);
            this.doubleBtn.Name = "doubleBtn";
            this.doubleBtn.Size = new System.Drawing.Size(134, 43);
            this.doubleBtn.TabIndex = 3;
            this.doubleBtn.Text = "Double";
            this.doubleBtn.UseVisualStyleBackColor = true;
            this.doubleBtn.Click += new System.EventHandler(this.doubleBtn_Click);
            this.doubleBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.doubleBtn_KeyDown);
            // 
            // takeOutBtn
            // 
            this.takeOutBtn.Enabled = false;
            this.takeOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.takeOutBtn.Location = new System.Drawing.Point(38, 19);
            this.takeOutBtn.Name = "takeOutBtn";
            this.takeOutBtn.Size = new System.Drawing.Size(134, 43);
            this.takeOutBtn.TabIndex = 4;
            this.takeOutBtn.Text = "Take out";
            this.takeOutBtn.UseVisualStyleBackColor = true;
            this.takeOutBtn.Click += new System.EventHandler(this.takeOutBtn_Click);
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.BackColor = System.Drawing.Color.Transparent;
            this.amountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLbl.Location = new System.Drawing.Point(125, 156);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(69, 20);
            this.amountLbl.TabIndex = 5;
            this.amountLbl.Text = "Amount:";
            // 
            // resetBtn
            // 
            this.resetBtn.Enabled = false;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetBtn.Location = new System.Drawing.Point(142, 74);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(134, 43);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.jackpotLbl);
            this.panel1.Controls.Add(this.multiplierLbl);
            this.panel1.Controls.Add(this.amountLbl);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 196);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.takeOutBtn);
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.doubleBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "RadioMan © 2020";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "KNAB <3";
            // 
            // chanceBox
            // 
            this.chanceBox.Controls.Add(this.jackpotAnim);
            this.chanceBox.Controls.Add(this.chanceBar);
            this.chanceBox.Location = new System.Drawing.Point(241, 12);
            this.chanceBox.Name = "chanceBox";
            this.chanceBox.Size = new System.Drawing.Size(190, 69);
            this.chanceBox.TabIndex = 11;
            this.chanceBox.TabStop = false;
            this.chanceBox.Text = "Chance: 50%";
            this.chanceBox.Visible = false;
            // 
            // chanceBar
            // 
            this.chanceBar.Location = new System.Drawing.Point(22, 15);
            this.chanceBar.Maximum = 100;
            this.chanceBar.Name = "chanceBar";
            this.chanceBar.Size = new System.Drawing.Size(150, 45);
            this.chanceBar.TabIndex = 0;
            this.chanceBar.Scroll += new System.EventHandler(this.chanceBar_Scroll);
            // 
            // jackpotAnim
            // 
            this.jackpotAnim.Image = global::DoubleOrNothing.Properties.Resources.win1;
            this.jackpotAnim.InitialImage = null;
            this.jackpotAnim.Location = new System.Drawing.Point(0, 0);
            this.jackpotAnim.Name = "jackpotAnim";
            this.jackpotAnim.Size = new System.Drawing.Size(190, 69);
            this.jackpotAnim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jackpotAnim.TabIndex = 6;
            this.jackpotAnim.TabStop = false;
            this.jackpotAnim.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.moneyLbl);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 69);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your money";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chanceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoubleOrNothing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.chanceBox.ResumeLayout(false);
            this.chanceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chanceBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jackpotAnim)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moneyLbl;
        private System.Windows.Forms.Label jackpotLbl;
        private System.Windows.Forms.Label multiplierLbl;
        private System.Windows.Forms.Button doubleBtn;
        private System.Windows.Forms.Button takeOutBtn;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox chanceBox;
        private System.Windows.Forms.TrackBar chanceBar;
        private System.Windows.Forms.PictureBox jackpotAnim;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

