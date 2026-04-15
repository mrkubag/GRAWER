namespace SMT_STOPPER_PANEL
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConnection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBackward = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCurPos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Move_Pos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonLaser = new System.Windows.Forms.Button();
            this.checkBoxLaser = new System.Windows.Forms.CheckBox();
            this.checkBoxSmema = new System.Windows.Forms.CheckBox();
            this.buttonSmema = new System.Windows.Forms.Button();
            this.checkBoxSolenoid = new System.Windows.Forms.CheckBox();
            this.buttonSolenoid = new System.Windows.Forms.Button();
            this.timerSolenoid = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLaser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSmema = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSolenoid = new System.Windows.Forms.TextBox();
            this.timerLaser = new System.Windows.Forms.Timer(this.components);
            this.timerSmema = new System.Windows.Forms.Timer(this.components);
            this.home_label = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.newPos = new System.Windows.Forms.NumericUpDown();
            this.doneButton = new System.Windows.Forms.Button();
            this.bypassButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.newPos)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonConnect.Location = new System.Drawing.Point(1744, 29);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(357, 81);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Otwórz";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(1429, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stan połączenia:";
            // 
            // textBoxConnection
            // 
            this.textBoxConnection.Enabled = false;
            this.textBoxConnection.Location = new System.Drawing.Point(1776, 141);
            this.textBoxConnection.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxConnection.Name = "textBoxConnection";
            this.textBoxConnection.Size = new System.Drawing.Size(271, 38);
            this.textBoxConnection.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(32, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stan stopera:";
            // 
            // textBoxState
            // 
            this.textBoxState.Enabled = false;
            this.textBoxState.Location = new System.Drawing.Point(296, 339);
            this.textBoxState.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(569, 38);
            this.textBoxState.TabIndex = 4;
            this.textBoxState.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonForward
            // 
            this.buttonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonForward.Location = new System.Drawing.Point(1627, 424);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(213, 191);
            this.buttonForward.TabIndex = 5;
            this.buttonForward.Text = ">";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            this.buttonForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonForward_MouseDown);
            this.buttonForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonForward_MouseUp);
            // 
            // buttonBackward
            // 
            this.buttonBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackward.Location = new System.Drawing.Point(1397, 424);
            this.buttonBackward.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(213, 191);
            this.buttonBackward.TabIndex = 6;
            this.buttonBackward.Text = "<";
            this.buttonBackward.UseVisualStyleBackColor = true;
            this.buttonBackward.Click += new System.EventHandler(this.buttonBackward_Click);
            this.buttonBackward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBackward_MouseDown);
            this.buttonBackward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonBackward_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(32, 460);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aktualna pozycja:";
            // 
            // textBoxCurPos
            // 
            this.textBoxCurPos.Enabled = false;
            this.textBoxCurPos.Location = new System.Drawing.Point(365, 453);
            this.textBoxCurPos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxCurPos.Name = "textBoxCurPos";
            this.textBoxCurPos.Size = new System.Drawing.Size(271, 38);
            this.textBoxCurPos.TabIndex = 8;
            this.textBoxCurPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(1389, 661);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "Do pozycji:";
            // 
            // Move_Pos
            // 
            this.Move_Pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Move_Pos.Location = new System.Drawing.Point(1397, 744);
            this.Move_Pos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Move_Pos.Name = "Move_Pos";
            this.Move_Pos.Size = new System.Drawing.Size(443, 81);
            this.Move_Pos.TabIndex = 11;
            this.Move_Pos.Text = "Ruch do pozycji";
            this.Move_Pos.UseVisualStyleBackColor = true;
            this.Move_Pos.Click += new System.EventHandler(this.Move_Pos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(1019, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 39);
            this.label5.TabIndex = 12;
            this.label5.Text = "Port:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1136, 48);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 39);
            this.comboBox1.TabIndex = 13;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRefresh.Location = new System.Drawing.Point(1499, 29);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(203, 81);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonLaser
            // 
            this.buttonLaser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonLaser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonLaser.Location = new System.Drawing.Point(40, 608);
            this.buttonLaser.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonLaser.Name = "buttonLaser";
            this.buttonLaser.Size = new System.Drawing.Size(267, 143);
            this.buttonLaser.TabIndex = 15;
            this.buttonLaser.Text = "LASER";
            this.buttonLaser.UseVisualStyleBackColor = false;
            this.buttonLaser.Click += new System.EventHandler(this.buttonLaser_Click);
            // 
            // checkBoxLaser
            // 
            this.checkBoxLaser.AutoSize = true;
            this.checkBoxLaser.Location = new System.Drawing.Point(45, 765);
            this.checkBoxLaser.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxLaser.Name = "checkBoxLaser";
            this.checkBoxLaser.Size = new System.Drawing.Size(211, 36);
            this.checkBoxLaser.TabIndex = 16;
            this.checkBoxLaser.Text = "CHWILOWO";
            this.checkBoxLaser.UseVisualStyleBackColor = true;
            // 
            // checkBoxSmema
            // 
            this.checkBoxSmema.AutoSize = true;
            this.checkBoxSmema.Location = new System.Drawing.Point(328, 765);
            this.checkBoxSmema.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxSmema.Name = "checkBoxSmema";
            this.checkBoxSmema.Size = new System.Drawing.Size(211, 36);
            this.checkBoxSmema.TabIndex = 18;
            this.checkBoxSmema.Text = "CHWILOWO";
            this.checkBoxSmema.UseVisualStyleBackColor = true;
            // 
            // buttonSmema
            // 
            this.buttonSmema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSmema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSmema.Location = new System.Drawing.Point(323, 608);
            this.buttonSmema.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSmema.Name = "buttonSmema";
            this.buttonSmema.Size = new System.Drawing.Size(267, 143);
            this.buttonSmema.TabIndex = 17;
            this.buttonSmema.Text = "SMEMA";
            this.buttonSmema.UseVisualStyleBackColor = false;
            this.buttonSmema.Click += new System.EventHandler(this.buttonSmema_Click);
            // 
            // checkBoxSolenoid
            // 
            this.checkBoxSolenoid.AutoSize = true;
            this.checkBoxSolenoid.Location = new System.Drawing.Point(611, 763);
            this.checkBoxSolenoid.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxSolenoid.Name = "checkBoxSolenoid";
            this.checkBoxSolenoid.Size = new System.Drawing.Size(211, 36);
            this.checkBoxSolenoid.TabIndex = 20;
            this.checkBoxSolenoid.Text = "CHWILOWO";
            this.checkBoxSolenoid.UseVisualStyleBackColor = true;
            // 
            // buttonSolenoid
            // 
            this.buttonSolenoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSolenoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSolenoid.Location = new System.Drawing.Point(605, 606);
            this.buttonSolenoid.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSolenoid.Name = "buttonSolenoid";
            this.buttonSolenoid.Size = new System.Drawing.Size(267, 143);
            this.buttonSolenoid.TabIndex = 19;
            this.buttonSolenoid.Text = "SOLENOID";
            this.buttonSolenoid.UseVisualStyleBackColor = false;
            this.buttonSolenoid.Click += new System.EventHandler(this.buttonSolenoid_Click);
            // 
            // timerSolenoid
            // 
            this.timerSolenoid.Enabled = true;
            this.timerSolenoid.Interval = 1000;
            this.timerSolenoid.Tick += new System.EventHandler(this.timerSolenoid_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(659, 460);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 39);
            this.label6.TabIndex = 21;
            this.label6.Text = "mm";
            // 
            // textBoxLaser
            // 
            this.textBoxLaser.Location = new System.Drawing.Point(45, 823);
            this.textBoxLaser.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxLaser.Name = "textBoxLaser";
            this.textBoxLaser.Size = new System.Drawing.Size(140, 38);
            this.textBoxLaser.TabIndex = 22;
            this.textBoxLaser.Text = "200";
            this.textBoxLaser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(211, 825);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 39);
            this.label7.TabIndex = 23;
            this.label7.Text = "ms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(493, 827);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 39);
            this.label8.TabIndex = 25;
            this.label8.Text = "ms";
            // 
            // textBoxSmema
            // 
            this.textBoxSmema.Location = new System.Drawing.Point(328, 825);
            this.textBoxSmema.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxSmema.Name = "textBoxSmema";
            this.textBoxSmema.Size = new System.Drawing.Size(140, 38);
            this.textBoxSmema.TabIndex = 24;
            this.textBoxSmema.Text = "200";
            this.textBoxSmema.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(776, 830);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 39);
            this.label9.TabIndex = 27;
            this.label9.Text = "ms";
            // 
            // textBoxSolenoid
            // 
            this.textBoxSolenoid.Location = new System.Drawing.Point(611, 827);
            this.textBoxSolenoid.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxSolenoid.Name = "textBoxSolenoid";
            this.textBoxSolenoid.Size = new System.Drawing.Size(140, 38);
            this.textBoxSolenoid.TabIndex = 26;
            this.textBoxSolenoid.Text = "2000";
            this.textBoxSolenoid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timerLaser
            // 
            this.timerLaser.Enabled = true;
            this.timerLaser.Tick += new System.EventHandler(this.timerLaser_Tick);
            // 
            // timerSmema
            // 
            this.timerSmema.Enabled = true;
            this.timerSmema.Tick += new System.EventHandler(this.timerSmema_Tick);
            // 
            // home_label
            // 
            this.home_label.AutoSize = true;
            this.home_label.BackColor = System.Drawing.Color.Red;
            this.home_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.home_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.home_label.Location = new System.Drawing.Point(1397, 887);
            this.home_label.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.home_label.Name = "home_label";
            this.home_label.Padding = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.home_label.Size = new System.Drawing.Size(231, 108);
            this.home_label.TabIndex = 28;
            this.home_label.Text = "HOME";
            this.home_label.Click += new System.EventHandler(this.label10_Click);
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.homeButton.Location = new System.Drawing.Point(1397, 317);
            this.homeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(443, 81);
            this.homeButton.TabIndex = 29;
            this.homeButton.Text = "Pozycja HOME";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(1856, 668);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 39);
            this.label10.TabIndex = 30;
            this.label10.Text = "mm";
            // 
            // newPos
            // 
            this.newPos.DecimalPlaces = 2;
            this.newPos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.newPos.Location = new System.Drawing.Point(1611, 661);
            this.newPos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.newPos.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.newPos.Name = "newPos";
            this.newPos.Size = new System.Drawing.Size(229, 38);
            this.newPos.TabIndex = 31;
            this.newPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.newPos.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // doneButton
            // 
            this.doneButton.Enabled = false;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.doneButton.Location = new System.Drawing.Point(1000, 503);
            this.doneButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(272, 196);
            this.doneButton.TabIndex = 32;
            this.doneButton.Text = "GOTOWA";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // bypassButton
            // 
            this.bypassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bypassButton.Location = new System.Drawing.Point(1000, 744);
            this.bypassButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bypassButton.Name = "bypassButton";
            this.bypassButton.Size = new System.Drawing.Size(272, 144);
            this.bypassButton.TabIndex = 33;
            this.bypassButton.Text = "BYPASS";
            this.bypassButton.UseVisualStyleBackColor = true;
            this.bypassButton.Click += new System.EventHandler(this.bypassButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1744, 887);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 108);
            this.button1.TabIndex = 34;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2155, 1042);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bypassButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.newPos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.home_label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSolenoid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSmema);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxLaser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxSolenoid);
            this.Controls.Add(this.buttonSolenoid);
            this.Controls.Add(this.checkBoxSmema);
            this.Controls.Add(this.buttonSmema);
            this.Controls.Add(this.checkBoxLaser);
            this.Controls.Add(this.buttonLaser);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Move_Pos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCurPos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBackward);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxConnection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConnect);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCurPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Move_Pos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonLaser;
        private System.Windows.Forms.CheckBox checkBoxLaser;
        private System.Windows.Forms.CheckBox checkBoxSmema;
        private System.Windows.Forms.Button buttonSmema;
        private System.Windows.Forms.CheckBox checkBoxSolenoid;
        private System.Windows.Forms.Button buttonSolenoid;
        private System.Windows.Forms.Timer timerSolenoid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLaser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSmema;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSolenoid;
        private System.Windows.Forms.Timer timerLaser;
        private System.Windows.Forms.Timer timerSmema;
        private System.Windows.Forms.Label home_label;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown newPos;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button bypassButton;
        private System.Windows.Forms.Button button1;
    }
}

