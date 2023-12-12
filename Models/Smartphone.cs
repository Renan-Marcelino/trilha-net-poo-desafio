namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Emei { get; set; }
        public string Modelo { get; set; }
        public int Memoria { get; set; }
        public string NomeApp { get; set; }  // Adicionando propriedade para armazenar o nome do aplicativo

        public Smartphone(string numero, string modelo, string emei, int memoria)
        {
            Numero = numero;
            Emei = emei;  // Corrigindo o nome do parâmetro
            Modelo = modelo;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}