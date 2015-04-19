using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encuesta
{
    public partial class FrmSection4 : Form
    {
        private Control[] panels;
        public FrmSection4(Form mdiParent)
        {
            InitializeComponent();
            this.MdiParent = mdiParent;
            addQuestions(new[] {
                "¿Cómo calificaría el aporte de la clase de C# a su carrera?",
                "¿Cómo es la calidad de las referencias bilbiográficas utilizadas?",
                "¿Cómo cree que le irá en la materia?",
                "¿Cómo cree que le irá al grupo en la materia?",
                "¿Cómo cree que le irá al profesor impartiendo la materia?",
                "¿Qué tan bueno es el material de la biblioteca relacionado con la materia?",
                "¿Cómo es la calidad de la sala dónde se desarrolla?",
                "¿Cómo es la calidad de las herramientas utilizadas?",
                "¿Cómo es su puntualidad? (hora inicio y fin)",
                "¿Cómo es la puntualidad del profesor? (hora inicio y fin)"
            });
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Program.Back();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // save questions
            Program.Results.QualityQuestions = new AnsweredQuestion[lblsQuestions.Length];

            for (int index = 0; index < lblsQuestions.Length; ++index)
            {
                Program.Results.QualityQuestions[index] = new AnsweredQuestion
                {
                    Question = lblsQuestions[index].Text,
                    Answer = panels[index].Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name.Split('_')[1]
                    //Answer = GetCheckedButton(panels[index]).Text
                };
                Console.WriteLine(panels[index].Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
            }

            // show results
            Program.Forward(new FrmResultados(Program.Results, this.MdiParent));
        }

        private RadioButton GetCheckedButton(Control panel)
        {
            foreach (RadioButton rd in panel.Controls.OfType<RadioButton>())
            {
                if (rd.Checked)
                {
                    return rd;
                }
            }

            return null;
        }
    }
}
