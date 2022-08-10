namespace EreignisEnter
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.chk_customer = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lst_parcel_service = new System.Windows.Forms.ListBox();
            this.lbl_help = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(120, 23);
            this.txt_name.TabIndex = 0;
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            // 
            // chk_customer
            // 
            this.chk_customer.AutoSize = true;
            this.chk_customer.Location = new System.Drawing.Point(12, 41);
            this.chk_customer.Name = "chk_customer";
            this.chk_customer.Size = new System.Drawing.Size(103, 19);
            this.chk_customer.TabIndex = 1;
            this.chk_customer.Text = "bereits Kunde?";
            this.chk_customer.UseVisualStyleBackColor = true;
            this.chk_customer.Enter += new System.EventHandler(this.chk_customer_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 66);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kreditkarte";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rbtn_payment_method_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 91);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 19);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Lastschrift";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rbtn_payment_method_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 116);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 19);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Überweisung";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.rbtn_payment_method_CheckedChanged);
            // 
            // lst_parcel_service
            // 
            this.lst_parcel_service.FormattingEnabled = true;
            this.lst_parcel_service.ItemHeight = 15;
            this.lst_parcel_service.Items.AddRange(new object[] {
            "DHL",
            "Hemes",
            "UPS"});
            this.lst_parcel_service.Location = new System.Drawing.Point(12, 141);
            this.lst_parcel_service.Name = "lst_parcel_service";
            this.lst_parcel_service.Size = new System.Drawing.Size(120, 79);
            this.lst_parcel_service.TabIndex = 5;
            this.lst_parcel_service.Enter += new System.EventHandler(this.lst_parcel_service_Enter);
            // 
            // lbl_help
            // 
            this.lbl_help.AutoSize = true;
            this.lbl_help.Location = new System.Drawing.Point(25, 237);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(0, 15);
            this.lbl_help.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 267);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.lst_parcel_service);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.chk_customer);
            this.Controls.Add(this.txt_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_name;
        private CheckBox chk_customer;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ListBox lst_parcel_service;
        private Label lbl_help;
    }
}