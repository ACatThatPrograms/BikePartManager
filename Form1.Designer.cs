namespace BikePartManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PartNameLabel = new System.Windows.Forms.Label();
            this.PartTypeLabel = new System.Windows.Forms.Label();
            this.PartTypeDropDown = new System.Windows.Forms.ComboBox();
            this.PartNameBox = new System.Windows.Forms.TextBox();
            this.PartManuLabel = new System.Windows.Forms.Label();
            this.MfgDropDown = new System.Windows.Forms.ComboBox();
            this.YearsDropdown = new System.Windows.Forms.ComboBox();
            this.yearOfMfgLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ebaySalePriceLabel = new System.Windows.Forms.Label();
            this.ebayPriceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AvgSaleReturn = new System.Windows.Forms.TextBox();
            this.addPartButton = new System.Windows.Forms.Button();
            this.typeFetchAvg = new System.Windows.Forms.ComboBox();
            this.mfgFetchAvg = new System.Windows.Forms.ComboBox();
            this.yearFetchAvg = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PartListBox = new System.Windows.Forms.ListBox();
            this.updatePartButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.delPartButton = new System.Windows.Forms.Button();
            this.initInv = new System.Windows.Forms.TextBox();
            this.investLabel = new System.Windows.Forms.Label();
            this.breakEvLabel = new System.Windows.Forms.Label();
            this.brkEvenCount = new System.Windows.Forms.Label();
            this.avgBreakEven = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PartNameLabel
            // 
            this.PartNameLabel.AutoSize = true;
            this.PartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNameLabel.Location = new System.Drawing.Point(12, 64);
            this.PartNameLabel.Name = "PartNameLabel";
            this.PartNameLabel.Size = new System.Drawing.Size(98, 20);
            this.PartNameLabel.TabIndex = 0;
            this.PartNameLabel.Text = "Part Name:";
            this.PartNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PartTypeLabel
            // 
            this.PartTypeLabel.AutoSize = true;
            this.PartTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartTypeLabel.Location = new System.Drawing.Point(289, 64);
            this.PartTypeLabel.Name = "PartTypeLabel";
            this.PartTypeLabel.Size = new System.Drawing.Size(90, 20);
            this.PartTypeLabel.TabIndex = 1;
            this.PartTypeLabel.Text = "Part Type:";
            // 
            // PartTypeDropDown
            // 
            this.PartTypeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartTypeDropDown.FormattingEnabled = true;
            this.PartTypeDropDown.Items.AddRange(new object[] {
            "Carbeurator",
            "Engine Block",
            "Fairing",
            "Gas Tank",
            "Seat",
            "Shock(s)"});
            this.PartTypeDropDown.Location = new System.Drawing.Point(393, 64);
            this.PartTypeDropDown.Name = "PartTypeDropDown";
            this.PartTypeDropDown.Size = new System.Drawing.Size(113, 21);
            this.PartTypeDropDown.TabIndex = 3;
            // 
            // PartNameBox
            // 
            this.PartNameBox.Location = new System.Drawing.Point(116, 64);
            this.PartNameBox.Name = "PartNameBox";
            this.PartNameBox.Size = new System.Drawing.Size(167, 20);
            this.PartNameBox.TabIndex = 4;
            this.PartNameBox.TextChanged += new System.EventHandler(this.PartNameBox_TextChanged);
            // 
            // PartManuLabel
            // 
            this.PartManuLabel.AutoSize = true;
            this.PartManuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartManuLabel.Location = new System.Drawing.Point(266, 96);
            this.PartManuLabel.Name = "PartManuLabel";
            this.PartManuLabel.Size = new System.Drawing.Size(121, 20);
            this.PartManuLabel.TabIndex = 5;
            this.PartManuLabel.Text = "Manufacturer:";
            this.PartManuLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // MfgDropDown
            // 
            this.MfgDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MfgDropDown.FormattingEnabled = true;
            this.MfgDropDown.Items.AddRange(new object[] {
            "Honda",
            "Indian",
            "Kawasaki",
            "Suzuki",
            "Yahama"});
            this.MfgDropDown.Location = new System.Drawing.Point(393, 98);
            this.MfgDropDown.Name = "MfgDropDown";
            this.MfgDropDown.Size = new System.Drawing.Size(113, 21);
            this.MfgDropDown.TabIndex = 6;
            // 
            // YearsDropdown
            // 
            this.YearsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearsDropdown.FormattingEnabled = true;
            this.YearsDropdown.Items.AddRange(new object[] {
            "1950 - 1959",
            "1960 - 1969",
            "1970 - 1979",
            "1980 - 1989",
            "1990 - 2000",
            "2000 - 2009"});
            this.YearsDropdown.Location = new System.Drawing.Point(159, 95);
            this.YearsDropdown.Name = "YearsDropdown";
            this.YearsDropdown.Size = new System.Drawing.Size(101, 21);
            this.YearsDropdown.TabIndex = 8;
            // 
            // yearOfMfgLabel
            // 
            this.yearOfMfgLabel.AutoSize = true;
            this.yearOfMfgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearOfMfgLabel.Location = new System.Drawing.Point(12, 96);
            this.yearOfMfgLabel.Name = "yearOfMfgLabel";
            this.yearOfMfgLabel.Size = new System.Drawing.Size(103, 20);
            this.yearOfMfgLabel.TabIndex = 7;
            this.yearOfMfgLabel.Text = "Year of Mfg";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1138, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(90, 22);
            this.toolStripButton1.Text = "Load Inventory";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(88, 22);
            this.toolStripButton2.Text = "Save Inventory";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ebaySalePriceLabel
            // 
            this.ebaySalePriceLabel.AutoSize = true;
            this.ebaySalePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ebaySalePriceLabel.Location = new System.Drawing.Point(12, 125);
            this.ebaySalePriceLabel.Name = "ebaySalePriceLabel";
            this.ebaySalePriceLabel.Size = new System.Drawing.Size(95, 20);
            this.ebaySalePriceLabel.TabIndex = 12;
            this.ebaySalePriceLabel.Text = "Sale Price:";
            this.ebaySalePriceLabel.Click += new System.EventHandler(this.ebaySalePriceLabel_Click);
            // 
            // ebayPriceBox
            // 
            this.ebayPriceBox.Location = new System.Drawing.Point(159, 127);
            this.ebayPriceBox.MaxLength = 6;
            this.ebayPriceBox.Name = "ebayPriceBox";
            this.ebayPriceBox.Size = new System.Drawing.Size(101, 20);
            this.ebayPriceBox.TabIndex = 13;
            this.ebayPriceBox.Text = "0.00";
            this.ebayPriceBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Average Sale Price By...";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // AvgSaleReturn
            // 
            this.AvgSaleReturn.Location = new System.Drawing.Point(1033, 94);
            this.AvgSaleReturn.MaxLength = 6;
            this.AvgSaleReturn.Name = "AvgSaleReturn";
            this.AvgSaleReturn.ReadOnly = true;
            this.AvgSaleReturn.Size = new System.Drawing.Size(75, 20);
            this.AvgSaleReturn.TabIndex = 15;
            this.AvgSaleReturn.Text = "0.00";
            this.AvgSaleReturn.TextChanged += new System.EventHandler(this.AvgSaleReturn_TextChanged);
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(270, 126);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(64, 23);
            this.addPartButton.TabIndex = 16;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // typeFetchAvg
            // 
            this.typeFetchAvg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeFetchAvg.FormattingEnabled = true;
            this.typeFetchAvg.Items.AddRange(new object[] {
            "",
            "Carbeurator",
            "Engine Block",
            "Fairing",
            "Gas Tank",
            "Seat",
            "Shock(s)"});
            this.typeFetchAvg.Location = new System.Drawing.Point(903, 63);
            this.typeFetchAvg.Name = "typeFetchAvg";
            this.typeFetchAvg.Size = new System.Drawing.Size(113, 21);
            this.typeFetchAvg.TabIndex = 17;
            // 
            // mfgFetchAvg
            // 
            this.mfgFetchAvg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mfgFetchAvg.FormattingEnabled = true;
            this.mfgFetchAvg.Items.AddRange(new object[] {
            "",
            "Honda",
            "Indian",
            "Kawasaki",
            "Suzuki",
            "Yahama"});
            this.mfgFetchAvg.Location = new System.Drawing.Point(903, 93);
            this.mfgFetchAvg.Name = "mfgFetchAvg";
            this.mfgFetchAvg.Size = new System.Drawing.Size(113, 21);
            this.mfgFetchAvg.TabIndex = 18;
            // 
            // yearFetchAvg
            // 
            this.yearFetchAvg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearFetchAvg.FormattingEnabled = true;
            this.yearFetchAvg.Items.AddRange(new object[] {
            "",
            "1950 - 1959",
            "1960 - 1969",
            "1970 - 1979",
            "1980 - 1989",
            "1990 - 2000",
            "2000 - 2009"});
            this.yearFetchAvg.Location = new System.Drawing.Point(903, 123);
            this.yearFetchAvg.Name = "yearFetchAvg";
            this.yearFetchAvg.Size = new System.Drawing.Size(113, 21);
            this.yearFetchAvg.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(776, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Manufacturer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(845, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(845, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Year:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1033, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Get Average";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // PartListBox
            // 
            this.PartListBox.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartListBox.FormattingEnabled = true;
            this.PartListBox.ItemHeight = 17;
            this.PartListBox.Location = new System.Drawing.Point(16, 186);
            this.PartListBox.Name = "PartListBox";
            this.PartListBox.Size = new System.Drawing.Size(883, 174);
            this.PartListBox.TabIndex = 24;
            this.PartListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // updatePartButton
            // 
            this.updatePartButton.Location = new System.Drawing.Point(393, 126);
            this.updatePartButton.Name = "updatePartButton";
            this.updatePartButton.Size = new System.Drawing.Size(117, 23);
            this.updatePartButton.TabIndex = 25;
            this.updatePartButton.Text = "Update Part";
            this.updatePartButton.UseVisualStyleBackColor = true;
            this.updatePartButton.Click += new System.EventHandler(this.updatePartButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(13, 170);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Name";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel2.Location = new System.Drawing.Point(197, 170);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(31, 13);
            this.linkLabel2.TabIndex = 27;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Type";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel3.Location = new System.Drawing.Point(379, 170);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(70, 13);
            this.linkLabel3.TabIndex = 28;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Manufacturer";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel4.Location = new System.Drawing.Point(558, 170);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(56, 13);
            this.linkLabel4.TabIndex = 29;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Mfg Dates";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel5.Location = new System.Drawing.Point(737, 170);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(82, 13);
            this.linkLabel5.TabIndex = 30;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Ebay Sale Price";
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // delPartButton
            // 
            this.delPartButton.Location = new System.Drawing.Point(340, 126);
            this.delPartButton.Name = "delPartButton";
            this.delPartButton.Size = new System.Drawing.Size(39, 23);
            this.delPartButton.TabIndex = 31;
            this.delPartButton.Text = "Del";
            this.delPartButton.UseVisualStyleBackColor = true;
            this.delPartButton.Click += new System.EventHandler(this.delPartButton_Click);
            // 
            // initInv
            // 
            this.initInv.Location = new System.Drawing.Point(289, 35);
            this.initInv.Name = "initInv";
            this.initInv.Size = new System.Drawing.Size(98, 20);
            this.initInv.TabIndex = 32;
            this.initInv.Text = "0";
            this.initInv.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // investLabel
            // 
            this.investLabel.AutoSize = true;
            this.investLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investLabel.Location = new System.Drawing.Point(171, 35);
            this.investLabel.Name = "investLabel";
            this.investLabel.Size = new System.Drawing.Size(112, 20);
            this.investLabel.TabIndex = 33;
            this.investLabel.Text = "Initial Invest:";
            // 
            // breakEvLabel
            // 
            this.breakEvLabel.AutoSize = true;
            this.breakEvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakEvLabel.Location = new System.Drawing.Point(901, 237);
            this.breakEvLabel.Name = "breakEvLabel";
            this.breakEvLabel.Size = new System.Drawing.Size(181, 20);
            this.breakEvLabel.TabIndex = 34;
            this.breakEvLabel.Text = "Current Break Even #";
            // 
            // brkEvenCount
            // 
            this.brkEvenCount.AutoSize = true;
            this.brkEvenCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brkEvenCount.Location = new System.Drawing.Point(1087, 237);
            this.brkEvenCount.Name = "brkEvenCount";
            this.brkEvenCount.Size = new System.Drawing.Size(19, 20);
            this.brkEvenCount.TabIndex = 35;
            this.brkEvenCount.Text = "0";
            // 
            // avgBreakEven
            // 
            this.avgBreakEven.AutoSize = true;
            this.avgBreakEven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgBreakEven.Location = new System.Drawing.Point(1087, 195);
            this.avgBreakEven.Name = "avgBreakEven";
            this.avgBreakEven.Size = new System.Drawing.Size(19, 20);
            this.avgBreakEven.TabIndex = 37;
            this.avgBreakEven.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(930, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Avg Break Even #";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1138, 370);
            this.Controls.Add(this.avgBreakEven);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.brkEvenCount);
            this.Controls.Add(this.breakEvLabel);
            this.Controls.Add(this.investLabel);
            this.Controls.Add(this.initInv);
            this.Controls.Add(this.delPartButton);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.updatePartButton);
            this.Controls.Add(this.PartListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearFetchAvg);
            this.Controls.Add(this.mfgFetchAvg);
            this.Controls.Add(this.typeFetchAvg);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.AvgSaleReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ebayPriceBox);
            this.Controls.Add(this.ebaySalePriceLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.YearsDropdown);
            this.Controls.Add(this.yearOfMfgLabel);
            this.Controls.Add(this.MfgDropDown);
            this.Controls.Add(this.PartManuLabel);
            this.Controls.Add(this.PartNameBox);
            this.Controls.Add(this.PartTypeDropDown);
            this.Controls.Add(this.PartTypeLabel);
            this.Controls.Add(this.PartNameLabel);
            this.Name = "Form1";
            this.Text = "Bike Part Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PartNameLabel;
        private System.Windows.Forms.Label PartTypeLabel;
        private System.Windows.Forms.ComboBox PartTypeDropDown;
        private System.Windows.Forms.TextBox PartNameBox;
        private System.Windows.Forms.Label PartManuLabel;
        private System.Windows.Forms.ComboBox MfgDropDown;
        private System.Windows.Forms.ComboBox YearsDropdown;
        private System.Windows.Forms.Label yearOfMfgLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label ebaySalePriceLabel;
        private System.Windows.Forms.TextBox ebayPriceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AvgSaleReturn;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.ComboBox typeFetchAvg;
        private System.Windows.Forms.ComboBox mfgFetchAvg;
        private System.Windows.Forms.ComboBox yearFetchAvg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox PartListBox;
        private System.Windows.Forms.Button updatePartButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Button delPartButton;
        private System.Windows.Forms.TextBox initInv;
        private System.Windows.Forms.Label investLabel;
        private System.Windows.Forms.Label breakEvLabel;
        private System.Windows.Forms.Label brkEvenCount;
        private System.Windows.Forms.Label avgBreakEven;
        private System.Windows.Forms.Label label6;
    }
}

