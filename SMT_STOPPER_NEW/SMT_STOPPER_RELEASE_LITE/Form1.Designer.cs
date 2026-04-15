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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxConnection = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCurPos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bypassButton = new System.Windows.Forms.Button();
            this.newPos = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.Move_Pos = new System.Windows.Forms.Button();
            this.buttonBackward = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.czasWypalania = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxProfile = new System.Windows.Forms.ComboBox();
            this.buttonRefrProf = new System.Windows.Forms.Button();
            this.buttonLoadProf = new System.Windows.Forms.Button();
            this.buttonPass = new System.Windows.Forms.Button();
            this.buttonSaveProf = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConn = new System.Windows.Forms.TabPage();
            this.buttonResetEZCAD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEzcad = new System.Windows.Forms.Label();
            this.tabPageProf = new System.Windows.Forms.TabPage();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonFilePath = new System.Windows.Forms.Button();
            this.textBoxNewProfName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pozycjaZadProf = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.czasWypalaniaProf = new System.Windows.Forms.NumericUpDown();
            this.tabPageSter = new System.Windows.Forms.TabPage();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxArmed = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.newPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czasWypalania)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageConn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageProf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjaZadProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czasWypalaniaProf)).BeginInit();
            this.tabPageSter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonRefresh.Location = new System.Drawing.Point(358, 14);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(203, 71);
            this.buttonRefresh.TabIndex = 20;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 31);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 39);
            this.comboBox1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(13, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 39);
            this.label5.TabIndex = 18;
            this.label5.Text = "Port:";
            // 
            // textBoxConnection
            // 
            this.textBoxConnection.Enabled = false;
            this.textBoxConnection.Location = new System.Drawing.Point(358, 116);
            this.textBoxConnection.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxConnection.Name = "textBoxConnection";
            this.textBoxConnection.Size = new System.Drawing.Size(206, 38);
            this.textBoxConnection.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Stan połączenia:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonConnect.Location = new System.Drawing.Point(15, 181);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(549, 81);
            this.buttonConnect.TabIndex = 15;
            this.buttonConnect.Text = "Otwórz";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(482, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 39);
            this.label6.TabIndex = 24;
            this.label6.Text = "mm";
            // 
            // textBoxCurPos
            // 
            this.textBoxCurPos.Enabled = false;
            this.textBoxCurPos.Location = new System.Drawing.Point(298, 138);
            this.textBoxCurPos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxCurPos.Name = "textBoxCurPos";
            this.textBoxCurPos.Size = new System.Drawing.Size(180, 38);
            this.textBoxCurPos.TabIndex = 23;
            this.textBoxCurPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(2, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 39);
            this.label3.TabIndex = 22;
            this.label3.Text = "Aktualna pozycja:";
            // 
            // bypassButton
            // 
            this.bypassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bypassButton.Location = new System.Drawing.Point(9, 534);
            this.bypassButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bypassButton.Name = "bypassButton";
            this.bypassButton.Size = new System.Drawing.Size(549, 85);
            this.bypassButton.TabIndex = 34;
            this.bypassButton.Text = "TRYB BYPASS";
            this.bypassButton.UseVisualStyleBackColor = true;
            this.bypassButton.Click += new System.EventHandler(this.bypassButton_Click);
            // 
            // newPos
            // 
            this.newPos.DecimalPlaces = 2;
            this.newPos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.newPos.Location = new System.Drawing.Point(298, 191);
            this.newPos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.newPos.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.newPos.Name = "newPos";
            this.newPos.Size = new System.Drawing.Size(180, 38);
            this.newPos.TabIndex = 41;
            this.newPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.newPos.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(482, 191);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 39);
            this.label10.TabIndex = 40;
            this.label10.Text = "mm";
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.homeButton.Location = new System.Drawing.Point(9, 369);
            this.homeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(549, 81);
            this.homeButton.TabIndex = 39;
            this.homeButton.Text = "Ustaw pozycję HOME";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // Move_Pos
            // 
            this.Move_Pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Move_Pos.Location = new System.Drawing.Point(9, 274);
            this.Move_Pos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Move_Pos.Name = "Move_Pos";
            this.Move_Pos.Size = new System.Drawing.Size(549, 81);
            this.Move_Pos.TabIndex = 38;
            this.Move_Pos.Text = "Ruch do pozycji";
            this.Move_Pos.UseVisualStyleBackColor = true;
            this.Move_Pos.Click += new System.EventHandler(this.Move_Pos_Click);
            // 
            // buttonBackward
            // 
            this.buttonBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackward.Location = new System.Drawing.Point(11, 10);
            this.buttonBackward.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(260, 103);
            this.buttonBackward.TabIndex = 36;
            this.buttonBackward.Text = "<";
            this.buttonBackward.UseVisualStyleBackColor = true;
            this.buttonBackward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBackward_MouseDown);
            this.buttonBackward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonBackward_MouseUp);
            // 
            // buttonForward
            // 
            this.buttonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonForward.Location = new System.Drawing.Point(300, 10);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(260, 104);
            this.buttonForward.TabIndex = 35;
            this.buttonForward.Text = ">";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonForward_MouseDown);
            this.buttonForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonForward_MouseUp);
            // 
            // doneButton
            // 
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.doneButton.Location = new System.Drawing.Point(9, 641);
            this.doneButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(546, 86);
            this.doneButton.TabIndex = 42;
            this.doneButton.Text = "TRYB AUTOMATYCZNY";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // czasWypalania
            // 
            this.czasWypalania.DecimalPlaces = 2;
            this.czasWypalania.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.czasWypalania.Location = new System.Drawing.Point(287, 476);
            this.czasWypalania.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.czasWypalania.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.czasWypalania.Name = "czasWypalania";
            this.czasWypalania.Size = new System.Drawing.Size(178, 38);
            this.czasWypalania.TabIndex = 43;
            this.czasWypalania.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.czasWypalania.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.czasWypalania.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.czasWypalania.ValueChanged += new System.EventHandler(this.czasWypalania_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(1, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 39);
            this.label4.TabIndex = 37;
            this.label4.Text = "Do pozycji:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(1, 473);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 39);
            this.label2.TabIndex = 44;
            this.label2.Text = "Czas wypalania:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(481, 473);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 39);
            this.label7.TabIndex = 45;
            this.label7.Text = "s";
            // 
            // comboBoxProfile
            // 
            this.comboBoxProfile.FormattingEnabled = true;
            this.comboBoxProfile.Location = new System.Drawing.Point(16, 48);
            this.comboBoxProfile.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxProfile.Name = "comboBoxProfile";
            this.comboBoxProfile.Size = new System.Drawing.Size(544, 39);
            this.comboBoxProfile.TabIndex = 62;
            // 
            // buttonRefrProf
            // 
            this.buttonRefrProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRefrProf.Location = new System.Drawing.Point(16, 101);
            this.buttonRefrProf.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonRefrProf.Name = "buttonRefrProf";
            this.buttonRefrProf.Size = new System.Drawing.Size(260, 81);
            this.buttonRefrProf.TabIndex = 48;
            this.buttonRefrProf.Text = "Odśwież";
            this.buttonRefrProf.UseVisualStyleBackColor = true;
            this.buttonRefrProf.Click += new System.EventHandler(this.buttonRefrProf_Click);
            // 
            // buttonLoadProf
            // 
            this.buttonLoadProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonLoadProf.Location = new System.Drawing.Point(305, 101);
            this.buttonLoadProf.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonLoadProf.Name = "buttonLoadProf";
            this.buttonLoadProf.Size = new System.Drawing.Size(260, 81);
            this.buttonLoadProf.TabIndex = 49;
            this.buttonLoadProf.Text = "Załaduj ";
            this.buttonLoadProf.UseVisualStyleBackColor = true;
            this.buttonLoadProf.Click += new System.EventHandler(this.buttonLoadProf_Click);
            // 
            // buttonPass
            // 
            this.buttonPass.Enabled = false;
            this.buttonPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonPass.Location = new System.Drawing.Point(11, 746);
            this.buttonPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPass.Name = "buttonPass";
            this.buttonPass.Size = new System.Drawing.Size(546, 86);
            this.buttonPass.TabIndex = 50;
            this.buttonPass.Text = "PASS";
            this.buttonPass.UseVisualStyleBackColor = true;
            this.buttonPass.Click += new System.EventHandler(this.buttonPass_Click);
            // 
            // buttonSaveProf
            // 
            this.buttonSaveProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSaveProf.Location = new System.Drawing.Point(23, 108);
            this.buttonSaveProf.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSaveProf.Name = "buttonSaveProf";
            this.buttonSaveProf.Size = new System.Drawing.Size(544, 81);
            this.buttonSaveProf.TabIndex = 51;
            this.buttonSaveProf.Text = "Zapisz jako nowy";
            this.buttonSaveProf.UseVisualStyleBackColor = true;
            this.buttonSaveProf.Click += new System.EventHandler(this.buttonSaveProf_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusStripLabel});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 1296);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(10);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 54);
            this.statusStrip1.TabIndex = 52;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(105, 41);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(237, 41);
            this.statusStripLabel.Spring = true;
            this.statusStripLabel.Text = "toolStripStatusLabel2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageConn);
            this.tabControl1.Controls.Add(this.tabPageProf);
            this.tabControl1.Controls.Add(this.tabPageSter);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 1076);
            this.tabControl1.TabIndex = 54;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageConn
            // 
            this.tabPageConn.Controls.Add(this.buttonResetEZCAD);
            this.tabPageConn.Controls.Add(this.panel1);
            this.tabPageConn.Controls.Add(this.buttonConnect);
            this.tabPageConn.Controls.Add(this.label1);
            this.tabPageConn.Controls.Add(this.textBoxConnection);
            this.tabPageConn.Controls.Add(this.comboBox1);
            this.tabPageConn.Controls.Add(this.label5);
            this.tabPageConn.Controls.Add(this.buttonRefresh);
            this.tabPageConn.Location = new System.Drawing.Point(10, 48);
            this.tabPageConn.Name = "tabPageConn";
            this.tabPageConn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConn.Size = new System.Drawing.Size(578, 1018);
            this.tabPageConn.TabIndex = 0;
            this.tabPageConn.Text = "Połączenie";
            this.tabPageConn.UseVisualStyleBackColor = true;
            // 
            // buttonResetEZCAD
            // 
            this.buttonResetEZCAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonResetEZCAD.Location = new System.Drawing.Point(15, 509);
            this.buttonResetEZCAD.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonResetEZCAD.Name = "buttonResetEZCAD";
            this.buttonResetEZCAD.Size = new System.Drawing.Size(549, 81);
            this.buttonResetEZCAD.TabIndex = 22;
            this.buttonResetEZCAD.Text = "Reset przechwycania EZCAD";
            this.buttonResetEZCAD.UseVisualStyleBackColor = true;
            this.buttonResetEZCAD.Click += new System.EventHandler(this.buttonResetEZCAD_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelEzcad);
            this.panel1.Location = new System.Drawing.Point(20, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 181);
            this.panel1.TabIndex = 21;
            // 
            // labelEzcad
            // 
            this.labelEzcad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelEzcad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEzcad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEzcad.Location = new System.Drawing.Point(0, 0);
            this.labelEzcad.Name = "labelEzcad";
            this.labelEzcad.Size = new System.Drawing.Size(541, 181);
            this.labelEzcad.TabIndex = 0;
            this.labelEzcad.Text = "PROSZĘ OTWORZYĆ OKNO EZCAD ";
            this.labelEzcad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageProf
            // 
            this.tabPageProf.Controls.Add(this.groupBox2);
            this.tabPageProf.Controls.Add(this.groupBox1);
            this.tabPageProf.Controls.Add(this.buttonApply);
            this.tabPageProf.Controls.Add(this.label9);
            this.tabPageProf.Controls.Add(this.label11);
            this.tabPageProf.Controls.Add(this.pozycjaZadProf);
            this.tabPageProf.Controls.Add(this.label12);
            this.tabPageProf.Controls.Add(this.label13);
            this.tabPageProf.Controls.Add(this.czasWypalaniaProf);
            this.tabPageProf.Location = new System.Drawing.Point(10, 48);
            this.tabPageProf.Name = "tabPageProf";
            this.tabPageProf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProf.Size = new System.Drawing.Size(578, 1018);
            this.tabPageProf.TabIndex = 2;
            this.tabPageProf.Text = "Wybór profilu";
            this.tabPageProf.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonApply.Location = new System.Drawing.Point(18, 159);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(544, 81);
            this.buttonApply.TabIndex = 64;
            this.buttonApply.Text = "Zastosouj ustawienia";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.ButtonApply);
            // 
            // buttonFilePath
            // 
            this.buttonFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonFilePath.Location = new System.Drawing.Point(16, 196);
            this.buttonFilePath.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonFilePath.Name = "buttonFilePath";
            this.buttonFilePath.Size = new System.Drawing.Size(544, 81);
            this.buttonFilePath.TabIndex = 63;
            this.buttonFilePath.Text = "Wybierz plik";
            this.buttonFilePath.UseVisualStyleBackColor = true;
            this.buttonFilePath.Click += new System.EventHandler(this.buttonFilePath_Click);
            // 
            // textBoxNewProfName
            // 
            this.textBoxNewProfName.Location = new System.Drawing.Point(158, 64);
            this.textBoxNewProfName.Name = "textBoxNewProfName";
            this.textBoxNewProfName.Size = new System.Drawing.Size(411, 38);
            this.textBoxNewProfName.TabIndex = 62;
            this.textBoxNewProfName.Text = "Wpisz nazwę dla nowego profilu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(16, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 39);
            this.label14.TabIndex = 61;
            this.label14.Text = "Nazwa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(11, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 39);
            this.label9.TabIndex = 58;
            this.label9.Text = "Do pozycji:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(491, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 39);
            this.label11.TabIndex = 59;
            this.label11.Text = "mm";
            // 
            // pozycjaZadProf
            // 
            this.pozycjaZadProf.DecimalPlaces = 2;
            this.pozycjaZadProf.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.pozycjaZadProf.Location = new System.Drawing.Point(297, 20);
            this.pozycjaZadProf.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pozycjaZadProf.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.pozycjaZadProf.Name = "pozycjaZadProf";
            this.pozycjaZadProf.Size = new System.Drawing.Size(178, 38);
            this.pozycjaZadProf.TabIndex = 60;
            this.pozycjaZadProf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pozycjaZadProf.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.pozycjaZadProf.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(491, 71);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 39);
            this.label12.TabIndex = 57;
            this.label12.Text = "s";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(11, 71);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(266, 39);
            this.label13.TabIndex = 56;
            this.label13.Text = "Czas wypalania:";
            // 
            // czasWypalaniaProf
            // 
            this.czasWypalaniaProf.DecimalPlaces = 2;
            this.czasWypalaniaProf.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.czasWypalaniaProf.Location = new System.Drawing.Point(297, 74);
            this.czasWypalaniaProf.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.czasWypalaniaProf.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.czasWypalaniaProf.Name = "czasWypalaniaProf";
            this.czasWypalaniaProf.Size = new System.Drawing.Size(178, 38);
            this.czasWypalaniaProf.TabIndex = 61;
            this.czasWypalaniaProf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.czasWypalaniaProf.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.czasWypalaniaProf.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tabPageSter
            // 
            this.tabPageSter.Controls.Add(this.buttonBackward);
            this.tabPageSter.Controls.Add(this.label3);
            this.tabPageSter.Controls.Add(this.textBoxCurPos);
            this.tabPageSter.Controls.Add(this.label6);
            this.tabPageSter.Controls.Add(this.buttonPass);
            this.tabPageSter.Controls.Add(this.buttonForward);
            this.tabPageSter.Controls.Add(this.label4);
            this.tabPageSter.Controls.Add(this.Move_Pos);
            this.tabPageSter.Controls.Add(this.homeButton);
            this.tabPageSter.Controls.Add(this.label10);
            this.tabPageSter.Controls.Add(this.doneButton);
            this.tabPageSter.Controls.Add(this.label7);
            this.tabPageSter.Controls.Add(this.bypassButton);
            this.tabPageSter.Controls.Add(this.newPos);
            this.tabPageSter.Controls.Add(this.label2);
            this.tabPageSter.Controls.Add(this.czasWypalania);
            this.tabPageSter.Location = new System.Drawing.Point(10, 48);
            this.tabPageSter.Name = "tabPageSter";
            this.tabPageSter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSter.Size = new System.Drawing.Size(578, 1018);
            this.tabPageSter.TabIndex = 1;
            this.tabPageSter.Text = "Zaawans.";
            this.tabPageSter.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(3, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(293, 94);
            this.buttonStart.TabIndex = 55;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStop.Enabled = false;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonStop.Location = new System.Drawing.Point(302, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(293, 94);
            this.buttonStop.TabIndex = 56;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonStop, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonStart, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1196);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 100);
            this.tableLayoutPanel1.TabIndex = 55;
            // 
            // checkBoxArmed
            // 
            this.checkBoxArmed.AutoSize = true;
            this.checkBoxArmed.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBoxArmed.Enabled = false;
            this.checkBoxArmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxArmed.Location = new System.Drawing.Point(0, 0);
            this.checkBoxArmed.Name = "checkBoxArmed";
            this.checkBoxArmed.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.checkBoxArmed.Size = new System.Drawing.Size(487, 100);
            this.checkBoxArmed.TabIndex = 56;
            this.checkBoxArmed.Text = "WYZWALANIE LASERA";
            this.checkBoxArmed.UseVisualStyleBackColor = true;
            this.checkBoxArmed.CheckedChanged += new System.EventHandler(this.checkBoxArmed_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxArmed);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1096);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 100);
            this.panel2.TabIndex = 57;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xlsx";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveProf);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBoxNewProfName);
            this.groupBox1.Location = new System.Drawing.Point(3, 667);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 218);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tworzenie nowego profilu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFilePath);
            this.groupBox2.Controls.Add(this.buttonLoadProf);
            this.groupBox2.Controls.Add(this.buttonRefrProf);
            this.groupBox2.Controls.Add(this.comboBoxProfile);
            this.groupBox2.Location = new System.Drawing.Point(2, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 297);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybór profilu z pliku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(598, 1350);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Sterowanie SMT STOPPER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czasWypalania)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageConn.ResumeLayout(false);
            this.tabPageConn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPageProf.ResumeLayout(false);
            this.tabPageProf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjaZadProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czasWypalaniaProf)).EndInit();
            this.tabPageSter.ResumeLayout(false);
            this.tabPageSter.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCurPos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bypassButton;
        private System.Windows.Forms.NumericUpDown newPos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button Move_Pos;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button doneButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown czasWypalania;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxProfile;
        private System.Windows.Forms.Button buttonRefrProf;
        private System.Windows.Forms.Button buttonLoadProf;
        private System.Windows.Forms.Button buttonPass;
        private System.Windows.Forms.Button buttonSaveProf;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConn;
        private System.Windows.Forms.TabPage tabPageSter;
        private System.Windows.Forms.TabPage tabPageProf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown pozycjaZadProf;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown czasWypalaniaProf;
        private System.Windows.Forms.TextBox textBoxNewProfName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEzcad;
        private System.Windows.Forms.CheckBox checkBoxArmed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonFilePath;
        private System.Windows.Forms.Button buttonResetEZCAD;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

