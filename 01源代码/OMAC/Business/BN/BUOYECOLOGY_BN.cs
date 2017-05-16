﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;

namespace Business.BN
{
    /// <summary>
    /// 生态数据视图（浮标）
    /// </summary>
    public class BUOYECOLOGY_BN
    {
        /// <summary>
        /// 获取生态数据的标准：水质监测参数
        /// </summary>
        public Entity.BUOYECOLOGY GetModel(string deviceCode)
        {
            string sql = " SELECT STDTYPE FROM DEVICEATTACH WHERE DEVICECODE=:DEVICECODE ";
            DbAPI dbHelper = new DbAPI();
            OracleParameter[] parameters = {
                    new OracleParameter(":DEVICECODE",deviceCode)
			};

            try
            {
                dbHelper.OpenConn("");
                DataTable ds = dbHelper.GetDataTable(sql, parameters);
                dbHelper.CloseConn();

                if (ds.Rows.Count > 0)
                {
                    Entity.BUOYECOLOGY model = new Entity.BUOYECOLOGY();
                    if (ds.Rows[0]["STDTYPE"].ToString() != "")
                    {
                        string stdType = ds.Rows[0]["STDTYPE"].ToString();
                        StringBuilder strSql = new StringBuilder();

                        if (stdType == "1")
                        {
                            strSql.Append(" SELECT DATETIME,CURRENTTEM, WATERTEM, CTDTEM, SALINITY, CONDUCTIVITY, OXYGEN, PH, TURBIDITY, YLS, YLSTEM, UNDERWATERCO2, OXYGENCHEMICAL, MNO4, OXYGENBIOLOGY, NH3N, NO3, NO2, PO4, SIO3, PAHS, \"P\", N, C, S, ALKALINITY, SUSPENSION, CYANIDE, HG, CD, CR6, PB, \"AS\", YLSA, PHYCOCY, PHYCOER, COLIFORM, POTENTIAL, TOTALY, K40, CS134, CS137, CO60, CU, ZN, PHENOL, BOD5, ORGANIC, DETERGENTS, OIL, VIRUS, PETRO, DDT, PCBS, BENZOL, CHLO, ANTIBIOTIC, POISONA, POISONB ");
                            strSql.Append(" FROM BUOYECOLOGY_LV1 ");
                            strSql.Append(" WHERE DEVICECODE=:DEVICECODE ");
                            strSql.Append(" AND DATETIME=(SELECT MAX(DATETIME) DATETIME FROM BUOYECOLOGY_LV1 WHERE DEVICECODE=:DEVICECODE) ");
                        }
                        else if (stdType == "2")
                        {
                            strSql.Append(" SELECT DATETIME,CURRENTTEM, WATERTEM, CTDTEM, SALINITY, CONDUCTIVITY, OXYGEN, PH, TURBIDITY, YLS, YLSTEM, UNDERWATERCO2, OXYGENCHEMICAL, MNO4, OXYGENBIOLOGY, NH3N, NO3, NO2, PO4, SIO3, PAHS, \"P\", N, C, S, ALKALINITY, SUSPENSION, CYANIDE, HG, CD, CR6, PB, \"AS\", YLSA, PHYCOCY, PHYCOER, COLIFORM, POTENTIAL, TOTALY, K40, CS134, CS137, CO60, CU, ZN, PHENOL, BOD5, ORGANIC, DETERGENTS, OIL, VIRUS, PETRO, DDT, PCBS, BENZOL, CHLO, ANTIBIOTIC, POISONA, POISONB ");
                            strSql.Append(" FROM BUOYECOLOGY_LV2 ");
                            strSql.Append(" WHERE DEVICECODE=:DEVICECODE ");
                            strSql.Append(" AND DATETIME=(SELECT MAX(DATETIME) DATETIME FROM BUOYECOLOGY_LV2 WHERE DEVICECODE=:DEVICECODE) ");
                        }
                        else if (stdType == "3")
                        {
                            strSql.Append(" SELECT DATETIME,CURRENTTEM, WATERTEM, CTDTEM, SALINITY, CONDUCTIVITY, OXYGEN, PH, TURBIDITY, YLS, YLSTEM, UNDERWATERCO2, OXYGENCHEMICAL, MNO4, OXYGENBIOLOGY, NH3N, NO3, NO2, PO4, SIO3, PAHS, \"P\", N, C, S, ALKALINITY, SUSPENSION, CYANIDE, HG, CD, CR6, PB, \"AS\", YLSA, PHYCOCY, PHYCOER, COLIFORM, POTENTIAL, TOTALY, K40, CS134, CS137, CO60, CU, ZN, PHENOL, BOD5, ORGANIC, DETERGENTS, OIL, VIRUS, PETRO, DDT, PCBS, BENZOL, CHLO, ANTIBIOTIC, POISONA, POISONB ");
                            strSql.Append(" FROM BUOYECOLOGY_LV3 ");
                            strSql.Append(" WHERE DEVICECODE=:DEVICECODE ");
                            strSql.Append(" AND DATETIME=(SELECT MAX(DATETIME) DATETIME FROM BUOYECOLOGY_LV3 WHERE DEVICECODE=:DEVICECODE) ");
                        }
                        else if (stdType == "4")
                        {
                            strSql.Append(" SELECT DATETIME,CURRENTTEM, WATERTEM, CTDTEM, SALINITY, CONDUCTIVITY, OXYGEN, PH, TURBIDITY, YLS, YLSTEM, UNDERWATERCO2, OXYGENCHEMICAL, MNO4, OXYGENBIOLOGY, NH3N, NO3, NO2, PO4, SIO3, PAHS, \"P\", N, C, S, ALKALINITY, SUSPENSION, CYANIDE, HG, CD, CR6, PB, \"AS\", YLSA, PHYCOCY, PHYCOER, COLIFORM, POTENTIAL, TOTALY, K40, CS134, CS137, CO60, CU, ZN, PHENOL, BOD5, ORGANIC, DETERGENTS, OIL, VIRUS, PETRO, DDT, PCBS, BENZOL, CHLO, ANTIBIOTIC, POISONA, POISONB ");
                            strSql.Append(" FROM BUOYECOLOGY_LV4 ");
                            strSql.Append(" WHERE DEVICECODE=:DEVICECODE ");
                            strSql.Append(" AND DATETIME=(SELECT MAX(DATETIME) DATETIME FROM BUOYECOLOGY_LV4 WHERE DEVICECODE=:DEVICECODE) ");
                        }

                        OracleParameter[] parameters2 = {
                                new OracleParameter(":DEVICECODE",deviceCode)
			                };

                        dbHelper.OpenConn("");
                        DataTable dt = dbHelper.GetDataTable(strSql.ToString(), parameters2);
                        dbHelper.CloseConn();

                        if (dt.Rows.Count > 0)
                        {
                            #region 获取字段值
                            //model.DEVICECODE = ds.Rows[0]["DEVICECODE"].ToString();
                            if (dt.Rows[0]["DATETIME"].ToString() != "")
                            {
                                model.DATETIME = DateTime.Parse(dt.Rows[0]["DATETIME"].ToString());
                            }
                            if (dt.Rows[0]["CURRENTTEM"].ToString() != "")
                            {
                                model.CURRENTTEM = decimal.Parse(dt.Rows[0]["CURRENTTEM"].ToString());
                            }
                            if (dt.Rows[0]["WATERTEM"].ToString() != "")
                            {
                                model.WATERTEM = decimal.Parse(dt.Rows[0]["WATERTEM"].ToString());
                            }
                            if (dt.Rows[0]["CTDTEM"].ToString() != "")
                            {
                                model.CTDTEM = decimal.Parse(dt.Rows[0]["CTDTEM"].ToString());
                            }
                            if (dt.Rows[0]["SALINITY"].ToString() != "")
                            {
                                model.SALINITY = decimal.Parse(dt.Rows[0]["SALINITY"].ToString());
                            }
                            if (dt.Rows[0]["CONDUCTIVITY"].ToString() != "")
                            {
                                model.CONDUCTIVITY = decimal.Parse(dt.Rows[0]["CONDUCTIVITY"].ToString());
                            }
                            if (dt.Rows[0]["OXYGEN"].ToString() != "")
                            {
                                model.OXYGEN = decimal.Parse(dt.Rows[0]["OXYGEN"].ToString());
                            }
                            if (dt.Rows[0]["PH"].ToString() != "")
                            {
                                model.PH = decimal.Parse(dt.Rows[0]["PH"].ToString());
                            }
                            if (dt.Rows[0]["TURBIDITY"].ToString() != "")
                            {
                                model.TURBIDITY = decimal.Parse(dt.Rows[0]["TURBIDITY"].ToString());
                            }
                            if (dt.Rows[0]["YLS"].ToString() != "")
                            {
                                model.YLS = decimal.Parse(dt.Rows[0]["YLS"].ToString());
                            }
                            if (dt.Rows[0]["YLSTEM"].ToString() != "")
                            {
                                model.YLSTEM = decimal.Parse(dt.Rows[0]["YLSTEM"].ToString());
                            }
                            if (dt.Rows[0]["UNDERWATERCO2"].ToString() != "")
                            {
                                model.UNDERWATERCO2 = decimal.Parse(dt.Rows[0]["UNDERWATERCO2"].ToString());
                            }
                            if (dt.Rows[0]["OXYGENCHEMICAL"].ToString() != "")
                            {
                                model.OXYGENCHEMICAL = decimal.Parse(dt.Rows[0]["OXYGENCHEMICAL"].ToString());
                            }
                            if (dt.Rows[0]["MNO4"].ToString() != "")
                            {
                                model.MNO4 = decimal.Parse(dt.Rows[0]["MNO4"].ToString());
                            }
                            if (dt.Rows[0]["OXYGENBIOLOGY"].ToString() != "")
                            {
                                model.OXYGENBIOLOGY = decimal.Parse(dt.Rows[0]["OXYGENBIOLOGY"].ToString());
                            }
                            if (dt.Rows[0]["NH3N"].ToString() != "")
                            {
                                model.NH3N = decimal.Parse(dt.Rows[0]["NH3N"].ToString());
                            }
                            if (dt.Rows[0]["NO3"].ToString() != "")
                            {
                                model.NO3 = decimal.Parse(dt.Rows[0]["NO3"].ToString());
                            }
                            if (dt.Rows[0]["NO2"].ToString() != "")
                            {
                                model.NO2 = decimal.Parse(dt.Rows[0]["NO2"].ToString());
                            }
                            if (dt.Rows[0]["PO4"].ToString() != "")
                            {
                                model.PO4 = decimal.Parse(dt.Rows[0]["PO4"].ToString());
                            }
                            if (dt.Rows[0]["SIO3"].ToString() != "")
                            {
                                model.SIO3 = decimal.Parse(dt.Rows[0]["SIO3"].ToString());
                            }
                            if (dt.Rows[0]["PAHS"].ToString() != "")
                            {
                                model.PAHS = decimal.Parse(dt.Rows[0]["PAHS"].ToString());
                            }
                            if (dt.Rows[0]["P"].ToString() != "")
                            {
                                model.P = decimal.Parse(dt.Rows[0]["P"].ToString());
                            }
                            if (dt.Rows[0]["N"].ToString() != "")
                            {
                                model.N = decimal.Parse(dt.Rows[0]["N"].ToString());
                            }
                            if (dt.Rows[0]["C"].ToString() != "")
                            {
                                model.C = decimal.Parse(dt.Rows[0]["C"].ToString());
                            }
                            if (dt.Rows[0]["S"].ToString() != "")
                            {
                                model.S = decimal.Parse(dt.Rows[0]["S"].ToString());
                            }
                            if (dt.Rows[0]["ALKALINITY"].ToString() != "")
                            {
                                model.ALKALINITY = decimal.Parse(dt.Rows[0]["ALKALINITY"].ToString());
                            }
                            if (dt.Rows[0]["SUSPENSION"].ToString() != "")
                            {
                                model.SUSPENSION = decimal.Parse(dt.Rows[0]["SUSPENSION"].ToString());
                            }
                            if (dt.Rows[0]["CYANIDE"].ToString() != "")
                            {
                                model.CYANIDE = decimal.Parse(dt.Rows[0]["CYANIDE"].ToString());
                            }
                            if (dt.Rows[0]["HG"].ToString() != "")
                            {
                                model.HG = decimal.Parse(dt.Rows[0]["HG"].ToString());
                            }
                            if (dt.Rows[0]["CD"].ToString() != "")
                            {
                                model.CD = decimal.Parse(dt.Rows[0]["CD"].ToString());
                            }
                            if (dt.Rows[0]["CR6"].ToString() != "")
                            {
                                model.CR6 = decimal.Parse(dt.Rows[0]["CR6"].ToString());
                            }
                            if (dt.Rows[0]["PB"].ToString() != "")
                            {
                                model.PB = decimal.Parse(dt.Rows[0]["PB"].ToString());
                            }
                            if (dt.Rows[0]["AS"].ToString() != "")
                            {
                                model.AS = decimal.Parse(dt.Rows[0]["AS"].ToString());
                            }
                            if (dt.Rows[0]["YLSA"].ToString() != "")
                            {
                                model.YLSA = decimal.Parse(dt.Rows[0]["YLSA"].ToString());
                            }
                            if (dt.Rows[0]["PHYCOCY"].ToString() != "")
                            {
                                model.PHYCOCY = decimal.Parse(dt.Rows[0]["PHYCOCY"].ToString());
                            }
                            if (dt.Rows[0]["PHYCOER"].ToString() != "")
                            {
                                model.PHYCOER = decimal.Parse(dt.Rows[0]["PHYCOER"].ToString());
                            }
                            if (dt.Rows[0]["COLIFORM"].ToString() != "")
                            {
                                model.COLIFORM = decimal.Parse(dt.Rows[0]["COLIFORM"].ToString());
                            }
                            if (dt.Rows[0]["POTENTIAL"].ToString() != "")
                            {
                                model.POTENTIAL = decimal.Parse(dt.Rows[0]["POTENTIAL"].ToString());
                            }
                            if (dt.Rows[0]["TOTALY"].ToString() != "")
                            {
                                model.TOTALY = decimal.Parse(dt.Rows[0]["TOTALY"].ToString());
                            }
                            if (dt.Rows[0]["K40"].ToString() != "")
                            {
                                model.K40 = decimal.Parse(dt.Rows[0]["K40"].ToString());
                            }
                            if (dt.Rows[0]["CS134"].ToString() != "")
                            {
                                model.CS134 = decimal.Parse(dt.Rows[0]["CS134"].ToString());
                            }
                            if (dt.Rows[0]["CS137"].ToString() != "")
                            {
                                model.CS137 = decimal.Parse(dt.Rows[0]["CS137"].ToString());
                            }
                            if (dt.Rows[0]["CO60"].ToString() != "")
                            {
                                model.CO60 = decimal.Parse(dt.Rows[0]["CO60"].ToString());
                            }
                            if (dt.Rows[0]["CU"].ToString() != "")
                            {
                                model.CU = decimal.Parse(dt.Rows[0]["CU"].ToString());
                            }
                            if (dt.Rows[0]["ZN"].ToString() != "")
                            {
                                model.ZN = decimal.Parse(dt.Rows[0]["ZN"].ToString());
                            }
                            if (dt.Rows[0]["PHENOL"].ToString() != "")
                            {
                                model.PHENOL = decimal.Parse(dt.Rows[0]["PHENOL"].ToString());
                            }
                            if (dt.Rows[0]["BOD5"].ToString() != "")
                            {
                                model.BOD5 = decimal.Parse(dt.Rows[0]["BOD5"].ToString());
                            }
                            if (dt.Rows[0]["ORGANIC"].ToString() != "")
                            {
                                model.ORGANIC = decimal.Parse(dt.Rows[0]["ORGANIC"].ToString());
                            }
                            if (dt.Rows[0]["DETERGENTS"].ToString() != "")
                            {
                                model.DETERGENTS = decimal.Parse(dt.Rows[0]["DETERGENTS"].ToString());
                            }
                            if (dt.Rows[0]["OIL"].ToString() != "")
                            {
                                model.OIL = decimal.Parse(dt.Rows[0]["OIL"].ToString());
                            }
                            if (dt.Rows[0]["VIRUS"].ToString() != "")
                            {
                                model.VIRUS = decimal.Parse(dt.Rows[0]["VIRUS"].ToString());
                            }
                            if (dt.Rows[0]["PETRO"].ToString() != "")
                            {
                                model.PETRO = decimal.Parse(dt.Rows[0]["PETRO"].ToString());
                            }
                            if (dt.Rows[0]["DDT"].ToString() != "")
                            {
                                model.DDT = decimal.Parse(dt.Rows[0]["DDT"].ToString());
                            }
                            if (dt.Rows[0]["PCBS"].ToString() != "")
                            {
                                model.PCBS = decimal.Parse(dt.Rows[0]["PCBS"].ToString());
                            }
                            if (dt.Rows[0]["BENZOL"].ToString() != "")
                            {
                                model.BENZOL = decimal.Parse(dt.Rows[0]["BENZOL"].ToString());
                            }
                            if (dt.Rows[0]["CHLO"].ToString() != "")
                            {
                                model.CHLO = decimal.Parse(dt.Rows[0]["CHLO"].ToString());
                            }
                            if (dt.Rows[0]["ANTIBIOTIC"].ToString() != "")
                            {
                                model.ANTIBIOTIC = decimal.Parse(dt.Rows[0]["ANTIBIOTIC"].ToString());
                            }
                            if (dt.Rows[0]["POISONA"].ToString() != "")
                            {
                                model.POISONA = decimal.Parse(dt.Rows[0]["POISONA"].ToString());
                            }
                            if (dt.Rows[0]["POISONB"].ToString() != "")
                            {
                                model.POISONB = decimal.Parse(dt.Rows[0]["POISONB"].ToString());
                            }

                            #endregion

                            //return model;
                        }
                        else
                        {
                            return null;
                        }
                    }

                    return model;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(BUOYECOLOGY_BN), "GetModel 程序段的异常" + ex);
                return null;
            }
        }

    }
}
