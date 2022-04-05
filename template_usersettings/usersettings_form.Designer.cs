namespace template_usersettings
{
    partial class usersettings_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.applyInput = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.browseInput = new System.Windows.Forms.Button();
            this.filepathInput = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyInput
            // 
            this.applyInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyInput.Location = new System.Drawing.Point(375, 3);
            this.applyInput.Name = "applyInput";
            this.applyInput.Size = new System.Drawing.Size(119, 170);
            this.applyInput.TabIndex = 0;
            this.applyInput.Text = "Apply";
            this.applyInput.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.applyInput, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.browseInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.filepathInput, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 353);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // browseInput
            // 
            this.browseInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseInput.Location = new System.Drawing.Point(251, 3);
            this.browseInput.Name = "browseInput";
            this.browseInput.Size = new System.Drawing.Size(118, 170);
            this.browseInput.TabIndex = 1;
            this.browseInput.Text = "...";
            this.browseInput.UseVisualStyleBackColor = true;
            this.browseInput.Click += new System.EventHandler(this.browseInput_Click);
            // 
            // filepathInput
            // 
            this.filepathInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filepathInput.Location = new System.Drawing.Point(74, 76);
            this.filepathInput.Name = "filepathInput";
            this.filepathInput.Size = new System.Drawing.Size(100, 23);
            this.filepathInput.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "sasd";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // usersettings_form
            // 
            this.AcceptButton = this.applyInput;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 353);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "usersettings_form";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button applyInput;
        private TableLayoutPanel tableLayoutPanel1;
        private Button browseInput;
        private TextBox filepathInput;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}