

namespace Jogo_da_Velha {
    class Player {
        private string Name;
        private char Symbol;

        public Player(string Name, char Symbol) {
            setName(Name);
            setSymbol(Symbol);
        }

        private void setName(String Name) {
            this.Name = Name;
        }

        public string getName() {
            return Name;
        }

        private void setSymbol(char Symbol) {
            this.Symbol = Symbol;
        }

        public char getSymbol() {
            return Symbol;
        }
    }
}
