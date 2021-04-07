using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    class Articulo
    {
        private int id;
        private string nombre;
        private string categoria;
        private int cantidad;
        private string estado;
        private DateTime fecha;

        public Articulo()
        {

        }
        public Articulo(int id, string nombre, string categoria, int cantidad, string estado, DateTime fecha)
        {
            this.id = id;
            this.nombre = nombre;
            this.categoria = categoria;
            this.cantidad = cantidad;
            this.estado = estado;
            this.fecha = fecha;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Estado { get => estado; set => estado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
