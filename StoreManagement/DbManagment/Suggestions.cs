using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DbManagment
{
    public class Suggestions
    {
        /*
         * public List<string> ArchiveGoodsValueSelect(DataTable dt, int caseSelect, string updateValue)
        {

            List<String> ColumnNameArchiveGoodsValue = new List<String>() { SelectParameters[0], SelectParameters[1], SelectParameters[2], SelectParameters[3], SelectParameters[4], SelectParameters[5], SelectParameters[6], SelectParameters[7] };
            DataTable table = dt;
            DataRow[] foundRows;
            

                    foundRows = table.Select("IDProduct, VAT, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateOldValue FROM ArchiveGoodsValue" + GetWhereCondition());

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
         */

        /*
         * public string ArchiveGoodsValueSelect(DataTable dt, int caseSelect)
        {

            DataTable table = dt;
            DataRow[] foundRows;

            string updateValue = string.Empty;

                    foundRows = table.Select("IDProduct, VAT, Price, DiscountPercentage, DiscountLimitNumbers, NetCost, NetNetCost, DateOldValue FROM ArchiveGoodsValue" + GetWhereCondition());

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
                                        updateValue = "IDProduct";
                                        ColumnNameArchiveGoodsValue[0] = updateValue;
                                    }
                                    return updateValue;
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
                                          updateValue = "VAT";
                                          ColumnNameArchiveGoodsValue[0] = updateValue;
                                        }
                                        return updateValue;
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
                                            updateValue = "Price";
                                            ColumnNameArchiveGoodsValue[0] = updateValue;
                                        }
                                        return updateValue;
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
                                            updateValue = "DiscountPercentage";
                                            ColumnNameArchiveGoodsValue[0] = updateValue;
                                        }
                                        return updateValue;
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
                                        updateValue = "DiscountLimitNumbers";
                                        ColumnNameArchiveGoodsValue[0] = updateValue;
                                    }
                                    return updateValue;
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
                                        updateValue = "NetCost";
                                        ColumnNameArchiveGoodsValue[0] = updateValue;
                                    }
                                    return updateValue;
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
                                        updateValue = "NetNetCost";
                                        ColumnNameArchiveGoodsValue[0] = updateValue;
                                    }
                                    return updateValue;
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
                                        updateValue = "NetNetCost";
                                        ColumnNameArchiveGoodsValue[0] = updateValue;
                                    }
                                    return updateValue;
                                }
                            }
                            break;

                        case 8:


                        default:

                            throw new Exception();
                    }
            return updateValue;
          
        }
         * 
         * */
    }
}
