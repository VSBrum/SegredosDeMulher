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

namespace SegredosDeMulher {
    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();
            this.Text = "Segredos de Mulher";
     
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        //Método para abrir as forms no painel
        private void OpenFormInPainel(object FormSecundaria) {

            if (this.painelPrincipal.Controls.Count > 0) { 
                this.painelPrincipal.Controls.RemoveAt(0);
            }       
            Form fs = FormSecundaria as Form;
            fs.TopLevel = false;
            fs.Dock = DockStyle.Bottom;
            this.painelPrincipal.Controls.Add(fs);
            this.painelPrincipal.Tag = fs;
            fs.Show();
        }

        //Método para permitir que se arraste a form pela barra de titulo
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconcerrar_Click(object sender, EventArgs e) {

            if(MessageBox.Show("Tem certeza que deseja fechar?", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                Application.Exit();
            }
            
        }

        private void iconrestaurar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconmaximizar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
           
        }


        private void btnprod_Click(object sender, EventArgs e) {
            lbTitulo.Text = "Produtos";
            OpenFormInPainel(new Produtos());
        }

        private void btnVenda_Click(object sender, EventArgs e) {
            lbTitulo.Text = "Vendas";
            OpenFormInPainel(new Vendas());
        }

        private void btnCliente_Click(object sender, EventArgs e) {
            lbTitulo.Text = "Clientes";
            OpenFormInPainel(new Cliente());
        }
    }
}
