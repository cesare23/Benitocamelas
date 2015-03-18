using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Encuesta
{
    class clTransito
    {
        private string _nombretransito;
        public string NombreTransito
        {
            set
            {
                _nombretransito = value;
            }
            get
            {
                return _nombretransito;
            }
        }
        
        private string _codigotransito;
        public string CodigoTransito
        {
            set
            {
                _codigotransito = value;
            }
            get
            {
                return _codigotransito;
            }
        }

        public int tarifatransito
        {
            get
            {
                if (_nombretransito == "Caribe" || _nombretransito == "Municipal")
                {
                    return 125000;
                }
                if (_nombretransito == "Bello" || _nombretransito == "Itagui" || _nombretransito == "Envigado")
                {
                    return 150000;
                }
                else
                {
                    return 80000;
                }
            }
        }

        private  string _nombreciudad;
        public string NombreCiudad
        {
            set
            {
                _nombreciudad = value;
            }
            get
            {
                return _nombreciudad;
            }
        }
        
        private string _codigociudad;
        public string CodigoCiudad
        {
            set
            {
                _codigociudad = value;
            }
            get
            {
                return _codigociudad;
            }
        }
    }
}
