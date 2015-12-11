using System.Collections.Generic;
using MvpWinformsApp.Vistas.Vistas.Modelo;

namespace MvpWinformsApp.Modelo
{
    interface IRepositorioDePersonal
    {
        IEnumerable<PersonaResumida> ObtenerPersonas();

        PersonaEnDetalle ObtenerPersona(string dni);

        IEnumerable<Inasistencia> ObtenerInasistencias(string dni);
    }
}
