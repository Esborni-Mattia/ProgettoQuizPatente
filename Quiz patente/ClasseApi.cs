using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_patente
{

        public class Argomenti
        {
            public int argomento { get; set; }
            public List<string> contenuti { get; set; }
        }
        
        public class Quiz
        {
            public int argomento { get; set; }
            public int domanda { get; set; }
            public int progressivo { get; set; }
            public string testo { get; set; }
            public string risposta { get; set; }
            public string idImmagine { get; set; }
        }
        //getquizzesbyargomento

        public class Immagini
        {
            public int id { get; set; }
            public string link { get; set; }
            public string immagine { get; set; }
        }
}
