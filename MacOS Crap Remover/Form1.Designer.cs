namespace MacOS_Crap_Remover
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.select_directory = new System.Windows.Forms.Button();
            this.location_display = new System.Windows.Forms.TextBox();
            this.select_text = new System.Windows.Forms.Label();
            this.run_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // select_directory
            // 
            this.select_directory.Location = new System.Drawing.Point(13, 71);
            this.select_directory.Name = "select_directory";
            this.select_directory.Size = new System.Drawing.Size(75, 23);
            this.select_directory.TabIndex = 0;
            this.select_directory.Text = "Select...";
            this.select_directory.UseVisualStyleBackColor = true;
            this.select_directory.Click += new System.EventHandler(this.select_directory_Click);
            // 
            // location_display
            // 
            this.location_display.Location = new System.Drawing.Point(13, 45);
            this.location_display.Name = "location_display";
            this.location_display.Size = new System.Drawing.Size(246, 20);
            this.location_display.TabIndex = 1;
            // 
            // select_text
            // 
            this.select_text.AutoSize = true;
            this.select_text.Location = new System.Drawing.Point(13, 26);
            this.select_text.Name = "select_text";
            this.select_text.Size = new System.Drawing.Size(100, 13);
            this.select_text.TabIndex = 2;
            this.select_text.Text = "Select File Location";
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(183, 70);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(75, 23);
            this.run_button.TabIndex = 3;
            this.run_button.Text = "Run";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.select_text);
            this.Controls.Add(this.location_display);
            this.Controls.Add(this.select_directory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button select_directory;
        private System.Windows.Forms.TextBox location_display;
        private System.Windows.Forms.Label select_text;
        private System.Windows.Forms.Button run_button;
    }
}

