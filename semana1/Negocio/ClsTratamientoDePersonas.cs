using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using semana1.Entidades;

namespace semana1.Negocio
{
    public class ClsTratamientoDePersonas
    {
        //Persona per = new Persona();


        //Las siguientes linias de codigo son para crear metodos

        //Los metodos en c# pueden retornar informacion y existen metodo (Void) que no retornan informacion
        public String ObtenerNombrePersona(Persona per){


        //Obligatorio utilizar la palabra return cuando se trata de un metodo que devuelve informacion
            return $"Tu te llamas {per.Nombre}";
        }

        public String MayorDeEdad(Persona per){

            if(per.Edad>=18){
            return "Eres mayor de edad";

            }

            return "Eres menor de edad";
        }





        public int ObtenerEdad (){
        return 9;
        }

        public void NombrePersona(){

        }

    }
}