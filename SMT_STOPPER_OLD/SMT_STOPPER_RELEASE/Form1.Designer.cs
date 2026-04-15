namespace SMT_STOPPER_RELEASE
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBoxArmed = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonZast = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pozycjaZadProf = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.czasWypalaniaProf = new System.Windows.Forms.NumericUpDown();
            this.buttonResetEZCAD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEzcad = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConnection = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonPass = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.bypassButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonPosRefr = new System.Windows.Forms.Button();
            this.textBoxCurPos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBoxLiczMno = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownLicznikMnoznik = new System.Windows.Forms.NumericUpDown();
            this.groupBoxLiczIlo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownLicznik = new System.Windows.Forms.NumericUpDown();
            this.checkBoxLicznik = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.serialPortSkaner = new System.IO.Ports.SerialPort(this.components);
            this.timerSkaner = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjaZadProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czasWypalaniaProf)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBoxLiczMno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLicznikMnoznik)).BeginInit();
            this.groupBoxLiczIlo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLicznik)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusStripLabel});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(4);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.statusStrip1.Size = new System.Drawing.Size(357, 22);
            this.statusStrip1.TabIndex = 52;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(95, 17);
            this.statusStripLabel.Spring = true;
            this.statusStripLabel.Text = "toolStripStatusLabel2";
            // 
            // checkBoxArmed
            // 
            this.checkBoxArmed.AutoSize = true;
            this.checkBoxArmed.Enabled = false;
            this.checkBoxArmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxArmed.ForeColor = System.Drawing.Color.Black;
            this.checkBoxArmed.Location = new System.Drawing.Point(61, 11);
            this.checkBoxArmed.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxArmed.Name = "checkBoxArmed";
            this.checkBoxArmed.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.checkBoxArmed.Size = new System.Drawing.Size(258, 26);
            this.checkBoxArmed.TabIndex = 56;
            this.checkBoxArmed.Text = "WYZWALANIE LASERA";
            this.checkBoxArmed.UseVisualStyleBackColor = true;
            this.checkBoxArmed.CheckedChanged += new System.EventHandler(this.checkBoxArmed_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xlsx";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonZast
            // 
            this.buttonZast.Enabled = false;
            this.buttonZast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonZast.Location = new System.Drawing.Point(19, 96);
            this.buttonZast.Name = "buttonZast";
            this.buttonZast.Size = new System.Drawing.Size(323, 30);
            this.buttonZast.TabIndex = 83;
            this.buttonZast.Text = "ZASTOSUJ USTAWIENIA";
            this.buttonZast.UseVisualStyleBackColor = true;
            this.buttonZast.Click += new System.EventHandler(this.ButtonApply);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(88, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 79;
            this.label9.Text = "Do pozycji:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(263, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 80;
            this.label11.Text = "mm";
            // 
            // pozycjaZadProf
            // 
            this.pozycjaZadProf.DecimalPlaces = 2;
            this.pozycjaZadProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pozycjaZadProf.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.pozycjaZadProf.Location = new System.Drawing.Point(196, 47);
            this.pozycjaZadProf.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.pozycjaZadProf.Name = "pozycjaZadProf";
            this.pozycjaZadProf.Size = new System.Drawing.Size(67, 23);
            this.pozycjaZadProf.TabIndex = 81;
            this.pozycjaZadProf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pozycjaZadProf.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.pozycjaZadProf.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(265, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 17);
            this.label12.TabIndex = 78;
            this.label12.Text = "s";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(88, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 17);
            this.label13.TabIndex = 77;
            this.label13.Text = "Czas wypalania:";
            // 
            // czasWypalaniaProf
            // 
            this.czasWypalaniaProf.DecimalPlaces = 2;
            this.czasWypalaniaProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.czasWypalaniaProf.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.czasWypalaniaProf.Location = new System.Drawing.Point(196, 69);
            this.czasWypalaniaProf.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.czasWypalaniaProf.Name = "czasWypalaniaProf";
            this.czasWypalaniaProf.Size = new System.Drawing.Size(67, 23);
            this.czasWypalaniaProf.TabIndex = 82;
            this.czasWypalaniaProf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.czasWypalaniaProf.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.czasWypalaniaProf.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonResetEZCAD
            // 
            this.buttonResetEZCAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonResetEZCAD.Location = new System.Drawing.Point(249, 96);
            this.buttonResetEZCAD.Name = "buttonResetEZCAD";
            this.buttonResetEZCAD.Size = new System.Drawing.Size(82, 49);
            this.buttonResetEZCAD.TabIndex = 76;
            this.buttonResetEZCAD.Text = "Reset EZCAD";
            this.buttonResetEZCAD.UseVisualStyleBackColor = true;
            this.buttonResetEZCAD.Click += new System.EventHandler(this.buttonResetEZCAD_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelEzcad);
            this.panel1.Location = new System.Drawing.Point(249, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 69);
            this.panel1.TabIndex = 75;
            // 
            // labelEzcad
            // 
            this.labelEzcad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelEzcad.Cursor = System.Windows.Forms.Cursors.No;
            this.labelEzcad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEzcad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.labelEzcad.Location = new System.Drawing.Point(0, 0);
            this.labelEzcad.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEzcad.Name = "labelEzcad";
            this.labelEzcad.Size = new System.Drawing.Size(82, 69);
            this.labelEzcad.TabIndex = 0;
            this.labelEzcad.Text = "PROSZĘ OTWORZYĆ OKNO EZCAD ";
            this.labelEzcad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonConnect.Location = new System.Drawing.Point(4, 96);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(206, 49);
            this.buttonConnect.TabIndex = 69;
            this.buttonConnect.Text = "Otwórz port";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(2, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Stan połączenia:";
            // 
            // textBoxConnection
            // 
            this.textBoxConnection.Enabled = false;
            this.textBoxConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxConnection.Location = new System.Drawing.Point(121, 68);
            this.textBoxConnection.Name = "textBoxConnection";
            this.textBoxConnection.Size = new System.Drawing.Size(91, 21);
            this.textBoxConnection.TabIndex = 71;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 21);
            this.comboBox1.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(5, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 72;
            this.label5.Text = "Port transp:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonRefresh.Location = new System.Drawing.Point(169, 15);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(76, 47);
            this.buttonRefresh.TabIndex = 74;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonPass
            // 
            this.buttonPass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPass.Enabled = false;
            this.buttonPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonPass.Location = new System.Drawing.Point(1, 75);
            this.buttonPass.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPass.Name = "buttonPass";
            this.buttonPass.Size = new System.Drawing.Size(351, 44);
            this.buttonPass.TabIndex = 86;
            this.buttonPass.Text = "PASS";
            this.buttonPass.UseVisualStyleBackColor = true;
            this.buttonPass.Click += new System.EventHandler(this.buttonPass_Click);
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.doneButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.doneButton.Enabled = false;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.doneButton.Location = new System.Drawing.Point(193, 14);
            this.doneButton.Margin = new System.Windows.Forms.Padding(8);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(159, 61);
            this.doneButton.TabIndex = 85;
            this.doneButton.Text = "AUTOMATYCZNY";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // bypassButton
            // 
            this.bypassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bypassButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.bypassButton.Enabled = false;
            this.bypassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bypassButton.Location = new System.Drawing.Point(1, 14);
            this.bypassButton.Margin = new System.Windows.Forms.Padding(1);
            this.bypassButton.Name = "bypassButton";
            this.bypassButton.Padding = new System.Windows.Forms.Padding(8);
            this.bypassButton.Size = new System.Drawing.Size(157, 61);
            this.bypassButton.TabIndex = 84;
            this.bypassButton.Text = "BYPASS";
            this.bypassButton.UseVisualStyleBackColor = false;
            this.bypassButton.Click += new System.EventHandler(this.bypassButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.doneButton);
            this.groupBox3.Controls.Add(this.bypassButton);
            this.groupBox3.Controls.Add(this.buttonPass);
            this.groupBox3.Location = new System.Drawing.Point(1, 288);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox3.Size = new System.Drawing.Size(353, 120);
            this.groupBox3.TabIndex = 87;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TRYB PRACY";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(1, 121);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 50);
            this.panel4.TabIndex = 92;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(0, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 44);
            this.button1.TabIndex = 87;
            this.button1.Text = "NIE WYKRYTO PŁYTKI";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonPosRefr);
            this.groupBox4.Controls.Add(this.textBoxCurPos);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.buttonZast);
            this.groupBox4.Controls.Add(this.czasWypalaniaProf);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.pozycjaZadProf);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(1, 156);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox4.Size = new System.Drawing.Size(353, 130);
            this.groupBox4.TabIndex = 88;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "USTAWIENIA STOPERA";
            // 
            // buttonPosRefr
            // 
            this.buttonPosRefr.Enabled = false;
            this.buttonPosRefr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonPosRefr.Location = new System.Drawing.Point(6, 33);
            this.buttonPosRefr.Name = "buttonPosRefr";
            this.buttonPosRefr.Size = new System.Drawing.Size(76, 47);
            this.buttonPosRefr.TabIndex = 87;
            this.buttonPosRefr.Text = "Odśwież pozycję";
            this.buttonPosRefr.UseVisualStyleBackColor = true;
            this.buttonPosRefr.Click += new System.EventHandler(this.buttonPosRefr_Click);
            // 
            // textBoxCurPos
            // 
            this.textBoxCurPos.Enabled = false;
            this.textBoxCurPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCurPos.Location = new System.Drawing.Point(208, 23);
            this.textBoxCurPos.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxCurPos.Name = "textBoxCurPos";
            this.textBoxCurPos.Size = new System.Drawing.Size(57, 23);
            this.textBoxCurPos.TabIndex = 86;
            this.textBoxCurPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(89, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "Aktualna pozycja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(264, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "mm";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.buttonRefresh);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.textBoxConnection);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.buttonResetEZCAD);
            this.groupBox5.Controls.Add(this.buttonConnect);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Location = new System.Drawing.Point(1, 1);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox5.Size = new System.Drawing.Size(353, 153);
            this.groupBox5.TabIndex = 89;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "POŁĄCZENIE";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(5, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 77;
            this.label7.Text = "Port skan:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(93, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(68, 21);
            this.comboBox2.TabIndex = 78;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBoxArmed);
            this.panel3.Location = new System.Drawing.Point(1, 481);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 50);
            this.panel3.TabIndex = 90;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox6);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.richTextBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 450);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(357, 704);
            this.flowLayoutPanel1.TabIndex = 91;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBoxLiczMno);
            this.groupBox6.Controls.Add(this.groupBoxLiczIlo);
            this.groupBox6.Controls.Add(this.checkBoxLicznik);
            this.groupBox6.Location = new System.Drawing.Point(3, 412);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(350, 65);
            this.groupBox6.TabIndex = 95;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "LICZNIK PŁYTEK";
            // 
            // groupBoxLiczMno
            // 
            this.groupBoxLiczMno.Controls.Add(this.label6);
            this.groupBoxLiczMno.Controls.Add(this.numericUpDownLicznikMnoznik);
            this.groupBoxLiczMno.Enabled = false;
            this.groupBoxLiczMno.Location = new System.Drawing.Point(201, 11);
            this.groupBoxLiczMno.Name = "groupBoxLiczMno";
            this.groupBoxLiczMno.Size = new System.Drawing.Size(140, 47);
            this.groupBoxLiczMno.TabIndex = 6;
            this.groupBoxLiczMno.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(15, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "MNOŻNIK";
            // 
            // numericUpDownLicznikMnoznik
            // 
            this.numericUpDownLicznikMnoznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.numericUpDownLicznikMnoznik.Location = new System.Drawing.Point(94, 15);
            this.numericUpDownLicznikMnoznik.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownLicznikMnoznik.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLicznikMnoznik.Name = "numericUpDownLicznikMnoznik";
            this.numericUpDownLicznikMnoznik.Size = new System.Drawing.Size(36, 22);
            this.numericUpDownLicznikMnoznik.TabIndex = 4;
            this.numericUpDownLicznikMnoznik.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLicznikMnoznik.ValueChanged += new System.EventHandler(this.numericUpDownLicznikMnoznik_ValueChanged);
            // 
            // groupBoxLiczIlo
            // 
            this.groupBoxLiczIlo.Controls.Add(this.label4);
            this.groupBoxLiczIlo.Controls.Add(this.numericUpDownLicznik);
            this.groupBoxLiczIlo.Enabled = false;
            this.groupBoxLiczIlo.Location = new System.Drawing.Point(48, 12);
            this.groupBoxLiczIlo.Name = "groupBoxLiczIlo";
            this.groupBoxLiczIlo.Size = new System.Drawing.Size(136, 47);
            this.groupBoxLiczIlo.TabIndex = 5;
            this.groupBoxLiczIlo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "ILOŚĆ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUpDownLicznik
            // 
            this.numericUpDownLicznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.numericUpDownLicznik.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownLicznik.Location = new System.Drawing.Point(73, 15);
            this.numericUpDownLicznik.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownLicznik.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownLicznik.Name = "numericUpDownLicznik";
            this.numericUpDownLicznik.Size = new System.Drawing.Size(53, 22);
            this.numericUpDownLicznik.TabIndex = 2;
            this.numericUpDownLicznik.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownLicznik.ValueChanged += new System.EventHandler(this.numericUpDownLicznik_ValueChanged);
            // 
            // checkBoxLicznik
            // 
            this.checkBoxLicznik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxLicznik.AutoSize = true;
            this.checkBoxLicznik.Location = new System.Drawing.Point(18, 31);
            this.checkBoxLicznik.Name = "checkBoxLicznik";
            this.checkBoxLicznik.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLicznik.TabIndex = 1;
            this.checkBoxLicznik.UseVisualStyleBackColor = true;
            this.checkBoxLicznik.CheckedChanged += new System.EventHandler(this.checkBoxLicznik_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 535);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(352, 162);
            this.richTextBox1.TabIndex = 96;
            this.richTextBox1.Text = "";
            // 
            // serialPortSkaner
            // 
            this.serialPortSkaner.BaudRate = 115200;
            this.serialPortSkaner.RtsEnable = true;
            this.serialPortSkaner.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortSkaner_DataReceived);
            // 
            // timerSkaner
            // 
            this.timerSkaner.Interval = 300;
            this.timerSkaner.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 726);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(351, 376);
            this.Name = "Form1";
            this.Text = "Sterowanie SMT STOPPER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjaZadProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czasWypalaniaProf)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBoxLiczMno.ResumeLayout(false);
            this.groupBoxLiczMno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLicznikMnoznik)).EndInit();
            this.groupBoxLiczIlo.ResumeLayout(false);
            this.groupBoxLiczIlo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLicznik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.CheckBox checkBoxArmed;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonZast;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown pozycjaZadProf;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown czasWypalaniaProf;
        private System.Windows.Forms.Button buttonResetEZCAD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEzcad;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConnection;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonPass;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button bypassButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCurPos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonPosRefr;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxLicznik;
        private System.Windows.Forms.NumericUpDown numericUpDownLicznikMnoznik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownLicznik;
        private System.Windows.Forms.GroupBox groupBoxLiczMno;
        private System.Windows.Forms.GroupBox groupBoxLiczIlo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.IO.Ports.SerialPort serialPortSkaner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Timer timerSkaner;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

