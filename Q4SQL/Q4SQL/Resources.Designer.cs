namespace Q4SQL
{
    partial class Resources
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
            this.Resources_dg = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Resources_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // Resources_dg
            // 
            this.Resources_dg.AllowUserToAddRows = false;
            this.Resources_dg.AllowUserToDeleteRows = false;
            this.Resources_dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Resources_dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Resources_dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Resources_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Resources_dg.Location = new System.Drawing.Point(264, 58);
            this.Resources_dg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Resources_dg.Name = "Resources_dg";
            this.Resources_dg.ReadOnly = true;
            this.Resources_dg.RowHeadersWidth = 51;
            this.Resources_dg.RowTemplate.Height = 24;
            this.Resources_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Resources_dg.Size = new System.Drawing.Size(557, 350);
            this.Resources_dg.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("David", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Bendak Resources Work"});
            this.comboBox1.Location = new System.Drawing.Point(21, 58);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "All";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.ComboBox1_SelectedValueChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Q4SQL.Properties.Resources.save21;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(695, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 37);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Q4SQL.Properties.Resources.searchicon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(21, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 39);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Resources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(828, 415);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Resources_dg);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Resources";
            this.Text = "Resources";
            this.Load += new System.EventHandler(this.Resources_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Resources_dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Resources_dg;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}