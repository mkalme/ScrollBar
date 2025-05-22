namespace ScrollBar {
    partial class ScrollablePanelNew {
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
            this.PanelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ScrollBarPanel = new ScrollBar.ScrollBarPanel();
            this.PanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.ColumnCount = 2;
            this.PanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.PanelContainer.Controls.Add(this.ScrollBarPanel, 1, 0);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.RowCount = 1;
            this.PanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelContainer.Size = new System.Drawing.Size(618, 351);
            this.PanelContainer.TabIndex = 0;
            // 
            // ScrollBarPanel
            // 
            this.ScrollBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ScrollBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScrollBarPanel.Location = new System.Drawing.Point(602, 0);
            this.ScrollBarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ScrollBarPanel.Name = "ScrollBarPanel";
            this.ScrollBarPanel.ScrollablePanel = null;
            this.ScrollBarPanel.Size = new System.Drawing.Size(16, 351);
            this.ScrollBarPanel.TabIndex = 0;
            // 
            // ScrollablePanelNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.PanelContainer);
            this.Name = "ScrollablePanelNew";
            this.Size = new System.Drawing.Size(618, 351);
            this.PanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelContainer;
        private ScrollBarPanel ScrollBarPanel;
    }
}
