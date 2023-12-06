using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData
{
    class IssueOfMaterials
    {
        public int Id { get; set; }
        public int MaterialCode { get; set; }
        public int WorkerCode { get; set; }
        public DateTime IssueDate { get; set; }

        public IssueOfMaterials (int id, int materialCode, int workerCode, DateTime issueDate)
        {
            Id = id;
            MaterialCode = materialCode;
            WorkerCode = workerCode;
            IssueDate = issueDate;
        }
    }
}
