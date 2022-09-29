using System;

namespace TP04Ajax_Zalcman_Gitman.Models
{
    public class Pais
    {
        private string _Nombre;
        private string _ImgBandera;
        private int _Poblacion;
        private DateTime _FechaIndependencia;
        private string _AtractivosTuristicos;
        private string _Himno;

        public Pais(string nombre, string imgBandera, int poblacion, DateTime fechaIndependencia, string atractivosTuristicos, string himno)
        {
            _Nombre = nombre;
            _ImgBandera = imgBandera;
            _Poblacion = poblacion;
            _FechaIndependencia = fechaIndependencia;
            _AtractivosTuristicos = atractivosTuristicos;
            _Himno = himno;
        }

        public string Nombre
        {
            get { return _Nombre; }
        }

        public string ImgBandera
        {
            get { return _ImgBandera; }
        }

        public int Poblacion
        {
            get { return _Poblacion; }
        }

        public DateTime FechaIndependencia
        {
            get { return _FechaIndependencia; }
        }

        public string AtractivosTuristicos
        {
            get { return _AtractivosTuristicos; }
        }
        public string Himno
        {
            get { return _Himno; }
        }
    }
}
