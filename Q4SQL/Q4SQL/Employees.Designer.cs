namespace Q4SQL
{
    partial class Employees
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
            this.components = new System.ComponentModel.Container();
            this.danceDBDataSet = new Q4SQL.DanceDBDataSet();
            this.danceDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Employee_dg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.emplyee_cb = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSearch_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RefreshEmployee_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.danceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danceDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // danceDBDataSet
            // 
            this.danceDBDataSet.DataSetName = "DanceDBDataSet";
            this.danceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danceDBDataSetBindingSource
            // 
            this.danceDBDataSetBindingSource.DataSource = this.danceDBDataSet;
            this.danceDBDataSetBindingSource.Position = 0;
            // 
            // Employee_dg
            // 
            this.Employee_dg.AllowUserToAddRows = false;
            this.Employee_dg.AllowUserToDeleteRows = false;
            this.Employee_dg.AllowUserToResizeColumns = false;
            this.Employee_dg.AllowUserToResizeRows = false;
            this.Employee_dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Employee_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee_dg.GridColor = System.Drawing.SystemColors.Control;
            this.Employee_dg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Employee_dg.Location = new System.Drawing.Point(118, 55);
            this.Employee_dg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Employee_dg.Name = "Employee_dg";
            this.Employee_dg.ReadOnly = true;
            this.Employee_dg.RowHeadersWidth = 51;
            this.Employee_dg.RowTemplate.Height = 24;
            this.Employee_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Employee_dg.Size = new System.Drawing.Size(640, 344);
            this.Employee_dg.TabIndex = 1;
            this.Employee_dg.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_RowHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(357, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employees";
            // 
            // emplyee_cb
            // 
            this.emplyee_cb.Font = new System.Drawing.Font("David", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.emplyee_cb.FormattingEnabled = true;
            this.emplyee_cb.Items.AddRange(new object[] {
            "All",
            "Mission Responsible "});
            this.emplyee_cb.Location = new System.Drawing.Point(4, 55);
            this.emplyee_cb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emplyee_cb.Name = "emplyee_cb";
            this.emplyee_cb.Size = new System.Drawing.Size(103, 21);
            this.emplyee_cb.TabIndex = 4;
            this.emplyee_cb.Text = "All";
            this.emplyee_cb.SelectedValueChanged += new System.EventHandler(this.Emplyee_cb_SelectedValueChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Q4SQL.Properties.Resources.save2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(653, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // buttonSearch_btn
            // 
            this.buttonSearch_btn.AccessibleDescription = "";
            this.buttonSearch_btn.AccessibleName = "";
            this.buttonSearch_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearch_btn.BackgroundImage = global::Q4SQL.Properties.Resources.serch;
            this.buttonSearch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch_btn.Location = new System.Drawing.Point(90, 10);
            this.buttonSearch_btn.Name = "buttonSearch_btn";
            this.buttonSearch_btn.Size = new System.Drawing.Size(60, 30);
            this.buttonSearch_btn.TabIndex = 6;
            this.buttonSearch_btn.UseVisualStyleBackColor = false;
            this.buttonSearch_btn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = global::Q4SQL.Properties.Resources._5update;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(9, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RefreshEmployee_btn
            // 
            this.RefreshEmployee_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RefreshEmployee_btn.BackgroundImage = global::Q4SQL.Properties.Resources.searchicon;
            this.RefreshEmployee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshEmployee_btn.Location = new System.Drawing.Point(14, 10);
            this.RefreshEmployee_btn.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshEmployee_btn.Name = "RefreshEmployee_btn";
            this.RefreshEmployee_btn.Size = new System.Drawing.Size(60, 32);
            this.RefreshEmployee_btn.TabIndex = 3;
            this.RefreshEmployee_btn.UseVisualStyleBackColor = false;
            this.RefreshEmployee_btn.Click += new System.EventHandler(this.RefreshEmployee_btn_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(761, 414);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSearch_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emplyee_cb);
            this.Controls.Add(this.RefreshEmployee_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employee_dg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(777, 453);
            this.MinimumSize = new System.Drawing.Size(777, 453);
            this.Name = "Employees";
            this.Text = "Employees";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employees_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Employees_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danceDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource danceDBDataSetBindingSource;
        private DanceDBDataSet danceDBDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RefreshEmployee_btn;
        private System.Windows.Forms.ComboBox emplyee_cb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Employee_dg;
        private System.Windows.Forms.Button buttonSearch_btn;
        private System.Windows.Forms.Button button2;
    }
}

