using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DbManagment
{
    public class QueryTest
    {


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

        private string WhereConditionArchiveGoodsValue = string.Empty;
        private string WhereConditionArchiveMovements = string.Empty;
        private string WhereConditionCustomers = string.Empty;
        private string WhereConditionCustomerState = string.Empty;
        private string WhereConditionFoodCategory = string.Empty;
        private string WhereConditionFoodGoods = string.Empty;
        private string WhereConditionGoodsDimension = string.Empty;
        private string WhereConditionGoodsImages = string.Empty;
        private string WhereConditionGoodsUpdateValue = string.Empty;
        private string WhereConditionGoodsValues = string.Empty;
        private string WhereConditionInvoicesHead = string.Empty;
        private string WhereConditionInvoicesRows = string.Empty;
        private string WhereConditionMovements = string.Empty;
        private string WhereConditionSuppliers = string.Empty;
        private string WhereConditionTypeMovements = string.Empty;



        private string WhereParametersArchiveGoodsValue = string.Empty;

        private string WhereParametersArchiveGoodsValueAND = string.Empty;

        private string WhereParametersArchiveGoodsValueOR = string.Empty;

        private string WhereConditionToReturn = string.Empty;

        private string WhereParametersToReturn = string.Empty;

        private string queryToReturn = string.Empty;


        private List<String> param = new List<String>();
        private List<String> WhereParameters = new List<String>();
        private List<String> SelectParameters = new List<String>();
        private List<String> UpdateParameters = new List<String>();
        List<String> SelectListToReturn = new List<string>();


        public List<string> SelectUpdate(DataTable dt, int caseSelect, string updateValue)
        {
            DataTable table = dt;
            DataRow[] foundRows;
            List<String> tmp = new List<String>();
            List<String> ColumnNameMovements = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7], SelectParameters[8], SelectParameters[9], SelectParameters[10] };
            List<String> ColumnNameArchiveMovements = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7], SelectParameters[8], SelectParameters[9], SelectParameters[10] };
            List<String> ColumnNameCustomers = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7], SelectParameters[8], SelectParameters[9], SelectParameters[10], SelectParameters[11], SelectParameters[12], SelectParameters[13], SelectParameters[14], SelectParameters[15] };
            List<String> ColumnNameArchiveGoodsValue = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7] };
            List<String> ColumnNameFoodGoods = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3] };
            List<String> ColumnNameGoodsDimension = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7], SelectParameters[8], SelectParameters[9] };
            List<String> ColumnNameGoodsValue = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7], SelectParameters[8] };
            List<String> ColumnNameInvoicesHead = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2] };
            List<String> ColumnNameInvoicesRows = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6] };
            List<String> ColumnNameSuppliers = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7], SelectParameters[8], SelectParameters[9], SelectParameters[10], SelectParameters[11], SelectParameters[12], SelectParameters[13], SelectParameters[14] };
            List<String> ColumnNameGoodsImages = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2] };

            switch (caseSelect)
            {
                case 0:

                    foundRows = table.Select("IDMovement, IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement FROM Movements" + GetWhereCondition());

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDCustomer")
                            {
                                ColumnNameMovements[0] = updateValue;
                            }
                            else if (nome == "IDSupplier")
                            {
                                ColumnNameMovements[1] = updateValue;
                            }
                            else if (nome == "IDProduct")
                            {
                                ColumnNameMovements[2] = updateValue;
                            }
                            else if (nome == "Qta")
                            {
                                ColumnNameMovements[3] = updateValue;
                            }
                            else if (nome == "Price")
                            {
                                ColumnNameMovements[4] = updateValue;
                            }
                            else if (nome == "DiscountPercentage")
                            {
                                ColumnNameMovements[5] = updateValue;
                            }
                            else if (nome == "DiscountLimitNumbers")
                            {
                                ColumnNameMovements[6] = updateValue;
                            }
                            else if (nome == "NetCost")
                            {
                                ColumnNameMovements[7] = updateValue;
                            }
                            else if (nome == "NetNetCost")
                            {
                                ColumnNameMovements[8] = updateValue;
                            }
                            else if (nome == "DateMovement")
                            {
                                ColumnNameMovements[9] = updateValue;
                            }
                            else if (nome == "TypeMovement")
                            {
                                ColumnNameMovements[10] = updateValue;
                            }
                        }
                    }

                    return ColumnNameMovements;

                    break;

                case 1:

                    foundRows = table.Select("IDMovement, IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement FROM Movements" + GetWhereCondition());

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDCustomer")
                            {
                                ColumnNameArchiveMovements[0] = updateValue;
                            }
                            else if (nome == "IDSupplier")
                            {
                                ColumnNameArchiveMovements[1] = updateValue;
                            }
                            else if (nome == "IDProduct")
                            {
                                ColumnNameArchiveMovements[2] = updateValue;
                            }
                            else if (nome == "Qta")
                            {
                                ColumnNameArchiveMovements[3] = updateValue;
                            }
                            else if (nome == "Price")
                            {
                                ColumnNameArchiveMovements[4] = updateValue;
                            }
                            else if (nome == "DiscountPercentage")
                            {
                                ColumnNameArchiveMovements[5] = updateValue;
                            }
                            else if (nome == "DiscountLimitNumbers")
                            {
                                ColumnNameArchiveMovements[6] = updateValue;
                            }
                            else if (nome == "NetCost")
                            {
                                ColumnNameArchiveMovements[7] = updateValue;
                            }
                            else if (nome == "NetNetCost")
                            {
                                ColumnNameArchiveMovements[8] = updateValue;
                            }
                            else if (nome == "DateMovement")
                            {
                                ColumnNameArchiveMovements[9] = updateValue;
                            }
                            else if (nome == "TypeMovement")
                            {
                                ColumnNameArchiveMovements[10] = updateValue;
                            }
                        }
                    }

                    return ColumnNameArchiveMovements;

                    break;

                case 2:

                    foundRows = table.Select("IDCustomer, NameLegalOwner, SurnameLegalOwner, CompanyName, Address, CivicNumber, ZipCode, City, Region, Nation, Phone, Email, PEC, WebSite, SDI_Code, VAT_Code, StatusCustomer FROM Customers" + GetWhereCondition());

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "NameLegalOwner")
                            {
                                ColumnNameCustomers[0] = updateValue;
                            }
                            if (nome == "SurnameLegalOwner")
                            {
                                ColumnNameCustomers[1] = updateValue;
                            }
                            if (nome == "CompanyName")
                            {
                                ColumnNameCustomers[2] = updateValue;
                            }
                            if (nome == "Address")
                            {
                                ColumnNameCustomers[3] = updateValue;
                            }
                            if (nome == "CivicNumber")
                            {
                                ColumnNameCustomers[4] = updateValue;
                            }
                            if (nome == "ZipCode")
                            {
                                ColumnNameCustomers[5] = updateValue;
                            }
                            if (nome == "City")
                            {
                                ColumnNameCustomers[6] = updateValue;
                            }

                            if (nome == "Region")
                            {
                                ColumnNameCustomers[7] = updateValue;
                            }
                            if (nome == "Nation")
                            {
                                ColumnNameCustomers[8] = updateValue;
                            }
                            if (nome == "Phone")
                            {
                                ColumnNameCustomers[9] = updateValue;
                            }
                            if (nome == "Email")
                            {
                                ColumnNameCustomers[10] = updateValue;
                            }
                            if (nome == "PEC")
                            {
                                ColumnNameCustomers[11] = updateValue;
                            }
                            if (nome == "WebSite")
                            {
                                ColumnNameCustomers[12] = updateValue;
                            }
                            if (nome == "SDI_Code")
                            {
                                ColumnNameCustomers[13] = updateValue;
                            }
                            if (nome == "VAT_Code")
                            {
                                ColumnNameCustomers[14] = updateValue;
                            }
                            if (nome == "StatusCustomer")
                            {
                                ColumnNameCustomers[15] = updateValue;
                            }
                        }
                    }

                    return ColumnNameCustomers;

                    break;

                case 3:

                    foundRows = table.Select("IDValue, IDProduct, VAT, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateOldValue FROM ArchiveGoodsValue" + GetWhereCondition());

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDProduct")
                            {
                                ColumnNameArchiveGoodsValue[0] = updateValue;
                            }
                            if (nome == "VAT")
                            {
                                ColumnNameArchiveGoodsValue[1] = updateValue;
                            }
                            if (nome == "Qta")
                            {
                                ColumnNameArchiveGoodsValue[2] = updateValue;
                            }
                            if (nome == "Price")
                            {
                                ColumnNameArchiveGoodsValue[3] = updateValue;
                            }
                            if (nome == "DiscountPercentage")
                            {
                                ColumnNameArchiveGoodsValue[4] = updateValue;
                            }
                            if (nome == "DiscountLimitNumbers")
                            {
                                ColumnNameArchiveGoodsValue[5] = updateValue;
                            }
                            if (nome == "NetCost")
                            {
                                ColumnNameArchiveGoodsValue[6] = updateValue;
                            }
                            if (nome == "NetNetCost")
                            {
                                ColumnNameArchiveGoodsValue[7] = updateValue;
                            }
                            if (nome == "DateOldValue")
                            {
                                ColumnNameArchiveGoodsValue[8] = updateValue;
                            }
                        }
                    }

                    return ColumnNameArchiveGoodsValue;

                    break;

                case 4:

                    foundRows = table.Select("IDProduct, DescriptionProduct, EAN, IDSupplier, IDCategory FROM FoodGoods" + GetWhereCondition());

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DescriptionProduct")
                            {
                                ColumnNameFoodGoods[0] = updateValue;
                            }
                            if (nome == "EAN")
                            {
                                ColumnNameFoodGoods[1] = updateValue;
                            }
                            if (nome == "IDSupplier")
                            {
                                ColumnNameFoodGoods[2] = updateValue;
                            }
                            if (nome == "IDCategory")
                            {
                                ColumnNameFoodGoods[3] = updateValue;
                            }
                        }
                    }

                    return ColumnNameFoodGoods;

                    break;

                case 5:

                    foundRows = table.Select("IDDimension, IDProduct, NumbersInBox, DimensionSingleHeight, DimensionSingleBase, DimensionSingleDepth, DimensionBoxHeight, DimensionBoxBase, DimensionBoxDepth, WeightSingle, WightBox FROM GoodsDimension" + GetWhereCondition());

                    for (int i = 0; i < dt.Rows.Count; i++)

                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDProduct")
                            {
                                ColumnNameGoodsDimension[0] = updateValue;
                            }
                            if (nome == "NumbersInBox")
                            {
                                ColumnNameGoodsDimension[1] = updateValue;
                            }
                            if (nome == "DimensionSingleHeight")
                            {
                                ColumnNameGoodsDimension[2] = updateValue;
                            }
                            if (nome == "DimensionSingleBase")
                            {
                                ColumnNameGoodsDimension[3] = updateValue;
                            }
                            if (nome == "DimensionSingleDepth")
                            {
                                ColumnNameGoodsDimension[4] = updateValue;
                            }
                            if (nome == "DimensionBoxHeight")
                            {
                                ColumnNameGoodsDimension[5] = updateValue;
                            }
                            if (nome == "DimensionBoxBase")
                            {
                                ColumnNameGoodsDimension[6] = updateValue;
                            }
                            if (nome == "DimensionBoxDepth")
                            {
                                ColumnNameGoodsDimension[7] = updateValue;
                            }
                            if (nome == "WeightSingle")
                            {
                                ColumnNameGoodsDimension[8] = updateValue;
                            }
                            if (nome == "WightBox")
                            {
                                ColumnNameGoodsDimension[9] = updateValue;
                            }
                        }
                    }

                    return ColumnNameGoodsDimension;

                    break;

                case 6:

                    foundRows = table.Select("IDValue, IDProduct, VAT, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateUpdateValue, TypeUpdateValue FROM GoodsValue" + GetWhereCondition());

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDProduct")
                            {
                                ColumnNameGoodsValue[0] = updateValue;
                            }
                            if (nome == "VAT")
                            {
                                ColumnNameGoodsValue[1] = updateValue;
                            }
                            if (nome == "Qta")
                            {
                                ColumnNameGoodsValue[2] = updateValue;
                            }
                            if (nome == "Price")
                            {
                                ColumnNameGoodsValue[3] = updateValue;
                            }
                            if (nome == "DiscountPercentage")
                            {
                                ColumnNameGoodsValue[4] = updateValue;
                            }
                            if (nome == "DiscountLimitNumbers")
                            {
                                ColumnNameGoodsValue[5] = updateValue;
                            }
                            if (nome == "NetCost")
                            {
                                ColumnNameGoodsValue[6] = updateValue;
                            }
                            if (nome == "NetNetCost")
                            {
                                ColumnNameGoodsValue[7] = updateValue;
                            }
                            if (nome == "DateUpdateValue")
                            {
                                ColumnNameGoodsValue[8] = updateValue;
                            }
                            if (nome == "TyteUpdateValue")
                            {
                                ColumnNameGoodsValue[9] = updateValue;
                            }
                        }
                    }

                    return ColumnNameGoodsValue;

                    break;


                case 7:

                    foundRows = table.Select("IDInvoice, IDCustomer, TotalPrice, DiscountedPrice FROM InvoicesHead" + GetWhereCondition());

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDCustomer")
                            {
                                ColumnNameInvoicesHead[0] = updateValue;
                            }
                            if (nome == "TotalPrice")
                            {
                                ColumnNameInvoicesHead[1] = updateValue;
                            }
                            if (nome == "DiscountedPrice")
                            {
                                ColumnNameInvoicesHead[2] = updateValue;
                            }
                        }
                    }

                    return ColumnNameInvoicesHead;

                    break;

                case 8:

                    foundRows = table.Select("IDInvoiceRows, IDInvoice, IDProduct, Qta, Price, VAT, PriceSubTotal, TotalQta FROM InvoicesRows" + GetWhereCondition());

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDInvoice")
                            {
                                ColumnNameInvoicesRows[0] = updateValue;
                            }
                            if (nome == "IDProduct")
                            {
                                ColumnNameInvoicesRows[1] = updateValue;
                            }
                            if (nome == "Qta")
                            {
                                ColumnNameInvoicesRows[2] = updateValue;
                            }
                            if (nome == "Price")
                            {
                                ColumnNameInvoicesRows[3] = updateValue;
                            }
                            if (nome == "VAT")
                            {
                                ColumnNameInvoicesRows[4] = updateValue;
                            }
                            if (nome == "PriceSubTotal")
                            {
                                ColumnNameInvoicesRows[5] = updateValue;
                            }
                            if (nome == "TotalQta")
                            {
                                ColumnNameInvoicesRows[6] = updateValue;
                            }

                        }
                    }

                    return ColumnNameInvoicesRows;

                    break;

                case 9:

                    foundRows = table.Select("IDCustomer, NameLegalOwner, SurnameLegalOwner, CompanyName, Address, CivicNumber, ZipCode, City, Region, Nation, Phone, Email, PEC, WebSite, SDI_Code, VAT_Code FROM Suppliers" + GetWhereCondition());

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "NameLegalOwner")
                            {
                                ColumnNameSuppliers[0] = updateValue;
                            }
                            if (nome == "SurnameLegalOwner")
                            {
                                ColumnNameSuppliers[1] = updateValue;
                            }
                            if (nome == "CompanyName")
                            {
                                ColumnNameSuppliers[2] = updateValue;
                            }
                            if (nome == "Address")
                            {
                                ColumnNameSuppliers[3] = updateValue;
                            }
                            if (nome == "CivicNumber")
                            {
                                ColumnNameSuppliers[4] = updateValue;
                            }
                            if (nome == "ZipCode")
                            {
                                ColumnNameSuppliers[5] = updateValue;
                            }
                            if (nome == "City")
                            {
                                ColumnNameSuppliers[6] = updateValue;
                            }

                            if (nome == "Region")
                            {
                                ColumnNameSuppliers[7] = updateValue;
                            }
                            if (nome == "Nation")
                            {
                                ColumnNameSuppliers[8] = updateValue;
                            }
                            if (nome == "Phone")
                            {
                                ColumnNameSuppliers[9] = updateValue;
                            }
                            if (nome == "Email")
                            {
                                ColumnNameSuppliers[10] = updateValue;
                            }
                            if (nome == "PEC")
                            {
                                ColumnNameSuppliers[11] = updateValue;
                            }
                            if (nome == "WebSite")
                            {
                                ColumnNameSuppliers[12] = updateValue;
                            }
                            if (nome == "SDI_Code")
                            {
                                ColumnNameSuppliers[13] = updateValue;
                            }
                            if (nome == "VAT_Code")
                            {
                                ColumnNameSuppliers[14] = updateValue;
                            }

                            
                        }
                    }

                    return ColumnNameSuppliers;

                case 10:

                    foundRows = table.Select("IDImage, IDProduct, ImageSingle, ImageBox FROM GoodsImages" + GetWhereCondition());

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDProduct")
                            {
                                ColumnNameGoodsImages[0] = updateValue;

                                if (nome == "ImageSingle")
                                {
                                    ColumnNameGoodsImages[1] = updateValue;
                                }
                                if (nome == "ImageBox")
                                {
                                    ColumnNameGoodsImages[2] = updateValue;
                                }
                                
                            }
                        } 

                    }

                    return ColumnNameGoodsImages;                   

                default:
                    throw new Exception();
            }

            return tmp;
        }

            public string SetWhereCondition(int dataToAnalyze, List<string> tableDataCondition, List<string> tableParameterCondition, string op)
            {
                string Cond = string.Empty;
                string temp = string.Empty;

                string conditionWhere = " WHERE ";

                switch (dataToAnalyze)
                {
                    case 0:

                        if (!String.IsNullOrEmpty(tableParameterCondition[0].ToString().Trim()))
                        {
                            temp = WhereConditionArchiveGoodsValue;
                            WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " {0} " + op + "  '{1}' ", tableDataCondition[0], tableParameterCondition[0]);
                            conditionWhere = WhereConditionArchiveGoodsValue;
                            Cond = WhereConditionArchiveGoodsValue;
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(tableParameterCondition[1].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveGoodsValue;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))
                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                else
                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " AND {0} " + op + "  '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                conditionWhere = WhereConditionArchiveGoodsValue;
                                Cond = WhereConditionArchiveGoodsValue;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[2].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveGoodsValue;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                else
                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                conditionWhere = WhereConditionArchiveGoodsValue;
                                Cond = WhereConditionArchiveGoodsValue;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[3].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveGoodsValue;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                else
                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                conditionWhere = WhereConditionArchiveGoodsValue;
                                Cond = WhereConditionArchiveGoodsValue;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[4].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveGoodsValue;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))
                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                else
                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                conditionWhere = WhereConditionArchiveGoodsValue;
                                Cond = WhereConditionArchiveGoodsValue;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[5].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveGoodsValue;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))
                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                else
                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                    Cond = WhereConditionArchiveGoodsValue;
                                }
                                conditionWhere = WhereConditionArchiveGoodsValue;
                                Cond = WhereConditionArchiveGoodsValue;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[6].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveGoodsValue;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                else
                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                conditionWhere = WhereConditionArchiveGoodsValue;
                                Cond = WhereConditionArchiveGoodsValue;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[7].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveGoodsValue;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                else
                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                conditionWhere = WhereConditionArchiveGoodsValue;
                                Cond = WhereConditionArchiveGoodsValue;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[8].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveGoodsValue;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[8], tableParameterCondition[8]);
                                }
                                else
                                {
                                    WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[8], tableParameterCondition[8]);
                                }
                                conditionWhere = WhereConditionArchiveGoodsValue;
                                Cond = WhereConditionArchiveGoodsValue;
                            }

                        }

                        break;


                    case 1:

                        if (!String.IsNullOrEmpty(tableParameterCondition[0].ToString().Trim()))
                        {
                            temp = WhereConditionArchiveMovements;
                            WhereConditionArchiveMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[0], tableParameterCondition[0]);
                            Cond = WhereConditionArchiveMovements;
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(tableParameterCondition[1].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                else
                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                conditionWhere = WhereConditionArchiveMovements;
                                Cond = WhereConditionArchiveMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[2].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                else
                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                conditionWhere = WhereConditionArchiveMovements;
                                Cond = WhereConditionArchiveMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[3].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                else
                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                conditionWhere = WhereConditionArchiveMovements;
                                Cond = WhereConditionArchiveMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[4].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                else
                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                conditionWhere = WhereConditionArchiveMovements;
                                Cond = WhereConditionArchiveMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[5].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                else
                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                conditionWhere = WhereConditionArchiveMovements;
                                Cond = WhereConditionArchiveMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[6].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                else
                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                conditionWhere = WhereConditionArchiveMovements;
                                Cond = WhereConditionArchiveMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[7].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                else
                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                conditionWhere = WhereConditionArchiveMovements;
                                Cond = WhereConditionArchiveMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[8].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[8], tableParameterCondition[8]);
                                }
                                else
                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[8], tableParameterCondition[8]);
                                }
                                conditionWhere = WhereConditionArchiveMovements;
                                Cond = WhereConditionArchiveMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[9].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[9], tableParameterCondition[9]);
                                }
                                else
                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[9], tableParameterCondition[9]);
                                }
                                conditionWhere = WhereConditionArchiveMovements;
                                Cond = WhereConditionArchiveMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[10].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[10], tableParameterCondition[10]);
                                }
                                else
                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[10], tableParameterCondition[10]);
                                }
                                conditionWhere = WhereConditionArchiveMovements;
                                Cond = WhereConditionArchiveMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[11].ToString().Trim()))
                            {
                                temp = WhereConditionArchiveMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[11], tableParameterCondition[11]);
                                }
                                else
                                {
                                    WhereConditionArchiveMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[11], tableParameterCondition[11]);
                                }
                                conditionWhere = WhereConditionArchiveMovements;
                                Cond = WhereConditionArchiveMovements;

                            }

                        }

                        break;


                    case 2:

                        if (!String.IsNullOrEmpty(tableParameterCondition[0].ToString().Trim()))
                        {
                            temp = WhereConditionCustomers;
                            WhereConditionCustomers = String.Format(conditionWhere + " {0} = '{1}' ", tableDataCondition[0], tableParameterCondition[0]);
                            Cond = WhereConditionCustomers;
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(tableParameterCondition[1].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[2].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[3].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[4].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[5].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[6].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[7].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[8].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[8], tableParameterCondition[8]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[8], tableParameterCondition[8]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[9].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[9], tableParameterCondition[9]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[9], tableParameterCondition[9]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[10].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[10], tableParameterCondition[10]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[10], tableParameterCondition[10]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[11].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[11], tableParameterCondition[11]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[11], tableParameterCondition[11]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[12].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[12], tableParameterCondition[12]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[12], tableParameterCondition[12]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[13].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[13], tableParameterCondition[13]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[13], tableParameterCondition[13]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[14].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[14], tableParameterCondition[14]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[14], tableParameterCondition[14]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[15].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[15], tableParameterCondition[15]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[15], tableParameterCondition[15]);
                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[16].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[16], tableParameterCondition[16]);
                                }
                                else
                                {
                                    WhereConditionCustomers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[16], tableParameterCondition[16]);

                                }
                                conditionWhere = WhereConditionCustomers;
                                Cond = WhereConditionCustomers;
                            }

                        }

                        break;

                    case 3:

                        if (!String.IsNullOrEmpty(tableParameterCondition[0].ToString().Trim()))
                        {
                            temp = WhereConditionFoodGoods;
                            WhereConditionFoodGoods = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[0], tableParameterCondition[0]);
                            Cond = WhereConditionFoodGoods;
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(tableParameterCondition[1].ToString().Trim()))
                            {
                                temp = WhereConditionFoodGoods;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionFoodGoods = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                else
                                {
                                    WhereConditionFoodGoods = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                conditionWhere = WhereConditionFoodGoods;
                                Cond = WhereConditionFoodGoods;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[2].ToString().Trim()))
                            {
                                temp = WhereConditionFoodGoods;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionFoodGoods = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                else
                                {
                                    WhereConditionFoodGoods = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                conditionWhere = WhereConditionFoodGoods;
                                Cond = WhereConditionArchiveMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[3].ToString().Trim()))
                            {
                                temp = WhereConditionFoodGoods;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionFoodGoods = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                else
                                {
                                    WhereConditionFoodGoods = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                conditionWhere = WhereConditionFoodGoods;
                                Cond = WhereConditionFoodGoods;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[4].ToString().Trim()))
                            {
                                temp = WhereConditionFoodGoods;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionFoodGoods = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                else
                                {
                                    WhereConditionFoodGoods = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                conditionWhere = WhereConditionFoodGoods;
                                Cond = WhereConditionFoodGoods;
                            }

                        }

                        break;

                    case 4:

                        if (!String.IsNullOrEmpty(tableParameterCondition[0].ToString().Trim()))
                        {
                            temp = WhereConditionGoodsDimension;
                            WhereConditionGoodsDimension = String.Format(conditionWhere + " {0} = '{1}' ", tableDataCondition[0], tableParameterCondition[0]);
                            Cond = WhereConditionGoodsDimension;
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(tableParameterCondition[1].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsDimension;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                else
                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                conditionWhere = WhereConditionGoodsDimension;
                                Cond = WhereConditionGoodsDimension;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[2].ToString().Trim()))
                            {
                                temp = WhereConditionCustomers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                else
                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                conditionWhere = WhereConditionGoodsDimension;
                                Cond = WhereConditionGoodsDimension;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[3].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsDimension;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                else
                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                conditionWhere = WhereConditionGoodsDimension;
                                Cond = WhereConditionGoodsDimension;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[4].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsDimension;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                else
                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                conditionWhere = WhereConditionGoodsDimension;
                                Cond = WhereConditionGoodsDimension;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[5].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsDimension;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                else
                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                conditionWhere = WhereConditionGoodsDimension;
                                Cond = WhereConditionGoodsDimension;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[6].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsDimension;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                else
                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                conditionWhere = WhereConditionGoodsDimension;
                                Cond = WhereConditionGoodsDimension;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[7].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsDimension;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                else
                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                conditionWhere = WhereConditionGoodsDimension;
                                Cond = WhereConditionGoodsDimension;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[8].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsDimension;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[8], tableParameterCondition[8]);
                                }
                                else
                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[8], tableParameterCondition[8]);
                                }
                                conditionWhere = WhereConditionGoodsDimension;
                                Cond = WhereConditionGoodsDimension;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[9].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsDimension;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[9], tableParameterCondition[9]);
                                }
                                else
                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[9], tableParameterCondition[9]);
                                }
                                conditionWhere = WhereConditionGoodsDimension;
                                Cond = WhereConditionGoodsDimension;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[10].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsDimension;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[10], tableParameterCondition[10]);
                                }
                                else
                                {
                                    WhereConditionGoodsDimension = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[10], tableParameterCondition[10]);
                                }
                                conditionWhere = WhereConditionGoodsDimension;
                                Cond = WhereConditionGoodsDimension;
                            }
                        }

                        break;

                    case 5:

                        if (!String.IsNullOrEmpty(tableParameterCondition[0].ToString().Trim()))
                        {
                            temp = WhereConditionGoodsImages;
                            WhereConditionGoodsImages = String.Format(conditionWhere + " {0} = '{1}' ", tableDataCondition[0], tableParameterCondition[0]);
                            Cond = WhereConditionGoodsImages;
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(tableParameterCondition[1].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsImages;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsImages = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                else
                                {
                                    WhereConditionGoodsImages = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                conditionWhere = WhereConditionGoodsImages;
                                Cond = WhereConditionGoodsImages;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[2].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsImages;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsImages = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                else
                                {
                                    WhereConditionGoodsImages = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                conditionWhere = WhereConditionGoodsImages;
                                Cond = WhereConditionGoodsImages;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[3].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsImages;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsImages = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                else
                                {
                                    WhereConditionGoodsImages = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                conditionWhere = WhereConditionGoodsImages;
                                Cond = WhereConditionGoodsImages;
                            }
                        }

                        break;

                    case 6:

                        if (!String.IsNullOrEmpty(tableParameterCondition[0].ToString().Trim()))
                        {
                            temp = WhereConditionGoodsValues;
                            WhereConditionGoodsValues = String.Format(conditionWhere + " {0} = '{1}' ", tableDataCondition[0], tableParameterCondition[0]);
                            Cond = WhereConditionGoodsValues;
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(tableParameterCondition[1].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsValues;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                else
                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                conditionWhere = WhereConditionGoodsValues;
                                Cond = WhereConditionGoodsValues;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[2].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsValues;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                else
                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                conditionWhere = WhereConditionGoodsValues;
                                Cond = WhereConditionGoodsValues;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[3].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsValues;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                else
                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                conditionWhere = WhereConditionGoodsValues;
                                Cond = WhereConditionGoodsValues;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[4].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsValues;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                else
                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                conditionWhere = WhereConditionGoodsValues;
                                Cond = WhereConditionGoodsValues;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[5].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsValues;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                else
                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                conditionWhere = WhereConditionGoodsValues;
                                Cond = WhereConditionGoodsValues;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[6].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsValues;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                else
                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                conditionWhere = WhereConditionGoodsValues;
                                Cond = WhereConditionGoodsValues;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[7].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsValues;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                else
                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                conditionWhere = WhereConditionGoodsValues;
                                Cond = WhereConditionGoodsValues;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[8].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsValues;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[8], tableParameterCondition[8]);
                                }
                                else
                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[8], tableParameterCondition[8]);
                                }
                                conditionWhere = WhereConditionGoodsValues;
                                Cond = WhereConditionGoodsValues;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[9].ToString().Trim()))
                            {
                                temp = WhereConditionGoodsValues;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[9], tableParameterCondition[9]);
                                }
                                else
                                {
                                    WhereConditionGoodsValues = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[9], tableParameterCondition[9]);
                                }
                                conditionWhere = WhereConditionGoodsValues;
                                Cond = WhereConditionGoodsValues;
                            }
                        }

                        break;

                    case 7:

                        if (!String.IsNullOrEmpty(tableParameterCondition[0].ToString().Trim()))
                        {
                            temp = WhereConditionInvoicesHead;
                            WhereConditionInvoicesHead = String.Format(conditionWhere + " {0} = '{1}' ", tableDataCondition[0], tableParameterCondition[0]);
                            Cond = WhereConditionInvoicesHead;
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(tableParameterCondition[1].ToString().Trim()))
                            {
                                temp = WhereConditionInvoicesHead;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionInvoicesHead = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                else
                                {
                                    WhereConditionInvoicesHead = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                conditionWhere = WhereConditionInvoicesHead;
                                Cond = WhereConditionInvoicesHead;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[2].ToString().Trim()))
                            {
                                temp = WhereConditionInvoicesHead;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionInvoicesHead = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                else
                                {
                                    WhereConditionInvoicesHead = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                conditionWhere = WhereConditionInvoicesHead;
                                Cond = WhereConditionInvoicesHead;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[3].ToString().Trim()))
                            {
                                temp = WhereConditionInvoicesHead;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionInvoicesHead = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                else
                                {
                                    WhereConditionInvoicesHead = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                conditionWhere = WhereConditionInvoicesHead;
                                Cond = WhereConditionInvoicesHead;
                            }
                        }

                        break;

                    case 8:

                        if (!String.IsNullOrEmpty(tableParameterCondition[0].ToString().Trim()))
                        {
                            temp = WhereConditionInvoicesRows;
                            WhereConditionInvoicesRows = String.Format(conditionWhere + " {0} = '{1}' ", tableDataCondition[0], tableParameterCondition[0]);
                            Cond = WhereConditionInvoicesRows;
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(tableParameterCondition[1].ToString().Trim()))
                            {
                                temp = WhereConditionInvoicesRows;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionInvoicesRows = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                else
                                {
                                    WhereConditionInvoicesRows = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                conditionWhere = WhereConditionInvoicesRows;
                                Cond = WhereConditionInvoicesRows;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[2].ToString().Trim()))
                            {
                                temp = WhereConditionInvoicesRows;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionInvoicesRows = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                else
                                {
                                    WhereConditionInvoicesRows = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                conditionWhere = WhereConditionInvoicesRows;
                                Cond = WhereConditionInvoicesRows;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[3].ToString().Trim()))
                            {
                                temp = WhereConditionInvoicesRows;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionInvoicesRows = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                else
                                {
                                    WhereConditionInvoicesRows = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                conditionWhere = WhereConditionInvoicesRows;
                                Cond = WhereConditionInvoicesRows;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[4].ToString().Trim()))
                            {
                                temp = WhereConditionInvoicesRows;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionInvoicesRows = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                else
                                {
                                    WhereConditionInvoicesRows = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                conditionWhere = WhereConditionInvoicesRows;
                                Cond = WhereConditionInvoicesRows;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[5].ToString().Trim()))
                            {
                                temp = WhereConditionInvoicesRows;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionInvoicesRows = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                else
                                {
                                    WhereConditionInvoicesRows = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                conditionWhere = WhereConditionInvoicesRows;
                                Cond = WhereConditionInvoicesRows;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[6].ToString().Trim()))
                            {
                                temp = WhereConditionInvoicesRows;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionInvoicesRows = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                else
                                {
                                    WhereConditionInvoicesRows = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                conditionWhere = WhereConditionInvoicesRows;
                                Cond = WhereConditionInvoicesRows;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[7].ToString().Trim()))
                            {
                                temp = WhereConditionInvoicesRows;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionInvoicesRows = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                else
                                {
                                    WhereConditionInvoicesRows = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                conditionWhere = WhereConditionInvoicesRows;
                                Cond = WhereConditionInvoicesRows;
                            }
                        }

                        break;

                    case 9:

                        if (!String.IsNullOrEmpty(tableParameterCondition[0].ToString().Trim()))
                        {
                            temp = WhereConditionMovements;
                            WhereConditionMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[0], tableParameterCondition[0]);
                            Cond = WhereConditionMovements;
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(tableParameterCondition[1].ToString().Trim()))
                            {
                                temp = WhereConditionMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                else
                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                conditionWhere = WhereConditionMovements;
                                Cond = WhereConditionMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[2].ToString().Trim()))
                            {
                                temp = WhereConditionMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                else
                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                conditionWhere = WhereConditionMovements;
                                Cond = WhereConditionMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[3].ToString().Trim()))
                            {
                                temp = WhereConditionMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                else
                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                conditionWhere = WhereConditionMovements;
                                Cond = WhereConditionMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[4].ToString().Trim()))
                            {
                                temp = WhereConditionMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                else
                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                conditionWhere = WhereConditionMovements;
                                Cond = WhereConditionMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[5].ToString().Trim()))
                            {
                                temp = WhereConditionMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                else
                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                conditionWhere = WhereConditionMovements;
                                Cond = WhereConditionMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[6].ToString().Trim()))
                            {
                                temp = WhereConditionMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                else
                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                conditionWhere = WhereConditionMovements;
                                Cond = WhereConditionMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[7].ToString().Trim()))
                            {
                                temp = WhereConditionMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                else
                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                conditionWhere = WhereConditionMovements;
                                Cond = WhereConditionMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[8].ToString().Trim()))
                            {
                                temp = WhereConditionMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[8], tableParameterCondition[8]);
                                }
                                else
                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[8], tableParameterCondition[8]);
                                }
                                conditionWhere = WhereConditionMovements;
                                Cond = WhereConditionMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[9].ToString().Trim()))
                            {
                                temp = WhereConditionMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[9], tableParameterCondition[9]);
                                }
                                else
                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[9], tableParameterCondition[9]);
                                }
                                conditionWhere = WhereConditionMovements;
                                Cond = WhereConditionMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[10].ToString().Trim()))
                            {
                                temp = WhereConditionMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[10], tableParameterCondition[10]);
                                }
                                else
                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[10], tableParameterCondition[10]);
                                }
                                conditionWhere = WhereConditionMovements;
                                Cond = WhereConditionMovements;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[11].ToString().Trim()))
                            {
                                temp = WhereConditionMovements;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[11], tableParameterCondition[11]);
                                }
                                else
                                {
                                    WhereConditionMovements = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[11], tableParameterCondition[11]);
                                }
                                conditionWhere = WhereConditionMovements;
                                Cond = WhereConditionMovements;

                            }

                        }


                        break;

                    case 10:

                        if (!String.IsNullOrEmpty(tableParameterCondition[0].ToString().Trim()))
                        {
                            temp = WhereConditionSuppliers;
                            WhereConditionSuppliers = String.Format(conditionWhere + " {0} = '{1}' ", tableDataCondition[0], tableParameterCondition[0]);
                            Cond = WhereConditionSuppliers;
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(tableParameterCondition[1].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[2].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[2], tableParameterCondition[2]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[3].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[3], tableParameterCondition[3]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[4].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[4], tableParameterCondition[4]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[5].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[5], tableParameterCondition[5]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[6].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[6], tableParameterCondition[6]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[7].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[7], tableParameterCondition[7]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[8].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[8], tableParameterCondition[8]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[8], tableParameterCondition[8]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[9].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[9], tableParameterCondition[9]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[9], tableParameterCondition[9]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[10].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[10], tableParameterCondition[10]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[10], tableParameterCondition[10]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[11].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[11], tableParameterCondition[11]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[11], tableParameterCondition[11]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[12].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[12], tableParameterCondition[12]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[12], tableParameterCondition[12]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[13].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[13], tableParameterCondition[13]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[13], tableParameterCondition[13]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[14].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[14], tableParameterCondition[14]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[14], tableParameterCondition[14]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                            if (!String.IsNullOrEmpty(tableParameterCondition[15].ToString().Trim()))
                            {
                                temp = WhereConditionSuppliers;

                                if (conditionWhere.Trim().Contains("WHERE") && (!conditionWhere.Contains("=") || conditionWhere.Contains("BETWEEN") || conditionWhere.Contains("AND") || conditionWhere.Contains("or") || conditionWhere.Contains("NOT") || conditionWhere.Contains("LIKE") || conditionWhere.Contains("NOT LIKE")))

                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " {0} " + op + " '{1}' ", tableDataCondition[15], tableParameterCondition[15]);
                                }
                                else
                                {
                                    WhereConditionSuppliers = String.Format(conditionWhere + " AND {0} " + op + " '{1}' ", tableDataCondition[15], tableParameterCondition[15]);
                                }
                                conditionWhere = WhereConditionSuppliers;
                                Cond = WhereConditionSuppliers;
                            }

                        }

                        break;

                    default:

                        throw new Exception();

                }
                return Cond;
            }

            public QueryTest(DataTable dt, int data, string updateValue)
            {
                SelectListToReturn = SelectUpdate(dt, data, updateValue);
            }
            
            public string GetWhereCondition()//string cond)
            {
               // WhereConditionToReturn = cond;
                return WhereConditionToReturn;
            }
          
            public string SetQuery(string QueryDaFare, List<String> parametri)
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

                        UpdateMovements = String.Format("UPDATE Movements SET IDCustomer = '{0}', IDSupplier = '{1}',  IDProduct = '{2}',  Qta = '{3}',  Price = '{4}',  DiscountPercentage = '{5}',  (DiscountLimitNumbers) = '{6}',  NetCost = '{7}',  NetNetCost = '{8}',  DateMovement = '{9}',  TypeMovement = '{10}'  " + GetWhereCondition(), param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
                        qry = UpdateMovements;
                        break;

                    case "SelectMovements":
                        temp = SelectMovements;

                        SelectMovements = "SELECT (IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement) FROM Movements" + GetWhereCondition();
                        qry = SelectMovements;
                        break;

                    case "DeleteMovements":
                        temp = DeleteMovements;

                        DeleteMovements = "DELETE FROM Movements" + GetWhereCondition();
                        qry = DeleteMovements;
                        break;

                    case "InsertIntoArchiveMovements":
                        temp = InsertIntoArchiveMovements;

                        InsertIntoArchiveMovements = String.Format("INSERT INTO ArchiveMovements(IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
                        qry = InsertIntoArchiveMovements;
                        break;

                    case "UpdateArchiveMovements":
                        temp = UpdateArchiveMovements;

                        UpdateArchiveMovements = String.Format("UPDATE ArchiveMovements SET IDCustomer = '{0}', SET IDSupplier = '{1}', SET IDProduct = '{2}', SET Qta = '{3}', SET Price = '{4}', SET DiscountPercentage = '{5}', SET DiscountLimitNumbers = '{6}', SET NetCost = '{7}', SET NetNetCost = '{8}', SET DateMovement = '{9}', SET TypeMovement = '{10}'  " + GetWhereCondition(), param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
                        qry = UpdateArchiveMovements;
                        break;

                    case "SelectArchiveMovements":
                        temp = SelectArchiveMovements;

                        SelectArchiveMovements = "SELECT (IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement) FROM ArchiveMovements" + GetWhereCondition();
                        qry = SelectArchiveMovements;
                        break;

                    case "DeleteArchiveMovements":
                        temp = DeleteArchiveMovements;

                        DeleteArchiveMovements = "DELETE FROM ArchiveMovements" + GetWhereCondition();
                        qry = DeleteArchiveMovements;
                        break;

                    case "InsertIntoArchiveGoodsValue":
                        temp = InsertIntoArchiveGoodsValue;

                        InsertIntoArchiveGoodsValue = String.Format("INSERT INTO ArchiveGoodsValue(IDProduct, VAT, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateOldValue) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7]);
                        qry = InsertIntoArchiveGoodsValue;
                        break;

                    case "UpdateArchiveGoodsValue":
                        temp = UpdateArchiveGoodsValue;

                        UpdateArchiveGoodsValue = String.Format("UPDATE ArchiveGoodsValue SET IDProduct = '{0}', VAT = '{1}',  Price = '{2}',  Qta = '{3}',  DiscountPercentage = '{4}',  DiscountLimitNumbers = '{5}',  NetCost = '{6}',  NetNetCost = '{7}',  DateOldValue = '{8}' " + GetWhereCondition(), UpdateParameters[0], UpdateParameters[1], UpdateParameters[2], UpdateParameters[3], UpdateParameters[4], UpdateParameters[5], UpdateParameters[6], UpdateParameters[7], UpdateParameters[8]);
                        qry = UpdateArchiveGoodsValue;
                        break;

                    case "SelectArchiveGoodsValue":
                        temp = SelectArchiveGoodsValue;

                        SelectArchiveGoodsValue = "SELECT * FROM ArchiveGoodsValue" + GetWhereCondition();
                        qry = SelectArchiveGoodsValue;
                        break;

                    case "DeleteArchiveGoodsValue":
                        temp = DeleteArchiveGoodsValue;

                        DeleteArchiveGoodsValue = "DELETE FROM ArchiveGoodsValue" + GetWhereCondition();
                        qry = DeleteArchiveGoodsValue;
                        break;                  

                    case "InsertIntoSuppliers":
                        temp = InsertIntoSuppliers;

                        InsertIntoSuppliers = String.Format("INSERT INTO Suppliers(NameLegalOwner, SurnameLegalOwner, CompanyName, Address, CivicNumber, ZipCode, City, Region, Nation, Phone, Email, PEC, WebSite, SDI_Code, VAT_Code) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10], param[11], param[12], param[13], param[14]);
                        qry = InsertIntoSuppliers;
                        break;

                    case "UpdateSuppliers":
                        temp = UpdateSuppliers;

                        UpdateSuppliers = String.Format("UPDATE Suppliers SET NameLegalOwner = '{0}', SurnameLegalOwner = '{1}',  CompanyName = '{2}',  Address = '{3}',  CivicNumber = '{4}',  ZipCode = '{5}',  City = '{6}',  Region = '{7}',  Nation = '{8}',  Phone = '{9}',  Email = '{10}',  PEC = '{11}',  WebSite = '{12}',  SDI_Code = '{13}',  VAT_Code = '{14}' " + GetWhereCondition(), param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10], param[11], param[12], param[13], param[14]);
                        qry = UpdateSuppliers;
                        break;

                    case "SelectSuppliers":
                        temp = SelectSuppliers;

                        SelectSuppliers = "SELECT (NameLegalOwner, SurnameLegalOwner, CompanyName, Address, CivicNumber, ZipCode, City, Region, Nation, Phone, Email, PEC, WebSite, SDI_Code, VAT_Code) FROM Suppliers";
                        qry = SelectSuppliers;
                        break;

                    case "DeleteSuppliers":
                        temp = DeleteSuppliers;

                        DeleteSuppliers = "DELETE FROM Suppliers" + GetWhereCondition();
                        qry = DeleteSuppliers;
                        break;

                    case "InsertIntoCustomers":
                        temp = InsertIntoCustomers;

                        InsertIntoCustomers = String.Format("INSERT INTO Customers(NameLegalOwner, SurnameLegalOwner, CompanyName, Address, CivicNumber, ZipCode, City, Region, Nation, Phone, Email, PEC, WebSite, SDI_Code, VAT_Code, StatusCustomer) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10], param[11], param[12], param[13], param[14], param[15]);
                        qry = InsertIntoCustomers;
                        break;

                    case "UpdateCustomers":
                        temp = UpdateCustomers;

                        UpdateCustomers = String.Format("UPDATE Suppliers SET NameLegalOwner = '{0}', SurnameLegalOwner = '{1}',  CompanyName = '{2}',  Address = '{3}',  CivicNumber = '{4}',  ZipCode = '{5}',  City = '{6}',  Region = '{7}',  Nation = '{8}',  Phone = '{9}',  Email = '{10}',  PEC = '{11}',  WebSite = '{12}',  SDI_Code = '{13}',  VAT_Code = '{14}', StatusCustomer = '{15}' " + GetWhereCondition(), param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10], param[11], param[12], param[13], param[14], param[15]);
                        qry = UpdateCustomers;
                        break;

                    case "SelectCustomers":
                        temp = SelectCustomers;

                        SelectCustomers = "SELECT * FROM Customers" + GetWhereCondition();
                        qry = SelectCustomers;
                        break;

                    case "DeleteCustomers":
                        temp = DeleteCustomers;

                        DeleteCustomers = "DELETE FROM Customers" + GetWhereCondition();
                        qry = DeleteCustomers;
                        break;
                   
                    case "InsertIntoInvoicesHead":
                        temp = InsertIntoInvoicesHead;

                        InsertIntoInvoicesHead = String.Format("INSERT INTO InvoicesHead(IDCustomer, TotalPrice, DiscountedPrice) VALUES('{0}', '{1}', '{2}')", param[0], param[1], param[2]);
                        qry = InsertIntoInvoicesHead;
                        break;

                    case "UpdateInvoicesHead":
                        temp = UpdateInvoicesHead;

                        UpdateInvoicesHead = String.Format("UPDATE InvoicesHead SET IDCustomer = '{0}', TotalPrice = '{1}', DiscountedPrice = '{2}' " + GetWhereCondition(), param[0], param[1], param[2]);
                        qry = UpdateInvoicesHead;
                        break;

                    case "SelectInvoicesHead":
                        temp = SelectInvoicesHead;

                        SelectInvoicesHead = "SELECT * FROM InvoicesHead" + GetWhereCondition();
                        qry = SelectInvoicesHead;
                        break;

                    case "DeleteInvoicesHead":
                        temp = DeleteInvoicesHead;

                        DeleteInvoicesHead = "DELETE FROM InvoicesHead" + GetWhereCondition();
                        qry = DeleteInvoicesHead;
                        break;

                    case "InsertIntoInvoicesRows":
                        temp = InsertIntoInvoicesRows;

                        InsertIntoInvoicesRows = String.Format("INSERT INTO InvoicesRows(IDInvoice, IDProduct, Qta, Price, VAT, PriceSubTotal, TotalQta) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6]);
                        qry = InsertIntoInvoicesRows;
                        break;

                    case "UpdateInvoicesRows":
                        temp = UpdateInvoicesRows;

                        UpdateInvoicesRows = String.Format("UPDATE InvoicesRows SET IDInvoice = '{0}', IDProduct = '{1}', Qta = '{2}', Price = '{3}', VAT = '{4}', PriceSubTotal = '{5}', TotalQta = '{6}'" + GetWhereCondition(), param[0], param[1], param[2], param[3], param[4], param[5], param[6]);
                        qry = UpdateInvoicesRows;
                        break;

                    case "SelectInvoicesRows":
                        temp = SelectInvoicesRows;

                        SelectInvoicesRows ="SELECT * FROM InvoicesRows" + GetWhereCondition();
                        qry = SelectInvoicesRows;
                        break;

                    case "DeleteInvoicesRows":
                        temp = DeleteInvoicesRows;

                        DeleteInvoicesRows = "DELETE FROM InvoicesRows" + GetWhereCondition();
                        qry = DeleteInvoicesRows;
                        break;

                    case "InsertGoodsValues":
                        temp = InsertGoodsValues;

                        InsertGoodsValues = String.Format("INSERT INTO GoodsValues(IDProduct, VAT, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateUpdateValue, TypeUpdateValue) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8]);
                        qry = InsertGoodsValues;
                        break;

                    case "UpdateGoodsValues":
                        temp = UpdateGoodsValues;

                        UpdateGoodsValues = String.Format("UPDATE GoodsValues SET IDProduct = '{0}', VAT = '{1}',  Price = '{2}',  DiscountPercentage = '{3}',  DiscountLimitNumbers = '{4}',  NetCost = '{5}',  NetNetCost = '{6}',  DateUpdateValue = '{7}',  TypeUpdateValue = '{8}' " + GetWhereCondition(), param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8]);
                        qry = UpdateGoodsValues;
                        break;

                    case "SelectGoodsValues":
                        temp = SelectGoodsValues;

                        SelectGoodsValues = "SELECT * FROM GoodsValues" + GetWhereCondition();
                        qry = SelectGoodsValues;
                        break;

                    case "DeleteGoodsValues":
                        temp = DeleteGoodsValues;

                        DeleteGoodsValues = "DELETE FROM GoodsValues" + GetWhereCondition();
                        qry = DeleteGoodsValues;
                        break;

                    case "InsertFoodGoods":
                        temp = InsertFoodGoods;

                        InsertFoodGoods = String.Format("INSERT INTO FoodGoods(DescriptionProduct, EAN, IDSupplier, IDCategory) VALUES('{0}', '{1}', '{2}', '{3}')", param[0], param[1], param[2], param[3]);
                        qry = InsertFoodGoods;
                        break;

                    case "UpdateFoodGoods":
                        temp = UpdateFoodGoods;

                        UpdateFoodGoods = String.Format("UPDATE FoodGoods SET DescriptionProduct = '{0}', EAN = '{1}', IDSupplier = '{2}', IDCategory = '{3}' " + GetWhereCondition(), param[0], param[1], param[2], param[3]);
                        qry = UpdateFoodGoods;
                        break;

                    case "SelectFoodGoods":
                        temp = SelectFoodGoods;

                        SelectFoodGoods = "SELECT * FROM FoodGoods" + GetWhereCondition();
                        qry = SelectFoodGoods;
                        break;

                    case "DeleteFoodGoods":
                        temp = DeleteFoodGoods;

                        DeleteFoodGoods = "DELETE FROM FoodGoods" + GetWhereCondition();
                        qry = DeleteFoodGoods;
                        break;
                  
                    case "InsertGoodsImages":
                        temp = InsertGoodsImages;

                        InsertGoodsImages = String.Format("INSERT INTO GoodsImages(IDProduct, ImageSingle, ImageBox) VALUES('{0}', '{1}', '{2}')", param[0], param[1], param[2]);
                        qry = InsertGoodsImages;
                        break;

                    case "UpdateGoodsImages":
                        temp = UpdateGoodsImages;

                        UpdateGoodsImages = String.Format("UPDATE GoodsImages SET IDProduct = '{0}', ImageSingle = '{1}', ImageBox = '{2}' " + GetWhereCondition(), param[0], param[1], param[2], param[3]);
                        qry = UpdateGoodsImages;
                        break;

                    case "SelectGoodsImages":
                        temp = SelectGoodsImages;

                        SelectGoodsImages = "SELECT * FROM GoodsImages" + GetWhereCondition();
                        qry = SelectGoodsImages;
                        break;

                    case "DeleteGoodsImages":
                        temp = DeleteGoodsImages;

                        DeleteGoodsImages = "DELETE FROM GoodsImages" + GetWhereCondition();
                        qry = DeleteGoodsImages;
                        break;

                    case "InsertGoodsDimensions":
                        temp = InsertGoodsDimensions;

                        InsertGoodsDimensions = String.Format("INSERT INTO GoodsDimensions(IDProduct, NumbersInBox, DimensionSingleHeight, DimensionSingleBase, DimensionSingleDepth, DimensionBoxHeight, DimensionBoxBase, DimensionBoxDepth, WeightSingle, WightBox) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9]);
                        qry = InsertGoodsDimensions;
                        break;

                    case "UpdateGoodsDimensions":
                        temp = UpdateGoodsDimensions;

                        UpdateGoodsDimensions = String.Format("UPDATE GoodsDimensions SET IDProduct = '{0}', NumbersInBox = '{1}', DimensionSingleHeight = '{2}', DimensionSingleBase = '{3}', DimensionSingleDepth = '{4}', DimensionBoxHeight = '{5}', DimensionBoxDepth = '{6}', WeightSingle = '{7}', WightBox = '{8}'" + GetWhereCondition(), param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8]);
                        qry = UpdateGoodsDimensions;
                        break;

                    case "SelectGoodsDimensions":
                        temp = SelectGoodsDimensions;

                        SelectGoodsDimensions = "SELECT * FROM GoodsDimensions" + GetWhereCondition();
                        qry = SelectGoodsDimensions;
                        break;

                    case "DeleteGoodsDimensions":
                        temp = DeleteGoodsDimensions;

                        DeleteGoodsDimensions = "DELETE FROM GoodsDimensions" + GetWhereCondition();
                        qry = DeleteGoodsDimensions;
                        break;
                }
                return qry;
            }

            public QueryTest(string QueryDaFare, List<String> parametri)
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
