namespace GardeningCompany_Delegate
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
            this.btn_Area = new System.Windows.Forms.Button();
            this.btn_Charges = new System.Windows.Forms.Button();
            this.listbox_Display = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Area
            // 
            this.btn_Area.Location = new System.Drawing.Point(13, 13);
            this.btn_Area.Name = "btn_Area";
            this.btn_Area.Size = new System.Drawing.Size(170, 60);
            this.btn_Area.TabIndex = 0;
            this.btn_Area.Text = "Area Report";
            this.btn_Area.UseVisualStyleBackColor = true;
            // 
            // btn_Charges
            // 
            this.btn_Charges.Location = new System.Drawing.Point(212, 12);
            this.btn_Charges.Name = "btn_Charges";
            this.btn_Charges.Size = new System.Drawing.Size(170, 60);
            this.btn_Charges.TabIndex = 1;
            this.btn_Charges.Text = "Charges Report";
            this.btn_Charges.UseVisualStyleBackColor = true;
            // 
            // listbox_Display
            // 
            this.listbox_Display.FormattingEnabled = true;
            this.listbox_Display.Location = new System.Drawing.Point(13, 93);
            this.listbox_Display.Name = "listbox_Display";
            this.listbox_Display.Size = new System.Drawing.Size(369, 212);
            this.listbox_Display.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 319);
            this.Controls.Add(this.listbox_Display);
            this.Controls.Add(this.btn_Charges);
            this.Controls.Add(this.btn_Area);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Area;
        private System.Windows.Forms.Button btn_Charges;
        private System.Windows.Forms.ListBox listbox_Display;
    }
}

