using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TattooAppAdry
{
    class Vendedor

    {
        private int id;
        private string nombre;
        private string apellidos;
        private string DNI;
        private string disponibilidad;
        private Image imagen_vendedor;
        private bool finesDeSemana;
        private bool festivos;
        private bool vacaciones;

        /// <summary>
        /// Creo el constructor por Defecto
        /// </summary>
        public Vendedor()
        {
            id = 0;
            nombre = null;
            apellidos = null;
            DNI = null;
            disponibilidad = null;
            imagen_vendedor = null;
            finesDeSemana = false;
            festivos = false;
            vacaciones = false;

        }
        /// <summary>
        /// constructor de la clase vendedor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="DNI"></param>
        /// <param name="disponibilidad"></param>
        /// <param name="imagen_vendedor"></param>
        /// <param name="finesDeSemana"></param>
        /// <param name="festivos"></param>
        /// <param name="vacaciones"></param>
        public Vendedor(int id, string nombre, string apellidos, string DNI,  string disponibilidad, Image imagen_vendedor, bool finesDeSemana, bool festivos, bool vacaciones)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.DNI = DNI;
            this.disponibilidad = disponibilidad;
            this.imagen_vendedor = imagen_vendedor;
            this.finesDeSemana = finesDeSemana;
            this.festivos = festivos;
            this.vacaciones = vacaciones;
        }
        /// <summary>
        /// metodo para asignar el nombre del vendedor
        /// </summary>
        /// <param name="nombre">el nombre del vendedor</param>
        public void asignarNombre(string nombre)
        {
            this.nombre = nombre;
        }
        /// <summary>
        /// metodo que devuelve el nombre del vendedor
        /// </summary>
        /// <returns>Devuelve el nombre del vendedor</returns>
        public string obtenerNombre()
        {
            return this.nombre;
        }
        /// <summary>
        /// metodo que asigna los apellidos del vendedor
        /// </summary>
        /// <param name="apellidos">apellidos del vendedor</param>
        public void asignarApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }
        /// <summary>
        /// metodo que devuelve los apellidos del vendedor
        /// </summary>
        /// <returns>apellidos del vendedor</returns>
        public string obtenerApellidos()
        {
            return this.apellidos;
        }
        /// <summary>
        /// metodo que asigna el DNI del vendedor
        /// </summary>
        /// <param name="DNI">DNI del vendedor</param>
        public void asignarDNI(string DNI)
        {
            this.DNI = DNI;
        }
        /// <summary>
        /// metodo que devuelve el DNI del vendedor
        /// </summary>
        /// <returns></returns>
        public string obtenerDNI()
        {
            return this.DNI;
        }
        /// <summary>
        /// metodo para asignar disponibilidad
        /// </summary>
        /// <param name="disponibilidad"></param>
        public void asignarDisponibilidad(string disponibilidad)
        {
            this.disponibilidad = disponibilidad;
        }
        /// <summary>
        /// metodo para obtener disponibilidad
        /// </summary>
        /// <returns></returns>
        public string obtenerDisponibilidad()
        {
            return this.disponibilidad;
        }

        /// <summary>
        /// metodo para asignar la imagen del vendedor
        /// </summary>
        /// <param name="imagen_vendedor">imagen del vendedor</param>
        public void asignarImagen(Image imagen_vendedor)
        {
            this.imagen_vendedor = imagen_vendedor;
        }
        /// <summary>
        /// metodo para obtener la imagen del vendedor
        /// </summary>
        /// <returns>imagen del vendedor</returns>
        public Image obtenerImagen()
        {
            return this.imagen_vendedor;
        }
        /// <summary>
        /// metodo para asignar los fines de semana
        /// </summary>
        /// <param name="finesDeSemana"></param>
        public void asignarFinesDeSemana(bool finesDeSemana)
        {
            this.finesDeSemana = finesDeSemana;
        }
        /// <summary>
        /// metodo para obtener los fines de semana
        /// </summary>
        /// <returns></returns>
        public bool obtenerFinesDeSemana()
        {
            return this.finesDeSemana;
        }
        /// <summary>
        /// metodo para asignar los festivos
        /// </summary>
        /// <param name="festivos"></param>
        public void asignarFestivos(bool festivos)
        {
            this.festivos = festivos;
        }
        /// <summary>
        /// metodo para obtener los festivos
        /// </summary>
        /// <returns></returns>
        public bool obtenerFestivos()
        {
            return this.festivos;
        }
        /// <summary>
        /// metodo para asignar las vacaciones del vendedor
        /// </summary>
        /// <param name="vacaciones"></param>
        public void asignarVacaciones(bool vacaciones)
        {
            this.vacaciones = vacaciones;
        }
        /// <summary>
        /// metodo para obtener las vacaciones del vendedor
        /// </summary>
        /// <returns></returns>
        public bool obtenerVacaciones()
        {
            return this.vacaciones;
        }
        /// <summary>
        /// metodo para obtener los datos del vendedor
        /// </summary>
        /// <returns>devuelve los atributos que le metiesemos del vendedor</returns>
        public string obtenerDatosVendedor()
        {
            string infoVendedor =  this.nombre + "" + this.apellidos + "" + this.DNI + "" + this.disponibilidad; ;
            return infoVendedor;
        }










    }
}
