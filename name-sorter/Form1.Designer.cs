namespace name_sorter
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
            this.listRead = new System.Windows.Forms.ListBox();
            this.listSort = new System.Windows.Forms.ListBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listRead
            // 
            this.listRead.FormattingEnabled = true;
            this.listRead.Location = new System.Drawing.Point(25, 84);
            this.listRead.Name = "listRead";
            this.listRead.Size = new System.Drawing.Size(400, 472);
            this.listRead.TabIndex = 1;
            // 
            // listSort
            // 
            this.listSort.FormattingEnabled = true;
            this.listSort.Location = new System.Drawing.Point(473, 84);
            this.listSort.Name = "listSort";
            this.listSort.Size = new System.Drawing.Size(400, 472);
            this.listSort.TabIndex = 1;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(417, 27);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 606);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.listSort);
            this.Controls.Add(this.listRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listRead;
        private System.Windows.Forms.ListBox listSort;
        private System.Windows.Forms.Button btnRead;
    }
}

