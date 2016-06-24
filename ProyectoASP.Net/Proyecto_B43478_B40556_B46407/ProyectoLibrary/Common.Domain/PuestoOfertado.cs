using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class PuestoOfertado
    {
        private int clavePuesto;
        private String descripcionPuesto;
        private String experienciaRequerida;
        private int abierto;
        private int numeroVacantes;
        private String diasLaborar;
        private String horaEntrada;
        private String horaSalida;
        private float sueldo;
        private String provincia;
        private String ciudad;
        private ClienteEmpleador clienteEmpleador;
        private CategoriaPuesto categoriaPuesto;

        public PuestoOfertado()
        {
            this.clienteEmpleador = new ClienteEmpleador();
            this.categoriaPuesto = new CategoriaPuesto();
        }

        public int ClavePuesto
        {
            get
            {
                return clavePuesto;
            }

            set
            {
                clavePuesto = value;
            }
        }

        public string DescripcionPuesto
        {
            get
            {
                return descripcionPuesto;
            }

            set
            {
                descripcionPuesto = value;
            }
        }

        public string ExperienciaRequerida
        {
            get
            {
                return experienciaRequerida;
            }

            set
            {
                experienciaRequerida = value;
            }
        }

        public int Abierto
        {
            get
            {
                return abierto;
            }

            set
            {
                abierto = value;
            }
        }

        public int NumeroVacantes
        {
            get
            {
                return numeroVacantes;
            }

            set
            {
                numeroVacantes = value;
            }
        }

        public string DiasLaborar
        {
            get
            {
                return diasLaborar;
            }

            set
            {
                diasLaborar = value;
            }
        }

        public string HoraEntrada
        {
            get
            {
                return horaEntrada;
            }

            set
            {
                horaEntrada = value;
            }
        }

        public string HoraSalida
        {
            get
            {
                return horaSalida;
            }

            set
            {
                horaSalida = value;
            }
        }

        public float Sueldo
        {
            get
            {
                return sueldo;
            }

            set
            {
                sueldo = value;
            }
        }

        public string Provincia
        {
            get
            {
                return provincia;
            }

            set
            {
                provincia = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return ciudad;
            }

            set
            {
                ciudad = value;
            }
        }

        public ClienteEmpleador ClienteEmpleador
        {
            get
            {
                return clienteEmpleador;
            }

            set
            {
                clienteEmpleador = value;
            }
        }

        public CategoriaPuesto CategoriaPuesto
        {
            get
            {
                return categoriaPuesto;
            }

            set
            {
                categoriaPuesto = value;
            }
        }
    }
}
