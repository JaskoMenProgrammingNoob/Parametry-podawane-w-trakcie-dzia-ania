class Program
{
    bool sukces;
    
    double a = 0;
    double b = 0;
    double c = 0;
    double delta = 0;
    double x1 = 0;
    double x2 = 0;
    double x0 = 0;
    public void Pobierz_dane()
    {
        do
        {
            try
            {

                Console.WriteLine("Podaj a: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj b: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj c: ");
                c = double.Parse(Console.ReadLine());
                
                sukces = true;


            }
            catch (Exception)
            {
                Console.WriteLine("Wprowadzono nieprawidłowe dane.");
                
                sukces = false;
                return;
                //program ma zaczynac prace od nowa jakby;
            }
        } while (sukces == false);
    } 


         
         
        
            
        
    
    public void Oblicz()
    {



    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Pobierz_dane();
        
    
    }
}