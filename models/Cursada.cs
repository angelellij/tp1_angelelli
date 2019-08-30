using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_angelelli
{
    class Cursada:Materia
    {
        private int id;
        private int Materia;

        private int legajoProfesorResponsable;
        private int legajoProfesorAdjunto;
        private int legajoProfesorAdjunto2;
        private int legajoProfesorAdjunto3;
        //en el constructor se adjudicaria null por default a todos los adjuntos. (siendo que podria no haberlos)
        private int anio; //YYYY
        private int cuatrimestre; // 1 (marzo a junio) o 2 (agosto a noviembre)
        private int diaDeLaSemana; //siendo 1 el Lunes y 7 el domingo
        private int horarioInicio; //siendo 1800 las 18:00 y 930 las 9:30
        private int horarioFin;

        private int idAula;

        private int estado; // 0 Sin comenzar, 1 En curso, 2 Finalizada

        //setters, getters, constructores y metodos.
    }
}
