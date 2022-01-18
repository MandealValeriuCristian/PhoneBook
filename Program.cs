using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    static class Program
    {
        
        public class PhoneBookContext : DbContext
        {
            public DbSet<Person> Person { get; set; }

            public PhoneBookContext()
            : base("name=DefaultConnection")
            {
                
            }
        }

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());
        }
    }
}
