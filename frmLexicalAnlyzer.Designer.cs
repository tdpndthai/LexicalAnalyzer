namespace LexicalAnalyzer
{
    partial class frmLexicalAnlyzer
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.rTextSource = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.Libraries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReserveWords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariableNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operators = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đường dẫn";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(12, 45);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(382, 20);
            this.txtPath.TabIndex = 3;
            // 
            // rTextSource
            // 
            this.rTextSource.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTextSource.Location = new System.Drawing.Point(12, 133);
            this.rTextSource.Name = "rTextSource";
            this.rTextSource.Size = new System.Drawing.Size(382, 247);
            this.rTextSource.TabIndex = 6;
            this.rTextSource.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Source Code";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(417, 45);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 74);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Mở đường dẫn";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(417, 173);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 74);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Kết quả";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(417, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 74);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToOrderColumns = true;
            this.dgvOutput.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Libraries,
            this.ReserveWords,
            this.VariableNames,
            this.Operators});
            this.dgvOutput.Location = new System.Drawing.Point(550, 45);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutput.Size = new System.Drawing.Size(446, 247);
            this.dgvOutput.TabIndex = 11;
            // 
            // Libraries
            // 
            this.Libraries.HeaderText = "Thư viện";
            this.Libraries.Name = "Libraries";
            // 
            // ReserveWords
            // 
            this.ReserveWords.HeaderText = "Từ dùng riêng và kiểu dữ liệu";
            this.ReserveWords.Name = "ReserveWords";
            // 
            // VariableNames
            // 
            this.VariableNames.HeaderText = "Tên biến";
            this.VariableNames.Name = "VariableNames";
            // 
            // Operators
            // 
            this.Operators.HeaderText = "Toán tử";
            this.Operators.Name = "Operators";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(912, 306);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 74);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmLexicalAnlyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rTextSource);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmLexicalAnlyzer";
            this.Text = "LexicalAnlyzer";
            this.Load += new System.EventHandler(this.frmLexicalAnlyzer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.RichTextBox rTextSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libraries;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReserveWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn VariableNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operators;
    }
}

