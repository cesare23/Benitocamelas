using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Encuesta
{
    class clCiudad
    {
        private string _nombreciudad;
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
