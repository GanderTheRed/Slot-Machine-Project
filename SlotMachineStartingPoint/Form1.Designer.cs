namespace SlotMachineStartingPoint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSpin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn0005 = new System.Windows.Forms.Button();
            this.btn0010 = new System.Windows.Forms.Button();
            this.btn0025 = new System.Windows.Forms.Button();
            this.btn0100 = new System.Windows.Forms.Button();
            this.picSlot1 = new System.Windows.Forms.PictureBox();
            this.picSlot2 = new System.Windows.Forms.PictureBox();
            this.picSlot3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlot3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpin
            // 
            this.btnSpin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpin.BackgroundImage")));
            this.btnSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpin.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSpin.Location = new System.Drawing.Point(854, 147);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(107, 349);
            this.btnSpin.TabIndex = 3;
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            this.btnSpin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSpin_MouseDown);
            this.btnSpin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSpin_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Win:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Net:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loss:";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWin.Location = new System.Drawing.Point(42, 65);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(66, 30);
            this.lblWin.TabIndex = 7;
            this.lblWin.Text = "$0.00";
            this.lblWin.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoss.Location = new System.Drawing.Point(38, 65);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(66, 30);
            this.lblLoss.TabIndex = 8;
            this.lblLoss.Text = "$0.00";
            this.lblLoss.Click += new System.EventHandler(this.lblLoss_Click);
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNet.Location = new System.Drawing.Point(41, 67);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(66, 30);
            this.lblNet.TabIndex = 9;
            this.lblNet.Text = "$0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNet);
            this.groupBox1.Location = new System.Drawing.Point(676, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 129);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lblWin);
            this.groupBox4.Location = new System.Drawing.Point(218, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 129);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.lblLoss);
            this.groupBox5.Location = new System.Drawing.Point(447, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(152, 129);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // btn0005
            // 
            this.btn0005.BackColor = System.Drawing.Color.Gray;
            this.btn0005.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0005.Location = new System.Drawing.Point(292, 534);
            this.btn0005.Name = "btn0005";
            this.btn0005.Size = new System.Drawing.Size(111, 68);
            this.btn0005.TabIndex = 12;
            this.btn0005.Text = "$0.05";
            this.btn0005.UseVisualStyleBackColor = false;
            this.btn0005.Click += new System.EventHandler(this.btn0005_Click);
            // 
            // btn0010
            // 
            this.btn0010.BackColor = System.Drawing.Color.Gray;
            this.btn0010.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0010.Location = new System.Drawing.Point(409, 534);
            this.btn0010.Name = "btn0010";
            this.btn0010.Size = new System.Drawing.Size(111, 68);
            this.btn0010.TabIndex = 13;
            this.btn0010.Text = "$0.10";
            this.btn0010.UseVisualStyleBackColor = false;
            this.btn0010.Click += new System.EventHandler(this.btn0010_Click);
            // 
            // btn0025
            // 
            this.btn0025.BackColor = System.Drawing.Color.Gray;
            this.btn0025.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0025.Location = new System.Drawing.Point(526, 534);
            this.btn0025.Name = "btn0025";
            this.btn0025.Size = new System.Drawing.Size(111, 68);
            this.btn0025.TabIndex = 14;
            this.btn0025.Text = "$0.25";
            this.btn0025.UseVisualStyleBackColor = false;
            this.btn0025.Click += new System.EventHandler(this.btn0025_Click);
            // 
            // btn0100
            // 
            this.btn0100.BackColor = System.Drawing.Color.Gray;
            this.btn0100.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0100.Location = new System.Drawing.Point(643, 534);
            this.btn0100.Name = "btn0100";
            this.btn0100.Size = new System.Drawing.Size(111, 68);
            this.btn0100.TabIndex = 15;
            this.btn0100.Text = "$1.00";
            this.btn0100.UseVisualStyleBackColor = false;
            this.btn0100.Click += new System.EventHandler(this.btn0100_Click);
            // 
            // picSlot1
            // 
            this.picSlot1.Location = new System.Drawing.Point(26, 60);
            this.picSlot1.Name = "picSlot1";
            this.picSlot1.Size = new System.Drawing.Size(152, 160);
            this.picSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlot1.TabIndex = 16;
            this.picSlot1.TabStop = false;
            // 
            // picSlot2
            // 
            this.picSlot2.Location = new System.Drawing.Point(23, 60);
            this.picSlot2.Name = "picSlot2";
            this.picSlot2.Size = new System.Drawing.Size(152, 160);
            this.picSlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlot2.TabIndex = 17;
            this.picSlot2.TabStop = false;
            // 
            // picSlot3
            // 
            this.picSlot3.Location = new System.Drawing.Point(24, 60);
            this.picSlot3.Name = "picSlot3";
            this.picSlot3.Size = new System.Drawing.Size(152, 160);
            this.picSlot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlot3.TabIndex = 18;
            this.picSlot3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(190, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 349);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.picSlot1);
            this.panel2.Location = new System.Drawing.Point(13, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 275);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.picSlot2);
            this.panel3.Location = new System.Drawing.Point(233, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 275);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.picSlot3);
            this.panel4.Location = new System.Drawing.Point(453, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 275);
            this.panel4.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btn0100);
            this.Controls.Add(this.btn0025);
            this.Controls.Add(this.btn0010);
            this.Controls.Add(this.btn0005);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlot3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnSpin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblWin;
        private Label lblLoss;
        private Label lblNet;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button btn0005;
        private Button btn0010;
        private Button btn0025;
        private Button btn0100;
        private PictureBox picSlot1;
        private PictureBox picSlot2;
        private PictureBox picSlot3;
        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
    }
}