using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace JuliaFasciszewskaLab8PracDom.Models
{
    public class Pracownik
    {
        public int Id { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public string Stanowisko { get; set; }

        public int IdPizzeri { get; set; }
        //ICollection<Pizzeria> Pizzeria { get; set; };
    }
}
