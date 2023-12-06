using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData
{
    class IssueOfConsumables
    {
        public int Id { get; set; }
        public int ConsumableCode { get; set; }
        public int WorkerCode { get; set; }
        public DateTime IssueDate { get; set; }

        public IssueOfConsumables(int id, int consumableCode, int workerCode, DateTime issueDate)
        {
            Id = id;
            ConsumableCode = consumableCode;
            WorkerCode = workerCode;
            IssueDate = issueDate;
        }
    }
}
