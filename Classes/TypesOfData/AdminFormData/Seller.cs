using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.DirectorForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;

namespace Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData
{
    class Seller
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }

    }
}
