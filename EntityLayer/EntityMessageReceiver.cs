﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityMessageReceiver
    {       
        private string gonderen;    
        private string baslik;
        private string icerik;
   
        public string Gonderen { get => gonderen; set => gonderen = value; }      
        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
    }
}
