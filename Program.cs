using AtmDemo.services;

namespace AtmDemo
{
    /*
     *  The main Program class.
     *  Instantiates all dependencies and runs the program.   
     */
    /// <summary>
    /// The main <c>Program</c> class.
    /// Instantiates all dependencies and runs the program.
    /// </summary>
    /// <remarks>
    /// <para>Author: Daniel J. Byczynski - 2019</para>
    /// </remarks>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Instantiate Dependencies.
            IDisplayService displayService = new ConsoleDisplayService();
            IInputService inputService = new ConsoleInputService();
            var atmController = new AtmController(displayService, inputService);

            // Start Atm.
            atmController.StartAtm();
        }
    }
}