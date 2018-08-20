namespace file_sync
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
            this.tbPathSource = new System.Windows.Forms.TextBox();
            this.tbPathVault = new System.Windows.Forms.TextBox();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.btnPathSource = new System.Windows.Forms.Button();
            this.btnPathVault = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathVault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateVault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeVault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPathSource
            // 
            this.tbPathSource.Location = new System.Drawing.Point(12, 476);
            this.tbPathSource.Name = "tbPathSource";
            this.tbPathSource.Size = new System.Drawing.Size(712, 20);
            this.tbPathSource.TabIndex = 0;
            // 
            // tbPathVault
            // 
            this.tbPathVault.Location = new System.Drawing.Point(12, 502);
            this.tbPathVault.Name = "tbPathVault";
            this.tbPathVault.Size = new System.Drawing.Size(712, 20);
            this.tbPathVault.TabIndex = 1;
            // 
            // dgvFiles
            // 
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.pathSource,
            this.pathVault,
            this.dateSource,
            this.dateVault,
            this.sizeSource,
            this.sizeVault});
            this.dgvFiles.Location = new System.Drawing.Point(12, 48);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFiles.Size = new System.Drawing.Size(760, 420);
            this.dgvFiles.TabIndex = 2;
            // 
            // btnPathSource
            // 
            this.btnPathSource.Location = new System.Drawing.Point(730, 474);
            this.btnPathSource.Name = "btnPathSource";
            this.btnPathSource.Size = new System.Drawing.Size(42, 23);
            this.btnPathSource.TabIndex = 3;
            this.btnPathSource.Text = "path";
            this.btnPathSource.UseVisualStyleBackColor = true;
            this.btnPathSource.Click += new System.EventHandler(this.btnPathSource_Click);
            // 
            // btnPathVault
            // 
            this.btnPathVault.Location = new System.Drawing.Point(730, 500);
            this.btnPathVault.Name = "btnPathVault";
            this.btnPathVault.Size = new System.Drawing.Size(42, 23);
            this.btnPathVault.TabIndex = 4;
            this.btnPathVault.Text = "path";
            this.btnPathVault.UseVisualStyleBackColor = true;
            this.btnPathVault.Click += new System.EventHandler(this.btnPathVault_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(12, 526);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddFile.TabIndex = 5;
            this.btnAddFile.Text = "Добавить";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(93, 526);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFile.TabIndex = 6;
            this.btnRemoveFile.Text = "Удалить";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(174, 526);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(113, 23);
            this.btnSync.TabIndex = 7;
            this.btnSync.Text = "Синхронизировать";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // id
            // 
            this.id.FillWeight = 2F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 40;
            this.id.Name = "id";
            // 
            // pathSource
            // 
            this.pathSource.HeaderText = "Path source";
            this.pathSource.MinimumWidth = 160;
            this.pathSource.Name = "pathSource";
            // 
            // pathVault
            // 
            this.pathVault.HeaderText = "Path vault";
            this.pathVault.MinimumWidth = 160;
            this.pathVault.Name = "pathVault";
            // 
            // dateSource
            // 
            this.dateSource.FillWeight = 2F;
            this.dateSource.HeaderText = "Date source";
            this.dateSource.MinimumWidth = 90;
            this.dateSource.Name = "dateSource";
            // 
            // dateVault
            // 
            this.dateVault.FillWeight = 2F;
            this.dateVault.HeaderText = "Date vault";
            this.dateVault.MinimumWidth = 90;
            this.dateVault.Name = "dateVault";
            // 
            // sizeSource
            // 
            this.sizeSource.FillWeight = 2F;
            this.sizeSource.HeaderText = "Size source";
            this.sizeSource.MinimumWidth = 90;
            this.sizeSource.Name = "sizeSource";
            // 
            // sizeVault
            // 
            this.sizeVault.FillWeight = 2F;
            this.sizeVault.HeaderText = "Size vault";
            this.sizeVault.MinimumWidth = 90;
            this.sizeVault.Name = "sizeVault";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnRemoveFile);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.btnPathVault);
            this.Controls.Add(this.btnPathSource);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.tbPathVault);
            this.Controls.Add(this.tbPathSource);
            this.Name = "Form1";
            this.Text = "Синхронизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPathSource;
        private System.Windows.Forms.TextBox tbPathVault;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.Button btnPathSource;
        private System.Windows.Forms.Button btnPathVault;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathVault;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateVault;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeVault;
    }
}

