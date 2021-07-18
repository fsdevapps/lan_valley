
namespace LanValley
{
    partial class frmJogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogos));
            this.gameArea = new System.Windows.Forms.Panel();
            this.btn_Browser = new System.Windows.Forms.PictureBox();
            this.btn_playSelected = new System.Windows.Forms.PictureBox();
            this.lbl_gameName = new System.Windows.Forms.Label();
            this.dgv_Games = new System.Windows.Forms.DataGridView();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.gameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Browser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_playSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Games)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gameArea
            // 
            this.gameArea.Controls.Add(this.btn_Browser);
            this.gameArea.Controls.Add(this.btn_playSelected);
            this.gameArea.Controls.Add(this.lbl_gameName);
            this.gameArea.Controls.Add(this.dgv_Games);
            this.gameArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameArea.Location = new System.Drawing.Point(0, 100);
            this.gameArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(1000, 700);
            this.gameArea.TabIndex = 2;
            // 
            // btn_Browser
            // 
            this.btn_Browser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Browser.Image = global::LanValley.Properties.Resources.browser;
            this.btn_Browser.Location = new System.Drawing.Point(633, 582);
            this.btn_Browser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Browser.Name = "btn_Browser";
            this.btn_Browser.Size = new System.Drawing.Size(235, 86);
            this.btn_Browser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Browser.TabIndex = 8;
            this.btn_Browser.TabStop = false;
            this.btn_Browser.Click += new System.EventHandler(this.btn_Browser_Click);
            // 
            // btn_playSelected
            // 
            this.btn_playSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_playSelected.Image = global::LanValley.Properties.Resources.play;
            this.btn_playSelected.Location = new System.Drawing.Point(672, 103);
            this.btn_playSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_playSelected.Name = "btn_playSelected";
            this.btn_playSelected.Size = new System.Drawing.Size(157, 85);
            this.btn_playSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_playSelected.TabIndex = 7;
            this.btn_playSelected.TabStop = false;
            this.btn_playSelected.Click += new System.EventHandler(this.btn_playSelected_Click);
            // 
            // lbl_gameName
            // 
            this.lbl_gameName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gameName.Font = new System.Drawing.Font("ROG Fonts", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameName.Location = new System.Drawing.Point(629, 52);
            this.lbl_gameName.Name = "lbl_gameName";
            this.lbl_gameName.Size = new System.Drawing.Size(241, 30);
            this.lbl_gameName.TabIndex = 4;
            this.lbl_gameName.Text = "Nome do Jogo";
            this.lbl_gameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Games
            // 
            this.dgv_Games.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Games.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Games.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_Games.Location = new System.Drawing.Point(0, 0);
            this.dgv_Games.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Games.Name = "dgv_Games";
            this.dgv_Games.RowHeadersWidth = 51;
            this.dgv_Games.RowTemplate.Height = 24;
            this.dgv_Games.Size = new System.Drawing.Size(492, 700);
            this.dgv_Games.TabIndex = 1;
            this.dgv_Games.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Jogos_RowHeaderMouseClick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImage = global::LanValley.Properties.Resources.back;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(5, 58);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(44, 37);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
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
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // frmJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.gameArea);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogos";
            this.Load += new System.EventHandler(this.frmJogos_Load);
            this.gameArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Browser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_playSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Games)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel gameArea;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DataGridView dgv_Games;
        private System.Windows.Forms.Label lbl_gameName;
        private System.Windows.Forms.PictureBox btn_Browser;
        private System.Windows.Forms.PictureBox btn_playSelected;
    }
}