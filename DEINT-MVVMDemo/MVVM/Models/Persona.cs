using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_MVVMDemo.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Persona
    {
        public String nombre { get; set; }
        public int edad { get; set; }
        public string casado { get; set; }
    }
}
