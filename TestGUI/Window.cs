using System;
using System.Windows.Forms;
using ScrollBar;

namespace TestGUI {
    public partial class Window : Form {
        public Window() {
            InitializeComponent();

            GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            var panel = new ScrollablePanelNew();
            panel.Control = GridView;

            Controls.Add(panel);

            DisplayGrid();
        }
        private void DisplayGrid() {
            GridView.Rows.Clear();

            for (int i = 0; i < 30; i++) {
                GridView.Rows.Add($"{DateTime.Now} {i + 1}");
            }

            SetGridHeight();
        }
        private void SetGridHeight() {
            var height = GridView.ColumnHeadersHeight;
            foreach (DataGridViewRow row in GridView.Rows) {
                if (row.Visible)
                    height += row.Height;
            }

            GridView.Height = height + 2;
        }
    }
}
