namespace ShowAssignments
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
            this.button_Papers = new System.Windows.Forms.Button();
            this.button_Mark = new System.Windows.Forms.Button();
            this.button_Assignments = new System.Windows.Forms.Button();
            this.listBox_Display = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Papers
            // 
            this.button_Papers.Location = new System.Drawing.Point(13, 13);
            this.button_Papers.Name = "button_Papers";
            this.button_Papers.Size = new System.Drawing.Size(134, 41);
            this.button_Papers.TabIndex = 0;
            this.button_Papers.Text = "Papers";
            this.button_Papers.UseVisualStyleBackColor = true;
            this.button_Papers.Click += new System.EventHandler(this.button_Papers_Click);
            // 
            // button_Mark
            // 
            this.button_Mark.Location = new System.Drawing.Point(12, 107);
            this.button_Mark.Name = "button_Mark";
            this.button_Mark.Size = new System.Drawing.Size(134, 41);
            this.button_Mark.TabIndex = 1;
            this.button_Mark.Text = "Average Mark";
            this.button_Mark.UseVisualStyleBackColor = true;
            this.button_Mark.Click += new System.EventHandler(this.button_Mark_Click);
            // 
            // button_Assignments
            // 
            this.button_Assignments.Location = new System.Drawing.Point(13, 60);
            this.button_Assignments.Name = "button_Assignments";
            this.button_Assignments.Size = new System.Drawing.Size(134, 41);
            this.button_Assignments.TabIndex = 2;
            this.button_Assignments.Text = "Assignments Due";
            this.button_Assignments.UseVisualStyleBackColor = true;
            this.button_Assignments.Click += new System.EventHandler(this.button_Assignments_Click);
            // 
            // listBox_Display
            // 
            this.listBox_Display.FormattingEnabled = true;
            this.listBox_Display.Location = new System.Drawing.Point(177, 13);
            this.listBox_Display.Name = "listBox_Display";
            this.listBox_Display.Size = new System.Drawing.Size(361, 147);
            this.listBox_Display.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 175);
            this.Controls.Add(this.listBox_Display);
            this.Controls.Add(this.button_Assignments);
            this.Controls.Add(this.button_Mark);
            this.Controls.Add(this.button_Papers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Papers;
        private System.Windows.Forms.Button button_Mark;
        private System.Windows.Forms.Button button_Assignments;
        private System.Windows.Forms.ListBox listBox_Display;
    }
}

