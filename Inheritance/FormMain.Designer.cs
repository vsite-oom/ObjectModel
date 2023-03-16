namespace Vsite.Oom.ObjectModel
{
    partial class FormMain
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxShippingAddress = new TextBoxDefault();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxReceiptAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(147, 25);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(228, 27);
            this.textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Address:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(147, 75);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(228, 27);
            this.textBoxAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Receipt address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Shipping address:";
            // 
            // textBoxShippingAddress
            // 
            this.textBoxShippingAddress.Location = new System.Drawing.Point(147, 173);
            this.textBoxShippingAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxShippingAddress.Name = "textBoxShippingAddress";
            this.textBoxShippingAddress.Size = new System.Drawing.Size(228, 27);
            this.textBoxShippingAddress.TabIndex = 7;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(198, 260);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(86, 31);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(290, 260);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 31);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxReceiptAddress
            // 
            this.textBoxReceiptAddress.Location = new System.Drawing.Point(147, 124);
            this.textBoxReceiptAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxReceiptAddress.Name = "textBoxReceiptAddress";
            this.textBoxReceiptAddress.Size = new System.Drawing.Size(228, 27);
            this.textBoxReceiptAddress.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(405, 313);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxShippingAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxReceiptAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Customer Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxAddress;
        private Label label3;
        private Label label4;
        private TextBox textBoxShippingAddress;
        private Button buttonOk;
        private Button buttonCancel;
        private TextBox textBoxReceiptAddress;
    }
}

