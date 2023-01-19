using DEINT_MVVMDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_MVVMDemo.MVVM.ViewModels
{
    public class PersonasViewModel
    {
        public List<Persona> listaPersonas { get; set; }

        public PersonasViewModel()
        {
            listaPersonas = new List<Persona> {
                new Persona {
                    nombre = "Pablo Miguel del Castillo Barba",
                    edad = 2
                },
                new Persona {
                    nombre = "Marta Marical Velázquez",
                    edad = 5
                },
                new Persona {
                    nombre = "Manuel Jesús Guerrero Merino",
                    edad = 3
                },
                new Persona {
                    nombre = "Manuel Jesús Curtido Rosado",
                    edad = 20
                }
            };
        }
    }
}
