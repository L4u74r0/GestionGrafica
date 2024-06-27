using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_gráfica
{
    public partial class LDGvisual : Form
    {
        public LDGvisual()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing() //Metodo que oculta los paneles de submenus modificando la propiedad ".visible"
        {
            pnlGrafSubmenu.Visible = false;
            pnlCajaSubmenu.Visible = false;
        }
        private void hideSubMenu() //Metodo para ocultar el submenu agregado anteriormente
        {
            if (pnlGrafSubmenu.Visible == true)
                pnlGrafSubmenu.Visible = false;
            if (pnlCajaSubmenu.Visible == true)
                pnlCajaSubmenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu) //Metodo que muestra el submenu agregado anteriormente
        //como todos los elementos son paneles se establece un parametro "panel" con el nombre subMenu  
        {
            if(subMenu.Visible == false) //Si panel: subMenu está oculto, mostramos subMenu
            {
              
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;//Caso contrario se panel: subMenu esta visible, se oculta
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            //..
            //Form Code
            //..
            hideSubMenu();
        }

        private void btnGarantia_Click(object sender, EventArgs e)
        {
            //..
            //Form Code
            //..
            hideSubMenu();
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlGrafSubmenu);
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            //..
            //Form Code
            //..
            hideSubMenu();
        }

        private void btnConfirmado_Click(object sender, EventArgs e)
        {
            //..
            //Form Code
            //..
            hideSubMenu();
        }

        private void btnProceso_Click(object sender, EventArgs e)
        {
            //..
            //Form Code
            //..
            hideSubMenu();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlCajaSubmenu);
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            //..
            //Form Code
            //..
            hideSubMenu();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            //..
            //Form Code
            //..
            hideSubMenu();
        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {
            //..
            //Form Code
            //..
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(childForm);
            pnlContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
