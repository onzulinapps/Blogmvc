using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace blogmvc.Models
{
    class BlogInit : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        //aqui se puede introducir datos por ej para añadir datos a la tabla en plan semilla que se crearancuando la DB se inicialice.
        // en este caso cuando haya cambios en el modelo 
        //aqui se puede introducir datos por ej para añadir datos a la tabla en plan semilla que se crearancuando la DB se inicialice.
        // en este caso cuando haya cambios en el modelo 
        protected override void Seed(ApplicationDbContext context)
        {
            //aqui pondre seguramente metodos para crear un usuario Admin o incluso insertar datos en otras tablas
            //base.Seed(context);
            List<Option> Option = new List<Option>
            {
                new Option { OptionName = "siteurl", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "home", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "blogname", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "blogdescription", OptionValue = "", Autoload = "yes" },
                //este campo es el que cualquier usuario puede registrarse
                new Option { OptionName = "users_can_register", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "posts_per_page", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "admin_email", OptionValue = "", Autoload = "yes" },
                /* por si me hace falta añadir mas datos 
                new Option { OptionName = "siteurl", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "siteurl", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "siteurl", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "siteurl", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "siteurl", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "siteurl", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "siteurl", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "siteurl", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "siteurl", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "siteurl", OptionValue = "", Autoload = "yes" },
                new Option { OptionName = "siteurl", OptionValue = "", Autoload = "yes" }
                */
                
            };
            Option.ForEach(s => context.Option.Add(s));
            context.SaveChanges();
        }
}
