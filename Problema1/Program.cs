/* 
 * Autor: Jhonathan Bermudez
 * Grupo: 283
 * Programa: Ingeniería de Sistemas
 */

internal class Program
{
    private static void Main(string[] args)
    {

        int BasicRate;
        byte PassengerAge;
        int Discount;
        int Increment;
        int Total;

        string PassengerName;
        string CompanyName;
        string Season;
        string TyperOfPassenger;

        bool ValidateInt;
        bool ValidateString;

        Console.WriteLine("Ingrese la tarifa básica: ");
        ValidateInt = int.TryParse(Console.ReadLine(), out BasicRate);

        if (!ValidateInt)
        {
            Console.WriteLine("Recuerde ingresar un valor númerico para la tarifa básica. Intente de nuevo.");
            return;
        }

        Console.WriteLine("Ingrese la edad del pasajero");
        ValidateInt = byte.TryParse(Console.ReadLine(), out PassengerAge);

        if (!ValidateInt)
        {
            Console.WriteLine("Recuerde ingresar un valor númerico para la edad. Intente de nuevo.");
            return;
        }

        if(PassengerAge < 0 || PassengerAge > 119)
        {
            Console.WriteLine("La edad no está dentro del rango valido.");
            return;
        }

        if (PassengerAge < 18)
        {
            Discount = ((int)(BasicRate * 0.5));
            BasicRate -= Discount;
        }


        Console.WriteLine("Ingrese el nombre de la compañia (alas o volar)");
        CompanyName = Console.ReadLine().ToLower();

        if (CompanyName != "alas" && CompanyName != "volar")
        {
            Console.WriteLine("El nombre de la compañia es invalido. Intente nuevamente");
            return;

        }

        Console.WriteLine("Ingrese la temporada (alta o baja)");
        Season = Console.ReadLine().ToLower();

        if ( Season.ToLower() != "alta" && Season.ToLower() != "baja" )
        {
            Console.WriteLine("El nombre de la temporada es invalido. Intente nuevamente");
            return;
        }


        if (CompanyName == "alas" && Season == "alta")
        {
            Increment = (int)(BasicRate * 0.3);
            BasicRate += Increment;
        }
        else if(CompanyName == "volar" && Season == "alta")
        {
            Increment = (int)(BasicRate * 0.2);
            BasicRate += Increment;
        }

        if(PassengerAge >= 60 && CompanyName == "Volar")
        {
            BasicRate += 10000;
        }

        Console.WriteLine("¿El pasajero es Estudiante o Particular?");
        TyperOfPassenger = Console.ReadLine().ToLower();

        if(TyperOfPassenger != "estudiante" && TyperOfPassenger != "particular")
        {
            Console.WriteLine("Tipo de pasajero no valido.");
        }

        if (Season == "baja" && PassengerAge >= 18 && 
            CompanyName == "alas" && TyperOfPassenger == "estudiante")
        {
            Discount = ((int)(BasicRate * 0.1));
            BasicRate -= Discount;
        }

        Console.WriteLine("Ingrese el nombre del pasajero");
        PassengerName = Console.ReadLine();

        Console.WriteLine("Pasajero: " + PassengerName + ".\nTotal a pagar: $" + BasicRate);
    }
}