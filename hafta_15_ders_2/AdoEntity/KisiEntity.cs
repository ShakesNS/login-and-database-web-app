using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoEntity
{
    public class KisiEntity
    {
        private string _Id;
        private string _Ad;
        private string _Soyad;
        private string _TcKimlik;
        private string _Adres;

        public string Id { get => _Id; set => _Id = value; }
        public string Ad { get => _Ad; set => _Ad = value; }
        public string Soyad { get => _Soyad; set => _Soyad = value; }
        public string TcKimlik { get => _TcKimlik; set => _TcKimlik = value; }
        public string Adres { get => _Adres; set => _Adres = value; }
    }
}
