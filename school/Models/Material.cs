using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school.Models
{
    public class Material
    {
        public Material()
        {
        }

        public Material(int id, int language, int math, int sciences, int biology, int geology, int iT, int sport, int practice)
        {
            Id = id;
            Language = language;
            Math = math;
            Sciences = sciences;
            Biology = biology;
            this.geology = geology;
            IT = iT;
            Sport = sport;
            Practice = practice;
        }

        public int Id { get; set; }
        public int Language { get; set; }
        public int Math { get; set; }
        public int Sciences { get; set; }
        public int Biology { get; set; }
        public int geology { get; set; }
        public int IT { get; set; }
        public int Sport { get; set; }
        public int Practice { get; set; }

    }
}
