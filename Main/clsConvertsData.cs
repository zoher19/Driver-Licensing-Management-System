using BusinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject
{
    public static class clsConvertsData
    {

        public static int ConvertFromCountryNameToCountryID(string CountryName)
        {
            clsBCountries Country = clsBCountries.Find(CountryName);

            if (Country != null)
            {
                return Country.CountryID;
            }

            return 90;
        }
        public static string ConvertFromCountryIDToCountryName(int CountryID)
        {
            clsBCountries Country = clsBCountries.Find(CountryID);

            if (Country != null)
            {
                return Country.CountryName;
            }

            return "Jordan";
        }

        public static int ConvertBetweenApplicationTypeTitleToApplicationTypeID(string Title)
        {
            DataTable dt=clsBApplicationTypes.GetAllApplicationTypes();

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["ApplicationTypeTilte"].ToString() == Title)
                {
                    return Convert.ToInt32(dr["ApplicationTypeID"]);
                }
            }

            return 1;
        }
        public static DataTable FilterBy(DataTable Tables,string FillterBy,string value)
        {
            DataView dataView = Tables.DefaultView;
            try
            {
                dataView.RowFilter =$"{FillterBy} = '{value}'";
                Tables=dataView.ToTable();
            }
            catch (Exception ex)
            {
                Tables=null;
            }
            return Tables;
        }


    }
}
