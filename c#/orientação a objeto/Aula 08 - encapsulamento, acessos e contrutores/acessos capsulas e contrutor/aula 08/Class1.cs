using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_08
{
    class Bicicleta
    {
        private int velocidade = 0;
        private int marcha = 0;
        private string cor = "Branco";
        private int tamanho = 1;
        private string material = "aluminio";

        public Bicicleta(int velocidade, int marcha, string cor, int tamanho, string material)
        {
            this.velocidade = velocidade;
            this.cor = cor;
            this.marcha = marcha;
            this.tamanho = tamanho;
            this.material = material;

        }

        public Bicicleta(int velocidade, int marcha)
        {
            if( velocidade > 0)
            {
                if( marcha >=1)
                {
                    this.velocidade = velocidade;
                    this.marcha = marcha;
                }
            }

        }

        public Bicicleta(int tamanho, string cor)
        {
            if( tamanho > 1)
            {
                this.tamanho = tamanho;
                this.cor = cor;
            }
        }

        public int GetVelocidade()
        {
            return velocidade;
        }

        public int GetMarcha()
        {
            return marcha;
        }

        public string GetCor()
        {
            return cor;
        }

        public int GetTamanho()
        {
            return tamanho;
        }

        public string GetMaterial()
        {
            return material;
        }
        

        public void SetVelocidade(int vel)
        {
            velocidade = vel;
        }

        public void SetMarch(int marc)
        {
            marcha = marc;
        }

        public void SetCor(string co)
        {
            cor = co;
        }

        public void SetTamanho(int tam)
        {
            tamanho = tam;
        }

        public void SetMaterial(string mat)
        {
            material = mat;
        }
    }
}
