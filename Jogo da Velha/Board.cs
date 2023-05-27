namespace Jogo_da_Velha {
    class Board {
        public char[][] boardGame = new char[][] {
            new char[]{' ','|',' ','|',' '},
            new char[]{'-','|','-','|','-'},
            new char[]{' ','|',' ','|',' '},
            new char[]{'-','|','-','|','-'},
            new char[]{' ','|',' ','|',' '},
        };

      

        public bool setCoordinates(int x, int y, char playerSymbol) {
            switch (x) {
                case 1: x -= 1; break;
                case 2: break;
                case 3: x += 1; break;
                default: return false;
            }
            switch (y) {
                case 1: y -= 1; break;
                case 2: break;
                case 3: y += 1; break;
                default: return false;
            }

            if (playerSymbol == 'X' && boardGame[x][y] == ' ') {
                boardGame[x][y] = 'X';
                return true;
            } else if(playerSymbol == 'O' && boardGame[x][y] == ' ') {
                boardGame[x][y] = 'O';
                return true;
            }else {
                return false;
            }
        }    
    }
}