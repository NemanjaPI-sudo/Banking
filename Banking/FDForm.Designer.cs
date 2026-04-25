namespace Banking
{
    partial class FDForm
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
            this.datelbl = new System.Windows.Forms.Label();
            this.datetxt = new System.Windows.Forms.Label();
            this.accnolbl = new System.Windows.Forms.Label();
            this.modelbl = new System.Windows.Forms.Label();
            this.amountlbl = new System.Windows.Forms.Label();
            this.perioddaylbl = new System.Windows.Forms.Label();
            this.interestlbl = new System.Windows.Forms.Label();
            this.accnotxt = new System.Windows.Forms.TextBox();
            this.modecmbox = new System.Windows.Forms.ComboBox();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.periodtxt = new System.Windows.Forms.TextBox();
            this.interesttxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.Location = new System.Drawing.Point(644, 43);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(70, 25);
            this.datelbl.TabIndex = 0;
            this.datelbl.Text = "Date :";
            // 
            // datetxt
            // 
            this.datetxt.AutoSize = true;
            this.datetxt.Location = new System.Drawing.Point(741, 52);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(35, 13);
            this.datetxt.TabIndex = 1;
            this.datetxt.Text = "label2";
            // 
            // accnolbl
            // 
            this.accnolbl.AutoSize = true;
            this.accnolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accnolbl.Location = new System.Drawing.Point(112, 120);
            this.accnolbl.Name = "accnolbl";
            this.accnolbl.Size = new System.Drawing.Size(96, 20);
            this.accnolbl.TabIndex = 2;
            this.accnolbl.Text = "Account No.";
            // 
            // modelbl
            // 
            this.modelbl.AutoSize = true;
            this.modelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelbl.Location = new System.Drawing.Point(112, 192);
            this.modelbl.Name = "modelbl";
            this.modelbl.Size = new System.Drawing.Size(49, 20);
            this.modelbl.TabIndex = 3;
            this.modelbl.Text = "Mode";
            // 
            // amountlbl
            // 
            this.amountlbl.AutoSize = true;
            this.amountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlbl.Location = new System.Drawing.Point(112, 260);
            this.amountlbl.Name = "amountlbl";
            this.amountlbl.Size = new System.Drawing.Size(91, 20);
            this.amountlbl.TabIndex = 4;
            this.amountlbl.Text = "Amount(💶)";
            // 
            // perioddaylbl
            // 
            this.perioddaylbl.AutoSize = true;
            this.perioddaylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perioddaylbl.Location = new System.Drawing.Point(112, 335);
            this.perioddaylbl.Name = "perioddaylbl";
            this.perioddaylbl.Size = new System.Drawing.Size(89, 20);
            this.perioddaylbl.TabIndex = 5;
            this.perioddaylbl.Text = "Period(day)";
            // 
            // interestlbl
            // 
            this.interestlbl.AutoSize = true;
            this.interestlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestlbl.Location = new System.Drawing.Point(112, 401);
            this.interestlbl.Name = "interestlbl";
            this.interestlbl.Size = new System.Drawing.Size(88, 20);
            this.interestlbl.TabIndex = 6;
            this.interestlbl.Text = "Interest(%)";
            // 
            // accnotxt
            // 
            this.accnotxt.Location = new System.Drawing.Point(228, 120);
            this.accnotxt.Name = "accnotxt";
            this.accnotxt.Size = new System.Drawing.Size(305, 20);
            this.accnotxt.TabIndex = 7;
            // 
            // modecmbox
            // 
            this.modecmbox.FormattingEnabled = true;
            this.modecmbox.Location = new System.Drawing.Point(228, 190);
            this.modecmbox.Name = "modecmbox";
            this.modecmbox.Size = new System.Drawing.Size(305, 21);
            this.modecmbox.TabIndex = 8;
            // 
            // amounttxt
            // 
            this.amounttxt.Location = new System.Drawing.Point(228, 262);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(305, 20);
            this.amounttxt.TabIndex = 9;
            // 
            // periodtxt
            // 
            this.periodtxt.Location = new System.Drawing.Point(228, 337);
            this.periodtxt.Name = "periodtxt";
            this.periodtxt.Size = new System.Drawing.Size(305, 20);
            this.periodtxt.TabIndex = 10;
            // 
            // interesttxt
            // 
            this.interesttxt.Location = new System.Drawing.Point(228, 403);
            this.interesttxt.Name = "interesttxt";
            this.interesttxt.Size = new System.Drawing.Size(101, 20);
            this.interesttxt.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.interesttxt);
            this.Controls.Add(this.periodtxt);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.modecmbox);
            this.Controls.Add(this.accnotxt);
            this.Controls.Add(this.interestlbl);
            this.Controls.Add(this.perioddaylbl);
            this.Controls.Add(this.amountlbl);
            this.Controls.Add(this.modelbl);
            this.Controls.Add(this.accnolbl);
            this.Controls.Add(this.datetxt);
            this.Controls.Add(this.datelbl);
            this.Name = "FDForm";
            this.Text = "FDForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label datetxt;
        private System.Windows.Forms.Label accnolbl;
        private System.Windows.Forms.Label modelbl;
        private System.Windows.Forms.Label amountlbl;
        private System.Windows.Forms.Label perioddaylbl;
        private System.Windows.Forms.Label interestlbl;
        private System.Windows.Forms.TextBox accnotxt;
        private System.Windows.Forms.ComboBox modecmbox;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.TextBox periodtxt;
        private System.Windows.Forms.TextBox interesttxt;
        private System.Windows.Forms.Button button1;
    }
}