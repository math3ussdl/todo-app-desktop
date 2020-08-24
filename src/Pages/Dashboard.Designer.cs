namespace TodoApp
{
    partial class Dashboard
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
            this.addListBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.logoutLbl = new System.Windows.Forms.Label();
            this.dividerLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.tasksGridView = new System.Windows.Forms.DataGridView();
            this.activityLbl = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atividades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tasksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addListBtn
            // 
            this.addListBtn.Depth = 0;
            this.addListBtn.Location = new System.Drawing.Point(652, 463);
            this.addListBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addListBtn.Name = "addListBtn";
            this.addListBtn.Primary = true;
            this.addListBtn.Size = new System.Drawing.Size(146, 45);
            this.addListBtn.TabIndex = 0;
            this.addListBtn.Text = "Adicionar Lista";
            this.addListBtn.UseVisualStyleBackColor = true;
            this.addListBtn.Click += new System.EventHandler(this.AddListBtn_Click);
            // 
            // logoutLbl
            // 
            this.logoutLbl.AutoSize = true;
            this.logoutLbl.BackColor = System.Drawing.Color.Transparent;
            this.logoutLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutLbl.ForeColor = System.Drawing.Color.White;
            this.logoutLbl.Location = new System.Drawing.Point(773, 37);
            this.logoutLbl.Name = "logoutLbl";
            this.logoutLbl.Size = new System.Drawing.Size(25, 13);
            this.logoutLbl.TabIndex = 1;
            this.logoutLbl.Text = "Sair";
            this.logoutLbl.Click += new System.EventHandler(this.logoutLbl_Click);
            // 
            // dividerLbl
            // 
            this.dividerLbl.AutoSize = true;
            this.dividerLbl.BackColor = System.Drawing.Color.Transparent;
            this.dividerLbl.ForeColor = System.Drawing.Color.White;
            this.dividerLbl.Location = new System.Drawing.Point(765, 37);
            this.dividerLbl.Name = "dividerLbl";
            this.dividerLbl.Size = new System.Drawing.Size(9, 13);
            this.dividerLbl.TabIndex = 2;
            this.dividerLbl.Text = "|";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(688, 37);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(35, 13);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "label1";
            // 
            // tasksGridView
            // 
            this.tasksGridView.AllowUserToAddRows = false;
            this.tasksGridView.AllowUserToOrderColumns = true;
            this.tasksGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tasksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.titulo,
            this.descricao,
            this.owner,
            this.categoria,
            this.atividades});
            this.tasksGridView.Location = new System.Drawing.Point(12, 116);
            this.tasksGridView.Name = "tasksGridView";
            this.tasksGridView.Size = new System.Drawing.Size(786, 341);
            this.tasksGridView.TabIndex = 19;
            this.tasksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tasksGridView_CellContentClick);
            // 
            // activityLbl
            // 
            this.activityLbl.AutoSize = true;
            this.activityLbl.BackColor = System.Drawing.Color.Transparent;
            this.activityLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.activityLbl.Location = new System.Drawing.Point(12, 83);
            this.activityLbl.Name = "activityLbl";
            this.activityLbl.Size = new System.Drawing.Size(84, 30);
            this.activityLbl.TabIndex = 20;
            this.activityLbl.Text = "Tarefas";
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // owner
            // 
            this.owner.HeaderText = "Responsável";
            this.owner.Name = "owner";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // atividades
            // 
            this.atividades.HeaderText = "Atividades";
            this.atividades.Name = "atividades";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 520);
            this.Controls.Add(this.activityLbl);
            this.Controls.Add(this.tasksGridView);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.dividerLbl);
            this.Controls.Add(this.logoutLbl);
            this.Controls.Add(this.addListBtn);
            this.Location = new System.Drawing.Point(10, 0);
            this.MinimumSize = new System.Drawing.Size(810, 520);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tasksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton addListBtn;
        private System.Windows.Forms.Label logoutLbl;
        private System.Windows.Forms.Label dividerLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.DataGridView tasksGridView;
        private System.Windows.Forms.Label activityLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn atividades;
    }
}