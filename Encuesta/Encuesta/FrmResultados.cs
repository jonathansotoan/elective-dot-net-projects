using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encuesta
{
    public partial class FrmResultados : Form
    {
        private int rightQuestions = 0;
        private int wrongQuestions = 0;
        private int quantityQuestions = 0;
        private string[] answers = { 
                                   "6-10",
                                   "15 - 25",
                                   "Verde",
                                   "Bandeja Paisa",
                                   "estudia mucho",
                                   "0",
                                   "1",
                                   "2",
                                   "3",
                                   "2",
                                   "1",
                                   "0",
                                   "1",
                                   "2",
                                   "3"
                                   };

        public FrmResultados(ResultSet results, Form mdiParent)
        {
            InitializeComponent();
            this.MdiParent = mdiParent;
            showResults(results);
        }

        private void showResults(ResultSet results)
        {
            // section 1
            IsRight(results.ScheduleForStudying.Answer, answers[0]);
            IsRight(results.QuantityOfClassmates.Answer, answers[1]);
            IsRight(results.FavoriteColor.Answer, answers[2]);
            IsRight(results.FavoriteFood.Answer, answers[3]);

            // section 3
            IsRight(results.TalkToThePastMe, answers[4]);

            // section 4
            for(int index = 0; index < results.QualityQuestions.Length; ++index)
            {
                IsRight(results.QualityQuestions[index].Answer, answers[5 + index]);
            }

            // basic info
            using (StreamWriter writer = new StreamWriter("BasicInformation.txt"))
            {
                writer.WriteLine("Names: " + results.Names);
                lblNames.Text = "Names: " + results.Names;
                writer.WriteLine("Apellidos: " + results.LastNames);
                lblLastNames.Text = "Apellidos: " + results.LastNames;
                writer.WriteLine("Fecha de nacimiento: " + results.BirthDate);
                lblBirthDate.Text = "Fecha de nacimiento: " + results.BirthDate;
                writer.WriteLine("Ciudad de nacimiento: " + results.City);
                lblBirthCity.Text = "Ciudad de nacimiento: " + results.City;
                writer.WriteLine("Edad: " + results.Age);
                lblAge.Text = "Edad: " + results.Age;
                writer.WriteLine("Pregrados: " + ArrayToString(results.Undergraduates));
                lblUndergraduates.Text = "Pregrados: " + ArrayToString(results.Undergraduates);
            }

            lblQuantityOfQuestions.Text = "Cantidad de preguntas: " + quantityQuestions;
            lblQuantityOfRightQuestions.Text = "Cantidad de preguntas correctas: " + rightQuestions;
            lblQuantityOfWrongQuestions.Text = "Cantidad de preguntas incorrectas: " + wrongQuestions;
        }

        private void IsRight(string answerAttempt, string rightAnswer) 
        {
            ++quantityQuestions;

            if (answerAttempt == rightAnswer)
            {
                Console.WriteLine(answerAttempt + " is equal to " + rightAnswer);
                ++rightQuestions;
            }
            else
            {
                Console.WriteLine(answerAttempt + " is not equal to " + rightAnswer);
                ++wrongQuestions;
            }
        }

        private string ArrayToString(object[] objects)
        {
            StringBuilder builder = new StringBuilder("[");

            foreach(object obj in objects)
            {
                builder.Append(obj).Append(", ");
            }

            return builder.Append("]").ToString();
        }
    }
}
