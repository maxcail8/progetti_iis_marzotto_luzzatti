using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class GameOfLife
    {
        private bool[,] mondo;
        private int righe, colonne;
        private List<Cella> listaCelleVive = new List<Cella>();

        public GameOfLife(int righe, int colonne)
        {
            if (righe >= 1 && colonne >=1)
            {
                this.mondo = new bool[righe, colonne];
                this.righe = righe;
                this.colonne = colonne;
            }
            else
                throw new ArgumentException("Dimensioni non valide");
            Azzera();
        }

        #region Azzera
        public void Azzera()
        {
            for (int i = 0; i < this.righe; i++)
                for (int j = 0; j < this.colonne; j++)
                    mondo[i, j] = false;
        }
        #endregion

        #region ValoreCella
        public bool this[int riga, int colonna]
        {
            get
            {
                if (riga >= 0 && colonna >= 0)
                    return mondo[riga, colonna];
                else
                    return false;
            }
        }
        #endregion 

        #region Vivi
        public int Vivi
        {
            get
            {
                int con = 0;
                for (int i = 0; i < this.righe; i++)
                    for (int j = 0; j < this.colonne; j++)
                        if (mondo[i, j] == true)
                            con++;
                return con;
            }
        }
        #endregion

        #region Vicini
        public int Vicini(int riga, int colonna)
        {
            //controllo in quale posizione la cella con coordinate passate si trova, gestendo i casi in cui si trova sui bordi
            int con = 0;
            if (riga >= 0 && colonna >= 0)
            {
                if (riga != 0 && riga != righe - 1)
                {
                    //non si trova su nessun bordo
                    if (colonna != 0 && colonna != colonne - 1)
                    {
                        if (mondo[riga, colonna + 1])
                            con++;
                        if (mondo[riga, colonna - 1])
                            con++;
                        if (mondo[riga + 1, colonna])
                            con++;
                        if (mondo[riga - 1, colonna])
                            con++;
                        if (mondo[riga + 1, colonna + 1])
                            con++;
                        if (mondo[riga - 1, colonna - 1])
                            con++;
                        if (mondo[riga + 1, colonna - 1])
                            con++;
                        if (mondo[riga - 1, colonna + 1])
                            con++;
                    }
                    else
                    //si trova sul bordo sinistro
                    if (colonna == 0)
                    {
                        if (mondo[riga, colonna + 1])
                            con++;
                        if (mondo[riga + 1, colonna])
                            con++;
                        if (mondo[riga - 1, colonna])
                            con++;
                        if (mondo[riga + 1, colonna + 1])
                            con++;
                        if (mondo[riga - 1, colonna + 1])
                            con++;
                    }
                    //si trova sul bordo destro
                    if (colonna == colonne - 1)
                    {
                        if (mondo[riga, colonna - 1])
                            con++;
                        if (mondo[riga + 1, colonna])
                            con++;
                        if (mondo[riga - 1, colonna])
                            con++;
                        if (mondo[riga - 1, colonna - 1])
                            con++;
                        if (mondo[riga + 1, colonna - 1])
                            con++;
                    }
                }
                if (colonna != 0 && colonna != colonne - 1)
                {
                    //si trova sul bordo alto
                    if (riga == 0)
                    {
                        if (mondo[riga, colonna + 1])
                            con++;
                        if (mondo[riga, colonna - 1])
                            con++;
                        if (mondo[riga + 1, colonna])
                            con++;
                        if (mondo[riga + 1, colonna + 1])
                            con++;
                        if (mondo[riga + 1, colonna - 1])
                            con++;
                    }
                    //si trova sul bordo basso
                    if (riga == righe - 1)
                    {
                        if (mondo[riga, colonna + 1])
                            con++;
                        if (mondo[riga, colonna - 1])
                            con++;
                        if (mondo[riga - 1, colonna])
                            con++;
                        if (mondo[riga - 1, colonna - 1])
                            con++;
                        if (mondo[riga - 1, colonna + 1])
                            con++;
                    }
                }
                else
                //si trova in prima posizione
                if (riga == 0 && colonna == 0)
                {
                    if (mondo[riga, colonna + 1])
                        con++;
                    if (mondo[riga + 1, colonna])
                        con++;
                    if (mondo[riga + 1, colonna + 1])
                        con++;
                }
                //si trova in ultima posizione
                if (riga == righe - 1 && colonna == colonne - 1)
                {
                    if (mondo[riga, colonna - 1])
                        con++;
                    if (mondo[riga - 1, colonna])
                        con++;
                    if (mondo[riga - 1, colonna - 1])
                        con++;
                }
            }
            else throw new ArgumentException("Parametri non validi");
            return con;
        }
        #endregion

        #region AggiungiCella
        public void AggiungiCella(int riga, int colonna)
        {
            if (riga >= 0 && colonna >= 0)
            {
                if (!mondo[riga, colonna])
                    mondo[riga, colonna] = true;
                else
                if (mondo[riga, colonna])
                    mondo[riga, colonna] = false;
            }
            else
                throw new ArgumentException("Parametri non validi");
        }

        public void AggiungiCella(Cella c)
        {
            AggiungiCella(c.CooordinataY, c.CoordinataX);
        }
        #endregion

        #region Imposta
        public void Imposta(List<Cella> lista)
        {
            Azzera();
            for (int i = 0; i < lista.Count; i++)
                AggiungiCella(lista[i]);
        }
        #endregion

        #region Prossimo
        public void Prossimo()
        {
            int con;
            listaCelleVive.Clear();
            for(int i=0; i<righe;i++)
                for(int j=0; j < colonne; j++)
                {
                    if (!mondo[i, j])
                    {
                        //comincia a vivere con 3 vicini vivi
                        con = Vicini(i, j);
                        if (con == 3)
                        {
                            Cella c = new Cella(i, j);
                            listaCelleVive.Add(c);
                        }
                    }
                    if (mondo[i, j])
                    {
                        //resta viva solo con 2 o 3 vicini vivi
                        con = Vicini(i, j);
                        if (con >= 2 && con <= 3)
                        {
                            Cella c = new Cella(i, j);
                            listaCelleVive.Add(c);
                        }
                    }
                }

            Imposta(listaCelleVive);
        }
        #endregion Prossimo
    }
}
