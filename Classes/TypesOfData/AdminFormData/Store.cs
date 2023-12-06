using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData
{
    class Store
    {
        public int id { get; set; }
        public string address { get; set; }
        public int directorCode { get; set; }
        public int phone { get; set; }
        public List<Seller> sellers { get; set; }
        public int warehouseWorkerCode { get; set; }
        public Store(int id, string address, int directorCode, int phone, List<Seller> sellers, int warehouseWorkerCode)
        {
            this.id = id;
            this.address = address;
            this.directorCode = directorCode;
            this.phone = phone;
            this.sellers = sellers;
            this.warehouseWorkerCode = warehouseWorkerCode;
        }
        public string GetSellers()
        {
            string total = "";
            foreach(var seller in sellers)
            {
                total += total + seller.id + " " + seller.surname + " " + seller.name + " " + seller.patronymic + "\n";
            }
            return total;
        }
    }
}
