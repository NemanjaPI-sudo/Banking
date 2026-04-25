namespace Banking
{
    partial class TransferForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fromacctxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.curentamounttxt = new System.Windows.Forms.TextBox();
            this.destinationacctxt = new System.Windows.Forms.TextBox();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.detailsbtn = new System.Windows.Forms.Button();
            this.transferbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From Account Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Destination Account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount";
            // 
            // fromacctxt
            // 
            this.fromacctxt.Location = new System.Drawing.Point(280, 96);
            this.fromacctxt.Name = "fromacctxt";
            this.fromacctxt.Size = new System.Drawing.Size(274, 20);
            this.fromacctxt.TabIndex = 6;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(280, 162);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(274, 20);
            this.nametxt.TabIndex = 7;
            // 
            // curentamounttxt
            // 
            this.curentamounttxt.Location = new System.Drawing.Point(280, 225);
            this.curentamounttxt.Name = "curentamounttxt";
            this.curentamounttxt.Size = new System.Drawing.Size(274, 20);
            this.curentamounttxt.TabIndex = 8;
            // 
            // destinationacctxt
            // 
            this.destinationacctxt.Location = new System.Drawing.Point(280, 274);
            this.destinationacctxt.Name = "destinationacctxt";
            this.destinationacctxt.Size = new System.Drawing.Size(274, 20);
            this.destinationacctxt.TabIndex = 9;
            // 
            // amounttxt
            // 
            this.amounttxt.Location = new System.Drawing.Point(280, 334);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(274, 20);
            this.amounttxt.TabIndex = 10;
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.Location = new System.Drawing.Point(158, 26);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(85, 29);
            this.datelbl.TabIndex = 11;
            this.datelbl.Text = "label7";
            // 
            // detailsbtn
            // 
            this.detailsbtn.Location = new System.Drawing.Point(576, 92);
            this.detailsbtn.Name = "detailsbtn";
            this.detailsbtn.Size = new System.Drawing.Size(112, 37);
            this.detailsbtn.TabIndex = 12;
            this.detailsbtn.Text = "Show Details";
            this.detailsbtn.UseVisualStyleBackColor = true;
            this.detailsbtn.Click += new System.EventHandler(this.detailsbtn_Click);
            // 
            // transferbtn
            // 
            this.transferbtn.Location = new System.Drawing.Point(280, 383);
            this.transferbtn.Name = "transferbtn";
            this.transferbtn.Size = new System.Drawing.Size(120, 37);
            this.transferbtn.TabIndex = 13;
            this.transferbtn.Text = "Transfer Amount";
            this.transferbtn.UseVisualStyleBackColor = true;
            this.transferbtn.Click += new System.EventHandler(this.transferbtn_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transferbtn);
            this.Controls.Add(this.detailsbtn);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.destinationacctxt);
            this.Controls.Add(this.curentamounttxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.fromacctxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransferForm";
            this.Text = "Transferfrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fromacctxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox curentamounttxt;
        private System.Windows.Forms.TextBox destinationacctxt;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Button detailsbtn;
        private System.Windows.Forms.Button transferbtn;
    }
}