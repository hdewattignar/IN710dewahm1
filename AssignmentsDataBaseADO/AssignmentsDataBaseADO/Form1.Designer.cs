namespace AssignmentsDataBaseADO
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_createTables = new System.Windows.Forms.Button();
            this.btn_populateTables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(13, 13);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(141, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_createTables
            // 
            this.btn_createTables.Location = new System.Drawing.Point(13, 43);
            this.btn_createTables.Name = "btn_createTables";
            this.btn_createTables.Size = new System.Drawing.Size(141, 23);
            this.btn_createTables.TabIndex = 1;
            this.btn_createTables.Text = "Create Tables";
            this.btn_createTables.UseVisualStyleBackColor = true;
            this.btn_createTables.Click += new System.EventHandler(this.btn_createTables_Click);
            // 
            // btn_populateTables
            // 
            this.btn_populateTables.Location = new System.Drawing.Point(13, 73);
            this.btn_populateTables.Name = "btn_populateTables";
            this.btn_populateTables.Size = new System.Drawing.Size(141, 23);
            this.btn_populateTables.TabIndex = 2;
            this.btn_populateTables.Text = "Populate Tables";
            this.btn_populateTables.UseVisualStyleBackColor = true;
            this.btn_populateTables.Click += new System.EventHandler(this.btn_populateTables_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 477);
            this.Controls.Add(this.btn_populateTables);
            this.Controls.Add(this.btn_createTables);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_createTables;
        private System.Windows.Forms.Button btn_populateTables;
    }
}

