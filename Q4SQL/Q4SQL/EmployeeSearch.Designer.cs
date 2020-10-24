namespace Q4SQL
{
    partial class EmployeeSearch
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
            this.dataGridViewSearch_dg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeSearch_lbl = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.noResult_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSearch_dg
            // 
            this.dataGridViewSearch_dg.AllowUserToAddRows = false;
            this.dataGridViewSearch_dg.AllowUserToDeleteRows = false;
            this.dataGridViewSearch_dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearch_dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewSearch_dg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSearch_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch_dg.Location = new System.Drawing.Point(27, 113);
            this.dataGridViewSearch_dg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSearch_dg.Name = "dataGridViewSearch_dg";
            this.dataGridViewSearch_dg.ReadOnly = true;
            this.dataGridViewSearch_dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSearch_dg.RowHeadersWidth = 51;
            this.dataGridViewSearch_dg.RowTemplate.Height = 24;
            this.dataGridViewSearch_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearch_dg.Size = new System.Drawing.Size(443, 62);
            this.dataGridViewSearch_dg.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(35, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter employee ID (9 digits) :";
            // 
            // EmployeeSearch_lbl
            // 
            this.EmployeeSearch_lbl.AutoSize = true;
            this.EmployeeSearch_lbl.Font = new System.Drawing.Font("David", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EmployeeSearch_lbl.Location = new System.Drawing.Point(149, 11);
            this.EmployeeSearch_lbl.Name = "EmployeeSearch_lbl";
            this.EmployeeSearch_lbl.Size = new System.Drawing.Size(188, 24);
            this.EmployeeSearch_lbl.TabIndex = 3;
            this.EmployeeSearch_lbl.Text = "Employee Search";
            // 
            // textBox
            // 
            this.textBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox.Location = new System.Drawing.Point(307, 64);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.MaxLength = 9;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 22);
            this.textBox.TabIndex = 4;
            this.textBox.Text = "000000000";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // noResult_lbl
            // 
            this.noResult_lbl.AutoSize = true;
            this.noResult_lbl.Font = new System.Drawing.Font("David", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.noResult_lbl.Location = new System.Drawing.Point(132, 133);
            this.noResult_lbl.Name = "noResult_lbl";
            this.noResult_lbl.Size = new System.Drawing.Size(207, 13);
            this.noResult_lbl.TabIndex = 6;
            this.noResult_lbl.Text = "No results for the inserted employee";
            this.noResult_lbl.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Q4SQL.Properties.Resources.search;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(135, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 87);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EmployeeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(499, 331);
            this.Controls.Add(this.noResult_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.EmployeeSearch_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSearch_dg);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeSearch";
            this.Text = "Employee Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSearch_dg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmployeeSearch_lbl;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label noResult_lbl;
    }
}