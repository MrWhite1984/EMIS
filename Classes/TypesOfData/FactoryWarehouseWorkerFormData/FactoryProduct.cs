using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData
{
    class FactoryProduct
    {
        public int ID { get; set; }
        public int ProductCode { get; set; }
        public int AmountOfProduct { get; set; }
        public FactoryProduct (int id, int productCode, int amountOfProduct)
        {
            ID = id;
            ProductCode = productCode;
            AmountOfProduct = amountOfProduct;
        }


    }
}
