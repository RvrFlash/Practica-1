using System;

namespace Practica_1
{
    internal class DispositivoElectronicoPortatil
    {
        #region Atributos
        private string marca;
        private string modelo;
        private int año;
        private byte carga;
        #endregion

        #region Propiedades
        public string Marca 
        {
            get => marca;
            set => marca = value == "" ? "Patito" : value;
        }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Año { get => año; set => año = value; }
        public byte Carga
        { 
            get => carga; 
            set => carga = value < 0 ? (byte)0 : value; 
        }
        #endregion

        #region Métodos
        private void Encender(byte carga)
        {

        }
        private void Apagar()
        {

        }
        private void MostrarBatería(byte carga)
        {

        }
        private void CargarDispositivo(byte carga)
        {

        }
        private void MostrarInformacion()
        {

        }
        private void Actualizar(int año)
        {

        }

        #endregion

        #region Constructor
        public DispositivoElectronicoPortatil(string marca, int año)
        {
            Marca = marca;
            Año = año;
        }

        public DispositivoElectronicoPortatil(byte carga)
        {
            Carga = carga;
        }
        #endregion
    }
}
