namespace PP_oppgave_01
{
    internal class Program
    {//Hei, jeg heter Kurt! Jeg er 55 år gammel og jeg har brunt hår
     // Nå er jeg ute på fisketur.
     // Se, jeg kan også klatre høyt i klatreparken!
        static void Main(string[] args)
        {
            Console.WriteLine("Hei, hva heter du?");
            var navn = Console.ReadLine();
            Console.WriteLine("Hvor gammel er du?");
            var alder = Console.ReadLine();
            Console.WriteLine("Hva slags hårfarge har du??");
            var hår = Console.ReadLine();
            Console.WriteLine("Hva slags tur er du på nå?");
            var tur = Console.ReadLine();
            Console.WriteLine("Hva liker du å gjøre?");
            var hobby = Console.ReadLine();
            Console.WriteLine("Hvor liker du å gjøre det?");
            var hvor = Console.ReadLine();
            Console.WriteLine($"Hei, jeg heter {navn}! Jeg er {alder} år gammel og jeg har {hår} hår." +
                              $"\nNå er jeg ute på {tur}." +
                              $"\nSe, jeg kan også {hobby} høyt i {hvor}!");     
        }
    }
}
