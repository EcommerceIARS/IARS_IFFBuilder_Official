namespace IARS_IFFBuilder
{
    partial class IFFBuilderAPP
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.File_open_Window = new System.Windows.Forms.OpenFileDialog();
            this.buIFFInvList = new System.Windows.Forms.Button();
            this.cbIFFBuilderType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(525, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // File_open_Window
            // 
            this.File_open_Window.FileName = "openFileDialog1";
            this.File_open_Window.FileOk += new System.ComponentModel.CancelEventHandler(this.File_open_Window_FileOk);
            // 
            // buIFFInvList
            // 
            this.buIFFInvList.Location = new System.Drawing.Point(46, 138);
            this.buIFFInvList.Name = "buIFFInvList";
            this.buIFFInvList.Size = new System.Drawing.Size(217, 27);
            this.buIFFInvList.TabIndex = 2;
            this.buIFFInvList.Text = "button2";
            this.buIFFInvList.UseVisualStyleBackColor = true;
            this.buIFFInvList.Click += new System.EventHandler(this.buIFFInvList_Click);
            // 
            // cbIFFBuilderType
            // 
            this.cbIFFBuilderType.FormattingEnabled = true;
            this.cbIFFBuilderType.Location = new System.Drawing.Point(301, 138);
            this.cbIFFBuilderType.Name = "cbIFFBuilderType";
            this.cbIFFBuilderType.Size = new System.Drawing.Size(198, 21);
            this.cbIFFBuilderType.TabIndex = 3;
            // 
            // IFFBuilderAPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 455);
            this.Controls.Add(this.cbIFFBuilderType);
            this.Controls.Add(this.buIFFInvList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "IFFBuilderAPP";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog File_open_Window;
        private System.Windows.Forms.Button buIFFInvList;
        private System.Windows.Forms.ComboBox cbIFFBuilderType;
    }
}

