using Jogo_da_Velha;
using System;

namespace Jogo_Da_Velha {
    class Principal {
        static void Main(string[] args) {
            Board board = new Board();
            string name;
            Player player01;
            Player player02;
            string confirmacao;

            Console.WriteLine("Jogo da Velha");
            
            //setando informações dos jogadores
            Console.WriteLine("Digite o nome do primeiro Jogador");
            name = Console.ReadLine();
            player01 = new Player(name, 'X');

             Console.WriteLine("Digite o nome do segundo Jogador");
             name = Console.ReadLine();
             player02 = new Player(name, 'O');

                //inicio do jogo
                Game game = new Game();
            do {
                Console.Clear();
                game.turnPlayerString = player02.getName();
                do {
                    game.turnPlayer(player01, player02);
                    do {
                        Console.Clear();
                        Console.WriteLine("Vez de " + game.turnPlayerString);
                        game.displayBoard();
                    } while (!game.getCoordinates(player01, player02));
                } while (!game.gameOver(player01, player02));

                Console.Clear();
                Console.WriteLine(game.gameTie() ? "Empate" : "Vencedor: " + game.turnPlayerString);
                game.displayBoard();

                Console.WriteLine("\nDeseja jogar novamente?");
                confirmacao = Console.ReadLine().ToUpper();
                game.clearBoard();
            } while (confirmacao == "SIM");
        }
    }
}
