﻿using System;
using System.Collections.Generic;

namespace Armalo.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Evento = new HashSet<Evento>();
            Publicidad = new HashSet<Publicidad>();
            Staff = new HashSet<Staff>();
        }

        public int IdUsr { get; set; }
        public string Resume { get; set; }
        public int TipoUsr { get; set; }
        public string NombreUsr { get; set; }
        public string Pass { get; set; }
        public string Correo { get; set; }
        
        public ICollection<Evento> Evento { get; set; }
        public ICollection<Publicidad> Publicidad { get; set; }
        public ICollection<Staff> Staff { get; set; }
    }
}
