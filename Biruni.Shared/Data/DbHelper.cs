using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Biruni.Shared;
using Biruni.Shared.Logging;

namespace Biruni.Shared.Data
{
    public static class DbHelper
    {
        public static string GenerateNewOrderID(string type, int tahun)
        {
            string result;
            string sql = "select max(cast(substring(orderno,patindex('%" + type + "%',orderno)+2,len(orderno)) as int))+1 " +
                "from orders where orderno like '" + Convert.ToInt32(tahun).ToString("0000") + "-" + type + "%'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, AppHelper.GetDbConnection()))
                {
                    cmd.Connection.Open();
                    int id = (int)cmd.ExecuteScalar();
                    result = Convert.ToInt32(tahun).ToString("0000") + "-" + type + Convert.ToInt32(id).ToString("0000");
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                result = Convert.ToInt32(tahun).ToString("0000") + "-" + type + "0001";
                Logger.ErrorRoutine(ex);
            }
            return result;
        }

        public static string GenerateNewCompanyID(string type)
        {
            string result;
            string sql = "select max(cast(substring([Code],3,len([Code])) as int))+1 " +
                "from companies where [Code] like '" + type + "%'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, AppHelper.GetDbConnection()))
                {
                    cmd.Connection.Open();
                    int id = (int)cmd.ExecuteScalar();
                    result = type + Convert.ToInt32(id).ToString("0000");
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                result = type + "0001";
                Logger.ErrorRoutine(ex);
            }
            return result;
        }

        public static string GenerateNewCurrencyID()
        {
            string type = "CT";
            string result;
            string sql = "select max(cast(substring([Code],3,len([Code])) as int))+1 " +
                "from currencies where [Code] like '" + type + "%'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, AppHelper.GetDbConnection()))
                {
                    cmd.Connection.Open();
                    int id = (int)cmd.ExecuteScalar();
                    result = type + Convert.ToInt32(id).ToString("0000");
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                result = type + "0001";
                Logger.ErrorRoutine(ex);
            }
            return result;
        }

        public static string GenerateNewItemID()
        {
            string type = "II";
            string result;
            string sql = "select max(cast(substring([Code],3,len([Code])) as int))+1 " +
                "from items where [Code] like '" + type + "%'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, AppHelper.GetDbConnection()))
                {
                    cmd.Connection.Open();
                    int id = (int)cmd.ExecuteScalar();
                    result = type + Convert.ToInt32(id).ToString("0000");
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                result = type + "0001";
                Logger.ErrorRoutine(ex);
            }
            return result;
        }

        public static string GenerateNewCategoryID()
        {
            string type = "IC";
            string result;
            string sql = "select max(cast(substring([Code],3,len([Code])) as int))+1 " +
                "from itemcategories where [Code] like '" + type + "%'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, AppHelper.GetDbConnection()))
                {
                    cmd.Connection.Open();
                    int id = (int)cmd.ExecuteScalar();
                    result = type + Convert.ToInt32(id).ToString("0000");
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                result = type + "0001";
                Logger.ErrorRoutine(ex);
            }
            return result;
        }

        public static string GenerateNewWarehouseID()
        {
            string type = "WH";
            string result;
            string sql = "select max(cast(substring([Code],3,len([Code])) as int))+1 " +
                "from warehouse where [Code] like '" + type + "%'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, AppHelper.GetDbConnection()))
                {
                    cmd.Connection.Open();
                    int id = (int)cmd.ExecuteScalar();
                    result = type + Convert.ToInt32(id).ToString("0000");
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                result = type + "0001";
                Logger.ErrorRoutine(ex);
            }
            return result;
        }

        public static string GenerateNewUnitMeasureID()
        {
            string type = "UM";
            string result;
            string sql = "select max(cast(substring([Code],3,len([Code])) as int))+1 " +
                "from unitmeasures where [Code] like '" + type + "%'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, AppHelper.GetDbConnection()))
                {
                    cmd.Connection.Open();
                    int id = (int)cmd.ExecuteScalar();
                    result = type + Convert.ToInt32(id).ToString("0000");
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                result = type + "0001";
                Logger.ErrorRoutine(ex);
            }
            return result;
        }

    }
}
