﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityMessage
    {
        private int gonderen;
        private int alici;
        private string baslik;
        private string icerik;

        public int Gonderen { get => gonderen; set => gonderen = value; }
        public int Alici { get => alici; set => alici = value; }
        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        
    }
}
