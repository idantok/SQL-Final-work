namespace Q4SQL
{
    partial class Menu
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
            this.title_lbl = new System.Windows.Forms.Label();
            this.serve_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.res_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Location = new System.Drawing.Point(147, 20);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(147, 17);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = " SQL Final Work 2019";
            // 
            // serve_lbl
            // 
            this.serve_lbl.AutoSize = true;
            this.serve_lbl.Location = new System.Drawing.Point(147, 226);
            this.serve_lbl.Name = "serve_lbl";
            this.serve_lbl.Size = new System.Drawing.Size(140, 17);
            this.serve_lbl.TabIndex = 0;
            this.serve_lbl.Text = "Serve : Idan Tokayer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(184, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project4u";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(351, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "©Idan Tokayer v1.2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Since 2019";
            // 
            // res_btn
            // 
            this.res_btn.BackgroundImage = global::Q4SQL.Properties.Resources.resources2;
            this.res_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.res_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.res_btn.Location = new System.Drawing.Point(268, 85);
            this.res_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.res_btn.Name = "res_btn";
            this.res_btn.Size = new System.Drawing.Size(205, 180);
            this.res_btn.TabIndex = 3;
            this.res_btn.UseVisualStyleBackColor = true;
            this.res_btn.Click += new System.EventHandler(this.Res_btn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Q4SQL.Properties.Resources.employees1;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(29, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 180);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(485, 305);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.res_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.serve_lbl);
            this.Controls.Add(this.title_lbl);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(503, 352);
            this.MinimumSize = new System.Drawing.Size(503, 352);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label serve_lbl;
        private System.Windows.Forms.Button res_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}