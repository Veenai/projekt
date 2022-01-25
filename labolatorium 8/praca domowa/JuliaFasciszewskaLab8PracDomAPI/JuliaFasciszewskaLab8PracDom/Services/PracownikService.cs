using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuliaFasciszewskaLab8PracDom.Models;

namespace JuliaFasciszewskaLab8PracDom.Services
{
    public class PracownikService : IPracownikService
    {
        private static List<Pracownik> pracowniks = new List<Pracownik>()
        {
            new Pracownik()
            {
                Id=0,
                Imie="Anna",
                Nazwisko = "Ostra",
                Stanowisko = "Menadżer",
                IdPizzeri = 0
            },
            new Pracownik()
            {
                Id = 1,
                Imie = "Paweł",
                Nazwisko = "Salami",
                Stanowisko = "Kucharz",
                IdPizzeri = 0

            },
            new Pracownik()
            {
                Id = 2,
                Imie = "Adam",
                Nazwisko = "Szynka",
                Stanowisko = "Kelner",
                IdPizzeri = 0

            },
            new Pracownik()
            {
                Id=3,
                Imie="Adam",
                Nazwisko = "Łagodny",
                Stanowisko = "Menadżer",
                IdPizzeri = 1
            },
            new Pracownik()
            {
                Id = 4,
                Imie = "Paulina",
                Nazwisko = "Pomidor",
                Stanowisko = "Kucharka",
                IdPizzeri = 1

            },
            new Pracownik()
            {
                Id = 5,
                Imie = "Agnieszka",
                Nazwisko = "Mozzarella",
                Stanowisko = "Kelnerka",
                IdPizzeri = 1

            }

        };

        public List<Pracownik> Get()
        {
            return pracowniks;
        }

        public int Post(Pracownik pracownik)
        {
            int id;

            if (pracowniks.Count() == 0)
            {
                id = 0;
            }
            else
            {
                id = pracowniks.Max(x => x.Id) + 1;
            }

            pracownik.Id = id;
            pracowniks.Add(pracownik);
            return id;
        }

        public bool Put(int id, Pracownik pizza)
        {
            var pracownikToUpdate = pracowniks.Where(p => p.Id.Equals(id)).SingleOrDefault();
            if (pracownikToUpdate == null)
            {
                return false;
            }

            pracownikToUpdate.Imie = pizza.Stanowisko;
            pracownikToUpdate.Nazwisko = pizza.Nazwisko;
            pracownikToUpdate.Stanowisko = pizza.Stanowisko;
            pracownikToUpdate.IdPizzeri = pizza.IdPizzeri;

            return true;
        }

        public bool Delete(int id)
        {
            var pracownikToDelete = pracowniks.Where(p => p.Id.Equals(id)).SingleOrDefault();
            if (pracownikToDelete == null)
            {
                return false;
            }

            pracowniks.Remove(pracownikToDelete);
            return true;
        }
    }
}
