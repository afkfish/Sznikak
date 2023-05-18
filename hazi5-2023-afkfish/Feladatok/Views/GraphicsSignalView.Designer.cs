using Signals.DocView;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace Signals
{
    partial class GraphicsSignalView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bZoomIn = new Button();
            bZoomOut = new Button();
            SuspendLayout();
            // 
            // bZoomIn
            // 
            bZoomIn.Location = new Point(6, 6);
            bZoomIn.Margin = new Padding(6);
            bZoomIn.Name = "bZoomIn";
            bZoomIn.Size = new Size(40, 40);
            bZoomIn.TabIndex = 0;
            bZoomIn.Text = "+";
            bZoomIn.UseVisualStyleBackColor = true;
            bZoomIn.Click += bZoomIn_Click;
            // 
            // bZoomOut
            // 
            bZoomOut.Location = new Point(60, 6);
            bZoomOut.Margin = new Padding(6);
            bZoomOut.Name = "bZoomOut";
            bZoomOut.Size = new Size(40, 40);
            bZoomOut.TabIndex = 1;
            bZoomOut.Text = "-";
            bZoomOut.UseVisualStyleBackColor = true;
            bZoomOut.Click += bZoomOut_Click;
            // 
            // GraphicsSignalView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(bZoomOut);
            Controls.Add(bZoomIn);
            Margin = new Padding(6);
            Name = "GraphicsSignalView";
            Size = new Size(245, 286);
            ResumeLayout(false);
        }

        #endregion

        private Button bZoomIn;
        private Button bZoomOut;
    }
}
