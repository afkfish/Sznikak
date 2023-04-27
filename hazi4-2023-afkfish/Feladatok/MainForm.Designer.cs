namespace MultiThreadedApp
{
    partial class MainForm
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
            pTarget = new Panel();
            bBike1 = new Button();
            bStart = new Button();
            bBike2 = new Button();
            bBike3 = new Button();
            pStart = new Panel();
            bStep1 = new Button();
            pDepo = new Panel();
            bStep2 = new Button();
            bStepsCount = new Button();
            bStop = new Button();
            SuspendLayout();
            // 
            // pTarget
            // 
            pTarget.BackColor = Color.LightSteelBlue;
            pTarget.Location = new Point(1330, 41);
            pTarget.Margin = new Padding(4, 4, 4, 4);
            pTarget.Name = "pTarget";
            pTarget.Size = new Size(229, 842);
            pTarget.TabIndex = 0;
            // 
            // bBike1
            // 
            bBike1.Font = new Font("Webdings", 32F, FontStyle.Regular, GraphicsUnit.Point);
            bBike1.Location = new Point(160, 41);
            bBike1.Margin = new Padding(4, 4, 4, 4);
            bBike1.Name = "bBike1";
            bBike1.Size = new Size(214, 140);
            bBike1.TabIndex = 0;
            bBike1.Text = "b";
            bBike1.UseVisualStyleBackColor = true;
            bBike1.Click += bBike1_Click;
            // 
            // bStart
            // 
            bStart.Location = new Point(160, 972);
            bStart.Margin = new Padding(4, 4, 4, 4);
            bStart.Name = "bStart";
            bStart.Size = new Size(214, 113);
            bStart.TabIndex = 1;
            bStart.Text = "Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // bBike2
            // 
            bBike2.Font = new Font("Webdings", 32F, FontStyle.Regular, GraphicsUnit.Point);
            bBike2.Location = new Point(160, 188);
            bBike2.Margin = new Padding(4, 4, 4, 4);
            bBike2.Name = "bBike2";
            bBike2.Size = new Size(214, 140);
            bBike2.TabIndex = 2;
            bBike2.Text = "b";
            bBike2.UseVisualStyleBackColor = true;
            bBike2.Click += bBike1_Click;
            // 
            // bBike3
            // 
            bBike3.Font = new Font("Webdings", 32F, FontStyle.Regular, GraphicsUnit.Point);
            bBike3.Location = new Point(160, 335);
            bBike3.Margin = new Padding(4, 4, 4, 4);
            bBike3.Name = "bBike3";
            bBike3.Size = new Size(214, 140);
            bBike3.TabIndex = 3;
            bBike3.Text = "b";
            bBike3.UseVisualStyleBackColor = true;
            bBike3.Click += bBike1_Click;
            // 
            // pStart
            // 
            pStart.BackColor = Color.SteelBlue;
            pStart.Location = new Point(524, 41);
            pStart.Margin = new Padding(4, 4, 4, 4);
            pStart.Name = "pStart";
            pStart.Size = new Size(229, 842);
            pStart.TabIndex = 4;
            // 
            // bStep1
            // 
            bStep1.Location = new Point(524, 972);
            bStep1.Margin = new Padding(4, 4, 4, 4);
            bStep1.Name = "bStep1";
            bStep1.Size = new Size(229, 113);
            bStep1.TabIndex = 5;
            bStep1.Text = "Step1";
            bStep1.UseVisualStyleBackColor = true;
            bStep1.Click += bStep1_Click;
            // 
            // pDepo
            // 
            pDepo.BackColor = Color.LightSkyBlue;
            pDepo.Location = new Point(929, 41);
            pDepo.Margin = new Padding(4, 4, 4, 4);
            pDepo.Name = "pDepo";
            pDepo.Size = new Size(229, 842);
            pDepo.TabIndex = 6;
            // 
            // bStep2
            // 
            bStep2.Location = new Point(929, 972);
            bStep2.Margin = new Padding(4, 4, 4, 4);
            bStep2.Name = "bStep2";
            bStep2.Size = new Size(229, 113);
            bStep2.TabIndex = 7;
            bStep2.Text = "Step2";
            bStep2.UseVisualStyleBackColor = true;
            bStep2.Click += bStep2_Click;
            // 
            // bStepsCount
            // 
            bStepsCount.Location = new Point(1330, 972);
            bStepsCount.Margin = new Padding(4, 4, 4, 4);
            bStepsCount.Name = "bStepsCount";
            bStepsCount.Size = new Size(229, 113);
            bStepsCount.TabIndex = 8;
            bStepsCount.Text = "steps";
            bStepsCount.UseVisualStyleBackColor = true;
            bStepsCount.Click += bStepsCount_Click;
            // 
            // bStop
            // 
            bStop.Location = new Point(160, 1110);
            bStop.Margin = new Padding(4, 4, 4, 4);
            bStop.Name = "bStop";
            bStop.Size = new Size(214, 113);
            bStop.TabIndex = 9;
            bStop.Text = "Stop";
            bStop.UseVisualStyleBackColor = true;
            bStop.Click += bStop_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1794, 1238);
            Controls.Add(bStop);
            Controls.Add(bStepsCount);
            Controls.Add(bStep2);
            Controls.Add(bStep1);
            Controls.Add(bBike3);
            Controls.Add(bBike2);
            Controls.Add(bStart);
            Controls.Add(bBike1);
            Controls.Add(pTarget);
            Controls.Add(pStart);
            Controls.Add(pDepo);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainForm";
            Text = "Tour de France - JOYAXJ";
            ResumeLayout(false);
        }

        #endregion

        private Panel pTarget;
        private Button bBike1;
        private Button bStart;
        private Button bBike2;
        private Button bBike3;
        private Panel pStart;
        private Button bStep1;
        private Panel pDepo;
        private Button bStep2;
        private Button bStepsCount;
        private Button bStop;
    }
}