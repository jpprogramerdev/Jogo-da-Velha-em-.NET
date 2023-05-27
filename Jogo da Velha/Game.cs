
using System.Numerics;

namespace Jogo_da_Velha {
    
    class Game {
        public string turnPlayerString;
        Board board;

        public Game() {
            board = new Board();
        }

        public void turnPlayer(Player player01, Player player02) {
            if (turnPlayerString == player01.getName()) {
                turnPlayerString = player02.getName();
            } else {
                turnPlayerString = player01.getName();
            }
        }

        public void displayBoard() {
            for (int i = 0; i < board.boardGame.Length; i++) {
                for (int j = 0; j < board.boardGame[i].Length; j++) {
                    Console.Write(board.boardGame[i][j]);
                }
                Console.WriteLine();
            }
        }


        public bool getCoordinates(Player player01, Player player02) {
            int x = 0;
            int y = 0;
            if(turnPlayerString == player01.getName()) {
                Console.WriteLine("Digite a linha que deseje jogar");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a coluna que deseje jogar");
                y = int.Parse(Console.ReadLine());

               return board.setCoordinates(x, y, player01.getSymbol());
            } else {
                Console.WriteLine("Digite a linha que deseje jogar");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a coluna que deseje jogar");
                y = int.Parse(Console.ReadLine());

               return board.setCoordinates(x, y, player02.getSymbol());
            }
        }

        public bool gameOver(Player player01, Player player02) {
            /*public char[][] boardGame = new char[][] {
            new char[]{' ','|',' ','|',' '},
            new char[]{'-','|','-','|','-'},
            new char[]{' ','|',' ','|',' '},
            new char[]{'-','|','-','|','-'},
            new char[]{' ','|',' ','|',' '},
        };*/
            // Verificar linhas
            for (int i = 0; i < 5; i += 2) {
                if (board.boardGame[i][0] != ' ' &&
                    board.boardGame[i][0] == board.boardGame[i][2] &&
                    board.boardGame[i][2] == board.boardGame[i][4]) {
                    return true; // Vitória nas linhas
                }
            }

            // Verificar colunas
            for (int j = 0; j < 5; j += 2) {
                if (board.boardGame[0][j] != ' ' &&
                    board.boardGame[0][j] == board.boardGame[2][j] &&
                    board.boardGame[2][j] == board.boardGame[4][j]) {
                    return true; // Vitória nas colunas
                }
            }

            // Verificar diagonais
            if (board.boardGame[0][0] != ' ' &&
                board.boardGame[0][0] == board.boardGame[2][2] &&
                board.boardGame[2][2] == board.boardGame[4][4]) {
                return true; // Vitória na diagonal principal
            }else if (board.boardGame[0][4] != ' ' &&
                board.boardGame[0][4] == board.boardGame[2][2] &&
                board.boardGame[2][2] == board.boardGame[4][0]) {
                return true; // Vitória na diagonal secundária
            }

            //verifica se houve velha
            

            return gameTie();
        }

        public bool gameTie() {
            for (int i = 0; i < board.boardGame.Length; i++) {
                for (int j = 0; j < board.boardGame[i].Length; j++) {
                    if (board.boardGame[i][j] == ' ') {
                        return false;
                    }
                }
            }
            return true; 
        }

        public void clearBoard() {
            for (int i = 0; i < board.boardGame.Length; i+=2) {
                for (int j = 0; j < board.boardGame[i].Length; j+=2) {
                    board.boardGame[i][j] = ' ';
                }
            }
        }

    }
}
