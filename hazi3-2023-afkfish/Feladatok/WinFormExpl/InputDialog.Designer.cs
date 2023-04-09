namespace WinFormExpl
{
    partial class InputDialog
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
            textBox1 = new TextBox();
            bOk = new Button();
            bCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(184, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 31);
            textBox1.TabIndex = 0;
            // 
            // bOk
            // 
            bOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bOk.DialogResult = DialogResult.OK;
            bOk.Location = new Point(78, 189);
            bOk.Name = "bOk";
            bOk.Size = new Size(112, 34);
            bOk.TabIndex = 1;
            bOk.Text = "Ok";
            bOk.UseVisualStyleBackColor = true;
            bOk.Click += bOk_Click;
            // 
            // bCancel
            // 
            bCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bCancel.DialogResult = DialogResult.Cancel;
            bCancel.Location = new Point(303, 189);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(112, 34);
            bCancel.TabIndex = 2;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(230, 93);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 3;
            label1.Text = "Path";
            // 
            // InputDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 266);
            Controls.Add(label1);
            Controls.Add(bCancel);
            Controls.Add(bOk);
            Controls.Add(textBox1);
            Name = "InputDialog";
            Text = "InputDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button bOk;
        private Button bCancel;
        private Label label1;
    }
}