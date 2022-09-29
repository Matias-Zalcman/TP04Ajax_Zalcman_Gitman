using System;
using System.Collections.Generic;

namespace TP04Ajax_Zalcman_Gitman.Models
{
    public static class Info
    {
        private static List<Pais> _listaPaises = new List<Pais>();
    
        private static void InicializarLista()
        {
            Pais argentina = new Pais("Argentina","argentina.png",45380000,new DateTime(1816,7,9),"Puente de la mujer, Cabildo, Casa rosada, Obelisco","argentina.mp3");
            _listaPaises.Add(argentina);
            Pais eeuu = new Pais("Estados Unidos","eeuu.png",329500000,new DateTime(1776,7,4),"Empire State, White House, Hollywood sign, Golden Gate Bridge","eeuu.mp3");
            _listaPaises.Add(eeuu);
            Pais israel = new Pais("Israel","israel.png",9217000,new DateTime(1948,5,14),"Kotel Haamaravi, Masada, Bahá'Í","/israel.mp3");
            _listaPaises.Add(israel);
            Pais brasil = new Pais("Brasil","brasil.png",212600000,new DateTime(1822,9,7),"Cristo Redentor, Pan de Azucar, Playa de Copacabana, Museo de Arte de San Pablo","brasil.mp3");
            _listaPaises.Add(brasil);
            Pais mexico = new Pais("México","mexico.png",128900000,new DateTime(1821,9,27),"Chichenizta, Zona arquelogica de Tulum, Palacio de Bellas Artes, Parque Xel-Ha","mexico.mp3");
            _listaPaises.Add(mexico);
            Pais colombia = new Pais("Colombia","colombia.png",50880000,new DateTime(1810,7,20),"Minas de sal de Nemocón, Catedral de Sal, Parque nacional natural Tayrona, Castillo de San Felipe de Barajas","colombia.mp3");
            _listaPaises.Add(colombia);
        }

        public static List<Pais> ListarPaises()
        {
            if(_listaPaises.Count == 0)
            {
                Info.InicializarLista();
            }
            return _listaPaises;
        }

        public static void AgregarPais(Pais nuevoPais)
        {
            _listaPaises.Add(nuevoPais);
        }

        public static Pais BuscarPais(string nombrePais)
        {
            Pais objetoPais = null;
            foreach(Pais pais in _listaPaises)
            {
                if(pais.Nombre == nombrePais)
                {
                    objetoPais = pais;
                }
            }
            return objetoPais;
        }
    }
}
