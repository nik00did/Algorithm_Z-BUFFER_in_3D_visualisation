namespace Z_BUFFER
{
    partial class Form1
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
            if (disposing && (components != null)) components.Dispose();
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
            this.Загрузить = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.XOY = new System.Windows.Forms.Button();
            this.YOZ = new System.Windows.Forms.Button();
            this.XOZ = new System.Windows.Forms.Button();
            this.Движение = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Масштаб2Z = new System.Windows.Forms.Button();
            this.Масштаб2Y = new System.Windows.Forms.Button();
            this.Масштаб1Z = new System.Windows.Forms.Button();
            this.Масштаб1Y = new System.Windows.Forms.Button();
            this.Масштаб2Х = new System.Windows.Forms.Button();
            this.Масштаб1Х = new System.Windows.Forms.Button();
            this.Перенос2Z = new System.Windows.Forms.Button();
            this.Перенос2У = new System.Windows.Forms.Button();
            this.Перенос1Z = new System.Windows.Forms.Button();
            this.Перенос1У = new System.Windows.Forms.Button();
            this.Перенос2Х = new System.Windows.Forms.Button();
            this.Перенос1Х = new System.Windows.Forms.Button();
            this.ПротивстрелкиZ = new System.Windows.Forms.Button();
            this.ПострелкеZ = new System.Windows.Forms.Button();
            this.ПротивстрелкиУ = new System.Windows.Forms.Button();
            this.ПострелкеУ = new System.Windows.Forms.Button();
            this.ПротивстрелкиХ = new System.Windows.Forms.Button();
            this.ПострелкеХ = new System.Windows.Forms.Button();
            this.BOX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BOX)).BeginInit();
            this.SuspendLayout();
            // 
            // Загрузить
            // 
            this.Загрузить.BackColor = System.Drawing.Color.DodgerBlue;
            this.Загрузить.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Загрузить.Location = new System.Drawing.Point(924, 12);
            this.Загрузить.Name = "Загрузить";
            this.Загрузить.Size = new System.Drawing.Size(155, 54);
            this.Загрузить.TabIndex = 1;
            this.Загрузить.Text = "Load letter";
            this.Загрузить.UseVisualStyleBackColor = false;
            this.Загрузить.Click += new System.EventHandler(this.Загрузить_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(811, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rotation X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(811, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rotation Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(811, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rotation Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(811, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Move to X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(811, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Move to Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(811, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Move to Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(824, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Resize x";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(823, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Resize Y";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(823, 602);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Resize Z";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(968, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "Mirror";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // XOY
            // 
            this.XOY.BackColor = System.Drawing.Color.DodgerBlue;
            this.XOY.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XOY.Location = new System.Drawing.Point(700, 267);
            this.XOY.Name = "XOY";
            this.XOY.Size = new System.Drawing.Size(192, 42);
            this.XOY.TabIndex = 30;
            this.XOY.Text = "Axis XOY";
            this.XOY.UseVisualStyleBackColor = false;
            this.XOY.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // YOZ
            // 
            this.YOZ.BackColor = System.Drawing.Color.DodgerBlue;
            this.YOZ.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YOZ.Location = new System.Drawing.Point(1103, 267);
            this.YOZ.Name = "YOZ";
            this.YOZ.Size = new System.Drawing.Size(192, 42);
            this.YOZ.TabIndex = 31;
            this.YOZ.Text = "Axis YOZ";
            this.YOZ.UseVisualStyleBackColor = false;
            this.YOZ.Click += new System.EventHandler(this.YOZ_Click);
            // 
            // XOZ
            // 
            this.XOZ.BackColor = System.Drawing.Color.DodgerBlue;
            this.XOZ.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XOZ.Location = new System.Drawing.Point(902, 267);
            this.XOZ.Name = "XOZ";
            this.XOZ.Size = new System.Drawing.Size(192, 42);
            this.XOZ.TabIndex = 32;
            this.XOZ.Text = "Axis XOZ";
            this.XOZ.UseVisualStyleBackColor = false;
            this.XOZ.Click += new System.EventHandler(this.XOZ_Click);
            // 
            // Движение
            // 
            this.Движение.BackColor = System.Drawing.Color.DodgerBlue;
            this.Движение.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Движение.ForeColor = System.Drawing.Color.Black;
            this.Движение.Location = new System.Drawing.Point(924, 650);
            this.Движение.Name = "Движение";
            this.Движение.Size = new System.Drawing.Size(155, 45);
            this.Движение.TabIndex = 33;
            this.Движение.Text = "Move on curve";
            this.Движение.UseVisualStyleBackColor = false;
            this.Движение.Click += new System.EventHandler(this.Движение_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Масштаб2Z
            // 
            this.Масштаб2Z.BackColor = System.Drawing.Color.DodgerBlue;
            this.Масштаб2Z.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Масштаб2Z.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Масштаб2Z.Location = new System.Drawing.Point(1082, 593);
            this.Масштаб2Z.Name = "Масштаб2Z";
            this.Масштаб2Z.Size = new System.Drawing.Size(134, 42);
            this.Масштаб2Z.TabIndex = 28;
            this.Масштаб2Z.Text = "RIGHT";
            this.Масштаб2Z.UseVisualStyleBackColor = false;
            // 
            // Масштаб2Y
            // 
            this.Масштаб2Y.BackColor = System.Drawing.Color.DodgerBlue;
            this.Масштаб2Y.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Масштаб2Y.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Масштаб2Y.Location = new System.Drawing.Point(1082, 542);
            this.Масштаб2Y.Name = "Масштаб2Y";
            this.Масштаб2Y.Size = new System.Drawing.Size(134, 42);
            this.Масштаб2Y.TabIndex = 27;
            this.Масштаб2Y.Text = "RIGHT";
            this.Масштаб2Y.UseVisualStyleBackColor = false;
            // 
            // Масштаб1Z
            // 
            this.Масштаб1Z.BackColor = System.Drawing.Color.DodgerBlue;
            this.Масштаб1Z.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Масштаб1Z.ForeColor = System.Drawing.SystemColors.Control;
            this.Масштаб1Z.Location = new System.Drawing.Point(935, 593);
            this.Масштаб1Z.Name = "Масштаб1Z";
            this.Масштаб1Z.Size = new System.Drawing.Size(130, 42);
            this.Масштаб1Z.TabIndex = 26;
            this.Масштаб1Z.Text = "LEFT";
            this.Масштаб1Z.UseVisualStyleBackColor = false;
            // 
            // Масштаб1Y
            // 
            this.Масштаб1Y.BackColor = System.Drawing.Color.DodgerBlue;
            this.Масштаб1Y.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Масштаб1Y.ForeColor = System.Drawing.SystemColors.Control;
            this.Масштаб1Y.Location = new System.Drawing.Point(935, 542);
            this.Масштаб1Y.Name = "Масштаб1Y";
            this.Масштаб1Y.Size = new System.Drawing.Size(130, 42);
            this.Масштаб1Y.TabIndex = 25;
            this.Масштаб1Y.Text = "LEFT";
            this.Масштаб1Y.UseVisualStyleBackColor = false;
            // 
            // Масштаб2Х
            // 
            this.Масштаб2Х.BackColor = System.Drawing.Color.DodgerBlue;
            this.Масштаб2Х.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Масштаб2Х.ForeColor = System.Drawing.SystemColors.Control;
            this.Масштаб2Х.Location = new System.Drawing.Point(935, 490);
            this.Масштаб2Х.Name = "Масштаб2Х";
            this.Масштаб2Х.Size = new System.Drawing.Size(130, 42);
            this.Масштаб2Х.TabIndex = 21;
            this.Масштаб2Х.Text = "LEFT";
            this.Масштаб2Х.UseVisualStyleBackColor = false;
            this.Масштаб2Х.Click += new System.EventHandler(this.Масштаб2Х_Click);
            // 
            // Масштаб1Х
            // 
            this.Масштаб1Х.BackColor = System.Drawing.Color.DodgerBlue;
            this.Масштаб1Х.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Масштаб1Х.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Масштаб1Х.Location = new System.Drawing.Point(1082, 490);
            this.Масштаб1Х.Name = "Масштаб1Х";
            this.Масштаб1Х.Size = new System.Drawing.Size(134, 42);
            this.Масштаб1Х.TabIndex = 20;
            this.Масштаб1Х.Text = "RIGHT";
            this.Масштаб1Х.UseVisualStyleBackColor = false;
            // 
            // Перенос2Z
            // 
            this.Перенос2Z.BackColor = System.Drawing.Color.DodgerBlue;
            this.Перенос2Z.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Перенос2Z.Location = new System.Drawing.Point(1082, 176);
            this.Перенос2Z.Name = "Перенос2Z";
            this.Перенос2Z.Size = new System.Drawing.Size(134, 40);
            this.Перенос2Z.TabIndex = 19;
            this.Перенос2Z.Text = "RIGHT";
            this.Перенос2Z.UseVisualStyleBackColor = false;
            this.Перенос2Z.Click += new System.EventHandler(this.Перенос2Z_Click);
            // 
            // Перенос2У
            // 
            this.Перенос2У.BackColor = System.Drawing.Color.DodgerBlue;
            this.Перенос2У.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Перенос2У.Location = new System.Drawing.Point(1082, 128);
            this.Перенос2У.Name = "Перенос2У";
            this.Перенос2У.Size = new System.Drawing.Size(134, 42);
            this.Перенос2У.TabIndex = 18;
            this.Перенос2У.Text = "RIGHT";
            this.Перенос2У.UseVisualStyleBackColor = false;
            this.Перенос2У.Click += new System.EventHandler(this.Перенос2У_Click);
            // 
            // Перенос1Z
            // 
            this.Перенос1Z.BackColor = System.Drawing.Color.DodgerBlue;
            this.Перенос1Z.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Перенос1Z.ForeColor = System.Drawing.SystemColors.Control;
            this.Перенос1Z.Location = new System.Drawing.Point(935, 176);
            this.Перенос1Z.Name = "Перенос1Z";
            this.Перенос1Z.Size = new System.Drawing.Size(130, 40);
            this.Перенос1Z.TabIndex = 17;
            this.Перенос1Z.Text = "LEFT";
            this.Перенос1Z.UseVisualStyleBackColor = false;
            this.Перенос1Z.Click += new System.EventHandler(this.Перенос1Z_Click);
            // 
            // Перенос1У
            // 
            this.Перенос1У.BackColor = System.Drawing.Color.DodgerBlue;
            this.Перенос1У.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Перенос1У.ForeColor = System.Drawing.SystemColors.Control;
            this.Перенос1У.Location = new System.Drawing.Point(935, 128);
            this.Перенос1У.Name = "Перенос1У";
            this.Перенос1У.Size = new System.Drawing.Size(130, 42);
            this.Перенос1У.TabIndex = 16;
            this.Перенос1У.Text = "LEFT";
            this.Перенос1У.UseVisualStyleBackColor = false;
            this.Перенос1У.Click += new System.EventHandler(this.Перенос1У_Click);
            // 
            // Перенос2Х
            // 
            this.Перенос2Х.BackColor = System.Drawing.Color.DodgerBlue;
            this.Перенос2Х.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Перенос2Х.Location = new System.Drawing.Point(1082, 80);
            this.Перенос2Х.Name = "Перенос2Х";
            this.Перенос2Х.Size = new System.Drawing.Size(134, 42);
            this.Перенос2Х.TabIndex = 12;
            this.Перенос2Х.Text = "RIGHT";
            this.Перенос2Х.UseVisualStyleBackColor = false;
            this.Перенос2Х.Click += new System.EventHandler(this.Перенос2Х_Click);
            // 
            // Перенос1Х
            // 
            this.Перенос1Х.BackColor = System.Drawing.Color.DodgerBlue;
            this.Перенос1Х.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Перенос1Х.ForeColor = System.Drawing.SystemColors.Control;
            this.Перенос1Х.Location = new System.Drawing.Point(935, 80);
            this.Перенос1Х.Name = "Перенос1Х";
            this.Перенос1Х.Size = new System.Drawing.Size(130, 42);
            this.Перенос1Х.TabIndex = 11;
            this.Перенос1Х.Text = "LEFT";
            this.Перенос1Х.UseVisualStyleBackColor = false;
            this.Перенос1Х.Click += new System.EventHandler(this.Перенос1Х_Click);
            // 
            // ПротивстрелкиZ
            // 
            this.ПротивстрелкиZ.BackColor = System.Drawing.Color.DodgerBlue;
            this.ПротивстрелкиZ.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ПротивстрелкиZ.Location = new System.Drawing.Point(1082, 431);
            this.ПротивстрелкиZ.Name = "ПротивстрелкиZ";
            this.ПротивстрелкиZ.Size = new System.Drawing.Size(134, 42);
            this.ПротивстрелкиZ.TabIndex = 10;
            this.ПротивстрелкиZ.Text = "RIGHT";
            this.ПротивстрелкиZ.UseVisualStyleBackColor = false;
            this.ПротивстрелкиZ.Click += new System.EventHandler(this.ПротивстрелкиZ_Click);
            // 
            // ПострелкеZ
            // 
            this.ПострелкеZ.BackColor = System.Drawing.Color.DodgerBlue;
            this.ПострелкеZ.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ПострелкеZ.ForeColor = System.Drawing.SystemColors.Control;
            this.ПострелкеZ.Location = new System.Drawing.Point(935, 431);
            this.ПострелкеZ.Name = "ПострелкеZ";
            this.ПострелкеZ.Size = new System.Drawing.Size(130, 42);
            this.ПострелкеZ.TabIndex = 9;
            this.ПострелкеZ.Text = "LEFT";
            this.ПострелкеZ.UseVisualStyleBackColor = false;
            this.ПострелкеZ.Click += new System.EventHandler(this.ПострелкеZ_Click);
            // 
            // ПротивстрелкиУ
            // 
            this.ПротивстрелкиУ.BackColor = System.Drawing.Color.DodgerBlue;
            this.ПротивстрелкиУ.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ПротивстрелкиУ.Location = new System.Drawing.Point(1082, 376);
            this.ПротивстрелкиУ.Name = "ПротивстрелкиУ";
            this.ПротивстрелкиУ.Size = new System.Drawing.Size(134, 42);
            this.ПротивстрелкиУ.TabIndex = 7;
            this.ПротивстрелкиУ.Text = "RIGHT";
            this.ПротивстрелкиУ.UseVisualStyleBackColor = false;
            this.ПротивстрелкиУ.Click += new System.EventHandler(this.ПротивстрелкиУ_Click);
            // 
            // ПострелкеУ
            // 
            this.ПострелкеУ.BackColor = System.Drawing.Color.DodgerBlue;
            this.ПострелкеУ.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ПострелкеУ.ForeColor = System.Drawing.SystemColors.Control;
            this.ПострелкеУ.Location = new System.Drawing.Point(935, 376);
            this.ПострелкеУ.Name = "ПострелкеУ";
            this.ПострелкеУ.Size = new System.Drawing.Size(130, 42);
            this.ПострелкеУ.TabIndex = 6;
            this.ПострелкеУ.Text = "LEFT";
            this.ПострелкеУ.UseVisualStyleBackColor = false;
            this.ПострелкеУ.Click += new System.EventHandler(this.ПострелкеУ_Click);
            // 
            // ПротивстрелкиХ
            // 
            this.ПротивстрелкиХ.BackColor = System.Drawing.Color.DodgerBlue;
            this.ПротивстрелкиХ.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ПротивстрелкиХ.ForeColor = System.Drawing.SystemColors.Control;
            this.ПротивстрелкиХ.Location = new System.Drawing.Point(935, 319);
            this.ПротивстрелкиХ.Name = "ПротивстрелкиХ";
            this.ПротивстрелкиХ.Size = new System.Drawing.Size(130, 42);
            this.ПротивстрелкиХ.TabIndex = 3;
            this.ПротивстрелкиХ.Text = "LEFT";
            this.ПротивстрелкиХ.UseVisualStyleBackColor = false;
            this.ПротивстрелкиХ.Click += new System.EventHandler(this.ПротивстрелкиХ_Click);
            // 
            // ПострелкеХ
            // 
            this.ПострелкеХ.BackColor = System.Drawing.Color.DodgerBlue;
            this.ПострелкеХ.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ПострелкеХ.Location = new System.Drawing.Point(1082, 319);
            this.ПострелкеХ.Name = "ПострелкеХ";
            this.ПострелкеХ.Size = new System.Drawing.Size(134, 42);
            this.ПострелкеХ.TabIndex = 2;
            this.ПострелкеХ.Text = "RIGHT";
            this.ПострелкеХ.UseVisualStyleBackColor = false;
            this.ПострелкеХ.Click += new System.EventHandler(this.button1_Click);
            // 
            // BOX
            // 
            this.BOX.Location = new System.Drawing.Point(60, 3);
            this.BOX.Name = "BOX";
            this.BOX.Size = new System.Drawing.Size(590, 723);
            this.BOX.TabIndex = 0;
            this.BOX.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(1307, 724);
            this.Controls.Add(this.Движение);
            this.Controls.Add(this.XOZ);
            this.Controls.Add(this.YOZ);
            this.Controls.Add(this.XOY);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Масштаб2Z);
            this.Controls.Add(this.Масштаб2Y);
            this.Controls.Add(this.Масштаб1Z);
            this.Controls.Add(this.Масштаб1Y);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Масштаб2Х);
            this.Controls.Add(this.Масштаб1Х);
            this.Controls.Add(this.Перенос2Z);
            this.Controls.Add(this.Перенос2У);
            this.Controls.Add(this.Перенос1Z);
            this.Controls.Add(this.Перенос1У);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Перенос2Х);
            this.Controls.Add(this.Перенос1Х);
            this.Controls.Add(this.ПротивстрелкиZ);
            this.Controls.Add(this.ПострелкеZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ПротивстрелкиУ);
            this.Controls.Add(this.ПострелкеУ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ПротивстрелкиХ);
            this.Controls.Add(this.ПострелкеХ);
            this.Controls.Add(this.Загрузить);
            this.Controls.Add(this.BOX);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "LEFT";
            ((System.ComponentModel.ISupportInitialize)(this.BOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Загрузить;
        private System.Windows.Forms.Button ПострелкеХ;
        private System.Windows.Forms.Button ПротивстрелкиХ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ПострелкеУ;
        private System.Windows.Forms.Button ПротивстрелкиУ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ПострелкеZ;
        private System.Windows.Forms.Button ПротивстрелкиZ;
        private System.Windows.Forms.Button Перенос1Х;
        private System.Windows.Forms.Button Перенос2Х;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Перенос1У;
        private System.Windows.Forms.Button Перенос1Z;
        private System.Windows.Forms.Button Перенос2У;
        private System.Windows.Forms.Button Перенос2Z;
        private System.Windows.Forms.Button Масштаб1Х;
        private System.Windows.Forms.Button Масштаб2Х;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Масштаб1Y;
        private System.Windows.Forms.Button Масштаб1Z;
        private System.Windows.Forms.Button Масштаб2Y;
        private System.Windows.Forms.Button Масштаб2Z;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button XOY;
        private System.Windows.Forms.Button YOZ;
        private System.Windows.Forms.Button XOZ;
        public System.Windows.Forms.PictureBox BOX;
        private System.Windows.Forms.Button Движение;
        private System.Windows.Forms.Timer timer1;
    }
}

