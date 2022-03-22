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
    public class Patient : Form
    {
		private System.ComponentModel.IContainer components = null;
        ListView lstPaciente;
		Button btnInserir;
		Button btnUpdate;
		Button btnDelete;
		Button btnVoltar;

        public Patient()
        {
            lstPaciente = new ListView();
			lstPaciente.Location = new Point(50,50 );
			lstPaciente.Size = new Size(400,320);
			lstPaciente.View = View.Details;
			ListViewItem paciente1 = new ListViewItem("Elon Musk");
			paciente1.SubItems.Add("3");
			paciente1.SubItems.Add("1971");
			ListViewItem paciente2 = new ListViewItem("Rainha Elizabeth");
			paciente2.SubItems.Add("2");
			paciente2.SubItems.Add("55 AC");
			ListViewItem paciente3 = new ListViewItem("Bolsonaro");
			paciente3.SubItems.Add("1");	
			paciente3.SubItems.Add("1955");		
			lstPaciente.Items.AddRange(new ListViewItem[]{paciente1, paciente2, paciente3});
			lstPaciente.Columns.Add("Nome", -2, HorizontalAlignment.Left);
    		lstPaciente.Columns.Add("ID", -2, HorizontalAlignment.Left);
			lstPaciente.Columns.Add("Ano de Nasc", -2, HorizontalAlignment.Left);
			lstPaciente.FullRowSelect = true;
			lstPaciente.GridLines = true;
			lstPaciente.AllowColumnReorder = true;
			lstPaciente.Sorting = SortOrder.Ascending;

			//============= Inserir ===============

			this.btnInserir = new ButtonField("Inserir", 50, 380,100, 30);
			btnInserir.Click += new EventHandler(this.btnInserirClick);

			//================ Update ==================

			this.btnUpdate = new ButtonField("Update", 150, 380, 100, 30);

			//================= Delete =====================

			this.btnDelete = new ButtonField("Delete", 250, 380, 100, 30);
			btnDelete.Click += new EventHandler(this.btnDeleteClick);

			//================= Voltar =================

			this.btnVoltar = new ButtonField("Voltar", 350, 380, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lstPaciente);

			this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Paciente";

			
        }

			
			private void btnVoltarClick(object sender, EventArgs e)
           {
            	this.Close();
           }

			public class ButtonField : Button 
        {
            public ButtonField(string Text, int x, int y, int Z, int P)
           {
            this.Text = Text;
            this.Location = new Point(x ,y);
            this.Size = new Size(Z, P);
           }
        }

		public void btnDeleteClick(object sender, EventArgs e)
        {
            string message = "Você realmente deseja deletar o Paciente?";
            string caption = " ATENÇÃO! ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
           {
            
            	this.Close();

           }

        }

		private void btnInserirClick(object sender, EventArgs e)
            {
            
				CadPaciente CadPaciente = new CadPaciente();
				CadPaciente.ShowDialog();
            }

		
    }
}