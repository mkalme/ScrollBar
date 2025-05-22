namespace ScrollBar {
    partial class ScrollBarPanel {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Bar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Bar
            // 
            this.Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Bar.Location = new System.Drawing.Point(0, 0);
            this.Bar.Margin = new System.Windows.Forms.Padding(0);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(31, 100);
            this.Bar.TabIndex = 0;
            this.Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bar_MouseDown);
            this.Bar.MouseEnter += new System.EventHandler(this.Bar_MouseEnter);
            this.Bar.MouseLeave += new System.EventHandler(this.Bar_MouseLeave);
            this.Bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bar_MouseUp);
            // 
            // ScrollBarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.Bar);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ScrollBarPanel";
            this.Size = new System.Drawing.Size(31, 464);
            this.Load += new System.EventHandler(this.ScrollBar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Bar;
    }
}
