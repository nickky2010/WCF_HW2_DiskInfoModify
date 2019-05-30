namespace DiskInfoClientOnForms
{
    partial class Form1
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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.dataGridViewDiskInfo = new System.Windows.Forms.DataGridView();
            this.buttonShowDiskInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiskInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPath.Location = new System.Drawing.Point(74, 17);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(405, 28);
            this.textBoxPath.TabIndex = 0;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPath.Location = new System.Drawing.Point(12, 22);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(47, 24);
            this.labelPath.TabIndex = 1;
            this.labelPath.Text = "Path";
            // 
            // dataGridViewDiskInfo
            // 
            this.dataGridViewDiskInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiskInfo.Location = new System.Drawing.Point(16, 51);
            this.dataGridViewDiskInfo.Name = "dataGridViewDiskInfo";
            this.dataGridViewDiskInfo.RowTemplate.Height = 24;
            this.dataGridViewDiskInfo.Size = new System.Drawing.Size(463, 305);
            this.dataGridViewDiskInfo.TabIndex = 2;
            // 
            // buttonShowDiskInfo
            // 
            this.buttonShowDiskInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowDiskInfo.Location = new System.Drawing.Point(333, 362);
            this.buttonShowDiskInfo.Name = "buttonShowDiskInfo";
            this.buttonShowDiskInfo.Size = new System.Drawing.Size(146, 31);
            this.buttonShowDiskInfo.TabIndex = 3;
            this.buttonShowDiskInfo.Text = "Show disk info";
            this.buttonShowDiskInfo.UseVisualStyleBackColor = true;
            this.buttonShowDiskInfo.Click += new System.EventHandler(this.buttonShowDiskInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 400);
            this.Controls.Add(this.buttonShowDiskInfo);
            this.Controls.Add(this.dataGridViewDiskInfo);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.textBoxPath);
            this.Name = "Form1";
            this.Text = "Disk Info Client";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiskInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.DataGridView dataGridViewDiskInfo;
        private System.Windows.Forms.Button buttonShowDiskInfo;
    }
}

