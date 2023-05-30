namespace DEQUE;
public static class Program
{
    [STAThread]
    static void Main()
    {
        DEQUE pessoas = new DEQUE();
        int p0 = 0;
        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        int prox = 1;
        Random dados = new Random();
        //Criação dos grupos totais de pessoas usando o deque que será acessado de 10 em 10 Células.
        for (int i = 0; i < 150; i++)
        {
            if (dados.Next(0, 2) == 0)
            {
                pessoas.addEnd(i + 100, dados.Next(0, 111), 0, 0, 0, dados.Next(0, 2));
            }
            else
            {
                pessoas.addEnd(i + 100, dados.Next(0, 111), 1, dados.Next(0, 2), dados.Next(0, 2), dados.Next(0, 2));
            }
        }
        for (int i = 1; i <= 15; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                if (pessoas.getFirst().getPrioridade() == 3)
                {
                    pessoas.removeBegginning();
                    p3++;
                }
                else if (pessoas.getFirst().getPrioridade() == 2)
                {
                    pessoas.removeBegginning();
                    p2++;
                }
                else if (pessoas.getFirst().getPrioridade() == 1)
                {
                    pessoas.removeBegginning();
                    p1++;
                }
                else
                {
                    pessoas.removeBegginning();
                    p0++;
                }
            }
            Console.WriteLine("No grupo {0} foram atentidas {1} pessoas, sendo que havia a seguinte proporção:", i, prox);
            Console.WriteLine("{0} Lactantes ou Gestantes\n{1} Deficientes\n{2} Mais de 60 anos\n{3} Sem prioridades\n\n\n\n", p3, p2, p1, p0);
            prox++;
            p0 = 0; 
            p1 = 0;
            p2 = 0;
            p3 = 0;
        }
    }
}