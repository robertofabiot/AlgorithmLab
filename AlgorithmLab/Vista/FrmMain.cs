using AlgorithmLab.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmLab
{
    public partial class FrmMain : Form
    {
        Button[] navigationButtons = new Button[4];
        public FrmMain()
        {
            InitializeComponent();
            ArrayNavigationButtons();
            var vistaOrdenamiento = new UCConfiguration();
            ChangeView(vistaOrdenamiento);
            SelectBtn(btnConfiguration);

        }

        #region UserControl
        private void ArrayNavigationButtons()
        {
            navigationButtons = new Button[] { btnConfiguration, btnRecord, btnSearch, btnSort };
        }
        private void ChangeView(UserControl newView)
        {
            panelUserControl.Controls.Clear();
            newView.Dock = DockStyle.Fill;
            panelUserControl.Controls.Add(newView);
        }
        private void SelectBtn(Button btnSelected)
        {
            //btnSelected.BackColor = Color.FromArgb(150, 230, 179);
            btnSelected.Enabled = false;
            foreach (var button in navigationButtons.Where(b => b != btnSelected))
                UnselectBtn(button);
        }
        private void UnselectBtn(Button btnUnselected)
        {
            //btnUnselected.BackColor = Color.FromArgb(86, 130, 89);
            btnUnselected.Enabled = true;
        }
        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            SelectBtn(btnConfiguration);
            var viewConfiguration = new UCConfiguration();
            ChangeView(viewConfiguration);
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            SelectBtn(btnSort);
            var viewConfiguration = new UCSort();
            ChangeView(viewConfiguration);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SelectBtn(btnSearch);
            var viewConfiguration = new UCSearch();
            ChangeView(viewConfiguration);
        }
        private void btnRecord_Click(object sender, EventArgs e)
        {
            SelectBtn(btnRecord);
            var viewConfiguration = new UCRecord();
            ChangeView(viewConfiguration);
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            btn.BackColor = Color.FromArgb(86, 130, 89);
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            btn.BackColor = Color.Transparent;
        }
        #endregion
    }
}