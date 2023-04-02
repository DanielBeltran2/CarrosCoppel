using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosCoppel.datos
{


    internal class carros
    {
        string carId;
        string carMod;
        string carAño;
        string carMarcaID;
        string tipID;
        string carColorId;
        public carros(string carId, string carMod, string carAño, string carMarcaID, string tipID, string carColorId)
        {
            this.carId = carId;
            this.carMod = carMod;
            this.carAño = carAño;
            this.carMarcaID = carMarcaID;
            this.tipID = tipID;
            this.carColorId = carColorId;
        }
        public string CarId
        {
            get => carId; set => carId = value;
        }
        public string CarMod
        {
            get => carMod; set => carMod = value;
        }
        public string Caraño
        {
            get => carAño; set => carAño = value;
        }
        public string CarMarcaID
        {
            get => carMarcaID; set => carMarcaID = value;
        }
        public string TipID
        {
            get => tipID; set => tipID = value;
        }
        public string CarColorId
        {
            get => carColorId; set => carColorId = value;
        }

    }
}
