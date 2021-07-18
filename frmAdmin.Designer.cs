
namespace LanValley
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Users = new System.Windows.Forms.TabPage();
            this.btn_deleteUser = new System.Windows.Forms.PictureBox();
            this.btn_updateUser = new System.Windows.Forms.PictureBox();
            this.btn_insertUser = new System.Windows.Forms.PictureBox();
            this.lbl_totalUsers = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_InsModUser = new System.Windows.Forms.Label();
            this.txt_searchUser = new System.Windows.Forms.TextBox();
            this.lbl_searchUser = new System.Windows.Forms.Label();
            this.lbl_totalusersText = new System.Windows.Forms.Label();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.tp_PC = new System.Windows.Forms.TabPage();
            this.btn_deletePC = new System.Windows.Forms.PictureBox();
            this.btn_insertPC = new System.Windows.Forms.PictureBox();
            this.lbl_totalPC = new System.Windows.Forms.Label();
            this.dgv_PC = new System.Windows.Forms.DataGridView();
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_Brand = new System.Windows.Forms.TextBox();
            this.lbl_InsDelPC = new System.Windows.Forms.Label();
            this.lbl_totalpcText = new System.Windows.Forms.Label();
            this.tp_Movimentos = new System.Windows.Forms.TabPage();
            this.btn_Export = new System.Windows.Forms.PictureBox();
            this.dgv_Transactions = new System.Windows.Forms.DataGridView();
            this.tp_addJogos = new System.Windows.Forms.TabPage();
            this.btn_addGame = new System.Windows.Forms.PictureBox();
            this.btn_Search = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gameName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Games = new System.Windows.Forms.DataGridView();
            this.lbL_Texto = new System.Windows.Forms.Label();
            this.txt_exeName = new System.Windows.Forms.TextBox();
            this.ts_Menu = new System.Windows.Forms.ToolStrip();
            this.tsb_Lock = new System.Windows.Forms.ToolStripButton();
            this.tsb_Exit = new System.Windows.Forms.ToolStripButton();
            this.searchGame = new System.Windows.Forms.OpenFileDialog();
            this.logo = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tp_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deleteUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_updateUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_insertUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.tp_PC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deletePC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_insertPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PC)).BeginInit();
            this.tp_Movimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Export)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transactions)).BeginInit();
            this.tp_addJogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Games)).BeginInit();
            this.ts_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Users);
            this.tabControl1.Controls.Add(this.tp_PC);
            this.tabControl1.Controls.Add(this.tp_Movimentos);
            this.tabControl1.Controls.Add(this.tp_addJogos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 158);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 642);
            this.tabControl1.TabIndex = 1;
            // 
            // tp_Users
            // 
            this.tp_Users.BackColor = System.Drawing.Color.White;
            this.tp_Users.Controls.Add(this.btn_deleteUser);
            this.tp_Users.Controls.Add(this.btn_updateUser);
            this.tp_Users.Controls.Add(this.btn_insertUser);
            this.tp_Users.Controls.Add(this.lbl_totalUsers);
            this.tp_Users.Controls.Add(this.lbl_Pass);
            this.tp_Users.Controls.Add(this.lbl_User);
            this.tp_Users.Controls.Add(this.lbl_Nome);
            this.tp_Users.Controls.Add(this.txt_Pass);
            this.tp_Users.Controls.Add(this.txt_User);
            this.tp_Users.Controls.Add(this.txt_Name);
            this.tp_Users.Controls.Add(this.lbl_InsModUser);
            this.tp_Users.Controls.Add(this.txt_searchUser);
            this.tp_Users.Controls.Add(this.lbl_searchUser);
            this.tp_Users.Controls.Add(this.lbl_totalusersText);
            this.tp_Users.Controls.Add(this.dgv_Users);
            this.tp_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_Users.Location = new System.Drawing.Point(4, 28);
            this.tp_Users.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_Users.Name = "tp_Users";
            this.tp_Users.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_Users.Size = new System.Drawing.Size(992, 610);
            this.tp_Users.TabIndex = 0;
            this.tp_Users.Text = "Utilizadores";
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteUser.Image = global::LanValley.Properties.Resources.delete;
            this.btn_deleteUser.Location = new System.Drawing.Point(861, 208);
            this.btn_deleteUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(91, 70);
            this.btn_deleteUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_deleteUser.TabIndex = 18;
            this.btn_deleteUser.TabStop = false;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // btn_updateUser
            // 
            this.btn_updateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateUser.Image = global::LanValley.Properties.Resources.update;
            this.btn_updateUser.Location = new System.Drawing.Point(756, 208);
            this.btn_updateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_updateUser.Name = "btn_updateUser";
            this.btn_updateUser.Size = new System.Drawing.Size(91, 70);
            this.btn_updateUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_updateUser.TabIndex = 17;
            this.btn_updateUser.TabStop = false;
            this.btn_updateUser.Click += new System.EventHandler(this.btn_upgradeUser_Click);
            // 
            // btn_insertUser
            // 
            this.btn_insertUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insertUser.Image = global::LanValley.Properties.Resources.submit;
            this.btn_insertUser.Location = new System.Drawing.Point(653, 208);
            this.btn_insertUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_insertUser.Name = "btn_insertUser";
            this.btn_insertUser.Size = new System.Drawing.Size(91, 70);
            this.btn_insertUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_insertUser.TabIndex = 16;
            this.btn_insertUser.TabStop = false;
            this.btn_insertUser.Click += new System.EventHandler(this.btn_insertUser_Click);
            // 
            // lbl_totalUsers
            // 
            this.lbl_totalUsers.AutoSize = true;
            this.lbl_totalUsers.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalUsers.Font = new System.Drawing.Font("ROG Fonts", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalUsers.ForeColor = System.Drawing.Color.Red;
            this.lbl_totalUsers.Location = new System.Drawing.Point(199, 53);
            this.lbl_totalUsers.Name = "lbl_totalUsers";
            this.lbl_totalUsers.Size = new System.Drawing.Size(34, 29);
            this.lbl_totalUsers.TabIndex = 15;
            this.lbl_totalUsers.Text = "0";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pass.Font = new System.Drawing.Font("ROG Fonts", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Pass.Location = new System.Drawing.Point(491, 164);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(152, 23);
            this.lbl_Pass.TabIndex = 10;
            this.lbl_Pass.Text = "Password:";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.BackColor = System.Drawing.Color.Transparent;
            this.lbl_User.Font = new System.Drawing.Font("ROG Fonts", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_User.Location = new System.Drawing.Point(491, 124);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(150, 23);
            this.lbl_User.TabIndex = 9;
            this.lbl_User.Text = "Username:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nome.Font = new System.Drawing.Font("ROG Fonts", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Nome.Location = new System.Drawing.Point(491, 84);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(84, 23);
            this.lbl_Nome.TabIndex = 8;
            this.lbl_Nome.Text = "Nome:";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.ForeColor = System.Drawing.Color.Red;
            this.txt_Pass.Location = new System.Drawing.Point(653, 164);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(297, 27);
            this.txt_Pass.TabIndex = 7;
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.ForeColor = System.Drawing.Color.Red;
            this.txt_User.Location = new System.Drawing.Point(653, 124);
            this.txt_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(297, 27);
            this.txt_User.TabIndex = 6;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Name.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.Red;
            this.txt_Name.Location = new System.Drawing.Point(653, 84);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(297, 27);
            this.txt_Name.TabIndex = 5;
            // 
            // lbl_InsModUser
            // 
            this.lbl_InsModUser.AutoSize = true;
            this.lbl_InsModUser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_InsModUser.Font = new System.Drawing.Font("ROG Fonts", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsModUser.Location = new System.Drawing.Point(524, 23);
            this.lbl_InsModUser.Name = "lbl_InsModUser";
            this.lbl_InsModUser.Size = new System.Drawing.Size(428, 29);
            this.lbl_InsModUser.TabIndex = 4;
            this.lbl_InsModUser.Text = "Inserir/Modificar User";
            // 
            // txt_searchUser
            // 
            this.txt_searchUser.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchUser.ForeColor = System.Drawing.Color.Red;
            this.txt_searchUser.Location = new System.Drawing.Point(13, 240);
            this.txt_searchUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_searchUser.Name = "txt_searchUser";
            this.txt_searchUser.Size = new System.Drawing.Size(311, 27);
            this.txt_searchUser.TabIndex = 3;
            this.txt_searchUser.TextChanged += new System.EventHandler(this.txt_searchUser_TextChanged);
            // 
            // lbl_searchUser
            // 
            this.lbl_searchUser.AutoSize = true;
            this.lbl_searchUser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_searchUser.Font = new System.Drawing.Font("ROG Fonts", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchUser.Location = new System.Drawing.Point(24, 208);
            this.lbl_searchUser.Name = "lbl_searchUser";
            this.lbl_searchUser.Size = new System.Drawing.Size(299, 29);
            this.lbl_searchUser.TabIndex = 2;
            this.lbl_searchUser.Text = "Pesquisar User:";
            // 
            // lbl_totalusersText
            // 
            this.lbl_totalusersText.AutoSize = true;
            this.lbl_totalusersText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalusersText.Font = new System.Drawing.Font("ROG Fonts", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalusersText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_totalusersText.Location = new System.Drawing.Point(8, 23);
            this.lbl_totalusersText.Name = "lbl_totalusersText";
            this.lbl_totalusersText.Size = new System.Drawing.Size(417, 29);
            this.lbl_totalusersText.TabIndex = 1;
            this.lbl_totalusersText.Text = "Total de Utilizadores:";
            // 
            // dgv_Users
            // 
            this.dgv_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Users.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Users.Location = new System.Drawing.Point(3, 316);
            this.dgv_Users.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.RowHeadersWidth = 51;
            this.dgv_Users.RowTemplate.Height = 24;
            this.dgv_Users.Size = new System.Drawing.Size(986, 292);
            this.dgv_Users.TabIndex = 0;
            this.dgv_Users.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Users_RowHeaderMouseClick);
            // 
            // tp_PC
            // 
            this.tp_PC.BackColor = System.Drawing.Color.White;
            this.tp_PC.Controls.Add(this.btn_deletePC);
            this.tp_PC.Controls.Add(this.btn_insertPC);
            this.tp_PC.Controls.Add(this.lbl_totalPC);
            this.tp_PC.Controls.Add(this.dgv_PC);
            this.tp_PC.Controls.Add(this.lbl_Modelo);
            this.tp_PC.Controls.Add(this.lbl_Marca);
            this.tp_PC.Controls.Add(this.txt_Model);
            this.tp_PC.Controls.Add(this.txt_Brand);
            this.tp_PC.Controls.Add(this.lbl_InsDelPC);
            this.tp_PC.Controls.Add(this.lbl_totalpcText);
            this.tp_PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_PC.Location = new System.Drawing.Point(4, 28);
            this.tp_PC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_PC.Name = "tp_PC";
            this.tp_PC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_PC.Size = new System.Drawing.Size(992, 610);
            this.tp_PC.TabIndex = 1;
            this.tp_PC.Text = "PC\'s";
            // 
            // btn_deletePC
            // 
            this.btn_deletePC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletePC.Image = global::LanValley.Properties.Resources.delete;
            this.btn_deletePC.Location = new System.Drawing.Point(811, 219);
            this.btn_deletePC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deletePC.Name = "btn_deletePC";
            this.btn_deletePC.Size = new System.Drawing.Size(91, 70);
            this.btn_deletePC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_deletePC.TabIndex = 24;
            this.btn_deletePC.TabStop = false;
            this.btn_deletePC.Click += new System.EventHandler(this.btn_deletePC_Click);
            // 
            // btn_insertPC
            // 
            this.btn_insertPC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insertPC.Image = global::LanValley.Properties.Resources.submit;
            this.btn_insertPC.Location = new System.Drawing.Point(683, 219);
            this.btn_insertPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_insertPC.Name = "btn_insertPC";
            this.btn_insertPC.Size = new System.Drawing.Size(91, 70);
            this.btn_insertPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_insertPC.TabIndex = 23;
            this.btn_insertPC.TabStop = false;
            this.btn_insertPC.Click += new System.EventHandler(this.btn_insertPC_Click);
            // 
            // lbl_totalPC
            // 
            this.lbl_totalPC.AutoSize = true;
            this.lbl_totalPC.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalPC.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPC.ForeColor = System.Drawing.Color.Red;
            this.lbl_totalPC.Location = new System.Drawing.Point(138, 130);
            this.lbl_totalPC.Name = "lbl_totalPC";
            this.lbl_totalPC.Size = new System.Drawing.Size(40, 34);
            this.lbl_totalPC.TabIndex = 22;
            this.lbl_totalPC.Text = "0";
            // 
            // dgv_PC
            // 
            this.dgv_PC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PC.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_PC.Location = new System.Drawing.Point(3, 326);
            this.dgv_PC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_PC.Name = "dgv_PC";
            this.dgv_PC.RowHeadersWidth = 51;
            this.dgv_PC.RowTemplate.Height = 24;
            this.dgv_PC.Size = new System.Drawing.Size(986, 282);
            this.dgv_PC.TabIndex = 21;
            this.dgv_PC.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_PC_RowHeaderMouseClick);
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.AutoSize = true;
            this.lbl_Modelo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Modelo.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modelo.Location = new System.Drawing.Point(525, 172);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(119, 24);
            this.lbl_Modelo.TabIndex = 18;
            this.lbl_Modelo.Text = "Modelo:";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Marca.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.Location = new System.Drawing.Point(525, 130);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(105, 24);
            this.lbl_Marca.TabIndex = 17;
            this.lbl_Marca.Text = "Marca:";
            // 
            // txt_Model
            // 
            this.txt_Model.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Model.ForeColor = System.Drawing.Color.Red;
            this.txt_Model.Location = new System.Drawing.Point(651, 172);
            this.txt_Model.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(299, 27);
            this.txt_Model.TabIndex = 16;
            // 
            // txt_Brand
            // 
            this.txt_Brand.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Brand.ForeColor = System.Drawing.Color.Red;
            this.txt_Brand.Location = new System.Drawing.Point(651, 130);
            this.txt_Brand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Brand.Name = "txt_Brand";
            this.txt_Brand.Size = new System.Drawing.Size(299, 27);
            this.txt_Brand.TabIndex = 15;
            // 
            // lbl_InsDelPC
            // 
            this.lbl_InsDelPC.AutoSize = true;
            this.lbl_InsDelPC.BackColor = System.Drawing.Color.Transparent;
            this.lbl_InsDelPC.Font = new System.Drawing.Font("ROG Fonts", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsDelPC.Location = new System.Drawing.Point(646, 79);
            this.lbl_InsDelPC.Name = "lbl_InsDelPC";
            this.lbl_InsDelPC.Size = new System.Drawing.Size(346, 29);
            this.lbl_InsDelPC.TabIndex = 14;
            this.lbl_InsDelPC.Text = "Inserir/Apagar PC";
            // 
            // lbl_totalpcText
            // 
            this.lbl_totalpcText.AutoSize = true;
            this.lbl_totalpcText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalpcText.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalpcText.Location = new System.Drawing.Point(5, 79);
            this.lbl_totalpcText.Name = "lbl_totalpcText";
            this.lbl_totalpcText.Size = new System.Drawing.Size(306, 34);
            this.lbl_totalpcText.TabIndex = 2;
            this.lbl_totalpcText.Text = "Total de PC\'s: ";
            // 
            // tp_Movimentos
            // 
            this.tp_Movimentos.BackColor = System.Drawing.Color.White;
            this.tp_Movimentos.Controls.Add(this.btn_Export);
            this.tp_Movimentos.Controls.Add(this.dgv_Transactions);
            this.tp_Movimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_Movimentos.Location = new System.Drawing.Point(4, 28);
            this.tp_Movimentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_Movimentos.Name = "tp_Movimentos";
            this.tp_Movimentos.Size = new System.Drawing.Size(992, 610);
            this.tp_Movimentos.TabIndex = 2;
            this.tp_Movimentos.Text = "Movimentos";
            // 
            // btn_Export
            // 
            this.btn_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Export.Image = global::LanValley.Properties.Resources.export;
            this.btn_Export.Location = new System.Drawing.Point(444, 510);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(105, 95);
            this.btn_Export.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Export.TabIndex = 1;
            this.btn_Export.TabStop = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // dgv_Transactions
            // 
            this.dgv_Transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Transactions.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Transactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_Transactions.Location = new System.Drawing.Point(0, 0);
            this.dgv_Transactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Transactions.Name = "dgv_Transactions";
            this.dgv_Transactions.RowHeadersWidth = 51;
            this.dgv_Transactions.RowTemplate.Height = 24;
            this.dgv_Transactions.Size = new System.Drawing.Size(992, 503);
            this.dgv_Transactions.TabIndex = 0;
            // 
            // tp_addJogos
            // 
            this.tp_addJogos.BackColor = System.Drawing.Color.White;
            this.tp_addJogos.Controls.Add(this.btn_addGame);
            this.tp_addJogos.Controls.Add(this.btn_Search);
            this.tp_addJogos.Controls.Add(this.label2);
            this.tp_addJogos.Controls.Add(this.txt_gameName);
            this.tp_addJogos.Controls.Add(this.label1);
            this.tp_addJogos.Controls.Add(this.dgv_Games);
            this.tp_addJogos.Controls.Add(this.lbL_Texto);
            this.tp_addJogos.Controls.Add(this.txt_exeName);
            this.tp_addJogos.Location = new System.Drawing.Point(4, 28);
            this.tp_addJogos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_addJogos.Name = "tp_addJogos";
            this.tp_addJogos.Size = new System.Drawing.Size(992, 610);
            this.tp_addJogos.TabIndex = 3;
            this.tp_addJogos.Text = "Adicionar Jogos";
            // 
            // btn_addGame
            // 
            this.btn_addGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addGame.Image = global::LanValley.Properties.Resources.submit;
            this.btn_addGame.Location = new System.Drawing.Point(367, 260);
            this.btn_addGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addGame.Name = "btn_addGame";
            this.btn_addGame.Size = new System.Drawing.Size(259, 86);
            this.btn_addGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_addGame.TabIndex = 9;
            this.btn_addGame.TabStop = false;
            this.btn_addGame.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Image = global::LanValley.Properties.Resources.search;
            this.btn_Search.Location = new System.Drawing.Point(779, 181);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(144, 50);
            this.btn_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Search.TabIndex = 8;
            this.btn_Search.TabStop = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Procurar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Introduzir Nome do Jogo:";
            // 
            // txt_gameName
            // 
            this.txt_gameName.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gameName.ForeColor = System.Drawing.Color.Red;
            this.txt_gameName.Location = new System.Drawing.Point(27, 98);
            this.txt_gameName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gameName.Name = "txt_gameName";
            this.txt_gameName.Size = new System.Drawing.Size(897, 27);
            this.txt_gameName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "EXE:";
            // 
            // dgv_Games
            // 
            this.dgv_Games.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Games.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Games.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Games.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Games.Location = new System.Drawing.Point(0, 360);
            this.dgv_Games.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Games.Name = "dgv_Games";
            this.dgv_Games.RowHeadersWidth = 51;
            this.dgv_Games.RowTemplate.Height = 24;
            this.dgv_Games.Size = new System.Drawing.Size(992, 250);
            this.dgv_Games.TabIndex = 4;
            // 
            // lbL_Texto
            // 
            this.lbL_Texto.AutoSize = true;
            this.lbL_Texto.BackColor = System.Drawing.Color.Transparent;
            this.lbL_Texto.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbL_Texto.Location = new System.Drawing.Point(332, 23);
            this.lbL_Texto.Name = "lbL_Texto";
            this.lbL_Texto.Size = new System.Drawing.Size(341, 34);
            this.lbL_Texto.TabIndex = 3;
            this.lbL_Texto.Text = "Adicionar Jogos";
            // 
            // txt_exeName
            // 
            this.txt_exeName.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exeName.ForeColor = System.Drawing.Color.Red;
            this.txt_exeName.Location = new System.Drawing.Point(27, 192);
            this.txt_exeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_exeName.Name = "txt_exeName";
            this.txt_exeName.ReadOnly = true;
            this.txt_exeName.Size = new System.Drawing.Size(747, 27);
            this.txt_exeName.TabIndex = 0;
            // 
            // ts_Menu
            // 
            this.ts_Menu.AutoSize = false;
            this.ts_Menu.BackColor = System.Drawing.Color.Transparent;
            this.ts_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Lock,
            this.tsb_Exit});
            this.ts_Menu.Location = new System.Drawing.Point(0, 100);
            this.ts_Menu.Name = "ts_Menu";
            this.ts_Menu.Padding = new System.Windows.Forms.Padding(0);
            this.ts_Menu.Size = new System.Drawing.Size(1000, 55);
            this.ts_Menu.TabIndex = 2;
            this.ts_Menu.Text = "Menu";
            // 
            // tsb_Lock
            // 
            this.tsb_Lock.AutoSize = false;
            this.tsb_Lock.BackColor = System.Drawing.Color.Transparent;
            this.tsb_Lock.BackgroundImage = global::LanValley.Properties.Resources._lock;
            this.tsb_Lock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsb_Lock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Lock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Lock.Name = "tsb_Lock";
            this.tsb_Lock.Size = new System.Drawing.Size(40, 40);
            this.tsb_Lock.Text = "Bloquear";
            this.tsb_Lock.Click += new System.EventHandler(this.tsb_Lock_Click);
            // 
            // tsb_Exit
            // 
            this.tsb_Exit.AutoSize = false;
            this.tsb_Exit.BackColor = System.Drawing.Color.Transparent;
            this.tsb_Exit.BackgroundImage = global::LanValley.Properties.Resources.exit;
            this.tsb_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsb_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Exit.Name = "tsb_Exit";
            this.tsb_Exit.Size = new System.Drawing.Size(40, 40);
            this.tsb_Exit.Text = "Sair";
            this.tsb_Exit.Click += new System.EventHandler(this.tsb_Exit_Click);
            // 
            // searchGame
            // 
            this.searchGame.Filter = "\"EXE files (*.exe)|*.exe|All files (*.*)|*.*\"";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Image = global::LanValley.Properties.Resources.LAN_Valley__Transparent;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1000, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.ts_Menu);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administração";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_Users.ResumeLayout(false);
            this.tp_Users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deleteUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_updateUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_insertUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.tp_PC.ResumeLayout(false);
            this.tp_PC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deletePC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_insertPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PC)).EndInit();
            this.tp_Movimentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Export)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transactions)).EndInit();
            this.tp_addJogos.ResumeLayout(false);
            this.tp_addJogos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Games)).EndInit();
            this.ts_Menu.ResumeLayout(false);
            this.ts_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Users;
        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.TabPage tp_Movimentos;
        private System.Windows.Forms.ToolStrip ts_Menu;
        private System.Windows.Forms.Label lbl_totalusersText;
        private System.Windows.Forms.ToolStripButton tsb_Lock;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_InsModUser;
        private System.Windows.Forms.TextBox txt_searchUser;
        private System.Windows.Forms.Label lbl_searchUser;
        private System.Windows.Forms.DataGridView dgv_Transactions;
        private System.Windows.Forms.TabPage tp_addJogos;
        private System.Windows.Forms.Label lbL_Texto;
        private System.Windows.Forms.TextBox txt_exeName;
        private System.Windows.Forms.OpenFileDialog searchGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_gameName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Games;
        private System.Windows.Forms.ToolStripButton tsb_Exit;
        private System.Windows.Forms.Label lbl_totalUsers;
        private System.Windows.Forms.PictureBox btn_deleteUser;
        private System.Windows.Forms.PictureBox btn_updateUser;
        private System.Windows.Forms.PictureBox btn_insertUser;
        private System.Windows.Forms.TabPage tp_PC;
        private System.Windows.Forms.Label lbl_totalPC;
        private System.Windows.Forms.DataGridView dgv_PC;
        private System.Windows.Forms.Label lbl_Modelo;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox txt_Brand;
        private System.Windows.Forms.Label lbl_InsDelPC;
        private System.Windows.Forms.Label lbl_totalpcText;
        private System.Windows.Forms.PictureBox btn_deletePC;
        private System.Windows.Forms.PictureBox btn_insertPC;
        private System.Windows.Forms.PictureBox btn_Export;
        private System.Windows.Forms.PictureBox btn_Search;
        private System.Windows.Forms.PictureBox btn_addGame;
    }
}