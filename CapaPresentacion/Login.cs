using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMatricula.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        DataSet dsUsuario;
        DataTable dtUsuario;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CargarComboUsuario();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                using (GestorUsuario elUsuario = new GestorUsuario())
                {
                    cbxAccount.DataSource = elUsuario.ListarUsuario();
                    cbxAccount.ValueMember = "Usuario_id";
                    cbxAccount.DisplayMember = "Usuario_contrasenna";
                    
                    this.dsUsuario = elUsuario.ConsultarUsuario(int.Parse(cbxAccount.SelectedValue.ToString()));
                    this.dtUsuario = this.dsUsuario.Tables[0];
                
                    CargarComboUsuario();
                }
               string contra = dtUsuario.Rows[0]["Usuario_contrasenna"].ToString();
                
                if(txtUsuario_contrasenna.Text == contra)
                {
                    Form form = new frmPrincipal();
                    form.Show();
                    
                    Visible = false;
                    //.Enable = false;
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private int Validar()
        {
            epError.Clear();
            if (txtUsuario_contrasenna.Text.Trim() == "")
            {
                epError.SetError(txtUsuario_contrasenna, "Insertar contraseña...");
                txtUsuario_contrasenna.Focus();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void CargarComboUsuario()
        {
            using (GestorUsuario elUsuario = new GestorUsuario())
            {
                cbxAccount.DataSource = elUsuario.ListarUsuario();
                cbxAccount.ValueMember = "Usuario_id";
                cbxAccount.DisplayMember = "Usuario_nombre";
            }
        }

        
    }
}
