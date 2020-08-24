namespace TodoApp.Pages
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.captionLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.rpassTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.surnameTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.phoneTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.emailTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nameTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cadBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rPasslbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.registerLbl = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panelLeft.Controls.Add(this.captionLbl);
            this.panelLeft.Controls.Add(this.titleLbl);
            this.panelLeft.Controls.Add(this.logoBox);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(373, 500);
            this.panelLeft.TabIndex = 0;
            // 
            // captionLbl
            // 
            this.captionLbl.AutoSize = true;
            this.captionLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLbl.ForeColor = System.Drawing.Color.White;
            this.captionLbl.Location = new System.Drawing.Point(54, 263);
            this.captionLbl.Name = "captionLbl";
            this.captionLbl.Size = new System.Drawing.Size(249, 37);
            this.captionLbl.TabIndex = 2;
            this.captionLbl.Text = "Programe-se, Viva!";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(181, 203);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(85, 37);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "ToDo";
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(75, 30);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(191, 196);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.rpassTxt);
            this.panelRight.Controls.Add(this.passTxt);
            this.panelRight.Controls.Add(this.surnameLbl);
            this.panelRight.Controls.Add(this.surnameTxt);
            this.panelRight.Controls.Add(this.phoneTxt);
            this.panelRight.Controls.Add(this.emailTxt);
            this.panelRight.Controls.Add(this.nameTxt);
            this.panelRight.Controls.Add(this.cadBtn);
            this.panelRight.Controls.Add(this.rPasslbl);
            this.panelRight.Controls.Add(this.passLbl);
            this.panelRight.Controls.Add(this.phoneLbl);
            this.panelRight.Controls.Add(this.emailLbl);
            this.panelRight.Controls.Add(this.nameLbl);
            this.panelRight.Controls.Add(this.registerLbl);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(373, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(387, 500);
            this.panelRight.TabIndex = 1;
            // 
            // rpassTxt
            // 
            this.rpassTxt.Depth = 0;
            this.rpassTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.rpassTxt.Hint = "";
            this.rpassTxt.Location = new System.Drawing.Point(192, 312);
            this.rpassTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.rpassTxt.Name = "rpassTxt";
            this.rpassTxt.PasswordChar = '\0';
            this.rpassTxt.SelectedText = "";
            this.rpassTxt.SelectionLength = 0;
            this.rpassTxt.SelectionStart = 0;
            this.rpassTxt.Size = new System.Drawing.Size(148, 23);
            this.rpassTxt.TabIndex = 15;
            this.rpassTxt.UseSystemPasswordChar = false;
            // 
            // passTxt
            // 
            this.passTxt.Depth = 0;
            this.passTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.passTxt.Hint = "";
            this.passTxt.Location = new System.Drawing.Point(31, 312);
            this.passTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '\0';
            this.passTxt.SelectedText = "";
            this.passTxt.SelectionLength = 0;
            this.passTxt.SelectionStart = 0;
            this.passTxt.Size = new System.Drawing.Size(148, 23);
            this.passTxt.TabIndex = 14;
            this.passTxt.UseSystemPasswordChar = false;
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.surnameLbl.Location = new System.Drawing.Point(186, 89);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(121, 30);
            this.surnameLbl.TabIndex = 13;
            this.surnameLbl.Text = "Sobrenome";
            // 
            // surnameTxt
            // 
            this.surnameTxt.Depth = 0;
            this.surnameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.surnameTxt.Hint = "";
            this.surnameTxt.Location = new System.Drawing.Point(191, 125);
            this.surnameTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.PasswordChar = '\0';
            this.surnameTxt.SelectedText = "";
            this.surnameTxt.SelectionLength = 0;
            this.surnameTxt.SelectionStart = 0;
            this.surnameTxt.Size = new System.Drawing.Size(148, 23);
            this.surnameTxt.TabIndex = 12;
            this.surnameTxt.UseSystemPasswordChar = false;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Depth = 0;
            this.phoneTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.phoneTxt.Hint = "";
            this.phoneTxt.Location = new System.Drawing.Point(191, 211);
            this.phoneTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.PasswordChar = '\0';
            this.phoneTxt.SelectedText = "";
            this.phoneTxt.SelectionLength = 0;
            this.phoneTxt.SelectionStart = 0;
            this.phoneTxt.Size = new System.Drawing.Size(148, 23);
            this.phoneTxt.TabIndex = 11;
            this.phoneTxt.UseSystemPasswordChar = false;
            // 
            // emailTxt
            // 
            this.emailTxt.Depth = 0;
            this.emailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.emailTxt.Hint = "";
            this.emailTxt.Location = new System.Drawing.Point(30, 211);
            this.emailTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.SelectedText = "";
            this.emailTxt.SelectionLength = 0;
            this.emailTxt.SelectionStart = 0;
            this.emailTxt.Size = new System.Drawing.Size(148, 23);
            this.emailTxt.TabIndex = 10;
            this.emailTxt.UseSystemPasswordChar = false;
            // 
            // nameTxt
            // 
            this.nameTxt.Depth = 0;
            this.nameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.nameTxt.Hint = "";
            this.nameTxt.Location = new System.Drawing.Point(30, 125);
            this.nameTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.SelectedText = "";
            this.nameTxt.SelectionLength = 0;
            this.nameTxt.SelectionStart = 0;
            this.nameTxt.Size = new System.Drawing.Size(148, 23);
            this.nameTxt.TabIndex = 9;
            this.nameTxt.UseSystemPasswordChar = false;
            // 
            // cadBtn
            // 
            this.cadBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.cadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadBtn.Depth = 0;
            this.cadBtn.FlatAppearance.BorderSize = 0;
            this.cadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadBtn.ForeColor = System.Drawing.Color.Black;
            this.cadBtn.Location = new System.Drawing.Point(141, 400);
            this.cadBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cadBtn.Name = "cadBtn";
            this.cadBtn.Primary = true;
            this.cadBtn.Size = new System.Drawing.Size(95, 35);
            this.cadBtn.TabIndex = 8;
            this.cadBtn.Text = "Cadastrar";
            this.cadBtn.UseVisualStyleBackColor = false;
            this.cadBtn.Click += new System.EventHandler(this.CadBtn_Click);
            // 
            // rPasslbl
            // 
            this.rPasslbl.AutoSize = true;
            this.rPasslbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rPasslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.rPasslbl.Location = new System.Drawing.Point(186, 270);
            this.rPasslbl.Name = "rPasslbl";
            this.rPasslbl.Size = new System.Drawing.Size(156, 30);
            this.rPasslbl.TabIndex = 7;
            this.rPasslbl.Text = "Repita a Senha";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.passLbl.Location = new System.Drawing.Point(25, 270);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(71, 30);
            this.passLbl.TabIndex = 6;
            this.passLbl.Text = "Senha";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.phoneLbl.Location = new System.Drawing.Point(186, 175);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(95, 30);
            this.phoneLbl.TabIndex = 5;
            this.phoneLbl.Text = "Telefone";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.emailLbl.Location = new System.Drawing.Point(25, 175);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(67, 30);
            this.emailLbl.TabIndex = 4;
            this.emailLbl.Text = "Email";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.nameLbl.Location = new System.Drawing.Point(25, 89);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(71, 30);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Nome";
            // 
            // registerLbl
            // 
            this.registerLbl.AutoSize = true;
            this.registerLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.registerLbl.Location = new System.Drawing.Point(23, 9);
            this.registerLbl.Name = "registerLbl";
            this.registerLbl.Size = new System.Drawing.Size(161, 37);
            this.registerLbl.TabIndex = 2;
            this.registerLbl.Text = "Registre-se";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimumSize = new System.Drawing.Size(760, 500);
            this.Name = "Register";
            this.Text = "Register";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label captionLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label registerLbl;
        private System.Windows.Forms.Label rPasslbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label nameLbl;
        private MaterialSkin.Controls.MaterialRaisedButton cadBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField rpassTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField passTxt;
        private System.Windows.Forms.Label surnameLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField surnameTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField phoneTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailTxt;
    }
}