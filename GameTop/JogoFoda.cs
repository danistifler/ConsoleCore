using GameTop.Interface;

namespace GameTop
{
    public class JogoFoda
    {
    
        private readonly iJogador _jogadorA;

        private readonly iJogador _jogadorB;

        public JogoFoda(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {

        System.Console.Write(_jogadorA.Corre());
        System.Console.Write(_jogadorA.Chuta());
        System.Console.Write(_jogadorA.Passe());

        System.Console.Write("\n Próximo Jogador \n");

        System.Console.Write(_jogadorB.Corre());
        System.Console.Write(_jogadorB.Chuta());
        System.Console.Write(_jogadorB.Passe());
            
        }
    }
}
