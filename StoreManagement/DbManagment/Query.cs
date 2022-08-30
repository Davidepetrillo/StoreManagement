using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DbManagment
{
    public class Query
    {
        private List<String> param = new List<String>();
        private string InsertIntoMovements = string.Empty;
        private string UpdateMovements = string.Empty;
        private string SelectMovements = string.Empty;
        private string DeleteMovements = string.Empty;

        private string InsertIntoSuppliers = string.Empty;
        private string UpdateSuppliers = string.Empty;
        private string SelectSuppliers = string.Empty;
        private string DeleteSuppliers = string.Empty;

        private string InsertIntoCustomers = string.Empty;
        private string UpdateCustomers = string.Empty;
        private string SelectCustomers = string.Empty;
        private string DeleteCustomers = string.Empty;

        private string InsertIntoInvoices = string.Empty;
        private string UpdateInvoices = string.Empty;
        private string SelectInvoices = string.Empty;
        private string DeleteInvoices = string.Empty;

        private string InsertGoods = string.Empty;
        private string UpdateGoods = string.Empty;
        private string SelectGoods = string.Empty;
        private string DeleteGoods = string.Empty;


        private string queryToReturn = string.Empty;

        public string SetQuery(string QueryDaFare, List<String> parametri)
        {
            string qry = string.Empty;

            switch (QueryDaFare)
            {
                case "InsertIntoMovements":
                    string temp = InsertIntoMovements;

                    InsertIntoMovements = String.Format("INSERT INTO Movements(IDCustomer,IDSupplier,IDProduct,Qta,Price,DiscountPercentage,DiscountLimitNumbers,NetCost,NetNetCost,DateMovement,TypeMovement) VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10})", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
                    qry = InsertIntoMovements;
                    break;

                case "UpdateMovements":
                    temp = UpdateMovements;

                    UpdateMovements = String.Format("UPDATE Movements SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateMovements;
                    break;

                case "SelectMovements":
                    temp = SelectMovements;

                    SelectMovements = String.Format("Select {0} FROM Movements", param[0]);
                    qry = SelectMovements;
                    break;

                case "DeleteMovements":
                    temp = DeleteMovements;

                    DeleteMovements = String.Format("DELETE {0} FROM Movements WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteMovements;
                    break;

                case "InsertIntoSuppliers":
                    temp = InsertIntoSuppliers;

                    InsertIntoSuppliers = String.Format("INSERT INTO Suppliers(NameLegalOwner,SurnameLegalOwner,CompanyName,Address,CivicNumber,ZipCode,City,Region,Nation,Phone,Email,PEC,WebSite,SDI_Code,VAT_Code) VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10], param[11], param[12], param[13], param[14] );
                    qry = InsertIntoSuppliers;
                    break;

                case "UpdateSuppliers":
                    temp = UpdateSuppliers;

                    UpdateSuppliers = String.Format("UPDATE Suppliers SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateSuppliers;
                    break;

                case "SelectSuppliers":
                    temp = SelectSuppliers;

                    SelectSuppliers = String.Format("Select {0} FROM Suppliers", param[0]);
                    qry = SelectSuppliers;
                    break;

                case "DeleteSuppliers":
                    temp = DeleteSuppliers;

                    DeleteSuppliers = String.Format("DELETE {0} FROM Suppliers WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteSuppliers;
                    break;

                case "InsertIntoCustomers":
                    temp = InsertIntoCustomers;

                    InsertIntoCustomers = String.Format("INSERT INTO Customers(NameLegalOwner,SurnameLegalOwner,CompanyName,Address,CivicNumber,ZipCode,City,Region,Nation,Phone,Email,PEC,WebSite,SDI_Code,VAT_Code,StatusCustomer) VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15})", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10], param[11], param[12], param[13], param[14], param[15]);
                    qry = InsertIntoCustomers;
                    break;

                case "UpdateCustomers":
                    temp = UpdateCustomers;

                    UpdateCustomers = String.Format("UPDATE Customers SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateCustomers;
                    break;

                case "SelectCustomers":
                    temp = SelectCustomers;

                    SelectCustomers = String.Format("Select {0} FROM Customers", param[0]);
                    qry = SelectCustomers;
                    break;

                case "DeleteCustomers":
                    temp = DeleteCustomers;

                    DeleteCustomers = String.Format("DELETE {0} FROM Customers WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteCustomers;
                    break;

                case "InsertIntoInvoices":
                    temp = InsertIntoInvoices;

                    InsertIntoInvoices = String.Format("INSERT INTO Invoices() VALUES({0})", param[0]);
                    qry = InsertIntoInvoices;
                    break;

                case "UpdateInvoices":
                    temp = UpdateInvoices;

                    UpdateInvoices = String.Format("UPDATE Invoices SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateInvoices;
                    break;

                case "SelectInvoices":
                    temp = SelectInvoices;

                    SelectInvoices = String.Format("Select {0} FROM Invoices", param[0]);
                    qry = SelectInvoices;
                    break;

                case "DeleteInvoices":
                    temp = DeleteInvoices;

                    DeleteInvoices = String.Format("DELETE {0} FROM Invoices WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteInvoices;
                    break;

                case "InsertGoods":
                    temp = InsertGoods;

                    InsertGoods = String.Format("INSERT INTO Goods() VALUES({0})", param[0]);
                    qry = InsertGoods;
                    break;

                case "UpdateGoods":
                    temp = UpdateGoods;

                    UpdateGoods = String.Format("UPDATE Goods SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateGoods;
                    break;

                case "SelectGoods":
                    temp = SelectGoods;

                    SelectGoods = String.Format("Select {0} FROM Goods", param[0]);
                    qry = SelectGoods;
                    break;

                case "DeleteGoods":
                    temp = DeleteGoods;

                    DeleteGoods = String.Format("DELETE {0} FROM Goods WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteGoods;
                    break;
            }
            return qry;
        }

        public Query(string QueryDaFare, List<String> parametri)
        {
            param = parametri;
            queryToReturn = SetQuery(QueryDaFare, param);
        }

        public string GetQuery()
        {
            return queryToReturn;
        }



    }
}
