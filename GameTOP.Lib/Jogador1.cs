using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 :iJogador
    {
       public string Chuta()
        {
            return "Ronaldo está chutando \n";
        }

        public string Corre()
        {
            return "Ronaldo está correndo \n";
        }

        public string Passe()
        {
            return "Ronaldo está passando \n";
        }
    }
}

    