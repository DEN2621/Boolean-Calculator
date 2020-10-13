namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Input = new System.Windows.Forms.TextBox();
            this.Compute = new System.Windows.Forms.Button();
            this.Conjunction = new System.Windows.Forms.Button();
            this.Disjunction = new System.Windows.Forms.Button();
            this.Implication = new System.Windows.Forms.Button();
            this.Not_And = new System.Windows.Forms.Button();
            this.Not_Or = new System.Windows.Forms.Button();
            this.Converse = new System.Windows.Forms.Button();
            this.Exclusive_Disjunction = new System.Windows.Forms.Button();
            this.Negation = new System.Windows.Forms.Button();
            this.Equivalent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Output = new System.Windows.Forms.TextBox();
            this.Left_Bracket = new System.Windows.Forms.Button();
            this.Right_Bracket = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Table = new System.Windows.Forms.Label();
            this.In = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.Log_In = new System.Windows.Forms.Button();
            this.PasswordL = new System.Windows.Forms.Label();
            this.LoginL = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.A = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Button();
            this.Z = new System.Windows.Forms.Button();
            this.A_ = new System.Windows.Forms.Button();
            this.B_ = new System.Windows.Forms.Button();
            this.C_ = new System.Windows.Forms.Button();
            this.D_ = new System.Windows.Forms.Button();
            this.E_ = new System.Windows.Forms.Button();
            this.F_ = new System.Windows.Forms.Button();
            this.X_ = new System.Windows.Forms.Button();
            this.Y_ = new System.Windows.Forms.Button();
            this.Z_ = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(4, 4);
            this.Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input.Name = "Input";
            this.Input.ReadOnly = true;
            this.Input.Size = new System.Drawing.Size(1027, 22);
            this.Input.TabIndex = 0;
            // 
            // Compute
            // 
            this.Compute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Compute.Location = new System.Drawing.Point(1056, 31);
            this.Compute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(341, 142);
            this.Compute.TabIndex = 1;
            this.Compute.Text = "Вычислить";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Visible = false;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
            // 
            // Conjunction
            // 
            this.Conjunction.Location = new System.Drawing.Point(4, 4);
            this.Conjunction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Conjunction.Name = "Conjunction";
            this.Conjunction.Size = new System.Drawing.Size(84, 28);
            this.Conjunction.TabIndex = 3;
            this.Conjunction.TabStop = false;
            this.Conjunction.Text = "∧";
            this.Conjunction.UseVisualStyleBackColor = true;
            this.Conjunction.Click += new System.EventHandler(this.Conjunction_Click);
            // 
            // Disjunction
            // 
            this.Disjunction.Location = new System.Drawing.Point(96, 4);
            this.Disjunction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Disjunction.Name = "Disjunction";
            this.Disjunction.Size = new System.Drawing.Size(84, 28);
            this.Disjunction.TabIndex = 4;
            this.Disjunction.TabStop = false;
            this.Disjunction.Text = "∨";
            this.Disjunction.UseVisualStyleBackColor = true;
            this.Disjunction.Click += new System.EventHandler(this.Disjunction_Click);
            // 
            // Implication
            // 
            this.Implication.Location = new System.Drawing.Point(556, 4);
            this.Implication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Implication.Name = "Implication";
            this.Implication.Size = new System.Drawing.Size(84, 28);
            this.Implication.TabIndex = 5;
            this.Implication.TabStop = false;
            this.Implication.Text = "→";
            this.Implication.UseVisualStyleBackColor = true;
            this.Implication.Click += new System.EventHandler(this.Implication_Click);
            // 
            // Not_And
            // 
            this.Not_And.Location = new System.Drawing.Point(188, 4);
            this.Not_And.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Not_And.Name = "Not_And";
            this.Not_And.Size = new System.Drawing.Size(84, 28);
            this.Not_And.TabIndex = 6;
            this.Not_And.TabStop = false;
            this.Not_And.Text = "|";
            this.Not_And.UseVisualStyleBackColor = true;
            this.Not_And.Click += new System.EventHandler(this.Not_And_Click);
            // 
            // Not_Or
            // 
            this.Not_Or.Location = new System.Drawing.Point(280, 4);
            this.Not_Or.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Not_Or.Name = "Not_Or";
            this.Not_Or.Size = new System.Drawing.Size(84, 28);
            this.Not_Or.TabIndex = 7;
            this.Not_Or.TabStop = false;
            this.Not_Or.Text = "↓";
            this.Not_Or.UseVisualStyleBackColor = true;
            this.Not_Or.Click += new System.EventHandler(this.Not_Or_Click);
            // 
            // Converse
            // 
            this.Converse.Location = new System.Drawing.Point(648, 4);
            this.Converse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Converse.Name = "Converse";
            this.Converse.Size = new System.Drawing.Size(84, 28);
            this.Converse.TabIndex = 8;
            this.Converse.TabStop = false;
            this.Converse.Text = "←";
            this.Converse.UseVisualStyleBackColor = true;
            this.Converse.Click += new System.EventHandler(this.Converse_Click);
            // 
            // Exclusive_Disjunction
            // 
            this.Exclusive_Disjunction.Location = new System.Drawing.Point(464, 4);
            this.Exclusive_Disjunction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exclusive_Disjunction.Name = "Exclusive_Disjunction";
            this.Exclusive_Disjunction.Size = new System.Drawing.Size(84, 28);
            this.Exclusive_Disjunction.TabIndex = 9;
            this.Exclusive_Disjunction.TabStop = false;
            this.Exclusive_Disjunction.Text = "⊕";
            this.Exclusive_Disjunction.UseVisualStyleBackColor = true;
            this.Exclusive_Disjunction.Click += new System.EventHandler(this.Exclusive_Disjunction_Click);
            // 
            // Negation
            // 
            this.Negation.Location = new System.Drawing.Point(372, 4);
            this.Negation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Negation.Name = "Negation";
            this.Negation.Size = new System.Drawing.Size(84, 28);
            this.Negation.TabIndex = 10;
            this.Negation.TabStop = false;
            this.Negation.Text = "¬";
            this.Negation.UseVisualStyleBackColor = true;
            this.Negation.Click += new System.EventHandler(this.Negation_Click);
            // 
            // Equivalent
            // 
            this.Equivalent.Location = new System.Drawing.Point(740, 4);
            this.Equivalent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Equivalent.Name = "Equivalent";
            this.Equivalent.Size = new System.Drawing.Size(84, 28);
            this.Equivalent.TabIndex = 11;
            this.Equivalent.TabStop = false;
            this.Equivalent.Text = "↔";
            this.Equivalent.UseVisualStyleBackColor = true;
            this.Equivalent.Click += new System.EventHandler(this.Equivalent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(16, 199);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1381, 350);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.TabStop = false;
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output.Location = new System.Drawing.Point(16, 555);
            this.Output.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output.Size = new System.Drawing.Size(1380, 165);
            this.Output.TabIndex = 14;
            this.Output.TabStop = false;
            // 
            // Left_Bracket
            // 
            this.Left_Bracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Left_Bracket.Location = new System.Drawing.Point(4, 34);
            this.Left_Bracket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Left_Bracket.Name = "Left_Bracket";
            this.Left_Bracket.Size = new System.Drawing.Size(87, 106);
            this.Left_Bracket.TabIndex = 16;
            this.Left_Bracket.TabStop = false;
            this.Left_Bracket.Text = "(";
            this.Left_Bracket.UseVisualStyleBackColor = true;
            this.Left_Bracket.Click += new System.EventHandler(this.Left_Bracket_Click);
            // 
            // Right_Bracket
            // 
            this.Right_Bracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Right_Bracket.Location = new System.Drawing.Point(4, 148);
            this.Right_Bracket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Right_Bracket.Name = "Right_Bracket";
            this.Right_Bracket.Size = new System.Drawing.Size(87, 106);
            this.Right_Bracket.TabIndex = 17;
            this.Right_Bracket.TabStop = false;
            this.Right_Bracket.Text = ")";
            this.Right_Bracket.UseVisualStyleBackColor = true;
            this.Right_Bracket.Click += new System.EventHandler(this.Right_Bracket_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Table);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.In);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Register);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Log_In);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.PasswordL);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LoginL);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Login);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Password);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.flowLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Compute);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Output);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1408, 725);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1408, 756);
            this.toolStripContainer1.TabIndex = 18;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(262, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(220, 28);
            this.toolStripLabel1.Text = "Изменить цвет фона таблицы:";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "Сюда можно нажать ;)";
            // 
            // Table
            // 
            this.Table.AutoSize = true;
            this.Table.Location = new System.Drawing.Point(16, 181);
            this.Table.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(145, 17);
            this.Table.TabIndex = 28;
            this.Table.Text = "Таблица истинности";
            // 
            // In
            // 
            this.In.AutoSize = true;
            this.In.Location = new System.Drawing.Point(16, 11);
            this.In.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(220, 17);
            this.In.TabIndex = 27;
            this.In.Text = "Введите логическое выражение";
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(1231, 135);
            this.Register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(167, 28);
            this.Register.TabIndex = 26;
            this.Register.Text = "Зарегистрироваться";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Log_In
            // 
            this.Log_In.Location = new System.Drawing.Point(1056, 135);
            this.Log_In.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Log_In.Name = "Log_In";
            this.Log_In.Size = new System.Drawing.Size(167, 28);
            this.Log_In.TabIndex = 25;
            this.Log_In.Text = "Войти";
            this.Log_In.UseVisualStyleBackColor = true;
            this.Log_In.Click += new System.EventHandler(this.Log_In_Click);
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Location = new System.Drawing.Point(1056, 82);
            this.PasswordL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(57, 17);
            this.PasswordL.TabIndex = 24;
            this.PasswordL.Text = "Пароль";
            // 
            // LoginL
            // 
            this.LoginL.AutoSize = true;
            this.LoginL.Location = new System.Drawing.Point(1056, 34);
            this.LoginL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginL.Name = "LoginL";
            this.LoginL.Size = new System.Drawing.Size(47, 17);
            this.LoginL.TabIndex = 23;
            this.LoginL.Text = "Логин";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(1056, 54);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(340, 22);
            this.Login.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(1056, 102);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(340, 22);
            this.Password.TabIndex = 1;
            this.Password.UseSystemPasswordChar = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Input);
            this.flowLayoutPanel1.Controls.Add(this.Left_Bracket);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.Right_Bracket);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 31);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1032, 142);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Conjunction);
            this.flowLayoutPanel2.Controls.Add(this.Disjunction);
            this.flowLayoutPanel2.Controls.Add(this.Not_And);
            this.flowLayoutPanel2.Controls.Add(this.Not_Or);
            this.flowLayoutPanel2.Controls.Add(this.Negation);
            this.flowLayoutPanel2.Controls.Add(this.Exclusive_Disjunction);
            this.flowLayoutPanel2.Controls.Add(this.Implication);
            this.flowLayoutPanel2.Controls.Add(this.Converse);
            this.flowLayoutPanel2.Controls.Add(this.Equivalent);
            this.flowLayoutPanel2.Controls.Add(this.A);
            this.flowLayoutPanel2.Controls.Add(this.B);
            this.flowLayoutPanel2.Controls.Add(this.C);
            this.flowLayoutPanel2.Controls.Add(this.D);
            this.flowLayoutPanel2.Controls.Add(this.E);
            this.flowLayoutPanel2.Controls.Add(this.F);
            this.flowLayoutPanel2.Controls.Add(this.X);
            this.flowLayoutPanel2.Controls.Add(this.Y);
            this.flowLayoutPanel2.Controls.Add(this.Z);
            this.flowLayoutPanel2.Controls.Add(this.A_);
            this.flowLayoutPanel2.Controls.Add(this.B_);
            this.flowLayoutPanel2.Controls.Add(this.C_);
            this.flowLayoutPanel2.Controls.Add(this.D_);
            this.flowLayoutPanel2.Controls.Add(this.E_);
            this.flowLayoutPanel2.Controls.Add(this.F_);
            this.flowLayoutPanel2.Controls.Add(this.X_);
            this.flowLayoutPanel2.Controls.Add(this.Y_);
            this.flowLayoutPanel2.Controls.Add(this.Z_);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(99, 34);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(835, 106);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(4, 40);
            this.A.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(84, 28);
            this.A.TabIndex = 12;
            this.A.TabStop = false;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(96, 40);
            this.B.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(84, 28);
            this.B.TabIndex = 13;
            this.B.TabStop = false;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(188, 40);
            this.C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(84, 28);
            this.C.TabIndex = 14;
            this.C.TabStop = false;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(280, 40);
            this.D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(84, 28);
            this.D.TabIndex = 15;
            this.D.TabStop = false;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(372, 40);
            this.E.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(84, 28);
            this.E.TabIndex = 16;
            this.E.TabStop = false;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.E_Click);
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(464, 40);
            this.F.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(84, 28);
            this.F.TabIndex = 17;
            this.F.TabStop = false;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.F_Click);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(556, 40);
            this.X.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(84, 28);
            this.X.TabIndex = 18;
            this.X.TabStop = false;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(648, 40);
            this.Y.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(84, 28);
            this.Y.TabIndex = 19;
            this.Y.TabStop = false;
            this.Y.Text = "Y";
            this.Y.UseVisualStyleBackColor = true;
            this.Y.Click += new System.EventHandler(this.Y_Click);
            // 
            // Z
            // 
            this.Z.Location = new System.Drawing.Point(740, 40);
            this.Z.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(84, 28);
            this.Z.TabIndex = 20;
            this.Z.TabStop = false;
            this.Z.Text = "Z";
            this.Z.UseVisualStyleBackColor = true;
            this.Z.Click += new System.EventHandler(this.Z_Click);
            // 
            // A_
            // 
            this.A_.Location = new System.Drawing.Point(4, 76);
            this.A_.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.A_.Name = "A_";
            this.A_.Size = new System.Drawing.Size(84, 28);
            this.A_.TabIndex = 21;
            this.A_.TabStop = false;
            this.A_.Text = "a";
            this.A_.UseVisualStyleBackColor = true;
            this.A_.Click += new System.EventHandler(this.A__Click);
            // 
            // B_
            // 
            this.B_.Location = new System.Drawing.Point(96, 76);
            this.B_.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_.Name = "B_";
            this.B_.Size = new System.Drawing.Size(84, 28);
            this.B_.TabIndex = 22;
            this.B_.TabStop = false;
            this.B_.Text = "b";
            this.B_.UseVisualStyleBackColor = true;
            this.B_.Click += new System.EventHandler(this.B__Click);
            // 
            // C_
            // 
            this.C_.Location = new System.Drawing.Point(188, 76);
            this.C_.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.C_.Name = "C_";
            this.C_.Size = new System.Drawing.Size(84, 28);
            this.C_.TabIndex = 23;
            this.C_.TabStop = false;
            this.C_.Text = "c";
            this.C_.UseVisualStyleBackColor = true;
            this.C_.Click += new System.EventHandler(this.C__Click);
            // 
            // D_
            // 
            this.D_.Location = new System.Drawing.Point(280, 76);
            this.D_.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D_.Name = "D_";
            this.D_.Size = new System.Drawing.Size(84, 28);
            this.D_.TabIndex = 24;
            this.D_.TabStop = false;
            this.D_.Text = "d";
            this.D_.UseVisualStyleBackColor = true;
            this.D_.Click += new System.EventHandler(this.D__Click);
            // 
            // E_
            // 
            this.E_.Location = new System.Drawing.Point(372, 76);
            this.E_.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.E_.Name = "E_";
            this.E_.Size = new System.Drawing.Size(84, 28);
            this.E_.TabIndex = 25;
            this.E_.TabStop = false;
            this.E_.Text = "e";
            this.E_.UseVisualStyleBackColor = true;
            this.E_.Click += new System.EventHandler(this.E__Click);
            // 
            // F_
            // 
            this.F_.Location = new System.Drawing.Point(464, 76);
            this.F_.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.F_.Name = "F_";
            this.F_.Size = new System.Drawing.Size(84, 28);
            this.F_.TabIndex = 26;
            this.F_.TabStop = false;
            this.F_.Text = "f";
            this.F_.UseVisualStyleBackColor = true;
            this.F_.Click += new System.EventHandler(this.F__Click);
            // 
            // X_
            // 
            this.X_.Location = new System.Drawing.Point(556, 76);
            this.X_.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.X_.Name = "X_";
            this.X_.Size = new System.Drawing.Size(84, 28);
            this.X_.TabIndex = 27;
            this.X_.TabStop = false;
            this.X_.Text = "x";
            this.X_.UseVisualStyleBackColor = true;
            this.X_.Click += new System.EventHandler(this.X__Click);
            // 
            // Y_
            // 
            this.Y_.Location = new System.Drawing.Point(648, 76);
            this.Y_.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Y_.Name = "Y_";
            this.Y_.Size = new System.Drawing.Size(84, 28);
            this.Y_.TabIndex = 28;
            this.Y_.TabStop = false;
            this.Y_.Text = "y";
            this.Y_.UseVisualStyleBackColor = true;
            this.Y_.Click += new System.EventHandler(this.Y__Click);
            // 
            // Z_
            // 
            this.Z_.Location = new System.Drawing.Point(740, 76);
            this.Z_.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Z_.Name = "Z_";
            this.Z_.Size = new System.Drawing.Size(84, 28);
            this.Z_.TabIndex = 29;
            this.Z_.TabStop = false;
            this.Z_.Text = "z";
            this.Z_.UseVisualStyleBackColor = true;
            this.Z_.Click += new System.EventHandler(this.Z__Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Log_In;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1408, 756);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор алгебры логики";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button Compute;
        private System.Windows.Forms.Button Conjunction;
        private System.Windows.Forms.Button Disjunction;
        private System.Windows.Forms.Button Implication;
        private System.Windows.Forms.Button Not_And;
        private System.Windows.Forms.Button Not_Or;
        private System.Windows.Forms.Button Converse;
        private System.Windows.Forms.Button Exclusive_Disjunction;
        private System.Windows.Forms.Button Negation;
        private System.Windows.Forms.Button Equivalent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button Left_Bracket;
        private System.Windows.Forms.Button Right_Bracket;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label In;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Log_In;
        private System.Windows.Forms.Label PasswordL;
        private System.Windows.Forms.Label LoginL;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button Y;
        private System.Windows.Forms.Button Z;
        private System.Windows.Forms.Button A_;
        private System.Windows.Forms.Button B_;
        private System.Windows.Forms.Button C_;
        private System.Windows.Forms.Button D_;
        private System.Windows.Forms.Button E_;
        private System.Windows.Forms.Button F_;
        private System.Windows.Forms.Button X_;
        private System.Windows.Forms.Button Y_;
        private System.Windows.Forms.Button Z_;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label Table;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

