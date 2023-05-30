namespace DEQUE
{
    public class Celula
    {
        Celula proxima;
        Celula anterior;
        int ID;
        int idade;
        int gestante;
        int lactante;
        int sexo;
        int pcd;
        int prioridade;

        public Celula(int ID, int idade, int sexo, int lactante, int gestante, int pcd)
        {
            if (gestante == 1 || lactante == 1)
            {
                prioridade = 3;
            }else if (pcd == 1)
            {
                prioridade = 2;
            }else if (idade > 60)
            {
                prioridade = 1;
            }
            else
            {
                prioridade = 0;
            }
            this.idade = idade;
            this.gestante = gestante;
            this.lactante = lactante;
            this.sexo = sexo;
            this.pcd = pcd;
            this.ID = ID;
            proxima = null;
            anterior = null;
        }
        public Celula(Celula proxima, int ID, int idade, int sexo, int lactante, int gestante, int pcd)
        {
            if (gestante == 1 || lactante == 1)
            {
                prioridade = 3;
            }
            else if (pcd == 1)
            {
                prioridade = 2;
            }
            else if (idade > 60)
            {
                prioridade = 1;
            }
            else
            {
                prioridade = 0;
            }
            this.proxima = proxima;
            this.anterior = null;
            this.idade = idade;
            this.gestante = gestante;
            this.lactante = lactante;
            this.sexo = sexo;
            this.pcd = pcd;
            this.ID = ID;
        }
        public void setProxima(Celula prox)
        {
            proxima = prox;
        }
        public void setAnterior(Celula ant)
        {
            anterior = ant;
        }
        public Celula getProxima()
        {
            return proxima;
        }
        public Celula getAnterior()
        {
            return anterior;
        }
        public int getID()
        {
            return ID;
        }
        public int getIdade()
        {
            return idade;
        }
        public int getSexo()
        {
            return sexo;
        }
        public int getGestante()
        {
            return gestante;
        }
        public int getLactante()
        {
            return lactante;
        }
        public int getPcd()
        {
            return pcd;
        }
        public int getPrioridade()
        {
            return prioridade;
        }
        public void setPrioridade(int prioridade)
        {
            this.prioridade = prioridade;
        }
    }
}