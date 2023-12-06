using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataDeleterDescendants;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;
using Enterprise_Managment_IS.Classes.FormClasses.FactoryWarehouseWorkerForm;
using Enterprise_Managment_IS.Classes.ReportGenerator;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;
using Enterprise_Managment_IS.Forms.AdminFormDirectory;
using Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms;
using Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Products;
using Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Providers;

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory
{
    public partial class FactoryWarehouseWorkerForm : Form
    {
        public FactoryWarehouseWorkerForm()
        {
            InitializeComponent();
        }
        private void FactoryWarehouseWorkerForm_Load(object sender, EventArgs e)
        {
            panels = new List<Panel>()
            {
                materialsPanel, suppliesPanel, consumablePanel, productPanel, providerPanel, defectiveProductPanel, productionOrderPanel
            };
            SelectTypeOfSuppliesComboBox.Items.AddRange(new List<string> { "Активные", "Проведенные", "Отмененные" }.ToArray());
        }
        private void FactoryWarehouseWorkerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!devMode)
            {
                Application.Exit();
            }
        }

        //MenuButtons
        private void materialsButton_Click(object sender, EventArgs e)
        {
            PanelsHandlerClass.HideAllPanels(panels);
            materialsPanel.Visible = true;
            DataRefresher.RefreshTable_Materials(materialsDataGridView, DataLoader_Materials.GetAllMaterials());
        }
        private void suppliesButton_Click(object sender, EventArgs e)
        {
            PanelsHandlerClass.HideAllPanels(panels);
            suppliesPanel.Visible = true;
            SelectTypeOfSuppliesComboBox.SelectedIndex = 0;
            DataRefresher.RefreshTable_Supplies(suppliesDataGridView, DataLoader_Supplies.GetAllSupplies());
        }
        private void equipmentConsumablesButton_Click(object sender, EventArgs e)
        {
            PanelsHandlerClass.HideAllPanels(panels);
            consumablePanel.Visible = true;
            DataRefresher.RefreshTable_Materials(consumableDataGridView, DataLoader_Consumables.GetAllConsumables());
        }
        private void providersButton_Click(object sender, EventArgs e)
        {
            PanelsHandlerClass.HideAllPanels(panels);
            providerPanel.Visible = true;
            DataRefresher.RefreshTable(providerDataGridView, DataLoader_Providers.GetAllProviders());
        }
        private void productButton_Click(object sender, EventArgs e)
        {
            PanelsHandlerClass.HideAllPanels(panels);
            productPanel.Visible = true;
            DataRefresher.RefreshTable_FactoryProduct(productDataGridView, DataLoader_FactoryProducts.GetAllFactoryProducts());
        }
        private void defectiveProductsButton_Click(object sender, EventArgs e)
        {
            PanelsHandlerClass.HideAllPanels(panels);
            defectiveProductPanel.Visible = true;
            DataRefresher.RefreshTable_FactoryProduct(defectiveProductDataGridView, DataLoader_DefectiveFactoryProducts.GetAllDefectiveFactoryProducts());
        }
        private void ordersButton_Click(object sender, EventArgs e)
        {
            PanelsHandlerClass.HideAllPanels(panels);
            productionOrderPanel.Visible = true;
            DataRefresher.RefreshTable_ProductOrders(productionOrderDataGridView, DataLoader_ProductsOrders.GetAllProductsOrders());
        }

        //MaterialPanel
        private void addMaterialButton_Click(object sender, EventArgs e)
        {
            MaterialPanelClass.addMaterialButton_Click(materialsDataGridView);
        }
        private void deleteMaterialButton_Click(object sender, EventArgs e)
        {
            MaterialPanelClass.deleteMaterialButton_Click(materialsDataGridView);
        }
        private void filterButton_Click(object sender, EventArgs e)
        {
            MaterialPanelClass.filterButton_Click(materialsDataGridView);
        }
        private void releaseMaterialButton_Click(object sender, EventArgs e)
        {
            MaterialPanelClass.releaseMaterialButton_Click(materialsDataGridView);
        }

        //SupplyPanel
        private void createSupplyButton_Click(object sender, EventArgs e)
        {
            SupplyPanelClass.createSupplyButton_Click(suppliesDataGridView);
        }
        private void applyASupplyButton_Click(object sender, EventArgs e)
        {
            SupplyPanelClass.applyASupplyButton_Click(suppliesDataGridView);
        }
        private void cancelSupplyButton_Click(object sender, EventArgs e)
        {
            SupplyPanelClass.cancelSupplyButton_Click(suppliesDataGridView);
        }
        private void SelectTypeOfSuppliesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectTypeOfSuppliesComboBox.SelectedIndex == 0)
            {
                DataRefresher.RefreshTable_Supplies(suppliesDataGridView, DataLoader_Supplies.GetAllSupplies());
                createSupplyButton.Enabled = true;
                applyASupplyButton.Enabled = true;
                cancelSupplyButton.Enabled = true;
                generateActiveSuppliesReportButton.Visible = true;
                generateCanceledSuppliesReportButton.Visible = false;
                generateConductedSuppliesReportButton.Visible = false;
            }
            else if (SelectTypeOfSuppliesComboBox.SelectedIndex == 1)
            {
                DataRefresher.RefreshTable_Supplies(suppliesDataGridView, DataLoader_ConductedSupplies.GetAllConductedSupplies());
                createSupplyButton.Enabled = false;
                applyASupplyButton.Enabled = false;
                cancelSupplyButton.Enabled = false;
                generateActiveSuppliesReportButton.Visible = false;
                generateCanceledSuppliesReportButton.Visible = false;
                generateConductedSuppliesReportButton.Visible = true;
            }
            else if (SelectTypeOfSuppliesComboBox.SelectedIndex == 2)
            {
                DataRefresher.RefreshTable_Supplies(suppliesDataGridView, DataLoader_CanceledSupplies.GetAllCanceledSupplies());
                createSupplyButton.Enabled = false;
                applyASupplyButton.Enabled = false;
                cancelSupplyButton.Enabled = false;
                generateActiveSuppliesReportButton.Visible = false;
                generateCanceledSuppliesReportButton.Visible = true;
                generateConductedSuppliesReportButton.Visible = false;
            }
        }

        private async void generateCanceledSuppliesReportButton_Click(object sender, EventArgs e)
        {
            reportFolderBrowserDialog.ShowDialog();
            string path = reportFolderBrowserDialog.SelectedPath;
            if (path != null || path != "")
            {
                await Task.Run(() =>
                {
                    RG_CanceledSupplies.GenerateReport(path);
                });
            }
        }

        private async void generateActiveSuppliesReportButton_Click(object sender, EventArgs e)
        {
            reportFolderBrowserDialog.ShowDialog();
            string path = reportFolderBrowserDialog.SelectedPath;
            if (path != null || path != "")
            {
                await Task.Run(() =>
                {
                    RG_ActiveSupplies.GenerateReport(path);
                });
            }
        }
        private async void generateConductedSuppliesReportButton_Click(object sender, EventArgs e)
        {
            reportFolderBrowserDialog.ShowDialog();
            string path = reportFolderBrowserDialog.SelectedPath;
            if (path != null || path != "")
            {
                await Task.Run(() =>
                {
                    RG_ConductedSupplies.GenerateReport(path);
                });
            }
        }

        //ConsumablePanel
        private void addConsumableButton_Click(object sender, EventArgs e)
        {
            ConsumablePanelClass.addConsumableButton_Click(consumableDataGridView);
        }
        private void releaseConsumableButton_Click(object sender, EventArgs e)
        {
            ConsumablePanelClass.releaseConsumableButton_Click(consumableDataGridView);
        }
        private void filterConsumableButton_Click(object sender, EventArgs e)
        {
            ConsumablePanelClass.filterConsumableButton_Click(consumableDataGridView);
        }
        private void deleteConsumableButton_Click(object sender, EventArgs e)
        {
            ConsumablePanelClass.deleteConsumableButton_Click(consumableDataGridView);
        }

        //ProviderPanel
        private void addProviderButton_Click(object sender, EventArgs e)
        {
            ProviderPanelClass.addProviderButton_Click(providerDataGridView);
        }
        private void changeButton_Click(object sender, EventArgs e)
        {
            ProviderPanelClass.changeButton_Click(providerDataGridView);
        }
        private void deleteProviderButton_Click(object sender, EventArgs e)
        {
            ProviderPanelClass.deleteProviderButton_Click(providerDataGridView);
        }

        //ProductPanel
        private void addProductButton_Click(object sender, EventArgs e)
        {
            ProductPanelClass.addProductButton_Click(productDataGridView);
        }
        private void filterProductButton_Click(object sender, EventArgs e)
        {
            ProductPanelClass.filterProductButton_Click(productDataGridView);
        }
        private void acceptProductsButton_Click(object sender, EventArgs e)
        {
            ProductPanelClass.acceptProductsButton_Click(productDataGridView);
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            ProductPanelClass.deleteProductButton_Click(productDataGridView);
        }

        private void sendToDefectiveButton_Click(object sender, EventArgs e)
        {
            ProductPanelClass.sendToDefectiveButton_Click(productDataGridView);
        }

        //DefectiveProductPanel
        private void sendTheProductForProcessingButton_Click(object sender, EventArgs e)
        {
            DefectiveProductPanelClass.sendTheProductForProcessingButton_Click(defectiveProductDataGridView);
        }

        //ProductsOrdersPanel

        private void productionOrderDataGridView_Click(object sender, EventArgs e)
        {
            ProductOrderPanelClass.showOrderInfo(productionOrderDataGridView);
        }

        
    }
}
