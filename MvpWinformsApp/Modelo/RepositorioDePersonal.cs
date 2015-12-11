using System;
using System.Collections.Generic;
using System.Linq;
using MvpWinformsApp.Vistas.Vistas.Modelo;

namespace MvpWinformsApp.Modelo
{
    //En una aplicación real accederíamos a una base de datos
    class RepositorioDePersonal : IRepositorioDePersonal
    {
        DateTime fechaBase = new DateTime(2015,1,1);

        public IEnumerable<Inasistencia> ObtenerInasistencias(string dni)
        {
            return Enumerable.Range(1, 10).Select(i => new Inasistencia
            {
                Motivo = dni + ": Motivo " + i,
                Desde = fechaBase.AddDays(i*10),
                Hasta = fechaBase.AddDays(i*10 + 5),
            })
            .ToArray();
        }

        public PersonaEnDetalle ObtenerPersona(string dni)
        {
            return new PersonaEnDetalle
            {
                InformacionAdicional = "Info adicional para la persona con DNI " + dni
            };
        }

        public IEnumerable<PersonaResumida> ObtenerPersonas()
        {
            return Enumerable.Range(1, 10).Select(i => new PersonaResumida
            {
                Nombre = "Nombre " + i,
                Apellido = "Apellido " + i,
                Dni = "Dni"+i
            })
            .ToArray();
        }
    }
}
