using Ninject;
using Ninject.Modules;
using ShopApp.BLL.Infastructure.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsHomeWork_3.Forms;
using WindowsFormsHomeWork_3.Util;

namespace WindowsFormsHomeWork_3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //внедрение зависимостей
            NinjectModule databaseModule = new DatabaseModule("DefaultConnection");
            NinjectModule servicesModule = new ServicesModule();

            DIRoot.Wire(databaseModule);
            DIRoot.Bind(servicesModule);


            Application.Run(DIRoot.Resolve<ShopForm>());
        }
    }
}
