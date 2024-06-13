using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Cella
    {
        private int riga, colonna;

        public Cella(int riga, int colonna)
        {
            if (riga >= 0 && colonna >= 0)
            {
                this.riga = riga;
                this.colonna = colonna;
            }
            else
                throw new ArgumentException("Coordinate non valide");
        }

        #region Coordinate
        public int CoordinataX
        {
            get
            {
                return this.colonna;
            }
        }

        public int CooordinataY
        {
            get
            {
                return this.riga;
            }
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return $"Riga: {this.CooordinataY}\nColonna: {this.CoordinataX}";
        }
        #endregion 
    }
}
