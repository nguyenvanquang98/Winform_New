namespace QuangLySinhVien
{
    partial class Fix
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_mssv = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.gr_box = new System.Windows.Forms.GroupBox();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.btn_comfim = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gr_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIX STUDENT\r\nINFORMATION";
            // 
            // lb_mssv
            // 
            this.lb_mssv.AutoSize = true;
            this.lb_mssv.Location = new System.Drawing.Point(54, 120);
            this.lb_mssv.Name = "lb_mssv";
            this.lb_mssv.Size = new System.Drawing.Size(46, 17);
            this.lb_mssv.TabIndex = 1;
            this.lb_mssv.Text = "MSSV";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(54, 159);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(47, 17);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "NAME";
            // 
            // txt_mssv
            // 
            this.txt_mssv.Enabled = false;
            this.txt_mssv.Location = new System.Drawing.Point(118, 120);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(206, 22);
            this.txt_mssv.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(118, 159);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(206, 22);
            this.txt_name.TabIndex = 4;
            // 
            // gr_box
            // 
            this.gr_box.Controls.Add(this.radio_female);
            this.gr_box.Controls.Add(this.radioMale);
            this.gr_box.Location = new System.Drawing.Point(118, 213);
            this.gr_box.Name = "gr_box";
            this.gr_box.Size = new System.Drawing.Size(206, 47);
            this.gr_box.TabIndex = 5;
            this.gr_box.TabStop = false;
            this.gr_box.Text = "Gender";
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Location = new System.Drawing.Point(111, 15);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(75, 21);
            this.radio_female.TabIndex = 1;
            this.radio_female.TabStop = true;
            this.radio_female.Text = "Female";
            this.radio_female.UseVisualStyleBackColor = true;
            this.radio_female.CheckedChanged += new System.EventHandler(this.radio_female_CheckedChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(22, 15);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(59, 21);
            this.radioMale.TabIndex = 0;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // btn_comfim
            // 
            this.btn_comfim.Location = new System.Drawing.Point(118, 294);
            this.btn_comfim.Name = "btn_comfim";
            this.btn_comfim.Size = new System.Drawing.Size(101, 35);
            this.btn_comfim.TabIndex = 6;
            this.btn_comfim.Text = "Confim";
            this.btn_comfim.UseVisualStyleBackColor = true;
            this.btn_comfim.Click += new System.EventHandler(this.btn_comfim_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(223, 294);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(101, 35);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Fix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 357);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_comfim);
            this.Controls.Add(this.gr_box);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_mssv);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_mssv);
            this.Controls.Add(this.label1);
            this.Name = "Fix";
            this.Text = "FIX";
            this.Load += new System.EventHandler(this.Fix_Load);
            this.gr_box.ResumeLayout(false);
            this.gr_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_mssv;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.GroupBox gr_box;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Button btn_comfim;
        private System.Windows.Forms.Button btn_cancel;
    }
}