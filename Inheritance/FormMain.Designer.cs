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
			label1 = new Label();
			textBoxName = new TextBox();
			label2 = new Label();
			textBoxAddress = new TextBox();
			label3 = new Label();
			textBoxReceiptAddress = new TextBoxDefault();
			label4 = new Label();
			textBoxShippingAddress = new TextBoxDefault();
			buttonOk = new Button();
			buttonCancel = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(26, 29);
			label1.Name = "label1";
			label1.Size = new Size(52, 20);
			label1.TabIndex = 0;
			label1.Text = "&Name:";
			// 
			// textBoxName
			// 
			textBoxName.Location = new Point(147, 25);
			textBoxName.Margin = new Padding(3, 4, 3, 4);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(228, 27);
			textBoxName.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(26, 79);
			label2.Name = "label2";
			label2.Size = new Size(65, 20);
			label2.TabIndex = 2;
			label2.Text = "&Address:";
			// 
			// textBoxAddress
			// 
			textBoxAddress.Location = new Point(147, 75);
			textBoxAddress.Margin = new Padding(3, 4, 3, 4);
			textBoxAddress.Name = "textBoxAddress";
			textBoxAddress.Size = new Size(228, 27);
			textBoxAddress.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(26, 128);
			label3.Name = "label3";
			label3.Size = new Size(117, 20);
			label3.TabIndex = 4;
			label3.Text = "&Receipt address:";
			// 
			// textBoxReceiptAddress
			// 
			textBoxReceiptAddress.Location = new Point(147, 124);
			textBoxReceiptAddress.Margin = new Padding(3, 4, 3, 4);
			textBoxReceiptAddress.Name = "textBoxReceiptAddress";
			textBoxReceiptAddress.Size = new Size(228, 27);
			textBoxReceiptAddress.TabIndex = 5;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(26, 177);
			label4.Name = "label4";
			label4.Size = new Size(126, 20);
			label4.TabIndex = 6;
			label4.Text = "&Shipping address:";
			// 
			// textBoxShippingAddress
			// 
			textBoxShippingAddress.Location = new Point(147, 173);
			textBoxShippingAddress.Margin = new Padding(3, 4, 3, 4);
			textBoxShippingAddress.Name = "textBoxShippingAddress";
			textBoxShippingAddress.Size = new Size(228, 27);
			textBoxShippingAddress.TabIndex = 7;
			// 
			// buttonOk
			// 
			buttonOk.DialogResult = DialogResult.OK;
			buttonOk.Location = new Point(198, 260);
			buttonOk.Margin = new Padding(3, 4, 3, 4);
			buttonOk.Name = "buttonOk";
			buttonOk.Size = new Size(86, 31);
			buttonOk.TabIndex = 8;
			buttonOk.Text = "OK";
			buttonOk.UseVisualStyleBackColor = true;
			buttonOk.Click += buttonOk_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Location = new Point(290, 260);
			buttonCancel.Margin = new Padding(3, 4, 3, 4);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(86, 31);
			buttonCancel.TabIndex = 9;
			buttonCancel.Text = "Cancel";
			buttonCancel.UseVisualStyleBackColor = true;
			buttonCancel.Click += buttonOk_Click;
			// 
			// FormMain
			// 
			AcceptButton = buttonOk;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(405, 313);
			Controls.Add(buttonCancel);
			Controls.Add(buttonOk);
			Controls.Add(textBoxShippingAddress);
			Controls.Add(label4);
			Controls.Add(textBoxReceiptAddress);
			Controls.Add(label3);
			Controls.Add(textBoxAddress);
			Controls.Add(label2);
			Controls.Add(textBoxName);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Margin = new Padding(5, 4, 5, 4);
			MaximizeBox = false;
			Name = "FormMain";
			Text = "Customer Information";
			Load += FormMain_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxAddress;
        private Label label3;
        private TextBox textBoxReceiptAddress;
        private Label label4;
        private TextBox textBoxShippingAddress;
        private Button buttonOk;
        private Button buttonCancel;
    }
}

