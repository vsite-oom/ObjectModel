﻿namespace Vsite.Oom.ObjectModel
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
            textBoxReceiptAddress = new TextBox();
            label4 = new Label();
            textBoxShippingAddress = new TextBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "&Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(129, 19);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 23);
            textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 59);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "&Address:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(129, 56);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(200, 23);
            textBoxAddress.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 96);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 4;
            label3.Text = "&Receipt address:";
            // 
            // textBoxReceiptAddress
            // 
            textBoxReceiptAddress.Location = new Point(129, 93);
            textBoxReceiptAddress.Name = "textBoxReceiptAddress";
            textBoxReceiptAddress.Size = new Size(200, 23);
            textBoxReceiptAddress.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 133);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 6;
            label4.Text = "&Shipping address:";
            // 
            // textBoxShippingAddress
            // 
            textBoxShippingAddress.Location = new Point(129, 130);
            textBoxShippingAddress.Name = "textBoxShippingAddress";
            textBoxShippingAddress.Size = new Size(200, 23);
            textBoxShippingAddress.TabIndex = 7;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(173, 195);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 8;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(254, 195);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonOk_Click;
            // 
            // FormMain
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(354, 235);
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
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Customer Information";
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

