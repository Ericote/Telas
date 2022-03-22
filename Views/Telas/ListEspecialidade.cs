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
    public class ListEspecialidade : Form
    {
		private System.ComponentModel.IContainer components = null;
        ListView lstEspecialidade;
		Button btnInserir;
		Button btnUpdate;
		Button btnDelete;
		Button btnVoltar;

        public ListEspecialidade()
        {
            lstEspecialidade = new ListView();
			lstEspecialidade.Location = new Point(50,50 );
			lstEspecialidade.Size = new Size(400,320);
			lstEspecialidade.View = View.Details;
			ListViewItem especialidade1 = new ListViewItem("Extração");
			especialidade1.SubItems.Add("3");
			especialidade1.SubItems.Add("Extrair Dentes");
			ListViewItem especialidade2 = new ListViewItem("Limpeza");
			especialidade2.SubItems.Add("2");
			especialidade2.SubItems.Add("Limpar Dentes");
			ListViewItem especialidade3 = new ListViewItem("Anestesia");
			especialidade3.SubItems.Add("1");	
			especialidade3.SubItems.Add("Anestesiar Dentes");		
			lstEspecialidade.Items.AddRange(new ListViewItem[]{especialidade1, especialidade2, especialidade3});
			lstEspecialidade.Columns.Add("Nome", -2, HorizontalAlignment.Left);
    		lstEspecialidade.Columns.Add("ID", -2, HorizontalAlignment.Left);
			lstEspecialidade.Columns.Add("Tarefa", -2, HorizontalAlignment.Left);
			lstEspecialidade.FullRowSelect = true;
			lstEspecialidade.GridLines = true;
			lstEspecialidade.AllowColumnReorder = true;
			lstEspecialidade.Sorting = SortOrder.Ascending;

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
            this.Controls.Add(this.lstEspecialidade);

			this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Especialidades";

			
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
            string message = "Você realmente deseja deletar a Especialidade?";
            string caption = " ATENÇÃO! ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
           {
            	this.Close();
           }

        }

		private void btnInserirClick(object sender, EventArgs e)
            {
            
				CadEspecialidade CadEspecialidade = new CadEspecialidade();
				CadEspecialidade.ShowDialog();
            }

		
    }
}