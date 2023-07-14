using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoN1
{
    internal class Persona
    {
        private int DineroAhorrado;
        private int FondoPension;
        private string Nombres;
        private string Apellidos;

        public Persona(string Nombres, string Apellidos)
        {

            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
        }
        public string MedirInteligencia(int num)
        {
            if (num < 0)
                return "Parametro no valido";
            else if (num >= 0 && num <= 4)
                return "Capacidad cognitiva nula";
            else if (num >= 5 && num <= 19)
                return "Discapacidad cognitiva profunda";
            else if (num >= 20 && num <= 34)
                return "Discapacidad cognitiva grave";
            else if (num >= 35 && num <= 54)
                return "Discapacidad cognitiva moderada";
            else if (num >= 55 && num <= 69)
                return "Discapacidad cognitiva leve";
            else if (num >= 70 && num <= 84)
                return "Retraso Mental";
            else if (num >= 85 && num <= 99)
                return "Debajo de la media";
            else if (num  == 100)
                return "Inteligencia Media";
            else if (num >= 101 && num <= 114)
                return "Encima de la media";
            else if (num >= 115 && num <= 129)
                return "Inteligencia brillante";
            else if (num >= 130 && num <= 139)
                return "Superdotacion intelectual";
            else if (num >= 140 && num <= 154)
                return "Genialidad intelectual";
            else if (num >= 155 && num <= 174)
                return "Altas capacidades intelectuales";
            else if (num >= 175 && num <= 184)
                return "Inteligencia excepcional";
            else if (num >= 185 && num <= 201)
                return "Inteligencia profunda";
            else
                return "Inteligencia Mayor";
        }
        public int CalcularRiqueza()
        {
            return getDineroAhorrado() + getFondoPension();
        }
        public string getNombreCompleto()
        {
            return Nombres + " " + Apellidos;
        }
        public int getDineroAhorrado()
        {
            return DineroAhorrado;
        }
        public Boolean setDineroAhorrado(int DineroAhorrado)
        {
            if (DineroAhorrado >= 0)
            {
                this.DineroAhorrado = DineroAhorrado;
                return true;
            } else
                return false;
        }
        public int getFondoPension()
        {
            return FondoPension;
        }
        public Boolean setFondoPension(int FondoPension)
        {

            if (FondoPension >= 0)
            {
                this.FondoPension = FondoPension;
                return true;
            }
            else
                return false;
        }
        public string getNombres()
        {
            return Nombres;
        }
        public string getApellidos()
        {
            return Apellidos;
        }
    }
}
