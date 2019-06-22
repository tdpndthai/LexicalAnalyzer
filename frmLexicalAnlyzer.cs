using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LexicalAnalyzer
{
    public partial class frmLexicalAnlyzer : Form
    {
        public frmLexicalAnlyzer()
        {
            InitializeComponent();
        }

        private int count = 0;

        public void DisplayOutput() // để hiển thị đầu ra trong DataGridView
        {
            try
            {
                Analyzer.fileN = txtPath.Text; // đọc tập tin và lưu trữ vào mảng

                Analyzer.MyMain();

                for (int i = 0; i < Analyzer.librariesCount; i++)
                {
                    dgvOutput.Rows.Add();
                    dgvOutput.Rows[dgvOutput.RowCount - 1].Cells["Libraries"].Value = Analyzer.libraries[i].ToString();
                    count++;
                }

                for (int i = 0; i < Analyzer.keywordsCount; i++)
                {
                    dgvOutput.Rows.Add();
                    dgvOutput.Rows[dgvOutput.RowCount - count - 1].Cells["ReserveWords"].Value = Analyzer.keywordsArray[i].ToString();
                }

                for (int i = 0; i < Analyzer.operatorCount; i++)
                {
                    dgvOutput.Rows.Add();
                    dgvOutput.Rows[dgvOutput.RowCount - count - Analyzer.keywordsCount - 1].Cells["Operators"].Value = Analyzer.operators[i].ToString();
                }

                for (int i = 0; i < Analyzer.varCount; i++)
                {
                    dgvOutput.Rows.Add();
                    dgvOutput.Rows[dgvOutput.RowCount - count - Analyzer.operatorCount - Analyzer.keywordsCount - 1].Cells["VariableNames"].Value = Analyzer.originalVariables[i];
                }
            }
            catch (Exception)
            { }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.EndsWith(".cpp".ToUpper()))
                {
                    txtPath.Text = openFileDialog1.FileName;
                    rTextSource.Text = Analyzer.readFullFile(txtPath.Text);
                }
                else
                {
                    MessageBox.Show("Phải mở tệp có đuôi .cpp");
                }
            }
            else
            {
                return;
            }
        }

        private void frmLexicalAnlyzer_Load(object sender, EventArgs e)
        {
            Size = new Size(532, 455);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int width = 1013;
            while (width >= 532)
            {
                this.Size = new Size(width, 455);
                this.Refresh();
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                this.SetStyle(ControlStyles.UserPaint, true);
                Thread.Sleep(10);
                width -= 10;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // mở rộng form ra khi cho kết quả
            int width = 532;
            while (width <= 1013)
            {
                this.Size = new Size(width, 455);
                this.Refresh();
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.UserPaint, true);
                Thread.Sleep(10);
                width += 10;
            }

            DisplayOutput();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}