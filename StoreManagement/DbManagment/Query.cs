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

        private string InsertIntoArchiveMovements = string.Empty;
        private string UpdateArchiveMovements = string.Empty;
        private string SelectArchiveMovements = string.Empty;
        private string DeleteArchiveMovements = string.Empty;

        private string InsertIntoArchiveGoodsValue = string.Empty;
        private string UpdateArchiveGoodsValue = string.Empty;
        private string SelectArchiveGoodsValue = string.Empty;
        private string DeleteArchiveGoodsValue = string.Empty;

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

        private string InsertIntoCustomerState = string.Empty;
        private string UpdateCustomerState = string.Empty;
        private string SelectCustomerState = string.Empty;
        private string DeleteCustomerState = string.Empty;

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

        private string InsertFoodGoods = string.Empty;
        private string UpdateFoodGoods = string.Empty;
        private string SelectFoodGoods = string.Empty;
        private string DeleteFoodGoods = string.Empty;

        private string InsertFoodCategory = string.Empty;
        private string UpdateFoodCategory = string.Empty;
        private string SelectFoodCategory = string.Empty;
        private string DeleteFoodCategory = string.Empty;

        private string InsertGoodsDimensions = string.Empty;
        private string UpdateGoodsDimensions = string.Empty;
        private string SelectGoodsDimensions = string.Empty;
        private string DeleteGoodsDimensions = string.Empty;

        private string InsertGoodsUpdateValue = string.Empty;
        private string UpdateGoodsUpdateValue = string.Empty;
        private string SelectGoodsUpdateValue = string.Empty;
        private string DeleteGoodsUpdateValue = string.Empty;

        private string strWhere = string.Empty;

        private string queryToReturn = string.Empty;

        private List<String> Condition = new List<String>();
        private List<String> WhereParameters = new List<String>();
        private List<String> SelectCondition = new List<String>();

        private string WCArchiveGoodsValue = string.Empty;

        private string WPArchiveGoodsValue = string.Empty;
        private string wcaToReturn = string.Empty;



        private string SCArchiveGoodsValue = string.Empty;
        private string SelectConditionParameters = string.Empty;
        private string scpToReturn = string.Empty;
        public string SetWhereCondition(string WhereCondition)
        {
            string Cond = string.Empty;
            string temp = string.Empty;

            switch (int.Parse(WhereCondition))
            {
    
                case 1:
                    SetWhereParameters(01, WhereParameters);
                    temp = WCArchiveGoodsValue;
                    WCArchiveGoodsValue = "WHERE IDProduct " + GetWhereParameters();
                    Cond = WCArchiveGoodsValue;
                    break;

                case 2:
                    SetWhereParameters(01, WhereParameters);
                    temp = WCArchiveGoodsValue;
                    WCArchiveGoodsValue = "WHERE VAT " + GetWhereParameters();
                    Cond = WCArchiveGoodsValue;
                    break;
                case 3:
                    SetWhereParameters(02, WhereParameters);
                    temp = WCArchiveGoodsValue;
                    WCArchiveGoodsValue = "WHERE Price " + GetWhereParameters();
                    Cond = WCArchiveGoodsValue;
                    break;
                case 4:
                    SetWhereParameters(03, WhereParameters);
                    temp = WCArchiveGoodsValue;
                    WCArchiveGoodsValue = "WHERE DateOldValue " + GetWhereParameters();
                    Cond = WCArchiveGoodsValue;
                    break;

                default:

                    throw new Exception();

            }
            return Cond;
        }

        public Query(string WhereCondition)
        {
            wcaToReturn = SetWhereCondition(WhereCondition);
        }
        public string GetWhereCondition()
        {
            return wcaToReturn;
        }
        public string SetWhereParameters(int NumWhereParameters, List<String> WParameters)
        {
            string WParam = string.Empty;
            string temp = string.Empty;

            switch (NumWhereParameters)
            {
                case 01:
                    temp = WPArchiveGoodsValue;
                    WPArchiveGoodsValue = String.Format(" = '{0}' ", WParameters[0]);
                    WParam = WPArchiveGoodsValue;
                    break;

                case 02:
                    temp = WPArchiveGoodsValue;
                    WPArchiveGoodsValue = String.Format(" < '{0}' ", WParameters[0]);
                    WParam = WPArchiveGoodsValue;
                    break;
                case 03:
                    temp = WPArchiveGoodsValue;
                    WPArchiveGoodsValue = String.Format(" BETWEEN  '{0}' AND '{1}' ", WParameters[0], WParameters[1]);
                    WParam = WPArchiveGoodsValue;
                    break;

                default:

                    throw new Exception();

            }
            return WParam;
        }
        public Query(int NumWhereParameters, List<String> WParameters)
        {
            WhereParameters = WParameters;
            wcaToReturn = SetWhereParameters(NumWhereParameters, WhereParameters);
        }
        public string GetWhereParameters()
        {
            return wcaToReturn;
        }


        public string SetSelectCondition(int NumSelectCondition, List<String> SCParameters)
        {
            string SCparam = string.Empty;
            string temp = string.Empty;

            switch (NumSelectCondition)
            {
          
                case 01:
                    temp = SCArchiveGoodsValue;
                    SCArchiveGoodsValue = String.Format(" IDProduct, VAT, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateOldValue ", SCParameters[0]);
                    SCparam = SCArchiveGoodsValue;
                    break;

                default:

                    throw new Exception();

            }
            return SCparam;
        }


        
        public string SetQuery(string QueryDaFare, List<String> parametri, string stringaWhere)
        {
            string qry = string.Empty;

            switch (QueryDaFare)
            {
                case "InsertIntoMovements":
                    string temp = InsertIntoMovements;

                    InsertIntoMovements = String.Format("INSERT INTO Movements(IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
                    qry = InsertIntoMovements;
                    break;

                case "UpdateMovements":
                    temp = UpdateMovements;

                    UpdateMovements = String.Format("UPDATE Movements SET (IDCustomer) = ('{0}'), (IDSupplier) = ('{1}'),  (IDProduct) = ('{2}'),  (Qta) = ('{3}'),  (Price) = ('{4}'),  (DiscountPercentage) = ('{5}'),  (DiscountLimitNumbers) = ('{6}'),  (NetCost) = ('{7}'),  (NetNetCost) = ('{8}'),  (DateMovement) = ('{9}'),  (TypeMovement) = ('{10}')  " + stringaWhere, param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
                    qry = UpdateMovements;
                    break;

                case "SelectMovements":
                    temp = SelectMovements;

                    SelectMovements = String.Format("Select (IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement) FROM Movements" + stringaWhere);
                    qry = SelectMovements;
                    break;

                case "DeleteMovements":
                    temp = DeleteMovements;

                    DeleteMovements = String.Format("DELETE FROM Movements" + stringaWhere);
                    qry = DeleteMovements;
                    break;

                case "InsertIntoArchiveMovements":
                    temp = InsertIntoArchiveMovements;

                    InsertIntoArchiveMovements = String.Format("INSERT INTO ArchiveMovements(IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
                    qry = InsertIntoArchiveMovements;
                    break;

                case "UpdateArchiveMovements":
                    temp = UpdateArchiveMovements;

                    UpdateArchiveMovements = String.Format("UPDATE ArchiveMovements SET (IDCustomer) = ('{0}'), SET (IDSupplier) = ('{1}'), SET (IDProduct) = ('{2}'), SET (Qta) = ('{3}'), SET (Price) = ('{4}'), SET (DiscountPercentage) = ('{5}'), SET (DiscountLimitNumbers) = ('{6}'), SET (NetCost) = ('{7}'), SET (NetNetCost) = ('{8}'), SET (DateMovement) = ('{9}'), SET (TypeMovement) = ('{10}')  " + stringaWhere, param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
                    qry = UpdateArchiveMovements;
                    break;

                case "SelectArchiveMovements":
                    temp = SelectArchiveMovements;

                    SelectArchiveMovements = String.Format("Select (IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement) FROM ArchiveMovements" + stringaWhere);
                    qry = SelectArchiveMovements;
                    break;

                case "DeleteArchiveMovements":
                    temp = DeleteArchiveMovements;

                    DeleteArchiveMovements = String.Format("DELETE FROM ArchiveMovements" + stringaWhere);
                    qry = DeleteArchiveMovements;
                    break;

                case "InsertIntoArchiveGoodsValue":
                    temp = InsertIntoArchiveGoodsValue;

                    InsertIntoArchiveGoodsValue = String.Format("INSERT INTO ArchiveGoodsValue(IDProduct, VAT, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateOldValue) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7]);
                    qry = InsertIntoArchiveGoodsValue;
                    break;

                case "UpdateArchiveGoodsValue":
                    temp = UpdateArchiveGoodsValue;

                    UpdateArchiveGoodsValue = String.Format("UPDATE ArchiveGoodsValue SET() " + stringaWhere, param[0], param[1], param[2], param[3]);
                    qry = UpdateArchiveGoodsValue;
                    break;

                case "SelectArchiveGoodsValue":
                    temp = SelectArchiveGoodsValue;

                    SelectArchiveGoodsValue = String.Format("Select (IDProduct, VAT, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateOldValue) FROM ArchiveGoodsValue" + stringaWhere);
                    qry = SelectArchiveGoodsValue;
                    break;

                case "DeleteArchiveGoodsValue":
                    temp = DeleteArchiveGoodsValue;

                    DeleteArchiveGoodsValue = String.Format("DELETE FROM ArchiveGoodsValue" + stringaWhere);
                    qry = DeleteArchiveGoodsValue;
                    break;

                case "InsertIntoTypeMovements":
                    temp = InsertIntoTypeMovements;

                    InsertIntoTypeMovements = String.Format("INSERT INTO TypeMovements(DescriptionMovement) VALUES('{0}')", param[0]);
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

                    InsertIntoSuppliers = String.Format("INSERT INTO Suppliers(NameLegalOwner, SurnameLegalOwner, CompanyName, Address, CivicNumber, ZipCode, City, Region, Nation, Phone, Email, PEC, WebSite, SDI_Code, VAT_Code) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10], param[11], param[12], param[13], param[14] );
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

                    InsertIntoCustomers = String.Format("INSERT INTO Customers(NameLegalOwner, SurnameLegalOwner, CompanyName, Address, CivicNumber, ZipCode, City, Region, Nation, Phone, Email, PEC, WebSite, SDI_Code, VAT_Code, StatusCustomer) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10], param[11], param[12], param[13], param[14], param[15]);
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

                case "InsertIntoCustomerState":
                    temp = InsertIntoCustomerState;

                    InsertIntoCustomerState = String.Format("INSERT INTO Customer(StatusDescription) VALUES('{0}')", param[0]);
                    qry = InsertIntoCustomerState;
                    break;

                case "UpdateCustomerState":
                    temp = UpdateCustomerState;

                    UpdateCustomerState = String.Format("UPDATE Customer SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateCustomerState;
                    break;

                case "SelectCustomerState":
                    temp = SelectCustomerState;

                    SelectCustomerState = String.Format("Select {0} FROM Customer", param[0]);
                    qry = SelectCustomerState;
                    break;

                case "DeleteCustomerState":
                    temp = DeleteCustomerState;

                    DeleteCustomerState = String.Format("DELETE {0} FROM CustomerState WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteCustomerState;
                    break;

                case "InsertIntoInvoicesHead":
                    temp = InsertIntoInvoicesHead;

                    InsertIntoInvoicesHead = String.Format("INSERT INTO InvoicesHead(IDCustomer, TotalPrice, DiscountedPrice) VALUES('{0}', '{1}', '{2}')", param[0], param[1], param[2]);
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

                    InsertIntoInvoicesRows = String.Format("INSERT INTO InvoicesRows(IDInvoice, IDProduct, Qta, Price, VAT, PriceSubTotal, TotalQta) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6]);
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

                    InsertGoodsValues = String.Format("INSERT INTO GoodsValues(IDProduct, VAT, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateUpdateValue, TypeUpdateValue) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8]);
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

                case "InsertFoodGoods":
                    temp = InsertFoodGoods;

                    InsertFoodGoods = String.Format("INSERT INTO FoodGoods(DescriptionProduct, EAN, IDSupplier, IDCategory) VALUES('{0}', '{1}', '{2}', '{3}')", param[0], param[1], param[2], param[3]);
                    qry = InsertFoodGoods;
                    break;

                case "UpdateFoodGoods":
                    temp = UpdateFoodGoods;

                    UpdateFoodGoods = String.Format("UPDATE FoodGoods SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateFoodGoods;
                    break;

                case "SelectFoodGoods":
                    temp = SelectFoodGoods;

                    SelectFoodGoods = String.Format("Select {0} FROM FoodGoods", param[0]);
                    qry = SelectFoodGoods;
                    break;

                case "DeleteFoodGoods":
                    temp = DeleteFoodGoods;

                    DeleteFoodGoods = String.Format("DELETE {0} FROM FoodGoods WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteFoodGoods;
                    break;

                case "InsertFoodCategory":
                    temp = InsertFoodCategory;

                    InsertFoodCategory = String.Format("INSERT INTO FoodCategory(DescriptionCategory) VALUES('{0}')", param[0]);
                    qry = InsertFoodCategory;
                    break;

                case "UpdateFoodCategory":
                    temp = UpdateFoodCategory;

                    UpdateFoodCategory = String.Format("UPDATE FoodCategory SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateFoodCategory;
                    break;

                case "SelectFoodCategory":
                    temp = SelectFoodCategory;

                    SelectFoodCategory = String.Format("Select {0} FROM FoodCategory", param[0]);
                    qry = SelectFoodCategory;
                    break;

                case "DeleteFoodCategory":
                    temp = DeleteFoodCategory;

                    DeleteFoodCategory = String.Format("DELETE {0} FROM FoodCategory WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteFoodCategory;
                    break;

                case "InsertGoodsImages":
                    temp = InsertGoodsImages;

                    InsertGoodsImages = String.Format("INSERT INTO GoodsImages(IDProduct, ImageSingle, ImageBox) VALUES('{0}', '{1}', '{2}')", param[0], param[1], param[2]);
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

                case "InsertGoodsDimensions":
                    temp = InsertGoodsDimensions;

                    InsertGoodsDimensions = String.Format("INSERT INTO GoodsDimensions(IDProduct, NumbersInBox, DimensionSingleHeight, DimensionSingleBase, DimensionSingleDepth, DimensionBoxHeight, DimensionBoxBase, DimensionBoxDepth, WeightSingle, WightBox) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9]);
                    qry = InsertGoodsDimensions;
                    break;

                case "UpdateGoodsDimensions":
                    temp = UpdateGoodsDimensions;

                    UpdateGoodsDimensions = String.Format("UPDATE GoodsDimensions SET {0} = {1} WHERE {2} = {3}", param[0], param[1], param[2], param[3]);
                    qry = UpdateGoodsDimensions;
                    break;

                case "SelectGoodsDimensions":
                    temp = SelectGoodsDimensions;

                    SelectGoodsDimensions = String.Format("Select {0} FROM GoodsDimensions", param[0]);
                    qry = SelectGoodsDimensions;
                    break;

                case "DeleteGoodsDimensions":
                    temp = DeleteGoodsDimensions;

                    DeleteGoodsDimensions = String.Format("DELETE {0} FROM GoodsDimensions WHERE {1} = {2}", param[0], param[1], param[2]);
                    qry = DeleteGoodsDimensions;
                    break;

                case "InsertGoodsUpdateValue":
                    temp = InsertGoodsUpdateValue;

                    InsertGoodsUpdateValue = String.Format("INSERT INTO GoodsUpdateValue(DescriptionUpdateValue) VALUES('{0}')", param[0]);
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

                    DeleteGoodsUpdateValue = String.Format("DELETE FROM GoodsUpdateValue WHERE {0} = {1}", param[0], param[1]);
                    qry = DeleteGoodsUpdateValue;
                    break;
            }
            return qry;
        }

        public Query(string QueryDaFare, List<String> parametri, string strWhere)
        {
            param = parametri;
            queryToReturn = SetQuery(QueryDaFare, param, strWhere);
        }

        public string GetQuery()
        {
            return queryToReturn;
        }



    }
}












/*
 * public string SetStrWhere(string Table, string str, List<String> paramWhere)
        {
            string stringWhere = string.Empty;

            switch (Table)
            {
                case "Movements":
                    string temp = strWhere;
                    strWhere = String.Format("WHERE IDCustomer = ('{0}') AND IDSupplier = ('{1}') AND IDProduct = ('{2}') AND Qta = ('{3}') AND Price = ('{4}') AND DiscountPercentage = ('{5}') AND DiscountLimitNumbers = ('{6}') AND NetCost = ('{7}') AND NetNetCost = ('{8}') AND DateMovement = ('{9}') AND TypeMovement = ('{10}') ", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
                    stringWhere = strWhere;
                    break;

                case "ArchiveMovements":
                    temp = strWhere;
                    strWhere = String.Format("WHERE IDCustomer = ('{0}') AND IDSupplier = ('{1}') AND IDProduct = ('{2}') AND Qta = ('{3}') AND Price = ('{4}') AND DiscountPercentage = ('{5}') AND DiscountLimitNumbers = ('{6}') AND NetCost = ('{7}') AND NetNetCost = ('{8}') AND DateMovement = ('{9}') AND TypeMovement = ('{10}') ", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
                    stringWhere = strWhere;
                    break;

                case "ArchiveGoodsValue":
                    temp = strWhere;
                    strWhere = String.Format("WHERE IDProduct = ('{0}') AND VAT = ('{1}') AND Price = ('{2}') AND DiscountPercentage = ('{3}') AND DiscountLimitNumbers = ('{4}') AND NetCost = ('{5}') AND NetNetCost = ('{6}') AND DateOldValue = ('{7}') ", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7]);
                    stringWhere = strWhere;
                    break;

                case "TypeMovements":
                    temp = strWhere;
                    strWhere = String.Format("WHERE DescriptionMovement = ('{0}')) ", param[0]);
                    break;

                case "Suppliers":
                    temp = strWhere;
                    strWhere = String.Format("WHERE NameLegalOwner = ('{0}') AND SurnameLegalOwner = ('{1}') AND CompanyName = ('{2}') AND Address = ('{3}') AND CivicNumber = ('{4}') AND ZipCode = ('{5}') AND City = ('{6}') AND Region = ('{7}') AND Nation = ('{8}') AND Phone = ('{9}') AND Email = ('{10}') AND PEC = ('{11}') AND WebSite = ('{12}') AND SDI_Code = ('{13}') AND VAT_Code = ('{14}') ", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10], param[11], param[12], param[13], param[14]);
                    stringWhere = strWhere;
                    break;

                case "Customers":
                    temp = strWhere;
                    strWhere = String.Format("WHERE NameLegalOwner = ('{0}') AND SurnameLegalOwner = ('{1}') AND CompanyName = ('{2}') AND Address = ('{3}') AND CivicNumber = ('{4}') AND ZipCode = ('{5}') AND City = ('{6}') AND Region = ('{7}') AND Nation = ('{8}') AND Phone = ('{9}') AND Email = ('{10}') AND PEC = ('{11}') AND WebSite = ('{12}') AND SDI_Code = ('{13}') AND VAT_Code = ('{14}' AND StatusCustomer = ('{15}') ", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10], param[11], param[12], param[13], param[14], param[15]);
                    stringWhere = strWhere;
                    break;

                case "CustomerState":
                    temp = strWhere;
                    strWhere = String.Format("WHERE StatusDescription = ('{0}')) ", param[0]);
                    stringWhere = strWhere;
                    break;

                case "InvoicesHead":
                    temp = strWhere;
                    strWhere = String.Format("WHERE IDCustomer = ('{0}') AND TotalPrice = ('{1}') AND DiscountedPrice = ('{2}') ) ", param[0], param[1], param[2]);
                    stringWhere = strWhere;
                    break;

                case "InvoicesRows":
                    temp = strWhere;
                    strWhere = String.Format("WHERE IDInvoice = ('{0}') AND IDProduct = ('{1}') AND Qta = ('{2}') AND Price = ('{3}') AND VAT = ('{4}') AND PriceSubTotal = ('{5}') AND TotalQta = ('{6}') ) ", param[0], param[1], param[2], param[3], param[4], param[5], param[6]);
                    stringWhere = strWhere;
                    break;

                case "GoodsValues":
                    temp = strWhere;
                    strWhere = String.Format("WHERE IDProduct = ('{0}') AND VAT = ('{1}') AND Price = ('{2}') AND DiscountPercentage = ('{3}') AND DiscountLimitNumbers = ('{4}') AND NetCost = ('{5}') AND NetNetCost = ('{6}') AND DateUpdateValue = ('{7}') AND TypeUpdateValue = ('{8}') ", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8]);
                    stringWhere = strWhere;
                    break;

                case "GoodsImages":
                    temp = strWhere;
                    strWhere = String.Format("WHERE IDProduct = ('{0}') AND ImageSingle = ('{1}') AND ImageBox = ('{2}') ", param[0], param[1], param[2]);
                    stringWhere = strWhere;
                    break;

                case "FoodGoods":
                    temp = strWhere;
                    strWhere = String.Format("WHERE DescriptionProduct = ('{0}') AND EAN = ('{1}') AND IDSupplier = ('{2}') AND IDCategory = ('{3}') ) ", param[0], param[1], param[2], param[3] );
                    stringWhere = strWhere;
                    break;

                case "FoodCategory":
                    temp = strWhere;
                    strWhere = String.Format("WHERE DescriptionCategory = ('{0}')) ", param[0]);
                    stringWhere = strWhere;
                    break;

                case "GoodsDimensions":
                    temp = strWhere;
                    strWhere = String.Format("WHERE IDProduct = ('{0}') AND NumbersInBox = ('{1}') AND DimensionSingleHeight = ('{2}') AND DimensionSingleBase = ('{3}') AND DimensionSingleDepth = ('{4}') AND DimensionBoxHeight = ('{5}') AND DimensionBoxBase = ('{6}') AND WeightSingle = ('{7}') AND WightBox = ('{8}') ) ", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8] );
                    stringWhere = strWhere;
                    break;

                case "GoodsUpdateValue":
                    temp = strWhere;
                    strWhere = String.Format("WHERE IDCustomer = ('{0}') AND IDSupplier = ('{1}') AND IDProduct = ('{2}') AND Qta = ('{3}') AND Price = ('{4}') AND DiscountPercentage = ('{5}') AND DiscountLimitNumbers = ('{6}') AND NetCost = ('{7}') AND NetNetCost = ('{8}') AND DateMovement = ('{9}') AND TypeMovement = ('{10}') ", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
                    stringWhere = strWhere;
                    break;


            }

            return stringWhere;
        }

        public string GetWhereString()
        {
            return strWhere;
        }

*/