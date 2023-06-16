namespace ChessRank
{
    partial class Mainscreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainscreen));
            this.label1 = new System.Windows.Forms.Label();
            this.tablePlayer = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.Label();
            this.removePlayer = new System.Windows.Forms.Button();
            this.editPlayer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rankingDeJogadores = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRatingPlayer = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePlayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 65;
            // 
            // tablePlayer
            // 
            this.tablePlayer.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.tablePlayer.AllowUserToAddRows = false;
            this.tablePlayer.AllowUserToDeleteRows = false;
            this.tablePlayer.AllowUserToResizeColumns = false;
            this.tablePlayer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePlayer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablePlayer.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.tablePlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePlayer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.tablePlayer.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.tablePlayer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePlayer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablePlayer.ColumnHeadersHeight = 22;
            this.tablePlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dubai", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePlayer.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablePlayer.EnableHeadersVisualStyles = false;
            this.tablePlayer.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablePlayer.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tablePlayer.Location = new System.Drawing.Point(46, 110);
            this.tablePlayer.MultiSelect = false;
            this.tablePlayer.Name = "tablePlayer";
            this.tablePlayer.ReadOnly = true;
            this.tablePlayer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePlayer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablePlayer.RowHeadersVisible = false;
            this.tablePlayer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePlayer.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tablePlayer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePlayer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tablePlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablePlayer.ShowCellErrors = false;
            this.tablePlayer.ShowCellToolTips = false;
            this.tablePlayer.ShowEditingIcon = false;
            this.tablePlayer.ShowRowErrors = false;
            this.tablePlayer.Size = new System.Drawing.Size(199, 375);
            this.tablePlayer.StandardTab = true;
            this.tablePlayer.TabIndex = 109;
            this.tablePlayer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePlayer_CellContentClick);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(281, -2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(310, 75);
            this.title.TabIndex = 112;
            this.title.Text = "RANK CHESS";
            // 
            // removePlayer
            // 
            this.removePlayer.BackColor = System.Drawing.Color.MistyRose;
            this.removePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removePlayer.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.removePlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.removePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.removePlayer.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePlayer.Location = new System.Drawing.Point(158, 522);
            this.removePlayer.Name = "removePlayer";
            this.removePlayer.Size = new System.Drawing.Size(138, 29);
            this.removePlayer.TabIndex = 114;
            this.removePlayer.Text = "Remover jogador";
            this.removePlayer.UseVisualStyleBackColor = false;
            this.removePlayer.Click += new System.EventHandler(this.removePlayer_Click);
            // 
            // editPlayer
            // 
            this.editPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editPlayer.Cursor = System.Windows.Forms.Cursors.Default;
            this.editPlayer.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.editPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.editPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.editPlayer.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPlayer.Location = new System.Drawing.Point(12, 491);
            this.editPlayer.Name = "editPlayer";
            this.editPlayer.Size = new System.Drawing.Size(80, 60);
            this.editPlayer.TabIndex = 115;
            this.editPlayer.Text = "Editar";
            this.editPlayer.UseVisualStyleBackColor = false;
            this.editPlayer.Click += new System.EventHandler(this.editPlayer_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(158, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 27);
            this.button3.TabIndex = 116;
            this.button3.Text = "Adicionar jogador";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.newPlayer);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dubai", 8.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(731, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 117;
            this.label2.Text = "Clube de xadrez Campestre";
            // 
            // rankingDeJogadores
            // 
            this.rankingDeJogadores.AutoSize = true;
            this.rankingDeJogadores.BackColor = System.Drawing.Color.Transparent;
            this.rankingDeJogadores.Font = new System.Drawing.Font("Dubai", 8.25F);
            this.rankingDeJogadores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rankingDeJogadores.Location = new System.Drawing.Point(100, 89);
            this.rankingDeJogadores.Name = "rankingDeJogadores";
            this.rankingDeJogadores.Size = new System.Drawing.Size(104, 18);
            this.rankingDeJogadores.TabIndex = 118;
            this.rankingDeJogadores.Text = "Ranking de jogadores";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblRatingPlayer);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblNamePlayer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(512, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 398);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 18);
            this.label7.TabIndex = 129;
            this.label7.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 18);
            this.label4.TabIndex = 128;
            this.label4.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(20, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // lblRatingPlayer
            // 
            this.lblRatingPlayer.AutoSize = true;
            this.lblRatingPlayer.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingPlayer.Location = new System.Drawing.Point(123, 249);
            this.lblRatingPlayer.Name = "lblRatingPlayer";
            this.lblRatingPlayer.Size = new System.Drawing.Size(0, 18);
            this.lblRatingPlayer.TabIndex = 122;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(338, 309);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(12, 18);
            this.lblCidade.TabIndex = 125;
            this.lblCidade.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 121;
            this.label3.Text = "Rating";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(85, 319);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(12, 18);
            this.lblEstado.TabIndex = 126;
            this.lblEstado.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 124;
            this.label6.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 18);
            this.label9.TabIndex = 127;
            this.label9.Text = "Nome";
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.Location = new System.Drawing.Point(123, 43);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(12, 18);
            this.lblNamePlayer.TabIndex = 120;
            this.lblNamePlayer.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 123;
            this.label5.Text = "Estado";
            // 
            // Mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::ChessRank.Properties.Resources.leader_success_chess_pieces;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rankingDeJogadores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.editPlayer);
            this.Controls.Add(this.removePlayer);
            this.Controls.Add(this.title);
            this.Controls.Add(this.tablePlayer);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainscreen";
            this.Text = "RankChess";
            ((System.ComponentModel.ISupportInitialize)(this.tablePlayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablePlayer;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button removePlayer;
        private System.Windows.Forms.Button editPlayer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rankingDeJogadores;
        private System.Windows.Forms.Label lblNamePlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRatingPlayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}

