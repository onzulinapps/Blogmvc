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
    }
}
