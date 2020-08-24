namespace TodoApp.Pages
{
    partial class AddTask
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
            this.backBtn = new FontAwesome.Sharp.IconPictureBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.activityGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_do_responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_prevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_de_execucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityLbl = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.descTblTxt = new System.Windows.Forms.TextBox();
            this.dtPrevTxt = new System.Windows.Forms.TextBox();
            this.dtExecTxt = new System.Windows.Forms.TextBox();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.createListBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.backBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.backBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.backBtn.IconSize = 45;
            this.backBtn.Location = new System.Drawing.Point(1, 453);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(60, 45);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 1;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.titleLbl.Location = new System.Drawing.Point(14, 76);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(68, 30);
            this.titleLbl.TabIndex = 10;
            this.titleLbl.Text = "Título";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.descriptionLbl.Location = new System.Drawing.Point(472, 76);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(104, 30);
            this.descriptionLbl.TabIndex = 14;
            this.descriptionLbl.Text = "Descrição";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.BackColor = System.Drawing.Color.Transparent;
            this.categoryLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.categoryLbl.Location = new System.Drawing.Point(245, 76);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(106, 30);
            this.categoryLbl.TabIndex = 12;
            this.categoryLbl.Text = "Categoria";
            // 
            // activityGridView
            // 
            this.activityGridView.AllowUserToAddRows = false;
            this.activityGridView.AllowUserToOrderColumns = true;
            this.activityGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.email_do_responsavel,
            this.descricao,
            this.data_prevista,
            this.data_de_execucao,
            this.status});
            this.activityGridView.Location = new System.Drawing.Point(19, 188);
            this.activityGridView.Name = "activityGridView";
            this.activityGridView.Size = new System.Drawing.Size(769, 241);
            this.activityGridView.TabIndex = 18;
            this.activityGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activityGridView_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // email_do_responsavel
            // 
            this.email_do_responsavel.HeaderText = "Email do Responsável";
            this.email_do_responsavel.Name = "email_do_responsavel";
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // data_prevista
            // 
            this.data_prevista.HeaderText = "Data Prevista";
            this.data_prevista.Name = "data_prevista";
            // 
            // data_de_execucao
            // 
            this.data_de_execucao.HeaderText = "Data de Execução";
            this.data_de_execucao.Name = "data_de_execucao";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // activityLbl
            // 
            this.activityLbl.AutoSize = true;
            this.activityLbl.BackColor = System.Drawing.Color.Transparent;
            this.activityLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.activityLbl.Location = new System.Drawing.Point(14, 155);
            this.activityLbl.Name = "activityLbl";
            this.activityLbl.Size = new System.Drawing.Size(113, 30);
            this.activityLbl.TabIndex = 19;
            this.activityLbl.Text = "Atividades";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(19, 110);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(184, 20);
            this.titleTxt.TabIndex = 25;
            // 
            // categoryTxt
            // 
            this.categoryTxt.Location = new System.Drawing.Point(250, 110);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(184, 20);
            this.categoryTxt.TabIndex = 26;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(477, 110);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(184, 20);
            this.descriptionTxt.TabIndex = 27;
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.Snow;
            this.removeBtn.Location = new System.Drawing.Point(713, 151);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 33);
            this.removeBtn.TabIndex = 28;
            this.removeBtn.Text = "Remover";
            this.removeBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Snow;
            this.addBtn.Location = new System.Drawing.Point(632, 151);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 33);
            this.addBtn.TabIndex = 29;
            this.addBtn.Text = "Add...";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTxt.Location = new System.Drawing.Point(158, 431);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(103, 20);
            this.emailTxt.TabIndex = 30;
            // 
            // descTblTxt
            // 
            this.descTblTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descTblTxt.Location = new System.Drawing.Point(267, 431);
            this.descTblTxt.Name = "descTblTxt";
            this.descTblTxt.Size = new System.Drawing.Size(217, 20);
            this.descTblTxt.TabIndex = 31;
            // 
            // dtPrevTxt
            // 
            this.dtPrevTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPrevTxt.Location = new System.Drawing.Point(490, 431);
            this.dtPrevTxt.Name = "dtPrevTxt";
            this.dtPrevTxt.Size = new System.Drawing.Size(95, 20);
            this.dtPrevTxt.TabIndex = 32;
            // 
            // dtExecTxt
            // 
            this.dtExecTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtExecTxt.Location = new System.Drawing.Point(591, 431);
            this.dtExecTxt.Name = "dtExecTxt";
            this.dtExecTxt.Size = new System.Drawing.Size(95, 20);
            this.dtExecTxt.TabIndex = 33;
            // 
            // statusTxt
            // 
            this.statusTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTxt.Location = new System.Drawing.Point(692, 431);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(96, 20);
            this.statusTxt.TabIndex = 34;
            // 
            // createListBtn
            // 
            this.createListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.createListBtn.FlatAppearance.BorderSize = 0;
            this.createListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createListBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createListBtn.ForeColor = System.Drawing.Color.White;
            this.createListBtn.Location = new System.Drawing.Point(308, 465);
            this.createListBtn.Name = "createListBtn";
            this.createListBtn.Size = new System.Drawing.Size(255, 34);
            this.createListBtn.TabIndex = 35;
            this.createListBtn.Text = "Criar Lista";
            this.createListBtn.UseVisualStyleBackColor = false;
            this.createListBtn.Click += new System.EventHandler(this.CreateListBtn_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 510);
            this.Controls.Add(this.createListBtn);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.dtExecTxt);
            this.Controls.Add(this.dtPrevTxt);
            this.Controls.Add(this.descTblTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.activityLbl);
            this.Controls.Add(this.activityGridView);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.backBtn);
            this.MinimumSize = new System.Drawing.Size(820, 510);
            this.Name = "AddTask";
            this.Text = "Adicionar uma lista";
            this.Load += new System.EventHandler(this.AddTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox backBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.DataGridView activityGridView;
        private System.Windows.Forms.Label activityLbl;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox categoryTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_do_responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_prevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_de_execucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox descTblTxt;
        private System.Windows.Forms.TextBox dtPrevTxt;
        private System.Windows.Forms.TextBox dtExecTxt;
        private System.Windows.Forms.TextBox statusTxt;
        private System.Windows.Forms.Button createListBtn;
    }
}