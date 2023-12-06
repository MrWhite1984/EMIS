using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Managment_IS.Classes.FormClasses.FactoryWarehouseWorkerForm
{
    class PanelsHandlerClass
    {
        public static void HideAllPanels(List<Panel> panels)
        {
            foreach (var panel in panels)
                panel.Visible = false;
        }
    }
}
