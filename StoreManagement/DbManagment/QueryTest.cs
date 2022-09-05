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
        public List<String> ColumnNameArchiveGoodsValue = new List<String>();
        public List<String> ColumnNameMovements = new List<String>();
        public List<String> ColumnNameArchiveMovements = new List<String>();


        public List<string> ArchiveGoodsValueSelectUpdate(DataTable dt, int caseSelect, string updateValue)
        {

            List<String> ColumnNameArchiveGoodsValue = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7] };
            DataTable table = dt;
            DataRow[] foundRows;


            foundRows = table.Select("IDValue, IDProduct, VAT, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateOldValue FROM ArchiveGoodsValue" + GetWhereCondition());

            switch (caseSelect)
            {
                case 0:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDProduct")
                            {
                                ColumnNameArchiveGoodsValue[0] = updateValue;
                            }
                            return ColumnNameArchiveGoodsValue;
                        }
                    }

                    break;

                case 1:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "VAT")
                            {
                                ColumnNameArchiveGoodsValue[1] = updateValue;
                            }
                            return ColumnNameArchiveGoodsValue;
                        }
                    }

                    break;

                case 2:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Price")
                            {
                                ColumnNameArchiveGoodsValue[2] = updateValue;
                            }
                            return ColumnNameArchiveGoodsValue;
                        }
                    }

                    break;

                case 3:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DiscountPercentage")
                            {
                                ColumnNameArchiveGoodsValue[3] = updateValue;
                            }
                            return ColumnNameArchiveGoodsValue;
                        }
                    }

                    break;

                case 4:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DiscountLimitNumbers")
                            {
                                ColumnNameArchiveGoodsValue[4] = updateValue;
                            }
                            return ColumnNameArchiveGoodsValue;
                        }
                    }

                    break;

                case 5:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "NetCost")
                            {
                                ColumnNameArchiveGoodsValue[5] = updateValue;
                            }
                            return ColumnNameArchiveGoodsValue;
                        }
                    }
                    break;

                case 6:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "NetNetCost")
                            {
                                ColumnNameArchiveGoodsValue[6] = updateValue;
                            }
                            return ColumnNameArchiveGoodsValue;
                        }
                    }
                    break;

                case 7:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DateOldValue")
                            {
                                ColumnNameArchiveGoodsValue[7] = updateValue;
                            }
                            return ColumnNameArchiveGoodsValue;
                        }
                    }
                    break;

                default:

                    throw new Exception();
            }
            return ColumnNameArchiveGoodsValue;

        }
        public List<string> MovementsSelectUpdate(DataTable dt, int caseSelect, string updateValue)
        {
            List<String> ColumnNameMovements = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7], SelectParameters[8], SelectParameters[9], SelectParameters[10] };
            DataTable table = dt;
            DataRow[] foundRows;


            foundRows = table.Select("IDMovement, IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement FROM Movements" + GetWhereCondition());

            switch (caseSelect)
            {
                case 0:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDCustomer")
                            {
                                ColumnNameMovements[0] = updateValue;
                            }
                            return ColumnNameMovements;
                        }
                    }

                    break;

                case 1:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDSupplier")
                            {
                                ColumnNameMovements[1] = updateValue;
                            }
                            return ColumnNameMovements;
                        }
                    }

                    break;

                case 2:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDProduct")
                            {
                                ColumnNameMovements[2] = updateValue;
                            }
                            return ColumnNameMovements;
                        }
                    }

                    break;

                case 3:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Qta")
                            {
                                ColumnNameMovements[3] = updateValue;
                            }
                            return ColumnNameMovements;
                        }
                    }

                    break;

                case 4:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Price")
                            {
                                ColumnNameMovements[4] = updateValue;
                            }
                            return ColumnNameMovements;
                        }
                    }

                    break;

                case 5:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DiscountPercentage")
                            {
                                ColumnNameMovements[5] = updateValue;
                            }
                            return ColumnNameMovements;
                        }
                    }
                    break;

                case 6:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DiscountLimitNumbers")
                            {
                                ColumnNameMovements[6] = updateValue;
                            }
                            return ColumnNameMovements;
                        }
                    }
                    break;

                case 7:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "NetCost")
                            {
                                ColumnNameMovements[7] = updateValue;
                            }
                            return ColumnNameMovements;
                        }
                    }
                    break;

                case 8:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "NetNetCost")
                            {
                                ColumnNameMovements[7] = updateValue;
                            }
                            return ColumnNameMovements;
                        }
                    }
                    break;

                case 9:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DateMovement")
                            {
                                ColumnNameMovements[7] = updateValue;
                            }
                            return ColumnNameMovements;
                        }
                    }
                    break;

                case 10:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "TypeMovement")
                            {
                                ColumnNameMovements[7] = updateValue;
                            }
                            return ColumnNameMovements;
                        }
                    }
                    break;

                default:

                    throw new Exception();
            }
            return ColumnNameMovements;

        }
        public List<string> ArchiveMovementsSelectUpdate(DataTable dt, int caseSelect, string updateValue)
        {
            List<String> ColumnNameArchiveMovements = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7], SelectParameters[8], SelectParameters[9], SelectParameters[10] };
            DataTable table = dt;
            DataRow[] foundRows;


            foundRows = table.Select("IDMovement, IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement FROM Movements" + GetWhereCondition());

            switch (caseSelect)
            {
                case 0:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDCustomer")
                            {
                                ColumnNameArchiveMovements[0] = updateValue;
                            }
                            return ColumnNameArchiveMovements;
                        }
                    }

                    break;

                case 1:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDSupplier")
                            {
                                ColumnNameArchiveMovements[1] = updateValue;
                            }
                            return ColumnNameArchiveMovements;
                        }
                    }

                    break;

                case 2:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDProduct")
                            {
                                ColumnNameArchiveMovements[2] = updateValue;
                            }
                            return ColumnNameArchiveMovements;
                        }
                    }

                    break;

                case 3:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Qta")
                            {
                                ColumnNameArchiveMovements[3] = updateValue;
                            }
                            return ColumnNameArchiveMovements;
                        }
                    }

                    break;

                case 4:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Price")
                            {
                                ColumnNameArchiveMovements[4] = updateValue;
                            }
                            return ColumnNameArchiveMovements;
                        }
                    }

                    break;

                case 5:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DiscountPercentage")
                            {
                                ColumnNameArchiveMovements[5] = updateValue;
                            }
                            return ColumnNameArchiveMovements;
                        }
                    }
                    break;

                case 6:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DiscountLimitNumbers")
                            {
                                ColumnNameArchiveMovements[6] = updateValue;
                            }
                            return ColumnNameArchiveMovements;
                        }
                    }
                    break;

                case 7:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "NetCost")
                            {
                                ColumnNameArchiveMovements[7] = updateValue;
                            }
                            return ColumnNameArchiveMovements;
                        }
                    }
                    break;

                case 8:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "NetNetCost")
                            {
                                ColumnNameArchiveMovements[7] = updateValue;
                            }
                            return ColumnNameArchiveMovements;
                        }
                    }
                    break;

                case 9:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DateMovement")
                            {
                                ColumnNameArchiveMovements[7] = updateValue;
                            }
                            return ColumnNameArchiveMovements;
                        }
                    }
                    break;

                case 10:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "TypeMovement")
                            {
                                ColumnNameArchiveMovements[7] = updateValue;
                            }
                            return ColumnNameArchiveMovements;
                        }
                    }
                    break;

                default:

                    throw new Exception();
            }
            return ColumnNameArchiveMovements;

        }
        public List<string> CustomersSelectUpdate(DataTable dt, int caseSelect, string updateValue)
        {
            List<String> ColumnNameCustomers = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7], SelectParameters[8], SelectParameters[9], SelectParameters[10], SelectParameters[11], SelectParameters[12], SelectParameters[13], SelectParameters[14], SelectParameters[15] };
            DataTable table = dt;
            DataRow[] foundRows;


            foundRows = table.Select("NameLegalOwner, SurnameLegalOwner, CompanyName, Address, CivicNumber, ZipCode, City, Region, Nation, Phone, Email, PEC, WebSite, SDI_Code, VAT_Code, StatusCustomer FROM Customers" + GetWhereCondition());

            switch (caseSelect)
            {
                case 0:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "NameLegalOwner")
                            {
                                ColumnNameCustomers[0] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }

                    break;

                case 1:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "SurnameLegalOwner")
                            {
                                ColumnNameCustomers[1] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }

                    break;

                case 2:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "CompanyName")
                            {
                                ColumnNameCustomers[2] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }

                    break;

                case 3:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Address")
                            {
                                ColumnNameCustomers[3] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }

                    break;

                case 4:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "CivicNumber")
                            {
                                ColumnNameCustomers[4] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }

                    break;

                case 5:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "ZipCode")
                            {
                                ColumnNameCustomers[5] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }
                    break;

                case 6:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "City")
                            {
                                ColumnNameCustomers[6] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }
                    break;

                case 7:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Region")
                            {
                                ColumnNameCustomers[7] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }
                    break;

                case 8:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Nation")
                            {
                                ColumnNameCustomers[8] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }
                    break;

                case 9:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Phone")
                            {
                                ColumnNameCustomers[9] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }
                    break;

                case 10:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Email")
                            {
                                ColumnNameCustomers[10] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }
                    break;

                case 11:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "PEC")
                            {
                                ColumnNameCustomers[11] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }
                    break;

                case 12:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "WebSite")
                            {
                                ColumnNameCustomers[12] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }
                    break;

                case 13:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "SDI_Code")
                            {
                                ColumnNameCustomers[13] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }
                    break;

                case 14:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "VAT_Code")
                            {
                                ColumnNameCustomers[14] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }
                    break;

                case 15:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "StatusCustomer")
                            {
                                ColumnNameCustomers[15] = updateValue;
                            }
                            return ColumnNameCustomers;
                        }
                    }
                    break;

                default:

                    throw new Exception();
            }
            return ColumnNameCustomers;

        }
        public List<string> FoodGoodsSelectUpdate(DataTable dt, int caseSelect, string updateValue)
        {
            List<String> ColumnNameFoodGoods = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3]};
            DataTable table = dt;
            DataRow[] foundRows;


            foundRows = table.Select("IDProduct, DescriptionProduct, EAN, IDSupplier, IDCategory" + GetWhereCondition());

            switch (caseSelect)
            {
                case 0:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DescriptionProduct")
                            {
                                ColumnNameFoodGoods[0] = updateValue;
                            }
                            return ColumnNameFoodGoods;
                        }
                    }

                    break;

                case 1:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "EAN")
                            {
                                ColumnNameFoodGoods[1] = updateValue;
                            }
                            return ColumnNameFoodGoods;
                        }
                    }

                    break;

                case 2:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDSupplier")
                            {
                                ColumnNameFoodGoods[2] = updateValue;
                            }
                            return ColumnNameFoodGoods;
                        }
                    }

                    break;

                case 3:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDCategory")
                            {
                                ColumnNameFoodGoods[3] = updateValue;
                            }
                            return ColumnNameFoodGoods;
                        }
                    }

                    break;

                default:

                    throw new Exception();
            }
            return ColumnNameFoodGoods;

        }
        public List<string> GoodsDimensionSelectUpdate(DataTable dt, int caseSelect, string updateValue)
        {
            List<String> ColumnNameGoodsDimension = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7], SelectParameters[8], SelectParameters[9]};
            DataTable table = dt;
            DataRow[] foundRows;


            foundRows = table.Select("IDDimension, IDProduct, NumbersInBox, DimensionSingleHeight, DimensionSingleBase, DimensionSingleDepth, DimensionBoxHeight, DimensionBoxBase, DimensionBoxDepth, WeightSingle, WightBox FROM Movements" + GetWhereCondition());

            switch (caseSelect)
            {
                case 0:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDProduct")
                            {
                                ColumnNameGoodsDimension[0] = updateValue;
                            }
                            return ColumnNameGoodsDimension;
                        }
                    }

                    break;

                case 1:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "NumbersInBox")
                            {
                                ColumnNameGoodsDimension[1] = updateValue;
                            }
                            return ColumnNameGoodsDimension;
                        }
                    }

                    break;

                case 2:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DimensionSingleHeight")
                            {
                                ColumnNameGoodsDimension[2] = updateValue;
                            }
                            return ColumnNameGoodsDimension;
                        }
                    }

                    break;

                case 3:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DimensionSingleBase")
                            {
                                ColumnNameGoodsDimension[3] = updateValue;
                            }
                            return ColumnNameGoodsDimension;
                        }
                    }

                    break;

                case 4:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DimensionSingleDepth")
                            {
                                ColumnNameGoodsDimension[4] = updateValue;
                            }
                            return ColumnNameGoodsDimension;
                        }
                    }

                    break;

                case 5:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DimensionBoxHeight")
                            {
                                ColumnNameGoodsDimension[5] = updateValue;
                            }
                            return ColumnNameGoodsDimension;
                        }
                    }
                    break;

                case 6:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DimensionBoxBase")
                            {
                                ColumnNameGoodsDimension[6] = updateValue;
                            }
                            return ColumnNameGoodsDimension;
                        }
                    }
                    break;

                case 7:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DimensionBoxDepth")
                            {
                                ColumnNameGoodsDimension[7] = updateValue;
                            }
                            return ColumnNameGoodsDimension;
                        }
                    }
                    break;

                case 8:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "WeightSingle")
                            {
                                ColumnNameGoodsDimension[8] = updateValue;
                            }
                            return ColumnNameGoodsDimension;
                        }
                    }
                    break;

                case 9:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "WeightBox")
                            {
                                ColumnNameGoodsDimension[9] = updateValue;
                            }
                            return ColumnNameGoodsDimension;
                        }
                    }
                    break;

                
                default:

                    throw new Exception();
            }
            return ColumnNameGoodsDimension;

        }
        public List<string> GoodsValueSelectUpdate(DataTable dt, int caseSelect, string updateValue)
        {

            List<String> ColumnNameGoodsValue = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7], SelectParameters[8] };
            DataTable table = dt;
            DataRow[] foundRows;


            foundRows = table.Select("IDValue, IDProduct, VAT, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateUpdateValue, TypeUpdateValue FROM GoodsValue" + GetWhereCondition());

            switch (caseSelect)
            {
                case 0:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDProduct")
                            {
                                ColumnNameGoodsValue[0] = updateValue;
                            }
                            return ColumnNameGoodsValue;
                        }
                    }

                    break;

                case 1:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "VAT")
                            {
                                ColumnNameGoodsValue[1] = updateValue;
                            }
                            return ColumnNameGoodsValue;
                        }
                    }

                    break;

                case 2:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Price")
                            {
                                ColumnNameGoodsValue[2] = updateValue;
                            }
                            return ColumnNameGoodsValue;
                        }
                    }

                    break;

                case 3:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DiscountPercentage")
                            {
                                ColumnNameGoodsValue[3] = updateValue;
                            }
                            return ColumnNameGoodsValue;
                        }
                    }

                    break;

                case 4:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DiscountLimitNumbers")
                            {
                                ColumnNameGoodsValue[4] = updateValue;
                            }
                            return ColumnNameGoodsValue;
                        }
                    }

                    break;

                case 5:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "NetCost")
                            {
                                ColumnNameGoodsValue[5] = updateValue;
                            }
                            return ColumnNameGoodsValue;
                        }
                    }
                    break;

                case 6:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "NetNetCost")
                            {
                                ColumnNameGoodsValue[6] = updateValue;
                            }
                            return ColumnNameGoodsValue;
                        }
                    }
                    break;

                case 7:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DateUpdateValue")
                            {
                                ColumnNameGoodsValue[7] = updateValue;
                            }
                            return ColumnNameGoodsValue;
                        }
                    }
                    break;

                case 8:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "TypeUpdateValue")
                            {
                                ColumnNameGoodsValue[8] = updateValue;
                            }
                            return ColumnNameGoodsValue;
                        }
                    }
                    break;

                default:

                    throw new Exception();
            }
            return ColumnNameGoodsValue;

        }
        public List<string> InvoicesHeadSelectUpdate(DataTable dt, int caseSelect, string updateValue)
        {
            List<String> ColumnNameInvoicesHead = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2] };
            DataTable table = dt;
            DataRow[] foundRows;


            foundRows = table.Select("IDInvoice, IDCustomer, TotalPrice, DiscountedPrice FROM InvoicesHead" + GetWhereCondition());

            switch (caseSelect)
            {
                case 0:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDCustomer")
                            {
                                ColumnNameInvoicesHead[0] = updateValue;
                            }
                            return ColumnNameInvoicesHead;
                        }
                    }

                    break;

                case 1:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "TotalPrice")
                            {
                                ColumnNameInvoicesHead[1] = updateValue;
                            }
                            return ColumnNameInvoicesHead;
                        }
                    }

                    break;

                case 2:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "DiscountedPrice")
                            {
                                ColumnNameInvoicesHead[2] = updateValue;
                            }
                            return ColumnNameInvoicesHead;
                        }
                    }

                    break;

               
                default:

                    throw new Exception();
            }
            return ColumnNameInvoicesHead;

        }
        public List<string> InvoicesRowsSelectUpdate(DataTable dt, int caseSelect, string updateValue)
        {
            List<String> ColumnNameInvoicesRows = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6] };
            DataTable table = dt;
            DataRow[] foundRows;


            foundRows = table.Select("IDInvoiceRows, IDInvoice, IDProduct, Qta, Price, VAT, PriceSubTotal, TotalQta FROM InvoicesRows" + GetWhereCondition());

            switch (caseSelect)
            {
                case 0:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDInvoice")
                            {
                                ColumnNameInvoicesRows[0] = updateValue;
                            }
                            return ColumnNameInvoicesRows;
                        }
                    }

                    break;

                case 1:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDProduct")
                            {
                                ColumnNameInvoicesRows[1] = updateValue;
                            }
                            return ColumnNameInvoicesRows;
                        }
                    }

                    break;

                case 2:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Qta")
                            {
                                ColumnNameInvoicesRows[2] = updateValue;
                            }
                            return ColumnNameInvoicesRows;
                        }
                    }

                    break;

                case 3:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Price")
                            {
                                ColumnNameInvoicesRows[3] = updateValue;
                            }
                            return ColumnNameInvoicesRows;
                        }
                    }

                    break;

                case 4:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "VAT")
                            {
                                ColumnNameInvoicesRows[4] = updateValue;
                            }
                            return ColumnNameInvoicesRows;
                        }
                    }

                    break;

                case 5:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "PriceSubTotal")
                            {
                                ColumnNameInvoicesRows[5] = updateValue;
                            }
                            return ColumnNameInvoicesRows;
                        }
                    }

                    break;

                case 6:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "TotalQta")
                            {
                                ColumnNameInvoicesRows[6] = updateValue;
                            }
                            return ColumnNameInvoicesRows;
                        }
                    }

                    break;


                default:

                    throw new Exception();
            }
            return ColumnNameInvoicesRows;

        }
        public List<string> SuppliersSelectUpdate(DataTable dt, int caseSelect, string updateValue)
        {
            List<String> ColumnNameSuppliers = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7], SelectParameters[8], SelectParameters[9], SelectParameters[10], SelectParameters[11], SelectParameters[12], SelectParameters[13], SelectParameters[14] };
            DataTable table = dt;
            DataRow[] foundRows;


            foundRows = table.Select("NameLegalOwner, SurnameLegalOwner, CompanyName, Address, CivicNumber, ZipCode, City, Region, Nation, Phone, Email, PEC, WebSite, SDI_Code, VAT_Code FROM Suppliers" + GetWhereCondition());

            switch (caseSelect)
            {
                case 0:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "NameLegalOwner")
                            {
                                ColumnNameSuppliers[0] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }

                    break;

                case 1:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "SurnameLegalOwner")
                            {
                                ColumnNameSuppliers[1] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }

                    break;

                case 2:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "CompanyName")
                            {
                                ColumnNameSuppliers[2] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }

                    break;

                case 3:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Address")
                            {
                                ColumnNameSuppliers[3] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }

                    break;

                case 4:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "CivicNumber")
                            {
                                ColumnNameSuppliers[4] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }

                    break;

                case 5:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "ZipCode")
                            {
                                ColumnNameSuppliers[5] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }
                    break;

                case 6:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "City")
                            {
                                ColumnNameSuppliers[6] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }
                    break;

                case 7:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Region")
                            {
                                ColumnNameSuppliers[7] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }
                    break;

                case 8:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Nation")
                            {
                                ColumnNameSuppliers[8] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }
                    break;

                case 9:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Phone")
                            {
                                ColumnNameSuppliers[9] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }
                    break;

                case 10:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "Email")
                            {
                                ColumnNameSuppliers[10] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }
                    break;

                case 11:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "PEC")
                            {
                                ColumnNameSuppliers[11] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }
                    break;

                case 12:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "WebSite")
                            {
                                ColumnNameSuppliers[12] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }
                    break;

                case 13:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "SDI_Code")
                            {
                                ColumnNameSuppliers[13] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }
                    break;

                case 14:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "VAT_Code")
                            {
                                ColumnNameSuppliers[14] = updateValue;
                            }
                            return ColumnNameSuppliers;
                        }
                    }
                    break;

                default:

                    throw new Exception();
            }
            return ColumnNameSuppliers;

        }
        public List<string> GoodsImagesSelectUpdate(DataTable dt, int caseSelect, string updateValue)
        {
            List<String> ColumnNameGoodsImages = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2] };
            DataTable table = dt;
            DataRow[] foundRows;


            foundRows = table.Select("IDImage, IDProduct, ImageSingle, ImageBox FROM GoodsImages" + GetWhereCondition());

            switch (caseSelect)
            {
                case 0:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "IDProduct")
                            {
                                ColumnNameGoodsImages[0] = updateValue;
                            }
                            return ColumnNameGoodsImages;
                        }
                    }

                    break;

                case 1:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "ImageSingle")
                            {
                                ColumnNameGoodsImages[1] = updateValue;
                            }
                            return ColumnNameGoodsImages;
                        }
                    }

                    break;

                case 2:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string nome = dt.Rows[i].ItemArray[j].ToString().Trim();
                            if (nome == "ImageBox")
                            {
                                ColumnNameGoodsImages[2] = updateValue;
                            }
                            return ColumnNameGoodsImages;
                        }
                    }

                    break;


                default:

                    throw new Exception();
            }
            return ColumnNameGoodsImages;

        }


        public string SetArchiveGoodsValueWhereParameters(int tableToAnalyze, int caseToAnalyze, List<String> WParameters)
        {
            string WhereParams = string.Empty;
            WhereParametersArchiveGoodsValue = String.Format(" '{0}' ", WParameters[0]);

            switch (caseToAnalyze)
            {
                case 1:         
                    WhereParams = WhereParametersArchiveGoodsValue;
                    break;
                case 2:
                    WhereParametersArchiveGoodsValueAND = string.Format(" AND Price = '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 3:
                    WhereParametersArchiveGoodsValueAND = string.Format(" AND Price > '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 4:
                    WhereParametersArchiveGoodsValueAND = string.Format(" AND Price < '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 5:
                    WhereParametersArchiveGoodsValueAND = string.Format(" AND VAT = '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 6:
                    WhereParametersArchiveGoodsValueAND = string.Format(" AND VAT > '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 7:
                    WhereParametersArchiveGoodsValueAND = string.Format(" AND VAT < '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 8:
                    WhereParametersArchiveGoodsValueAND = string.Format(" AND DateOldValue = '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 9:
                    WhereParametersArchiveGoodsValueAND = string.Format(" AND DateOldValue > '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 10:
                    WhereParametersArchiveGoodsValueAND = string.Format(" AND DateOldValue < '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 11:
                    WhereParametersArchiveGoodsValueOR = string.Format(" OR Price = '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 12:
                    WhereParametersArchiveGoodsValueOR = string.Format(" OR Price > '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 13:
                    WhereParametersArchiveGoodsValueOR = string.Format(" OR Price < '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 14:
                    WhereParametersArchiveGoodsValueOR = string.Format(" OR VAT = '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 15:
                    WhereParametersArchiveGoodsValueOR = string.Format(" OR VAT > '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 16:
                    WhereParametersArchiveGoodsValueOR = string.Format(" OR VAT < '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 17:
                    WhereParametersArchiveGoodsValueOR = string.Format(" OR DateOldValue = '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 18:
                    WhereParametersArchiveGoodsValueOR = string.Format(" OR DateOldValue > '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
                case 19:
                    WhereParametersArchiveGoodsValueOR = string.Format(" OR DateOldValue < '{1}'", WParameters[1]);
                    WhereParams = WhereParametersArchiveGoodsValue + WhereParametersArchiveGoodsValueAND;
                    break;
            }


            return WhereParams;
        }

        public QueryTest(int table, int NumWhereParameters, List<String> WParameters)
        {
            WhereParameters = WParameters;
            WhereParametersToReturn = SetArchiveGoodsValueWhereParameters(table, NumWhereParameters, WhereParameters);
        }

        public string GetWhereParameters()
        {
            return WhereParametersToReturn;
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
                        WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " {0} "+ op +"  '{1}' ", tableDataCondition[0], tableParameterCondition[0]);
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
                                WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " {0} "+ op +" '{1}' ", tableDataCondition[1], tableParameterCondition[1]);
                            }
                            else
                            {
                                WhereConditionArchiveGoodsValue = String.Format(conditionWhere + " AND {0} "+ op +"  '{1}' ", tableDataCondition[1], tableParameterCondition[1]);                                
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

        public QueryTest(int data)
        {
            WhereConditionToReturn = SetArchiveGoodsValueWhereCondition(data);
        }

        public string GetWhereCondition()
        {
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

                    SelectMovements = String.Format("SELECT (IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement) FROM Movements" + GetWhereCondition());
                    qry = SelectMovements;
                    break;

                case "DeleteMovements":
                    temp = DeleteMovements;

                    DeleteMovements = String.Format("DELETE FROM Movements" + GetWhereCondition());
                    qry = DeleteMovements;
                    break;

                case "InsertIntoArchiveMovements":
                    temp = InsertIntoArchiveMovements;

                    InsertIntoArchiveMovements = String.Format("INSERT INTO ArchiveMovements(IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
                    qry = InsertIntoArchiveMovements;
                    break;

                case "UpdateArchiveMovements":
                    temp = UpdateArchiveMovements;

                    UpdateArchiveMovements = String.Format("UPDATE ArchiveMovements SET (IDCustomer) = ('{0}'), SET (IDSupplier) = ('{1}'), SET (IDProduct) = ('{2}'), SET (Qta) = ('{3}'), SET (Price) = ('{4}'), SET (DiscountPercentage) = ('{5}'), SET (DiscountLimitNumbers) = ('{6}'), SET (NetCost) = ('{7}'), SET (NetNetCost) = ('{8}'), SET (DateMovement) = ('{9}'), SET (TypeMovement) = ('{10}')  " + GetWhereCondition(), param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10]);
                    qry = UpdateArchiveMovements;
                    break;

                case "SelectArchiveMovements":
                    temp = SelectArchiveMovements;

                    SelectArchiveMovements = String.Format("Select (IDCustomer, IDSupplier, IDProduct, Qta, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateMovement, TypeMovement) FROM ArchiveMovements" + GetWhereCondition());
                    qry = SelectArchiveMovements;
                    break;

                case "DeleteArchiveMovements":
                    temp = DeleteArchiveMovements;

                    DeleteArchiveMovements = String.Format("DELETE FROM ArchiveMovements" + GetWhereCondition());
                    qry = DeleteArchiveMovements;
                    break;

                case "InsertIntoArchiveGoodsValue":
                    temp = InsertIntoArchiveGoodsValue;

                    InsertIntoArchiveGoodsValue = String.Format("INSERT INTO ArchiveGoodsValue(IDProduct, VAT, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateOldValue) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7]);
                    qry = InsertIntoArchiveGoodsValue;
                    break;

                case "UpdateArchiveGoodsValue":
                    temp = UpdateArchiveGoodsValue;

                    UpdateArchiveGoodsValue = String.Format("UPDATE ArchiveGoodsValue SET IDProduct = '{0}', VAT = '{1}',  Price = '{2}',  Qta = '{3}',  DiscountPercentage = '{4}',  DiscountLimitNumbers = '{5}',  NetCost = '{6}',  NetNetCost = '{7}',  DateOldValue = '{8}' " + GetWhereCondition(), ColumnNameArchiveGoodsValue[0], ColumnNameArchiveGoodsValue[1], ColumnNameArchiveGoodsValue[2], ColumnNameArchiveGoodsValue[3], ColumnNameArchiveGoodsValue[4], ColumnNameArchiveGoodsValue[5], ColumnNameArchiveGoodsValue[6], ColumnNameArchiveGoodsValue[7], ColumnNameArchiveGoodsValue[8]);
                    qry = UpdateArchiveGoodsValue;
                    break;

                case "SelectArchiveGoodsValue":
                    temp = SelectArchiveGoodsValue;

                    SelectArchiveGoodsValue = String.Format("SELECT * FROM ArchiveGoodsValue" + GetWhereCondition());
                    qry = SelectArchiveGoodsValue;
                    break;

                case "DeleteArchiveGoodsValue":
                    temp = DeleteArchiveGoodsValue;

                    DeleteArchiveGoodsValue = String.Format("DELETE FROM ArchiveGoodsValue" + GetWhereCondition());
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

                    InsertIntoSuppliers = String.Format("INSERT INTO Suppliers(NameLegalOwner, SurnameLegalOwner, CompanyName, Address, CivicNumber, ZipCode, City, Region, Nation, Phone, Email, PEC, WebSite, SDI_Code, VAT_Code) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}')", param[0], param[1], param[2], param[3], param[4], param[5], param[6], param[7], param[8], param[9], param[10], param[11], param[12], param[13], param[14]);
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
