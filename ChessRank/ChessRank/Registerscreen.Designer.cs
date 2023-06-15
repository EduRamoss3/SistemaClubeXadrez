namespace ChessRank
{
    partial class Registerscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registerscreen));
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.labelRating = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            this.textRating = new System.Windows.Forms.TextBox();
            this.labelEstate = new System.Windows.Forms.Label();
            this.textEstate = new System.Windows.Forms.TextBox();
            this.radioMasc = new System.Windows.Forms.RadioButton();
            this.radioFemini = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrors = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(193, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOVO JOGADOR";
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelName.Location = new System.Drawing.Point(18, 77);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 27);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nome ";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegister.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(662, 394);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(126, 44);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "CADASTRAR";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.saveAction);
            // 
            // labelRating
            // 
            this.labelRating.BackColor = System.Drawing.Color.Transparent;
            this.labelRating.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRating.Location = new System.Drawing.Point(18, 121);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(103, 23);
            this.labelRating.TabIndex = 7;
            this.labelRating.Text = "Rating atual";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(23, 98);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(322, 20);
            this.textName.TabIndex = 8;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(23, 194);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(100, 20);
            this.textCity.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(481, 394);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 44);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "VOLTAR";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // labelCity
            // 
            this.labelCity.BackColor = System.Drawing.Color.Transparent;
            this.labelCity.Font = new System.Drawing.Font("Dubai", 12F);
            this.labelCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCity.Location = new System.Drawing.Point(18, 170);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(85, 21);
            this.labelCity.TabIndex = 11;
            this.labelCity.Text = "Cidade";
            this.labelCity.Click += new System.EventHandler(this.label2_Click);
            // 
            // textRating
            // 
            this.textRating.Location = new System.Drawing.Point(23, 147);
            this.textRating.Name = "textRating";
            this.textRating.Size = new System.Drawing.Size(100, 20);
            this.textRating.TabIndex = 12;
            // 
            // labelEstate
            // 
            this.labelEstate.BackColor = System.Drawing.Color.Transparent;
            this.labelEstate.Font = new System.Drawing.Font("Dubai", 12F);
            this.labelEstate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEstate.Location = new System.Drawing.Point(20, 217);
            this.labelEstate.Name = "labelEstate";
            this.labelEstate.Size = new System.Drawing.Size(70, 24);
            this.labelEstate.TabIndex = 13;
            this.labelEstate.Text = "Estado";
            this.labelEstate.Click += new System.EventHandler(this.labelEstate_Click);
            // 
            // textEstate
            // 
            this.textEstate.Location = new System.Drawing.Point(23, 244);
            this.textEstate.Name = "textEstate";
            this.textEstate.Size = new System.Drawing.Size(100, 20);
            this.textEstate.TabIndex = 14;
            // 
            // radioMasc
            // 
            this.radioMasc.AutoSize = true;
            this.radioMasc.Location = new System.Drawing.Point(6, 30);
            this.radioMasc.Name = "radioMasc";
            this.radioMasc.Size = new System.Drawing.Size(96, 31);
            this.radioMasc.TabIndex = 15;
            this.radioMasc.TabStop = true;
            this.radioMasc.Text = "Masculino";
            this.radioMasc.UseVisualStyleBackColor = true;
            this.radioMasc.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioFemini
            // 
            this.radioFemini.AutoSize = true;
            this.radioFemini.Location = new System.Drawing.Point(109, 29);
            this.radioFemini.Name = "radioFemini";
            this.radioFemini.Size = new System.Drawing.Size(89, 31);
            this.radioFemini.TabIndex = 16;
            this.radioFemini.TabStop = true;
            this.radioFemini.Text = "Feminino";
            this.radioFemini.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioMasc);
            this.groupBox1.Controls.Add(this.radioFemini);
            this.groupBox1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(23, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 70);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblErrors
            // 
            this.lblErrors.BackColor = System.Drawing.Color.Transparent;
            this.lblErrors.ForeColor = System.Drawing.Color.Red;
            this.lblErrors.Location = new System.Drawing.Point(20, 394);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(437, 44);
            this.lblErrors.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(270, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Pronto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblId.Location = new System.Drawing.Point(87, 62);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 18);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "id";
            this.lblId.Visible = false;
            // 
            // lblIdName
            // 
            this.lblIdName.AutoSize = true;
            this.lblIdName.BackColor = System.Drawing.Color.Transparent;
            this.lblIdName.Font = new System.Drawing.Font("Dubai Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdName.Location = new System.Drawing.Point(20, 62);
            this.lblIdName.Name = "lblIdName";
            this.lblIdName.Size = new System.Drawing.Size(69, 18);
            this.lblIdName.TabIndex = 21;
            this.lblIdName.Text = "Jogador ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ChessRank.Properties.Resources.pngfind_com_blur_png_544255;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnInput
            // 
            this.btnInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInput.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInput.Font = new System.Drawing.Font("Dubai Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInput.Location = new System.Drawing.Point(554, 302);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(180, 27);
            this.btnInput.TabIndex = 23;
            this.btnInput.Text = "Insira uma imagem de perfil";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = global::ChessRank.Properties.Resources.pngfind_com_blur_png_544255;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Dubai Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(537, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 214);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perfil";
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(684, 337);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(59, 13);
            this.lblDirectory.TabIndex = 26;
            this.lblDirectory.Text = "lblDirectory";
            this.lblDirectory.Visible = false;
            // 
            // Registerscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::ChessRank.Properties.Resources.leader_success_chess_pieces;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lblIdName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textEstate);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.labelEstate);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Registerscreen";
            this.Text = "Tela de cadastro";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textRating;
        private System.Windows.Forms.Label labelEstate;
        private System.Windows.Forms.TextBox textEstate;
        private System.Windows.Forms.RadioButton radioMasc;
        private System.Windows.Forms.RadioButton radioFemini;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDirectory;
    }
}