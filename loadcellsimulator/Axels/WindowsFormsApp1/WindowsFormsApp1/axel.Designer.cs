namespace axelname
{
    partial class axel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(axel));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.w1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.w2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.w3 = new System.Windows.Forms.TextBox();
            this.w4 = new System.Windows.Forms.TextBox();
            this.w5 = new System.Windows.Forms.TextBox();
            this.w6 = new System.Windows.Forms.TextBox();
            this.w7 = new System.Windows.Forms.TextBox();
            this.w8 = new System.Windows.Forms.TextBox();
            this.w9 = new System.Windows.Forms.TextBox();
            this.w10 = new System.Windows.Forms.TextBox();
            this.wl1 = new System.Windows.Forms.Label();
            this.wl2 = new System.Windows.Forms.Label();
            this.wl3 = new System.Windows.Forms.Label();
            this.wl4 = new System.Windows.Forms.Label();
            this.wl5 = new System.Windows.Forms.Label();
            this.wl6 = new System.Windows.Forms.Label();
            this.wl7 = new System.Windows.Forms.Label();
            this.wl8 = new System.Windows.Forms.Label();
            this.wl9 = new System.Windows.Forms.Label();
            this.wl10 = new System.Windows.Forms.Label();
            this.tl9 = new System.Windows.Forms.Label();
            this.tl8 = new System.Windows.Forms.Label();
            this.tl7 = new System.Windows.Forms.Label();
            this.tl6 = new System.Windows.Forms.Label();
            this.tl5 = new System.Windows.Forms.Label();
            this.tl4 = new System.Windows.Forms.Label();
            this.tl3 = new System.Windows.Forms.Label();
            this.tl2 = new System.Windows.Forms.Label();
            this.tl1 = new System.Windows.Forms.Label();
            this.t9 = new System.Windows.Forms.TextBox();
            this.t8 = new System.Windows.Forms.TextBox();
            this.t7 = new System.Windows.Forms.TextBox();
            this.t6 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "CONNECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(276, 67);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 19);
            this.button2.TabIndex = 2;
            this.button2.Text = "DISCONNECT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 362);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Status :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(46, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Weight :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 115);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 112);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 24);
            this.button3.TabIndex = 19;
            this.button3.Text = "ENTER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(173, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Note : Please enter a weight between 0 and Span.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Time :";
            // 
            // w1
            // 
            this.w1.Location = new System.Drawing.Point(90, 180);
            this.w1.Margin = new System.Windows.Forms.Padding(2);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(38, 20);
            this.w1.TabIndex = 22;
            this.w1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 349);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 23;
            // 
            // w2
            // 
            this.w2.Location = new System.Drawing.Point(132, 180);
            this.w2.Margin = new System.Windows.Forms.Padding(2);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(38, 20);
            this.w2.TabIndex = 26;
            this.w2.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(161, 115);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Number of Axles:";
            // 
            // w3
            // 
            this.w3.Location = new System.Drawing.Point(174, 180);
            this.w3.Margin = new System.Windows.Forms.Padding(2);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(38, 20);
            this.w3.TabIndex = 28;
            this.w3.Visible = false;
            // 
            // w4
            // 
            this.w4.Location = new System.Drawing.Point(216, 180);
            this.w4.Margin = new System.Windows.Forms.Padding(2);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(38, 20);
            this.w4.TabIndex = 29;
            this.w4.Visible = false;
            // 
            // w5
            // 
            this.w5.Location = new System.Drawing.Point(258, 180);
            this.w5.Margin = new System.Windows.Forms.Padding(2);
            this.w5.Name = "w5";
            this.w5.Size = new System.Drawing.Size(38, 20);
            this.w5.TabIndex = 30;
            this.w5.Visible = false;
            // 
            // w6
            // 
            this.w6.Location = new System.Drawing.Point(300, 180);
            this.w6.Margin = new System.Windows.Forms.Padding(2);
            this.w6.Name = "w6";
            this.w6.Size = new System.Drawing.Size(38, 20);
            this.w6.TabIndex = 31;
            this.w6.Visible = false;
            // 
            // w7
            // 
            this.w7.Location = new System.Drawing.Point(342, 180);
            this.w7.Margin = new System.Windows.Forms.Padding(2);
            this.w7.Name = "w7";
            this.w7.Size = new System.Drawing.Size(38, 20);
            this.w7.TabIndex = 32;
            this.w7.Visible = false;
            // 
            // w8
            // 
            this.w8.Location = new System.Drawing.Point(384, 180);
            this.w8.Margin = new System.Windows.Forms.Padding(2);
            this.w8.Name = "w8";
            this.w8.Size = new System.Drawing.Size(38, 20);
            this.w8.TabIndex = 33;
            this.w8.Visible = false;
            // 
            // w9
            // 
            this.w9.Location = new System.Drawing.Point(426, 180);
            this.w9.Margin = new System.Windows.Forms.Padding(2);
            this.w9.Name = "w9";
            this.w9.Size = new System.Drawing.Size(38, 20);
            this.w9.TabIndex = 34;
            this.w9.Visible = false;
            // 
            // w10
            // 
            this.w10.Location = new System.Drawing.Point(468, 180);
            this.w10.Margin = new System.Windows.Forms.Padding(2);
            this.w10.Name = "w10";
            this.w10.Size = new System.Drawing.Size(38, 20);
            this.w10.TabIndex = 35;
            this.w10.Visible = false;
            // 
            // wl1
            // 
            this.wl1.AutoSize = true;
            this.wl1.Location = new System.Drawing.Point(98, 165);
            this.wl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wl1.Name = "wl1";
            this.wl1.Size = new System.Drawing.Size(24, 13);
            this.wl1.TabIndex = 36;
            this.wl1.Text = "W1";
            this.wl1.Visible = false;
            // 
            // wl2
            // 
            this.wl2.AutoSize = true;
            this.wl2.Location = new System.Drawing.Point(142, 165);
            this.wl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wl2.Name = "wl2";
            this.wl2.Size = new System.Drawing.Size(24, 13);
            this.wl2.TabIndex = 37;
            this.wl2.Text = "W2";
            this.wl2.Visible = false;
            // 
            // wl3
            // 
            this.wl3.AutoSize = true;
            this.wl3.Location = new System.Drawing.Point(182, 165);
            this.wl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wl3.Name = "wl3";
            this.wl3.Size = new System.Drawing.Size(24, 13);
            this.wl3.TabIndex = 38;
            this.wl3.Text = "W3";
            this.wl3.Visible = false;
            // 
            // wl4
            // 
            this.wl4.AutoSize = true;
            this.wl4.Location = new System.Drawing.Point(224, 165);
            this.wl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wl4.Name = "wl4";
            this.wl4.Size = new System.Drawing.Size(24, 13);
            this.wl4.TabIndex = 39;
            this.wl4.Text = "W4";
            this.wl4.Visible = false;
            // 
            // wl5
            // 
            this.wl5.AutoSize = true;
            this.wl5.Location = new System.Drawing.Point(266, 165);
            this.wl5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wl5.Name = "wl5";
            this.wl5.Size = new System.Drawing.Size(24, 13);
            this.wl5.TabIndex = 40;
            this.wl5.Text = "W5";
            this.wl5.Visible = false;
            // 
            // wl6
            // 
            this.wl6.AutoSize = true;
            this.wl6.Location = new System.Drawing.Point(309, 165);
            this.wl6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wl6.Name = "wl6";
            this.wl6.Size = new System.Drawing.Size(24, 13);
            this.wl6.TabIndex = 41;
            this.wl6.Text = "W6";
            this.wl6.Visible = false;
            // 
            // wl7
            // 
            this.wl7.AutoSize = true;
            this.wl7.Location = new System.Drawing.Point(352, 165);
            this.wl7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wl7.Name = "wl7";
            this.wl7.Size = new System.Drawing.Size(24, 13);
            this.wl7.TabIndex = 42;
            this.wl7.Text = "W7";
            this.wl7.Visible = false;
            // 
            // wl8
            // 
            this.wl8.AutoSize = true;
            this.wl8.Location = new System.Drawing.Point(392, 165);
            this.wl8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wl8.Name = "wl8";
            this.wl8.Size = new System.Drawing.Size(24, 13);
            this.wl8.TabIndex = 43;
            this.wl8.Text = "W8";
            this.wl8.Visible = false;
            // 
            // wl9
            // 
            this.wl9.AutoSize = true;
            this.wl9.Location = new System.Drawing.Point(436, 165);
            this.wl9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wl9.Name = "wl9";
            this.wl9.Size = new System.Drawing.Size(24, 13);
            this.wl9.TabIndex = 44;
            this.wl9.Text = "W9";
            this.wl9.Visible = false;
            // 
            // wl10
            // 
            this.wl10.AutoSize = true;
            this.wl10.Location = new System.Drawing.Point(473, 165);
            this.wl10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wl10.Name = "wl10";
            this.wl10.Size = new System.Drawing.Size(30, 13);
            this.wl10.TabIndex = 45;
            this.wl10.Text = "W10";
            this.wl10.Visible = false;
            // 
            // tl9
            // 
            this.tl9.AutoSize = true;
            this.tl9.Location = new System.Drawing.Point(459, 212);
            this.tl9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tl9.Name = "tl9";
            this.tl9.Size = new System.Drawing.Size(20, 13);
            this.tl9.TabIndex = 63;
            this.tl9.Text = "T9";
            this.tl9.Visible = false;
            // 
            // tl8
            // 
            this.tl8.AutoSize = true;
            this.tl8.Location = new System.Drawing.Point(415, 212);
            this.tl8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tl8.Name = "tl8";
            this.tl8.Size = new System.Drawing.Size(20, 13);
            this.tl8.TabIndex = 62;
            this.tl8.Text = "T8";
            this.tl8.Visible = false;
            // 
            // tl7
            // 
            this.tl7.AutoSize = true;
            this.tl7.Location = new System.Drawing.Point(375, 212);
            this.tl7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tl7.Name = "tl7";
            this.tl7.Size = new System.Drawing.Size(20, 13);
            this.tl7.TabIndex = 61;
            this.tl7.Text = "T7";
            this.tl7.Visible = false;
            // 
            // tl6
            // 
            this.tl6.AutoSize = true;
            this.tl6.Location = new System.Drawing.Point(332, 212);
            this.tl6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tl6.Name = "tl6";
            this.tl6.Size = new System.Drawing.Size(20, 13);
            this.tl6.TabIndex = 60;
            this.tl6.Text = "T6";
            this.tl6.Visible = false;
            // 
            // tl5
            // 
            this.tl5.AutoSize = true;
            this.tl5.Location = new System.Drawing.Point(290, 212);
            this.tl5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tl5.Name = "tl5";
            this.tl5.Size = new System.Drawing.Size(20, 13);
            this.tl5.TabIndex = 59;
            this.tl5.Text = "T5";
            this.tl5.Visible = false;
            // 
            // tl4
            // 
            this.tl4.AutoSize = true;
            this.tl4.Location = new System.Drawing.Point(248, 212);
            this.tl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tl4.Name = "tl4";
            this.tl4.Size = new System.Drawing.Size(20, 13);
            this.tl4.TabIndex = 58;
            this.tl4.Text = "T4";
            this.tl4.Visible = false;
            // 
            // tl3
            // 
            this.tl3.AutoSize = true;
            this.tl3.Location = new System.Drawing.Point(206, 212);
            this.tl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tl3.Name = "tl3";
            this.tl3.Size = new System.Drawing.Size(20, 13);
            this.tl3.TabIndex = 57;
            this.tl3.Text = "T3";
            this.tl3.Visible = false;
            // 
            // tl2
            // 
            this.tl2.AutoSize = true;
            this.tl2.Location = new System.Drawing.Point(165, 212);
            this.tl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tl2.Name = "tl2";
            this.tl2.Size = new System.Drawing.Size(20, 13);
            this.tl2.TabIndex = 56;
            this.tl2.Text = "T2";
            this.tl2.Visible = false;
            // 
            // tl1
            // 
            this.tl1.AutoSize = true;
            this.tl1.Location = new System.Drawing.Point(122, 212);
            this.tl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tl1.Name = "tl1";
            this.tl1.Size = new System.Drawing.Size(20, 13);
            this.tl1.TabIndex = 55;
            this.tl1.Text = "T1";
            this.tl1.Visible = false;
            // 
            // t9
            // 
            this.t9.Location = new System.Drawing.Point(449, 228);
            this.t9.Margin = new System.Windows.Forms.Padding(2);
            this.t9.Name = "t9";
            this.t9.Size = new System.Drawing.Size(38, 20);
            this.t9.TabIndex = 54;
            this.t9.Visible = false;
            // 
            // t8
            // 
            this.t8.Location = new System.Drawing.Point(407, 228);
            this.t8.Margin = new System.Windows.Forms.Padding(2);
            this.t8.Name = "t8";
            this.t8.Size = new System.Drawing.Size(38, 20);
            this.t8.TabIndex = 53;
            this.t8.Visible = false;
            // 
            // t7
            // 
            this.t7.Location = new System.Drawing.Point(365, 228);
            this.t7.Margin = new System.Windows.Forms.Padding(2);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(38, 20);
            this.t7.TabIndex = 52;
            this.t7.Visible = false;
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(323, 228);
            this.t6.Margin = new System.Windows.Forms.Padding(2);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(38, 20);
            this.t6.TabIndex = 51;
            this.t6.Visible = false;
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(281, 228);
            this.t5.Margin = new System.Windows.Forms.Padding(2);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(38, 20);
            this.t5.TabIndex = 50;
            this.t5.Visible = false;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(239, 228);
            this.t4.Margin = new System.Windows.Forms.Padding(2);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(38, 20);
            this.t4.TabIndex = 49;
            this.t4.Visible = false;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(197, 228);
            this.t3.Margin = new System.Windows.Forms.Padding(2);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(38, 20);
            this.t3.TabIndex = 48;
            this.t3.Visible = false;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(155, 228);
            this.t2.Margin = new System.Windows.Forms.Padding(2);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(38, 20);
            this.t2.TabIndex = 47;
            this.t2.Visible = false;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(113, 228);
            this.t1.Margin = new System.Windows.Forms.Padding(2);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(38, 20);
            this.t1.TabIndex = 46;
            this.t1.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 264);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 37);
            this.button4.TabIndex = 64;
            this.button4.Text = "START";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pBar1
            // 
            this.pBar1.Location = new System.Drawing.Point(6, 10);
            this.pBar1.Margin = new System.Windows.Forms.Padding(2);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(41, 19);
            this.pBar1.TabIndex = 65;
            this.pBar1.Click += new System.EventHandler(this.pBar1_Click);
            // 
            // axel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(552, 382);
            this.Controls.Add(this.pBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tl9);
            this.Controls.Add(this.tl8);
            this.Controls.Add(this.tl7);
            this.Controls.Add(this.tl6);
            this.Controls.Add(this.tl5);
            this.Controls.Add(this.tl4);
            this.Controls.Add(this.tl3);
            this.Controls.Add(this.tl2);
            this.Controls.Add(this.tl1);
            this.Controls.Add(this.t9);
            this.Controls.Add(this.t8);
            this.Controls.Add(this.t7);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.wl10);
            this.Controls.Add(this.wl9);
            this.Controls.Add(this.wl8);
            this.Controls.Add(this.wl7);
            this.Controls.Add(this.wl6);
            this.Controls.Add(this.wl5);
            this.Controls.Add(this.wl4);
            this.Controls.Add(this.wl3);
            this.Controls.Add(this.wl2);
            this.Controls.Add(this.wl1);
            this.Controls.Add(this.w10);
            this.Controls.Add(this.w9);
            this.Controls.Add(this.w8);
            this.Controls.Add(this.w7);
            this.Controls.Add(this.w6);
            this.Controls.Add(this.w5);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "axel";
            this.Text = "LOAD CELL SIMULATOR";
            this.Load += new System.EventHandler(this.axel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox w1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox w2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox w3;
        private System.Windows.Forms.TextBox w4;
        private System.Windows.Forms.TextBox w5;
        private System.Windows.Forms.TextBox w6;
        private System.Windows.Forms.TextBox w7;
        private System.Windows.Forms.TextBox w8;
        private System.Windows.Forms.TextBox w9;
        private System.Windows.Forms.TextBox w10;
        private System.Windows.Forms.Label wl1;
        private System.Windows.Forms.Label wl2;
        private System.Windows.Forms.Label wl3;
        private System.Windows.Forms.Label wl4;
        private System.Windows.Forms.Label wl5;
        private System.Windows.Forms.Label wl6;
        private System.Windows.Forms.Label wl7;
        private System.Windows.Forms.Label wl8;
        private System.Windows.Forms.Label wl9;
        private System.Windows.Forms.Label wl10;
        private System.Windows.Forms.Label tl9;
        private System.Windows.Forms.Label tl8;
        private System.Windows.Forms.Label tl7;
        private System.Windows.Forms.Label tl6;
        private System.Windows.Forms.Label tl5;
        private System.Windows.Forms.Label tl4;
        private System.Windows.Forms.Label tl3;
        private System.Windows.Forms.Label tl2;
        private System.Windows.Forms.Label tl1;
        private System.Windows.Forms.TextBox t9;
        private System.Windows.Forms.TextBox t8;
        private System.Windows.Forms.TextBox t7;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar pBar1;
    }
}

