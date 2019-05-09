using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Viagem
    {
        private double distancia;
        private double tempo;
        public void SetDistancia(double distancia)
        {
            this.distancia = distancia;

        }
        public void SetTempo(double tempo)
        {
            this.tempo = tempo;
        }
        public double GetDistancia()
        {
            return distancia;
        }
        public double GetTempo()
        {
            return tempo;
        }
        public double CalcVelocida()
        {
            return (distancia / tempo);
        }
    }
}
