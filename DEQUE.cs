namespace DEQUE
{
    public class DEQUE
    {
        Celula first;
        Celula last;
        Celula head;
        int qtdElement;
        public DEQUE()
        {
            qtdElement = 0;
            head = new Celula(-1, 0, 0, 0, 0, 0); 
        }
        public void addBeginning(int ID, int idade, int sexo, int lactante, int gestante, int pcd)
        {
            if (qtdElement == 0)
            {
                Celula nova = new Celula(ID, idade, sexo, lactante, gestante, pcd);
                first = nova;
                last = nova;
                head.setProxima(first);
                qtdElement++;
            }
            else
            {
                Celula nova = new Celula(first, ID, idade, sexo, lactante, gestante, pcd);
                first.setAnterior(nova);
                first = nova;
                first.setAnterior(last);
                last.setProxima(first);
                head.setProxima(first);
                qtdElement++;
            }
        }
        public void addEnd(int ID, int idade, int sexo, int lactante, int gestante, int pcd)
        {
            if (qtdElement == 0)
            {
                addBeginning(ID, idade, sexo, lactante, gestante, pcd);
            }
            else
            {
                Celula nova = new Celula(ID, idade, sexo, lactante, gestante, pcd);
                last.setProxima(nova);
                nova.setAnterior(last);
                nova.setProxima(first);
                last = nova;
                first.setAnterior(last);
                qtdElement++;
            }
        }
        public void removeBegginning()
        {
            if (qtdElement == 0)
            {
                Console.WriteLine("Deque vazio!!!");
            }
            else
            {
                first = first.getProxima();
                head.setProxima(first);
                last.setProxima(first);
                first.setAnterior(last);
                qtdElement--;
            }
        }
        public void removeEnd()
        {
            if (qtdElement == 0)
            {
                Console.WriteLine("Deque vazio!!!");
            }
            else
            {
                last = last.getAnterior();
                first.setAnterior(last);
                last.setProxima(first);
                qtdElement--;
            }
        }
        public int lenght()
        {
            return qtdElement;
        }
        public Celula getFirst()
        {
                return first;
        }
        public Celula getLast()
        {
            return last;
        }
        public void Reiniciar()
        {
            head.setProxima(null);
        }
    }
}