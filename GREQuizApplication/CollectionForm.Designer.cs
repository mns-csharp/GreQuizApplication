namespace QuizApplication
{
    partial class CollectionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionForm));
            this.dataGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.learnUnlearnMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToGroupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textSearchTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stopGlassButton = new EnhancedGlassButton.GlassButton();
            this.playTextGlassButton = new EnhancedGlassButton.GlassButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.wordMeaningTextBox = new System.Windows.Forms.TextBox();
            this.glassButton2 = new EnhancedGlassButton.GlassButton();
            this.glassButton1 = new EnhancedGlassButton.GlassButton();
            this.button1 = new EnhancedGlassButton.GlassButton();
            this.learntCheckBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalRowsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.learntComboBox = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.groupCheckBox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.learnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.httpwwwthefreedictionarycomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BengaliMeaning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correctness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rtbContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetZeroGlassButton = new EnhancedGlassButton.GlassButton();
            this.resetMaxGlassButton = new EnhancedGlassButton.GlassButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridViewContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.rtbContextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewContextMenuStrip
            // 
            this.dataGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.learnUnlearnMenuItem,
            this.goToGroupMenuItem});
            this.dataGridViewContextMenuStrip.Name = "contextMenuStrip1";
            this.dataGridViewContextMenuStrip.Size = new System.Drawing.Size(143, 48);
            this.dataGridViewContextMenuStrip.Click += new System.EventHandler(this.dataGridViewContextMenuStrip_Click);
            // 
            // learnUnlearnMenuItem
            // 
            this.learnUnlearnMenuItem.Name = "learnUnlearnMenuItem";
            this.learnUnlearnMenuItem.Size = new System.Drawing.Size(142, 22);
            this.learnUnlearnMenuItem.Text = "Learn/Unlearn";
            this.learnUnlearnMenuItem.Click += new System.EventHandler(this.learnUnlearnMenuItem_Click);
            // 
            // goToGroupMenuItem
            // 
            this.goToGroupMenuItem.Name = "goToGroupMenuItem";
            this.goToGroupMenuItem.Size = new System.Drawing.Size(142, 22);
            this.goToGroupMenuItem.Text = "Go to group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(432, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // stopGlassButton
            // 
            this.stopGlassButton.BackColor = System.Drawing.Color.Navy;
            this.stopGlassButton.GlowColor = System.Drawing.Color.Red;
            this.stopGlassButton.Location = new System.Drawing.Point(537, 626);
            this.stopGlassButton.Name = "stopGlassButton";
            this.stopGlassButton.OuterBorderColor = System.Drawing.Color.Transparent;
            this.stopGlassButton.Size = new System.Drawing.Size(100, 37);
            this.stopGlassButton.TabIndex = 36;
            this.stopGlassButton.Text = "Stop";
            this.stopGlassButton.Click += new System.EventHandler(this.stopGlassButton_Click);
            // 
            // playTextGlassButton
            // 
            this.playTextGlassButton.BackColor = System.Drawing.Color.Navy;
            this.playTextGlassButton.GlowColor = System.Drawing.Color.Red;
            this.playTextGlassButton.Location = new System.Drawing.Point(431, 626);
            this.playTextGlassButton.Name = "playTextGlassButton";
            this.playTextGlassButton.OuterBorderColor = System.Drawing.Color.Transparent;
            this.playTextGlassButton.Size = new System.Drawing.Size(100, 37);
            this.playTextGlassButton.TabIndex = 35;
            this.playTextGlassButton.Text = "Play";
            this.playTextGlassButton.Click += new System.EventHandler(this.readTextGlassButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(432, 405);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(738, 213);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseClick);
            // 
            // wordMeaningTextBox
            // 
            this.wordMeaningTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.wordMeaningTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordMeaningTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordMeaningTextBox.Location = new System.Drawing.Point(432, 370);
            this.wordMeaningTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.wordMeaningTextBox.Multiline = true;
            this.wordMeaningTextBox.Name = "wordMeaningTextBox";
            this.wordMeaningTextBox.ReadOnly = true;
            this.wordMeaningTextBox.Size = new System.Drawing.Size(738, 35);
            this.wordMeaningTextBox.TabIndex = 38;
            // 
            // glassButton2
            // 
            this.glassButton2.BackColor = System.Drawing.Color.Navy;
            this.glassButton2.GlowColor = System.Drawing.Color.Red;
            this.glassButton2.Location = new System.Drawing.Point(643, 60);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.OuterBorderColor = System.Drawing.Color.Transparent;
            this.glassButton2.Size = new System.Drawing.Size(100, 37);
            this.glassButton2.TabIndex = 34;
            this.glassButton2.Text = "Delete";
            this.glassButton2.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // glassButton1
            // 
            this.glassButton1.BackColor = System.Drawing.Color.Navy;
            this.glassButton1.GlowColor = System.Drawing.Color.Red;
            this.glassButton1.Location = new System.Drawing.Point(537, 60);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.OuterBorderColor = System.Drawing.Color.Transparent;
            this.glassButton1.Size = new System.Drawing.Size(100, 37);
            this.glassButton1.TabIndex = 33;
            this.glassButton1.Text = "Edit";
            this.glassButton1.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.GlowColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(431, 60);
            this.button1.Name = "button1";
            this.button1.OuterBorderColor = System.Drawing.Color.Transparent;
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 32;
            this.button1.Text = "New";
            this.button1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // learntCheckBox
            // 
            this.learntCheckBox.AutoSize = true;
            this.learntCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.learntCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learntCheckBox.Location = new System.Drawing.Point(305, 31);
            this.learntCheckBox.Name = "learntCheckBox";
            this.learntCheckBox.Size = new System.Drawing.Size(75, 19);
            this.learntCheckBox.TabIndex = 31;
            this.learntCheckBox.Text = "Learned :";
            this.learntCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.learntCheckBox.UseVisualStyleBackColor = true;
            this.learntCheckBox.CheckedChanged += new System.EventHandler(this.learnedCheckBox_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.totalRowsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 665);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1183, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel1.Text = "Words count:";
            // 
            // totalRowsLabel
            // 
            this.totalRowsLabel.Name = "totalRowsLabel";
            this.totalRowsLabel.Size = new System.Drawing.Size(13, 17);
            this.totalRowsLabel.Text = "0";
            // 
            // learntComboBox
            // 
            this.learntComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.learntComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.learntComboBox.Enabled = false;
            this.learntComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.learntComboBox.FormattingEnabled = true;
            this.learntComboBox.Location = new System.Drawing.Point(389, 26);
            this.learntComboBox.Name = "learntComboBox";
            this.learntComboBox.Size = new System.Drawing.Size(121, 28);
            this.learntComboBox.TabIndex = 29;
            this.learntComboBox.SelectionChangeCommitted += new System.EventHandler(this.learntComboBox_SelectionChangeCommitted);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(964, 60);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 37);
            this.button4.TabIndex = 28;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupComboBox
            // 
            this.groupComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox.Enabled = false;
            this.groupComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(94, 26);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(121, 28);
            this.groupComboBox.TabIndex = 27;
            this.groupComboBox.SelectionChangeCommitted += new System.EventHandler(this.groupComboBox_SelectionChangeCommitted);
            // 
            // groupCheckBox
            // 
            this.groupCheckBox.AutoSize = true;
            this.groupCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCheckBox.Location = new System.Drawing.Point(17, 31);
            this.groupCheckBox.Name = "groupCheckBox";
            this.groupCheckBox.Size = new System.Drawing.Size(69, 19);
            this.groupCheckBox.TabIndex = 26;
            this.groupCheckBox.Text = "Groups :";
            this.groupCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.groupCheckBox.UseVisualStyleBackColor = true;
            this.groupCheckBox.CheckedChanged += new System.EventHandler(this.groupCheckBox_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1070, 60);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.practiceToolStripMenuItem,
            this.dictionaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1183, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.learnToolStripMenuItem,
            this.toolStripMenuItem1,
            this.statisticsToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.manageGroupsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.practiceToolStripMenuItem.Text = "Practice";
            // 
            // learnToolStripMenuItem
            // 
            this.learnToolStripMenuItem.Name = "learnToolStripMenuItem";
            this.learnToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.learnToolStripMenuItem.Text = "Learn";
            this.learnToolStripMenuItem.Click += new System.EventHandler(this.learnToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuItem1.Text = "Flash Card";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.flashCardToolTipItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.manageToolStripMenuItem.Text = "Manage learnt words";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // manageGroupsToolStripMenuItem
            // 
            this.manageGroupsToolStripMenuItem.Name = "manageGroupsToolStripMenuItem";
            this.manageGroupsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.manageGroupsToolStripMenuItem.Text = "Manage groups";
            this.manageGroupsToolStripMenuItem.Click += new System.EventHandler(this.manageGroupsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.httpwwwthefreedictionarycomToolStripMenuItem});
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.dictionaryToolStripMenuItem.Text = "Dictionary";
            // 
            // httpwwwthefreedictionarycomToolStripMenuItem
            // 
            this.httpwwwthefreedictionarycomToolStripMenuItem.Name = "httpwwwthefreedictionarycomToolStripMenuItem";
            this.httpwwwthefreedictionarycomToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.httpwwwthefreedictionarycomToolStripMenuItem.Text = "http://www.thefreedictionary.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filter text :";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(94, 60);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(330, 35);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Group,
            this.BengaliMeaning,
            this.Correctness,
            this.dataGridViewColumnButton});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(11, 179);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 14;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(413, 439);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 41;
            // 
            // Group
            // 
            this.Group.HeaderText = "G";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Width = 43;
            // 
            // BengaliMeaning
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BengaliMeaning.DefaultCellStyle = dataGridViewCellStyle1;
            this.BengaliMeaning.HeaderText = "Name";
            this.BengaliMeaning.Name = "BengaliMeaning";
            this.BengaliMeaning.ReadOnly = true;
            this.BengaliMeaning.Width = 68;
            // 
            // Correctness
            // 
            this.Correctness.HeaderText = "C";
            this.Correctness.Name = "Correctness";
            this.Correctness.ReadOnly = true;
            this.Correctness.Width = 42;
            // 
            // dataGridViewColumnButton
            // 
            this.dataGridViewColumnButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewColumnButton.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewColumnButton.HeaderText = "... ...";
            this.dataGridViewColumnButton.Name = "dataGridViewColumnButton";
            this.dataGridViewColumnButton.ReadOnly = true;
            this.dataGridViewColumnButton.Text = "Play";
            this.dataGridViewColumnButton.Width = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(432, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 12);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(432, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 12);
            this.panel2.TabIndex = 40;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(751, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 35);
            this.textBox1.TabIndex = 41;
            this.textBox1.Text = "●";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbContextMenuStrip1
            // 
            this.rtbContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.rtbContextMenuStrip1.Name = "rtbContextMenuStrip1";
            this.rtbContextMenuStrip1.Size = new System.Drawing.Size(100, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // resetZeroGlassButton
            // 
            this.resetZeroGlassButton.BackColor = System.Drawing.Color.Navy;
            this.resetZeroGlassButton.GlowColor = System.Drawing.Color.Red;
            this.resetZeroGlassButton.Location = new System.Drawing.Point(11, 624);
            this.resetZeroGlassButton.Name = "resetZeroGlassButton";
            this.resetZeroGlassButton.OuterBorderColor = System.Drawing.Color.Transparent;
            this.resetZeroGlassButton.Size = new System.Drawing.Size(100, 37);
            this.resetZeroGlassButton.TabIndex = 42;
            this.resetZeroGlassButton.Text = "Reset to Zero";
            this.resetZeroGlassButton.Click += new System.EventHandler(this.resetGlassButton_Click);
            // 
            // resetMaxGlassButton
            // 
            this.resetMaxGlassButton.BackColor = System.Drawing.Color.Navy;
            this.resetMaxGlassButton.GlowColor = System.Drawing.Color.Red;
            this.resetMaxGlassButton.Location = new System.Drawing.Point(117, 624);
            this.resetMaxGlassButton.Name = "resetMaxGlassButton";
            this.resetMaxGlassButton.OuterBorderColor = System.Drawing.Color.Transparent;
            this.resetMaxGlassButton.Size = new System.Drawing.Size(100, 37);
            this.resetMaxGlassButton.TabIndex = 43;
            this.resetMaxGlassButton.Text = "Reset to Max";
            this.resetMaxGlassButton.Click += new System.EventHandler(this.resetMaxGlassButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(11, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 70);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order By";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(244, 27);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(137, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Correctness Count";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(126, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Name";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "GroupNo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // CollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resetMaxGlassButton);
            this.Controls.Add(this.resetZeroGlassButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stopGlassButton);
            this.Controls.Add(this.playTextGlassButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.wordMeaningTextBox);
            this.Controls.Add(this.glassButton2);
            this.Controls.Add(this.glassButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.learntCheckBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.learntComboBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.groupCheckBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "CollectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRE Vocabulary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CollectionForm_FormClosing);
            this.Load += new System.EventHandler(this.CollectionForm_Load);
            this.dataGridViewContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.rtbContextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem learnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem httpwwwthefreedictionarycomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem manageGroupsToolStripMenuItem;
        private System.Windows.Forms.CheckBox groupCheckBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox learntComboBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel totalRowsLabel;
        private System.Windows.Forms.CheckBox learntCheckBox;
        private EnhancedGlassButton.GlassButton button1;
        private EnhancedGlassButton.GlassButton glassButton1;
        private EnhancedGlassButton.GlassButton glassButton2;
        private System.Windows.Forms.ContextMenuStrip dataGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem goToGroupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private EnhancedGlassButton.GlassButton playTextGlassButton;
        private EnhancedGlassButton.GlassButton stopGlassButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox wordMeaningTextBox;
        private System.Windows.Forms.ToolStripMenuItem learnUnlearnMenuItem;
        private System.Windows.Forms.Timer textSearchTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip rtbContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private EnhancedGlassButton.GlassButton resetZeroGlassButton;
        private EnhancedGlassButton.GlassButton resetMaxGlassButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn BengaliMeaning;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correctness;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewColumnButton;
    }
}