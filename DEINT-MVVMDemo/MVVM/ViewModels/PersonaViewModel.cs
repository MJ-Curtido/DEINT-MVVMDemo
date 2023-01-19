using DEINT_MVVMDemo.MVVM.Models;
using Microsoft.Maui.Animations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DEINT_MVVMDemo.MVVM.ViewModels
{
    public class PersonaViewModel
    {
        public Persona persona { get; set; }
        public ICommand clickCommand { get; set; }

        public PersonaViewModel()
        {
            persona = new Persona
            {
                nombre = "Pepe",
                edad = 15,
                casado = "Si"
            };

            clickCommand = new Command(async (s) =>
            {
                //lo que queremos que haga al pulsar el botón
                Button btn = (Button) s;
                await App.Current.MainPage.DisplayAlert("Title", btn.Text.ToString(), "OK");
            });
        }
    }
}
