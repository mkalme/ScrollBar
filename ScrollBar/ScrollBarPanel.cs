using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScrollBar {
    public partial class ScrollBarPanel : UserControl {
        private ScrollablePanelNew _scrollablePanel;
        public ScrollablePanelNew ScrollablePanel {
            get => _scrollablePanel;
            set {
                _scrollablePanel = value;
                Update();
            }
        }

        public ScrollBarPanel() {
            InitializeComponent();
        }

        private void ScrollBar_Load(object sender, EventArgs e) {
            UpdatePanel();
        }

        public void UpdatePanel() {
            if (_scrollablePanel == null) return;

            Bar.Height = GetHeight();
            //Bar.Location = new Point(0, GetY());

            Console.WriteLine(_scrollablePanel.Control.Height);
        }
        private int GetHeight() {
            return (int)((float)_scrollablePanel.Height / _scrollablePanel.Control.Height * Height);
        }
        private int GetY() {
            return (int)((float)_scrollablePanel.Control.Location.Y / _scrollablePanel.Height * Height);
        }

        //Events
        private void Bar_MouseEnter(object sender, EventArgs e) {
            Bar.BackColor = Color.FromArgb(100, 100, 100);
        }
        private void Bar_MouseLeave(object sender, EventArgs e) {
            Bar.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void Bar_MouseDown(object sender, MouseEventArgs e) {
            Bar.BackColor = Color.FromArgb(140, 140, 140);
        }
        private void Bar_MouseUp(object sender, MouseEventArgs e) {
            Bar.BackColor = Color.FromArgb(100, 100, 100);
        }
    }
}
