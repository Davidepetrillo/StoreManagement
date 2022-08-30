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

        private string InsertIntoTypeMovements = string.Empty;
        private string UpdateTypeMovements = string.Empty;
        private string SelectTypeMovements = string.Empty;
        private string DeleteTypeMovements = string.Empty;

        private string InsertIntoSuppliers = string.Empty;
        private string UpdateSuppliers = string.Empty;
        private string SelectSuppliers = string.Empty;
        private string DeleteSuppliers = string.Empty;

        private string InsertIntoCustomers = string.Empty;
        private string UpdateCustomers = string.Empty;
        private string SelectCustomers = string.Empty;
        private string DeleteCustomers = string.Empty;

        private string InsertIntoInvoicesHead = string.Empty;
        private string UpdateInvoicesHead = string.Empty;
        private string SelectInvoicesHead = string.Empty;
        private string DeleteInvoicesHead = string.Empty;

        private string InsertIntoInvoicesRows = string.Empty;
        private string UpdateInvoicesRows = string.Empty;
        private string SelectInvoicesRows = string.Empty;
        private string DeleteInvoicesRows = string.Empty;

        private string InsertGoodsValues = string.Empty;
        private string UpdateGoodsValues = string.Empty;
        private string SelectGoodsValues = string.Empty;
        private string DeleteGoodsValues = string.Empty;

        private string InsertGoodsImages = string.Empty;
        private string UpdateGoodsImages = string.Empty;
        private string SelectGoodsImages = string.Empty;
        private string DeleteGoodsImages = string.Empty;

        private string InsertGoodsUpdateValue = string.Empty;
        private string UpdateGoodsUpdateValue = string.Empty;
        private string SelectGoodsUpdateValue = string.Empty;
        private string DeleteGoodsUpdateValue = string.Empty;


        private string queryToReturn = string.Empty;

        public string SetQuery(string QueryDaFare, List<String> parametri)
        {
            string qry = string.Empty;

            switch (QueryDaFare)
            {
                case "InsertIntoMovements":
                    string temp = InsertIntoMovements;

                    InsertIntoMovements = String.Format("INSERT INTO Movements(IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement) VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
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

                case "InsertIntoTypeMovements":
                    temp = InsertIntoTypeMovements;

                    InsertIntoTypeMovements = String.Format("INSERT INTO TypeMovements(IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement) VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
                    qry = InsertIntoTypeMovements;
                    break;

                case "UpdateTypeMovements":
                    temp = UpdateTypeMovements;

                    UpdateTypeMovements = String.Format("UPDATE TypeMovements SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateTypeMovements;
                    break;

                case "SelectTypeMovements":
                    temp = SelectTypeMovements;

                    SelectTypeMovements = String.Format("Select {0} FROM TypeMovements", param[0]);
                    qry = SelectTypeMovements;
                    break;

                case "DeleteTypeMovements":
                    temp = DeleteTypeMovements;

                    DeleteTypeMovements = String.Format("DELETE {0} FROM TypeMovements WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteTypeMovements;
                    break;

                case "InsertIntoSuppliers":
                    temp = InsertIntoSuppliers;

                    InsertIntoSuppliers = String.Format("INSERT INTO Suppliers(NameLegalOwner, SurnameLegalOwner, CompanyName, Address, CivicNumber, ZipCode, City, Region, Nation, Phone, Email, PEC, WebSite, SDI_Code, VAT_Code) VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14})", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10], param[11], param[12], param[13], param[14] );
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

                    InsertIntoCustomers = String.Format("INSERT INTO Customers(NameLegalOwner, SurnameLegalOwner, CompanyName, Address, CivicNumber, ZipCode, City, Region, Nation, Phone, Email, PEC, WebSite, SDI_Code, VAT_Code, StatusCustomer) VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15})", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10], param[11], param[12], param[13], param[14], param[15]);
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

                case "InsertIntoInvoicesHead":
                    temp = InsertIntoInvoicesHead;

                    InsertIntoInvoicesHead = String.Format("INSERT INTO InvoicesHead() VALUES({0})", param[0]);
                    qry = InsertIntoInvoicesHead;
                    break;

                case "UpdateInvoicesHead":
                    temp = UpdateInvoicesHead;

                    UpdateInvoicesHead = String.Format("UPDATE InvoicesHead SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateInvoicesHead;
                    break;

                case "SelectInvoicesHead":
                    temp = SelectInvoicesHead;

                    SelectInvoicesHead = String.Format("Select {0} FROM InvoicesHead", param[0]);
                    qry = SelectInvoicesHead;
                    break;

                case "DeleteInvoicesHead":
                    temp = DeleteInvoicesHead;

                    DeleteInvoicesHead = String.Format("DELETE {0} FROM InvoicesHead WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteInvoicesHead;
                    break;

                case "InsertIntoInvoicesRows":
                    temp = InsertIntoInvoicesRows;

                    InsertIntoInvoicesRows = String.Format("INSERT INTO InvoicesRows() VALUES({0})", param[0]);
                    qry = InsertIntoInvoicesRows;
                    break;

                case "UpdateInvoicesRows":
                    temp = UpdateInvoicesRows;

                    UpdateInvoicesRows = String.Format("UPDATE InvoicesRows SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateInvoicesRows;
                    break;

                case "SelectInvoicesRows":
                    temp = SelectInvoicesRows;

                    SelectInvoicesRows = String.Format("Select {0} FROM InvoicesRows", param[0]);
                    qry = SelectInvoicesRows;
                    break;

                case "DeleteInvoicesRows":
                    temp = DeleteInvoicesRows;

                    DeleteInvoicesRows = String.Format("DELETE {0} FROM InvoicesRows WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteInvoicesRows;
                    break;

                case "InsertGoodsValues":
                    temp = InsertGoodsValues;

                    InsertGoodsValues = String.Format("INSERT INTO GoodsValues() VALUES({0})", param[0]);
                    qry = InsertGoodsValues;
                    break;

                case "UpdateGoodsValues":
                    temp = UpdateGoodsValues;

                    UpdateGoodsValues = String.Format("UPDATE GoodsValues SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateGoodsValues;
                    break;

                case "SelectGoodsValues":
                    temp = SelectGoodsValues;

                    SelectGoodsValues = String.Format("Select {0} FROM GoodsValues", param[0]);
                    qry = SelectGoodsValues;
                    break;

                case "DeleteGoodsValues":
                    temp = DeleteGoodsValues;

                    DeleteGoodsValues = String.Format("DELETE {0} FROM GoodsValues WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteGoodsValues;
                    break;

                case "InsertGoodsImages":
                    temp = InsertGoodsImages;

                    InsertGoodsImages = String.Format("INSERT INTO GoodsImages() VALUES({0})", param[0]);
                    qry = InsertGoodsImages;
                    break;

                case "UpdateGoodsImages":
                    temp = UpdateGoodsImages;

                    UpdateGoodsImages = String.Format("UPDATE GoodsImages SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateGoodsImages;
                    break;

                case "SelectGoodsImages":
                    temp = SelectGoodsImages;

                    SelectGoodsImages = String.Format("Select {0} FROM GoodsImages", param[0]);
                    qry = SelectGoodsImages;
                    break;

                case "DeleteGoodsImages":
                    temp = DeleteGoodsImages;

                    DeleteGoodsImages = String.Format("DELETE {0} FROM GoodsImages WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteGoodsImages;
                    break;

                case "InsertGoodsUpdateValue":
                    temp = InsertGoodsUpdateValue;

                    InsertGoodsUpdateValue = String.Format("INSERT INTO GoodsUpdateValue() VALUES({0})", param[0]);
                    qry = InsertGoodsUpdateValue;
                    break;

                case "UpdateGoodsUpdateValue":
                    temp = UpdateGoodsUpdateValue;

                    UpdateGoodsUpdateValue = String.Format("UPDATE GoodsUpdateValue SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateGoodsUpdateValue;
                    break;

                case "SelectGoodsUpdateValue":
                    temp = SelectGoodsUpdateValue;

                    SelectGoodsUpdateValue = String.Format("Select {0} FROM GoodsUpdateValue", param[0]);
                    qry = SelectGoodsUpdateValue;
                    break;

                case "DeleteGoodsUpdateValue":
                    temp = DeleteGoodsUpdateValue;

                    DeleteGoodsUpdateValue = String.Format("DELETE {0} FROM GoodsUpdateValue WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteGoodsUpdateValue;
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
