namespace PrimeiroPoo
{
    public class Personagem
    {
        
        public string nome;
        public int idade;
        public float vida = 100.0f;
        public double dinheiro = 0.987;
        public bool pulando = false;      

        public string Correr(float velocidade)
        {
            return "A velocidade do personagem é "+velocidade+" km/h";
        }

        public float Atacar(float forca)
        {
            float forcaAtaque = 0;

            if(pulando == false){
                forcaAtaque = forca;
            }

            return forcaAtaque;
        }


    }
}