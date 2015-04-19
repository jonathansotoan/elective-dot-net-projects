using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encuesta
{
    public class ResultSet
    {
        // basic info
        public string Names { get; set; }
        public string LastNames { get; set; }
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string[] Undergraduates { get; set; }

        // section 1
        public AnsweredQuestion ScheduleForStudying{get; set;}
        public AnsweredQuestion QuantityOfClassmates{get; set;}
        public AnsweredQuestion FavoriteColor{get; set;}
        public AnsweredQuestion FavoriteFood{get; set;}

        // section 3
        public string TalkToThePastMe { get; set; }

        // section 4
        public AnsweredQuestion[] QualityQuestions { get; set; }

        public override string ToString()
        {
            return new StringBuilder("Nombres: ").Append(Names)
                .Append("\nApellidos: ").Append(LastNames)
                .Append("\nFecha de nacimiento: ").Append(BirthDate)
                .Append("\nCiudad: ").Append(City)
                .Append("\nEdad: ").Append(Age)
                .Append("\nProgramas: ").Append(Undergraduates)
                .Append("\nHorario de estudio: ").Append(ScheduleForStudying)
                .Append("\nCantidad de compañeros: ").Append(QuantityOfClassmates)
                .Append("\nColor favorito: ").Append(FavoriteColor)
                .Append("\nComida favorita: ").Append(FavoriteFood)

                .Append("\nComentario al \"yo\" del pasado: ").Append(TalkToThePastMe)
                .Append("\nPreguntas de calidad: ").Append(questionsToString(QualityQuestions))
                .ToString();
        }

        private string questionsToString(AnsweredQuestion[] questions)
        {
            StringBuilder results = new StringBuilder('[');

            foreach (AnsweredQuestion q in questions)
            {
                results.Append(q).Append('\n');
            }

            return results.Append(']').ToString();
        }
    }
}
