using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuliaFasciszewskaLab8PracDom.Models;

namespace JuliaFasciszewskaLab8PracDom.Services
{
    public class PizzeriaService : IPizzeriaService
    {
        private static List<Pizzeria> pizzerias = new List<Pizzeria>()
        {
            new Pizzeria()
            {
                Id=0,
                Nazwa="Ostre niczym Piekło",
                Miasto = "Sosnowiec"
            },
            new Pizzeria()
            {
                Id = 1,
                Nazwa = "Łagodne niczym niebo",
                Miasto = "Wadowice"

            }
        };

        public List<Pizzeria> Get()
        {
            return pizzerias;
        }

        public int Post(Pizzeria pizzeria)
        {
            int id;

            if (pizzerias.Count() == 0)
            {
                id = 0;
            }
            else
            {
                id = pizzerias.Max(x => x.Id) + 1;
            }

            pizzeria.Id = id;
            pizzerias.Add(pizzeria);

            return id;
        }

        public bool Put(int id, Pizzeria pizza)
        {
            var pizzeriaToUpdate = pizzerias.Where(p => p.Id.Equals(id)).SingleOrDefault();
            if (pizzeriaToUpdate == null)
            {
                return false;
            }

            pizzeriaToUpdate.Nazwa = pizza.Nazwa;
            pizzeriaToUpdate.Miasto = pizza.Miasto;
          
            return true;
        }

        public bool Delete(int id)
        {
            var pizzeriaToDelete = pizzerias.Where(p => p.Id.Equals(id)).SingleOrDefault();
            if (pizzeriaToDelete == null)
            {
                return false;
            }

            pizzerias.Remove(pizzeriaToDelete);
            return true;
        }
    }
}
