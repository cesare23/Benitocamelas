﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Encuesta
{
    class clSMCiudad
    {
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


        private string _codigoestado;
        public string CodigoEstado
        {
            set
            {
                _codigoestado = value;
            }
            get
            {
                return _codigoestado;
            }
        }


        private string _nombreestado;
        public string NombreEstado
        {
            set
            {
                _nombreestado = value;
            }
            get
            {
                return _nombreestado;
            }
        }


        private string _codigopais;
        public string CodigoPais
        {
            set
            {
                _codigopais = value;
            }
            get
            {
                return _codigopais;
            }
        }


        private string _nombrepais;
        public string NombrePais
        {
            set
            {
                _nombrepais = value;
            }
            get
            {
                return _nombrepais;
            }
        }
    }
}
