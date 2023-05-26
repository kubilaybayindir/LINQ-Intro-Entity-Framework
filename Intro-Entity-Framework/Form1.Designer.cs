namespace Intro_Entity_Framework
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtSixLetter = new System.Windows.Forms.Button();
            this.BtZa = new System.Windows.Forms.Button();
            this.BtALetter = new System.Windows.Forms.Button();
            this.BtAz = new System.Windows.Forms.Button();
            this.BtRLetter = new System.Windows.Forms.Button();
            this.BtLongName = new System.Windows.Forms.Button();
            this.BtGetAllNames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(262, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 411);
            this.listBox1.TabIndex = 1;
            // 
            // BtSixLetter
            // 
            this.BtSixLetter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtSixLetter.Location = new System.Drawing.Point(12, 89);
            this.BtSixLetter.Name = "BtSixLetter";
            this.BtSixLetter.Size = new System.Drawing.Size(237, 38);
            this.BtSixLetter.TabIndex = 2;
            this.BtSixLetter.Text = "Included Six Letter ";
            this.BtSixLetter.UseVisualStyleBackColor = true;
            this.BtSixLetter.Click += new System.EventHandler(this.BtSixLetter_Click);
            // 
            // BtZa
            // 
            this.BtZa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtZa.Location = new System.Drawing.Point(12, 213);
            this.BtZa.Name = "BtZa";
            this.BtZa.Size = new System.Drawing.Size(237, 38);
            this.BtZa.TabIndex = 2;
            this.BtZa.Text = "Z -->A";
            this.BtZa.UseVisualStyleBackColor = true;
            this.BtZa.Click += new System.EventHandler(this.BtZa_Click);
            // 
            // BtALetter
            // 
            this.BtALetter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtALetter.Location = new System.Drawing.Point(12, 275);
            this.BtALetter.Name = "BtALetter";
            this.BtALetter.Size = new System.Drawing.Size(237, 38);
            this.BtALetter.TabIndex = 2;
            this.BtALetter.Text = "Started A Letter";
            this.BtALetter.UseVisualStyleBackColor = true;
            this.BtALetter.Click += new System.EventHandler(this.BtALetter_Click);
            // 
            // BtAz
            // 
            this.BtAz.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtAz.Location = new System.Drawing.Point(12, 151);
            this.BtAz.Name = "BtAz";
            this.BtAz.Size = new System.Drawing.Size(237, 38);
            this.BtAz.TabIndex = 2;
            this.BtAz.Text = "A -->Z";
            this.BtAz.UseVisualStyleBackColor = true;
            this.BtAz.Click += new System.EventHandler(this.BtAz_Click);
            // 
            // BtRLetter
            // 
            this.BtRLetter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtRLetter.Location = new System.Drawing.Point(12, 337);
            this.BtRLetter.Name = "BtRLetter";
            this.BtRLetter.Size = new System.Drawing.Size(237, 38);
            this.BtRLetter.TabIndex = 2;
            this.BtRLetter.Text = "Finished R Letter";
            this.BtRLetter.UseVisualStyleBackColor = true;
            this.BtRLetter.Click += new System.EventHandler(this.BtRLetter_Click);
            // 
            // BtLongName
            // 
            this.BtLongName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtLongName.Location = new System.Drawing.Point(12, 399);
            this.BtLongName.Name = "BtLongName";
            this.BtLongName.Size = new System.Drawing.Size(237, 38);
            this.BtLongName.TabIndex = 2;
            this.BtLongName.Text = "Longest Name ";
            this.BtLongName.UseVisualStyleBackColor = true;
            this.BtLongName.Click += new System.EventHandler(this.BtLongName_Click);
            // 
            // BtGetAllNames
            // 
            this.BtGetAllNames.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtGetAllNames.Location = new System.Drawing.Point(12, 27);
            this.BtGetAllNames.Name = "BtGetAllNames";
            this.BtGetAllNames.Size = new System.Drawing.Size(237, 38);
            this.BtGetAllNames.TabIndex = 3;
            this.BtGetAllNames.Text = "Get All Names";
            this.BtGetAllNames.UseVisualStyleBackColor = true;
            this.BtGetAllNames.Click += new System.EventHandler(this.BtGetAllNames_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.BtGetAllNames);
            this.Controls.Add(this.BtLongName);
            this.Controls.Add(this.BtRLetter);
            this.Controls.Add(this.BtALetter);
            this.Controls.Add(this.BtZa);
            this.Controls.Add(this.BtAz);
            this.Controls.Add(this.BtSixLetter);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox listBox1;
        private Button BtSixLetter;
        private Button BtZa;
        private Button BtALetter;
        private Button BtAz;
        private Button BtRLetter;
        private Button BtLongName;
        private Button BtGetAllNames;
    }
}