using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;


namespace Promedio
{
    public partial class Notas : Form
    {
        public Queue Estudiantes;
        public char estado;
        public string mensaje;
        public Notas()
        {
            this.Estudiantes = new Queue();
            InitializeComponent(); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.estado = '0';
            showForm();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int _antes, _despues;
                _antes = int.Parse(this.listView1.SelectedItems[0].SubItems[0].Text);
                _despues = this.listView1.Items.Count - _antes;
                for (int i = 1; i < _antes; i++)
                {
                    this.Estudiantes.Enqueue(this.Estudiantes.Dequeue());
                }
                this.Estudiantes.Dequeue();
                for (int i = 0; i < _despues; i++)
                {
                    this.Estudiantes.Enqueue(this.Estudiantes.Dequeue());
                }


                for (int i = _antes; i < this.listView1.Items.Count; i++)
                {
                    this.listView1.Items[i].SubItems[0].Text = (i).ToString();
                }
                this.listView1.Items.Remove(this.listView1.SelectedItems[0]);
            }
            catch (Exception)
            {

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.estado == '0')
                {
                    this.registrarEstudiante();
                }
                else
                {
                    this.editarEstudiante();
                }
                showList();
                this.ClearPanelFormulario();
            }
            catch (Exception)
            {

            }
        }

        private void btnAddQuiz_Click(object sender, EventArgs e)
        {
            double _numero;
            if (this.txtBoxQuiz.Text != "")
            {
                try
                {
                    if (this.txtBoxQuiz.Text.Contains("."))
                    {
                        _numero = Convert.ToDouble(this.txtBoxQuiz.Text.Replace(".", ","));
                    }
                    else
                    {
                        _numero = Convert.ToDouble(this.txtBoxQuiz.Text);
                    }
                    if (_numero > 0 && _numero <= 5)
                    {
                        this.listQuices.Items.Add(_numero);
                        this.txtBoxQuiz.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Nota fuera de los rango calificables ( 0 - 5)");
                    }
                }catch(Exception)
                {
                    MessageBox.Show("ingrese un valor valido para quiz");
                }
            }

        }

        private void btnQuitQuiz_Click(object sender, EventArgs e)
        {
            if (this.listQuices.Items.Count > 0)
            {
                this.listQuices.Items.Remove(this.listQuices.SelectedItem);
            }
        }

        private void btnAddTaller_Click(object sender, EventArgs e)
        {
            double _numero;
            if (this.txtBoxTaller.Text != "")
            {
                try
                {

                    if (this.txtBoxTaller.Text.Contains("."))
                    {
                        _numero = Convert.ToDouble(this.txtBoxTaller.Text.Replace(".", ","));
                    }
                    else
                    {
                        _numero = Convert.ToDouble(this.txtBoxTaller.Text);
                    }
                    if (_numero > 0 && _numero <= 5)
                    {
                        this.listTalleres.Items.Add(_numero);
                        this.txtBoxTaller.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Nota fuera de los rango calificables ( 0 - 5)");
                    }
                }catch(Exception)
                {
                    MessageBox.Show("ingrese un valor valido para taller");
                }
                
            }
        }

        private void btnQuitTaller_Click(object sender, EventArgs e)
        {
            if (this.listTalleres.Items.Count > 0)
            {
                this.listTalleres.Items.Remove(this.listTalleres.SelectedItem);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                this.estado = '1';
                Estudiante editado = Utilidades.GetEstudiante(this.Estudiantes, int.Parse(this.listView1.SelectedItems[0].SubItems[0].Text));
                this.txtBoxNombre.Text = editado.nombre;
                this.txtBoxParcial.Text = editado.parcial.ToString();
                this.NumEdad.Value = editado.edad;

                if (editado.genero == char.Parse(this.btnF.Text))
                {
                    this.btnF.Checked = true;
                }
                else
                {
                    this.btnM.Checked = true;
                }
                Stack _helperS = (Stack)editado.quizes.Clone();
                double _helperD;
                for (int i = 0; i < editado.quizes.Count; i++)
                {
                    _helperD = (double)_helperS.Pop();
                    this.listQuices.Items.Add(_helperD);
                }
                _helperS = (Stack)editado.talleres.Clone();
                for (int i = 0; i < editado.talleres.Count; i++)
                {
                    _helperD = (double)_helperS.Pop();
                    this.listTalleres.Items.Add(_helperD);
                }

                this.showForm();
            }
            catch (Exception)
            {

            }
        }

        public void ClearPanelFormulario()
        {
            this.txtBoxNombre.Text =
                this.txtBoxParcial.Text =
                this.txtBoxQuiz.Text =
                this.txtBoxTaller.Text = "";
            this.listQuices.Items.Clear();
            this.listTalleres.Items.Clear();
            this.NumEdad.Value = 0;
            this.btnF.Checked = this.btnM.Checked = false;

        }

        public void showForm()
        {
            this.Visible = false;
            this.PanelTabla.Visible = false;
            this.PanelFormulario.Visible = true;
            this.Text = this.estado == '0' ? "Formulario" : "Edicion";
            this.Visible = true;
        }

        public void showList()
        {
            this.Visible = false;
            this.PanelTabla.Visible = true;
            this.PanelFormulario.Visible = false;
            this.Text = "Notas";
            this.Visible = true;
        }

        public void registrarEstudiante(){
            
            char _eGenero = btnF.Checked == true ?
                char.Parse(btnF.Text) :
                char.Parse(btnM.Text);

            Estudiante Nuevo = new Estudiante(txtBoxNombre.Text,
                _eGenero,
                int.Parse(NumEdad.Value.ToString())
                );
            Nuevo.parcial = Convert.ToDouble(txtBoxParcial.Text);
            for (int i = 0; i < listQuices.Items.Count; i++)
            {
                Nuevo.AddQuiz(Convert.ToDouble(listQuices.Items[i].ToString()));
            }
            for (int i = 0; i < listTalleres.Items.Count; i++)
            {
                Nuevo.AddTaller(Convert.ToDouble(listTalleres.Items[i].ToString()));
            }

            this.listView1.Items.Add(
                Utilidades.makeListViewItem(Nuevo, Estudiantes.Count)
                );
            this.Estudiantes.Enqueue(Nuevo);
        }

        public void editarEstudiante()
        {
            char _eGenero = btnF.Checked == true ?
                'F' :
                'M';

            Estudiante Nuevo = new Estudiante(txtBoxNombre.Text,
                _eGenero,
                int.Parse(NumEdad.Value.ToString())
                );
            Nuevo.parcial = Convert.ToDouble(txtBoxParcial.Text);
            for (int i = 0; i < listQuices.Items.Count; i++)
            {
                Nuevo.AddQuiz(Convert.ToDouble(listQuices.Items[i].ToString()));
            }
            for (int i = 0; i < listTalleres.Items.Count; i++)
            {
                Nuevo.AddTaller(Convert.ToDouble(listTalleres.Items[i].ToString()));
            }
            Utilidades.cambiarEstudiante( this.Estudiantes, int.Parse(this.listView1.SelectedItems[0].Text), Nuevo, this.listView1);
        }

    }
}
