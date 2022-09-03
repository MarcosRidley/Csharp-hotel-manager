
namespace HotelManager {
    
    class Inquilino {

        public string Nome { get; set; }
        public string Email { get; set; }

        public int Quarto { get; set; }

        public Inquilino(string nome, string email, int quarto) {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString() {
            return "Quarto " + Quarto + ": " + Nome + ", " + Email;
        }
    }

    class Program {
        static void Main() {
            int occupants = int.Parse(Console.ReadLine());
            Inquilino[] inquilinos = new Inquilino[10];

            for (int i = 0; i < occupants; i++) {
                string name = Console.ReadLine();
                string email = Console.ReadLine();
                int quarto = int.Parse(Console.ReadLine());
                inquilinos[quarto] = new Inquilino(name ?? "nome não informado", email ?? "email não informado", quarto);
            }

            Console.WriteLine("Quartos ocupados:");
            for(int i = 0; i < occupants; i++) {
                Console.WriteLine(inquilinos[i]);
            }
        }
    }
}