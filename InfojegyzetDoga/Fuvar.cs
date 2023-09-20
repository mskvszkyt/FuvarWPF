using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfojegyzetDoga
{
    internal class Fuvar
    {
        int id;
        DateTime indulasIdopontja;
        int idotartam;
        float tavolsag;
        float viteldij;
        float borravalo;
        string fizetesiMod;

        public Fuvar(int id, DateTime indulasIdopontja, int idotartam, float tavolsag, float viteldij, float borravalo, string fizetesiMod)
        {
            this.id = id;
            this.indulasIdopontja = indulasIdopontja;
            this.idotartam = idotartam;
            this.tavolsag = tavolsag;
            this.viteldij = viteldij;
            this.borravalo = borravalo;
            this.fizetesiMod = fizetesiMod;
        }

        public int Id { get => id; }
        public DateTime IndulasIdopontja { get => indulasIdopontja; }
        public int Idotartam { get => idotartam; }
        public float Tavolsag { get => tavolsag; }
        public float Viteldij { get => viteldij; }
        public float Borravalo { get => borravalo; }
        public string FizetesiMod { get => fizetesiMod; }
    }
}
