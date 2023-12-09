using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace Enterprise_Managment_IS.Classes.SettingsForm
{
    class NewDBCreaterClass
    {
        const string createTablesQuery = "" +
                "CREATE TABLE Workers (Worker_code INT PRIMARY KEY, Surname VARCHAR(30), Name VARCHAR(30), Fname VARCHAR(30), Birth DATETIME, Phone_number BIGINT, Job_title VARCHAR(50), Emploement_date DATETIME, Salary FLOAT, Checking_account BIGINT)" +
                "CREATE TABLE Users (User_code INT PRIMARY KEY, Worker INT FOREIGN KEY REFERENCES Workers(Worker_code), LogIn VARCHAR(30), Password VARCHAR(30))" +
                "CREATE TABLE Providers (Provider_code INT PRIMARY KEY, Provider_name CHAR(70), Provider_address CHAR(70), Provider_description CHAR(250))" +
                "CREATE TABLE Materials (Material_code INT PRIMARY KEY, Material_name CHAR(60), Amount_of_material INT, Material_description CHAR(250), Provider_code INT FOREIGN KEY REFERENCES Providers(Provider_code))" +
                "CREATE TABLE Consumables (Consumable_code INT PRIMARY KEY, Consumable_name CHAR(60), Amount_of_consumable INT, Consumable_description CHAR(250), Provider_code INT FOREIGN KEY REFERENCES Providers(Provider_code))" +
                "CREATE TABLE Supplies (Supply_code INT PRIMARY KEY, Supply_date DATETIME, Material VARCHAR(60), Amount_of_material INT, Provider_code INT FOREIGN KEY REFERENCES Providers(Provider_code), Supply_type CHAR(50), Supply_sum FLOAT)" +
                "CREATE TABLE CanceledSupplies (Supply_code INT PRIMARY KEY, Supply_date DATETIME, Material VARCHAR(60), Amount_of_material INT, Provider_code INT FOREIGN KEY REFERENCES Providers(Provider_code), Supply_type CHAR(50), Supply_sum FLOAT)" +
                "CREATE TABLE Products (Product_code INT PRIMARY KEY, Product_name VARCHAR(40), Product_description VARCHAR(500), Product_price FLOAT)" +
                "CREATE TABLE Factory_products(ID INT PRIMARY KEY, Product_code INT FOREIGN KEY REFERENCES Products(Product_code), Amount_of_product INT)" +
                "CREATE TABLE ConductedSupplies (Supply_code INT PRIMARY KEY, Supply_date DATETIME, Material VARCHAR(60), Amount_of_material INT, Provider_code INT FOREIGN KEY REFERENCES Providers(Provider_code), Supply_type CHAR(50), Supply_sum FLOAT)" +
                "CREATE TABLE Defective_factory_products(ID INT PRIMARY KEY, Product_code INT FOREIGN KEY REFERENCES Products(Product_code), Amount_of_product INT, Description_of_defect CHAR(300), Date_added DATETIME)" +
                "CREATE TABLE Stores (Store_code INT PRIMARY KEY, Address VARCHAR(70), Store_director_code INT FOREIGN KEY REFERENCES Workers(Worker_code), Store_phone BIGINT, Sellers VARCHAR(30), Warehouse_worker_code INT FOREIGN KEY REFERENCES Workers(Worker_code))" +
                "CREATE TABLE Order_from_the_store(Order_code INT PRIMARY KEY, Store INT FOREIGN KEY REFERENCES Stores(Store_code), Order_date DATETIME)" +
                "CREATE TABLE Store_warehouses_products (ID INT PRIMARY KEY, Store_code INT FOREIGN KEY REFERENCES Stores(Store_code), Product_code INT FOREIGN KEY REFERENCES Products(Product_code), Amount_of_product INT)" +
                "CREATE TABLE Issue_of_materials(Id INT PRIMARY KEY, Material_code INT FOREIGN KEY REFERENCES Materials(Material_code), Worker_code INT FOREIGN KEY REFERENCES Workers(Worker_code), Issue_date DATETIME)" +
                "CREATE TABLE Issue_of_consumables(Id INT PRIMARY KEY, Consumable_code INT FOREIGN KEY REFERENCES Consumables(Consumable_code), Worker_code INT FOREIGN KEY REFERENCES Workers(Worker_code), Issue_date DATETIME)" +
                "CREATE TABLE Production_order_elements(Element_code INT PRIMARY KEY, Order_code INT FOREIGN KEY REFERENCES Order_from_the_store(Order_code), Product_code INT FOREIGN KEY REFERENCES Products(Product_code), Amount INT, isProduced BIT, isLoaded BIT, isReceived BIT)";

        const string createTriggerQuery = "" +
                "CREATE TRIGGER INSERT_Supplly ON Supplies AFTER INSERT AS BEGIN SET NOCOUNT ON;" +
                "IF(SELECT Supply_date FROM inserted) > GETDATE() " +
                "BEGIN " +
                "ROLLBACK TRAN PRINT 'Откат! Дата добавляемой поставки должна соответствовать текущей.' " +
                "END " +
                "ELSE " +
                "BEGIN " +
                "PRINT 'Запись добавлена.' " +
                "END " +
                "END";

        public static void expandAllTablesInTheNewDatabase(string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = createTablesQuery;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            query = createTriggerQuery;
            sqlConnection.Open();
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static string ShowCreateTablesQuery()
        {
            return createTablesQuery;
        }
        public static string ShowCreateTriggerQuery()
        {
            return createTriggerQuery;
        }
    }
}
