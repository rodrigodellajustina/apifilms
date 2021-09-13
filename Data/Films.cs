using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilms
{
    public class Films
    {
        /// <summary>
        /// Identificar único do filme
        /// </summary>
        public int id { get; set; }


        /// <summary>
        /// título do filme
        /// </summary>
        public string title { get; set; }


        /// <summary>
        /// ano do filme
        /// </summary>
        public string year { get; set; }

        /// <summary>
        /// Stúdio de criação do filme
        /// </summary>
        public string studios { get; set; }

        /// <summary>
        /// Produtores do Filme
        /// </summary>
        public string producers { get; set; }

        /// <summary>
        /// Ganhador do Ano
        /// </summary>
        public string winner { get; set; }

        public void loadcsvtodatabase()
        {

            // verificar na revisão para criar uma variável de ambiente colocar no README do git para configurar ...
            var filepath = @"csv\movielist.csv";
            int id = 0;
            List<Films> movies = new List<Films>();

            using (var reader = new StreamReader(filepath))
            {       
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    if (id > 0) {                

                        movies.Add(new Films { id = id, title = values[1], year = values[0], studios = values[2], producers = values[3], winner = values[4] });
                       
                    }

                    id++;
                }                
            }
            
            using (FilmsDataContext movie = new FilmsDataContext())
            {
                /*Remove todos os dados da tabela*/
                /*Mantido dessa forma, para forçar o carregamento dos dados caso mude o arquivo csv*/
                movie.Films.RemoveRange(movie.Films);                
                /*Inserir após a leitura*/
                movie.Films.AddRange(movies);
                movie.SaveChanges();
            }
        

        }


    }
}
