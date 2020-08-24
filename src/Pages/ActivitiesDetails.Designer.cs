namespace TodoApp.src.Pages
{
    partial class ActivitiesDetails
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.ownerText = new System.Windows.Forms.Label();
            this.ownerLbl = new System.Windows.Forms.Label();
            this.activitiesLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.activityGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_do_responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_prevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_de_execucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleText = new System.Windows.Forms.TextBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.updateListBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.categoryText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activityGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.titleLbl.Location = new System.Drawing.Point(12, 80);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(68, 30);
            this.titleLbl.TabIndex = 21;
            this.titleLbl.Text = "Título";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.descriptionLbl.Location = new System.Drawing.Point(370, 80);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(104, 30);
            this.descriptionLbl.TabIndex = 23;
            this.descriptionLbl.Text = "Descrição";
            // 
            // ownerText
            // 
            this.ownerText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ownerText.AutoSize = true;
            this.ownerText.BackColor = System.Drawing.Color.Transparent;
            this.ownerText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ownerText.Location = new System.Drawing.Point(12, 187);
            this.ownerText.Name = "ownerText";
            this.ownerText.Size = new System.Drawing.Size(43, 25);
            this.ownerText.TabIndex = 26;
            this.ownerText.Text = "lbl3";
            // 
            // ownerLbl
            // 
            this.ownerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ownerLbl.AutoSize = true;
            this.ownerLbl.BackColor = System.Drawing.Color.Transparent;
            this.ownerLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ownerLbl.Location = new System.Drawing.Point(12, 157);
            this.ownerLbl.Name = "ownerLbl";
            this.ownerLbl.Size = new System.Drawing.Size(128, 30);
            this.ownerLbl.TabIndex = 25;
            this.ownerLbl.Text = "Proprietário";
            // 
            // activitiesLbl
            // 
            this.activitiesLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activitiesLbl.AutoSize = true;
            this.activitiesLbl.BackColor = System.Drawing.Color.Transparent;
            this.activitiesLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activitiesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.activitiesLbl.Location = new System.Drawing.Point(12, 442);
            this.activitiesLbl.Name = "activitiesLbl";
            this.activitiesLbl.Size = new System.Drawing.Size(113, 30);
            this.activitiesLbl.TabIndex = 27;
            this.activitiesLbl.Text = "Atividades";
            // 
            // categoryLbl
            // 
            this.categoryLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.BackColor = System.Drawing.Color.Transparent;
            this.categoryLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.categoryLbl.Location = new System.Drawing.Point(370, 157);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(106, 30);
            this.categoryLbl.TabIndex = 28;
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
            this.activityGridView.Location = new System.Drawing.Point(17, 228);
            this.activityGridView.Name = "activityGridView";
            this.activityGridView.Size = new System.Drawing.Size(776, 211);
            this.activityGridView.TabIndex = 30;
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
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(17, 110);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(286, 20);
            this.titleText.TabIndex = 31;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(375, 110);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(418, 36);
            this.descriptionText.TabIndex = 32;
            // 
            // updateListBtn
            // 
            this.updateListBtn.Depth = 0;
            this.updateListBtn.Location = new System.Drawing.Point(647, 450);
            this.updateListBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateListBtn.Name = "updateListBtn";
            this.updateListBtn.Primary = true;
            this.updateListBtn.Size = new System.Drawing.Size(146, 45);
            this.updateListBtn.TabIndex = 34;
            this.updateListBtn.Text = "Atualizar Lista";
            this.updateListBtn.UseVisualStyleBackColor = true;
            this.updateListBtn.Click += new System.EventHandler(this.UpdateListBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deleteBtn.IconColor = System.Drawing.Color.Red;
            this.deleteBtn.IconSize = 32;
            this.deleteBtn.Location = new System.Drawing.Point(587, 450);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Rotation = 0D;
            this.deleteBtn.Size = new System.Drawing.Size(45, 45);
            this.deleteBtn.TabIndex = 35;
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // categoryText
            // 
            this.categoryText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryText.AutoSize = true;
            this.categoryText.BackColor = System.Drawing.Color.Transparent;
            this.categoryText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.categoryText.Location = new System.Drawing.Point(370, 187);
            this.categoryText.Name = "categoryText";
            this.categoryText.Size = new System.Drawing.Size(43, 25);
            this.categoryText.TabIndex = 36;
            this.categoryText.Text = "lbl4";
            // 
            // ActivitiesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 507);
            this.Controls.Add(this.categoryText);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateListBtn);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.activityGridView);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.activitiesLbl);
            this.Controls.Add(this.ownerText);
            this.Controls.Add(this.ownerLbl);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.titleLbl);
            this.MinimumSize = new System.Drawing.Size(805, 467);
            this.Name = "ActivitiesDetails";
            this.Text = "Detalhamento da Atividade";
            this.Load += new System.EventHandler(this.ActivitiesDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label ownerText;
        private System.Windows.Forms.Label ownerLbl;
        private System.Windows.Forms.Label activitiesLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.DataGridView activityGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_do_responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_prevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_de_execucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox descriptionText;
        private MaterialSkin.Controls.MaterialRaisedButton updateListBtn;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.Label categoryText;
    }
}