using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollBar {
    public partial class ScrollablePanelNew : UserControl {
        private Control _control;
        public Control Control {
            get => _control;
            set {
                _control = value;
                PanelContainer.Controls.Add(value, 0, 0);

                ScrollBarPanel.UpdatePanel();
            }
        }

        public ScrollablePanelNew() {
            InitializeComponent();

            ScrollBarPanel.ScrollablePanel = this;
        }
    }
}
