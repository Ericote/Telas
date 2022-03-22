using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas
{
    public class CadAgendamento : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblIdDentista;
        Label lblIdPaciente;
        Label lblData;
        TextBox txtIdDentista;
        TextBox txtIdPaciente;
        TextBox txtData;
        Button btnConfirmar;
        Button btnCancelar;

        public CadAgendamento()
        {

            //========== Label e Box do nome =============

            this.lblIdDentista = new Label();
            this.lblIdDentista.Text = "ID Dentista";
            this.lblIdDentista.Location = new Point(125, 30);

            this.txtIdDentista = new TextBox();
            this.txtIdDentista.Location = new Point(60, 60);
            this.txtIdDentista.Size = new Size(180, 20);

            //========== Label e Box do Email =============

            this.lblIdPaciente = new Label();
            this.lblIdPaciente.Text = "ID Paciente";
            this.lblIdPaciente.Location = new Point(125, 90);

            this.txtIdPaciente = new TextBox();
            this.txtIdPaciente.Location = new Point(60, 120);
            this.txtIdPaciente.Size = new Size(180, 20);

            //========== Label e Box do CPF =============

            this.lblData = new Label();
            this.lblData.Text = "Data";
            this.lblData.Location = new Point(130, 150);

            this.txtData = new TextBox();
            this.txtData.Location = new Point(60, 180);
            this.txtData.Size = new Size(180, 20);

            //=========== Confirmar =============

            this.btnConfirmar = new ButtonField("Confirmar", 40, 220, 100, 30);
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);

            //========== Cancelar ===============

            this.btnCancelar = new ButtonField("Cancelar", 170, 220, 100, 30);
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);


            this.Controls.Add(this.lblIdDentista);
            this.Controls.Add(this.lblIdPaciente);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtIdDentista);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Cadastro de Agendamento";
        }

        private void btnCancelarClick(object sender, EventArgs e)
           {
                this.Close();
           }

           public void btnConfirmarClick(object sender, EventArgs e)
        {
            string message = "Agendamento cadastrado com sucesso! (Só que não, isso aqui é teste)";
            string caption = " PARABÉNS ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
           {
            	this.Close();
           }

        }
    }
}