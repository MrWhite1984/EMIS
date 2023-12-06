using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.FormClasses.FactoryWarehouseWorkerForm;

namespace Enterprise_Managment_IS.Classes.FormClasses.AdminForm
{
    class DeveloperPanelClass
    {
        public static void openUsersFormButton_Click(List<Panel> panels, int index)
        {
            PanelsHandlerClass.HideAllPanels(panels);
            panels[index].Show();
        }
    }
}
