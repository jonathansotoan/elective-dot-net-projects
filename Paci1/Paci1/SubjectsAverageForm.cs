using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Paci1
{
    public partial class SubjectsAverageForm : Form
    {
        private List<string> subjects;
        private List<float> grades;

        public SubjectsAverageForm()
        {
            InitializeComponent();
            grades = new List<float>();
            subjects = new List<string>();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSubject.Text != "")
                {
                    if (subjects.Contains(cmbSubject.Text))
                    {
                        MessageBox.Show("La asignatura \"" + cmbSubject.Text + "\" ya fue agregada");
                    }
                    else
                    {
                        subjects.Add(cmbSubject.Text);
                        grades.Add(float.Parse(txtGrade.Text, CultureInfo.InvariantCulture.NumberFormat));
                        ltbSubjects.Items.Add(cmbSubject.Text + " - " + txtGrade.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una asignatura");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("El formato de la nota no es el correcto o no lo ingresaste");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (grades.Count > 0)
            {
                float average = grades.Sum() / grades.Count();
                lblResults.Text = "Promedio: " + average;
                pcResultados.Image = ilstResultImages.Images[average < 3.5 ? "Failed.jpg" : "Success.jpg"];
            }
        }
    }
}
