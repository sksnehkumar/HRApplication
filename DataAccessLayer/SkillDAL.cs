using System;
using System.Data;
using System.Data.SqlClient;
using Common;
using BusinessEntities;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class SkillDAL
    {
        SqlConnection objConn;
        SqlCommand objComm;
        SqlDataReader objDR;
        DataTable objDT;

        SqlParameter objSP_SkillId;
        SqlParameter objSP_SkillName;
        SqlParameter objSP_SkillDescription;
        SqlParameter objSP_CategoryId;
        SqlParameter objSP_CreatedBy;
        SqlParameter objSP_CreatedDate;
        SqlParameter objSP_LastModifiedBy;
        SqlParameter objSP_LastModifiedDate;

       //void ConnectToDB()
       // {
       //     using (objConn = new SqlConnection(Database.ConnectionString))
       //     {
       //         try
       //         {
       //             objConn.Open();
       //         }
       //         catch (Exception e)
       //         {
       //             Console.WriteLine(e.Message);
       //         }
       //     }
       // }

        public bool CreateSkill(SkillInfo objSkillInfo)
        {
            int skillId = objSkillInfo.SkillId;
            string skillName = objSkillInfo.SkillName;
            string skillDescription = objSkillInfo.SkillDescription;
            int categoryId = objSkillInfo.CategoryId;
            int createdBy = objSkillInfo.CreatedBy;
            DateTime createdDate = DateTime.Now;
            int lastModifiedBy = objSkillInfo.LastModifiedBy;
            DateTime lastModifiedDate = DateTime.Now;

            objConn = new SqlConnection(Database.ConnectionString);
            objComm = new SqlCommand(Database.CreateSkill, objConn);
            objComm.CommandType = CommandType.StoredProcedure;

            objSP_SkillId = new SqlParameter("@SkillId", SqlDbType.Int);
            objSP_SkillName = new SqlParameter("@SkillName", SqlDbType.VarChar, 50);
            objSP_SkillDescription = new SqlParameter("@SkillDescription", SqlDbType.VarChar, 50);
            objSP_CategoryId = new SqlParameter("@CategoryId", SqlDbType.Int);
            objSP_CreatedBy = new SqlParameter("@CreatedBy", SqlDbType.Int);
            objSP_CreatedDate = new SqlParameter("@CreatedDate", SqlDbType.DateTime);
            objSP_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
            objSP_LastModifiedDate = new SqlParameter("@LastModifiedDate", SqlDbType.DateTime);

            objSP_SkillId.Direction = ParameterDirection.Input;
            objSP_SkillName.Direction = ParameterDirection.Input;
            objSP_SkillDescription.Direction = ParameterDirection.Input;
            objSP_CategoryId.Direction = ParameterDirection.Input;
            objSP_CreatedBy.Direction = ParameterDirection.Input;
            objSP_CreatedDate.Direction = ParameterDirection.Input;
            objSP_LastModifiedBy.Direction = ParameterDirection.Input;
            objSP_LastModifiedDate.Direction = ParameterDirection.Input;

            objComm.Parameters.Add(objSP_SkillId);
            objComm.Parameters.Add(objSP_SkillName);
            objComm.Parameters.Add(objSP_SkillDescription);
            objComm.Parameters.Add(objSP_CategoryId);
            objComm.Parameters.Add(objSP_CreatedBy);
            objComm.Parameters.Add(objSP_CreatedDate);
            objComm.Parameters.Add(objSP_LastModifiedBy);
            objComm.Parameters.Add(objSP_LastModifiedDate);

            objSP_SkillId.Value = skillId;
            objSP_SkillName.Value = skillName;
            objSP_SkillDescription.Value = skillDescription;
            objSP_CategoryId.Value = categoryId;
            objSP_CreatedBy.Value = createdBy;
            objSP_CreatedDate.Value = createdDate;
            objSP_LastModifiedBy.Value = lastModifiedBy;
            objSP_LastModifiedDate.Value = lastModifiedDate;

            try
            {
                objConn.Open();

                int rowsAffected = objComm.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                
            }
            catch(Exception e)
            {
                //Console.WriteLine(e.Message);
            }
            finally
            {
                objConn.Close();
            }
            return false;
        }

        public DataTable SearchSkills()
        {
            objConn = new SqlConnection(Database.ConnectionString);
            objComm = new SqlCommand(Database.SearchSkills, objConn);
            objComm.CommandType = CommandType.StoredProcedure;

            try
            {
                objConn.Open();
                objDR = objComm.ExecuteReader();
                objDT = new DataTable();
                objDT.Load(objDR);
                
                objConn.Close();

                return objDT;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public DataTable ViewSkill(int skillId)
        {
            //objConn = new SqlConnection(Database.ConnectionString);
            //objComm = new SqlCommand(Database.ViewSkill, objConn);
            //objComm.CommandType = CommandType.StoredProcedure;

            //objSP_SkillId = new SqlParameter("@SkillId", SqlDbType.Int);
            //objSP_SkillName = new SqlParameter("@SkillName", SqlDbType.VarChar, 50);
            //objSP_SkillDescription = new SqlParameter("@SkillDescription", SqlDbType.VarChar, 50);
            //objSP_CategoryId = new SqlParameter("@CategoryId", SqlDbType.Int);
            //objSP_CreatedBy = new SqlParameter("@CreatedBy", SqlDbType.Int);
            //objSP_CreatedDate = new SqlParameter("@CreatedDate", SqlDbType.DateTime);
            //objSP_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
            //objSP_LastModifiedDate = new SqlParameter("@LastModifiedDate", SqlDbType.DateTime);

            //objSP_SkillId.Direction = ParameterDirection.Input;
            //objSP_SkillName.Direction = ParameterDirection.Output;
            //objSP_SkillDescription.Direction = ParameterDirection.Output;
            //objSP_CategoryId.Direction = ParameterDirection.Output;
            //objSP_CreatedBy.Direction = ParameterDirection.Output;
            //objSP_CreatedDate.Direction = ParameterDirection.Output;
            //objSP_LastModifiedBy.Direction = ParameterDirection.Output;
            //objSP_LastModifiedDate.Direction = ParameterDirection.Output;

            //objComm.Parameters.Add(objSP_SkillId);
            //objComm.Parameters.Add(objSP_SkillName);
            //objComm.Parameters.Add(objSP_SkillDescription);
            //objComm.Parameters.Add(objSP_CategoryId);
            //objComm.Parameters.Add(objSP_CreatedBy);
            //objComm.Parameters.Add(objSP_CreatedDate);
            //objComm.Parameters.Add(objSP_LastModifiedBy);
            //objComm.Parameters.Add(objSP_LastModifiedDate);

            //objSP_SkillId.Value = skillId;

            //try
            //{
            //    objConn.Open();
            //    objComm.ExecuteNonQuery();

            //    SkillInfo objSkillInfo = new SkillInfo(Convert.ToInt32(objSP_SkillId.Value), objSP_SkillName.Value.ToString(), objSP_SkillDescription.Value.ToString(), 
            //        Convert.ToInt32(objSP_CategoryId), Convert.ToInt32(objSP_CreatedBy), Convert.ToDateTime(objSP_CreatedDate), Convert.ToInt32(objSP_LastModifiedBy),
            //        Convert.ToDateTime(objSP_LastModifiedDate));

            //    objConn.Close();
            //    return objSkillInfo;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    return null;
            //}

            objConn = new SqlConnection(Database.ConnectionString);
            objComm = new SqlCommand(Database.ViewSkill, objConn);
            objComm.CommandType = CommandType.StoredProcedure;

            objSP_SkillId = new SqlParameter("@SkillId", SqlDbType.Int);
            objSP_SkillId.Direction = ParameterDirection.Input;
            objSP_SkillId.Value = skillId;
            objComm.Parameters.Add(objSP_SkillId);

            try
            {
                objConn.Open();
                objDR = objComm.ExecuteReader();
                objDT = new DataTable();
                objDT.Load(objDR);

                objConn.Close();

                return objDT;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public bool UpdateSkill(SkillInfo objSkillInfo)
        {
            int skillId = objSkillInfo.SkillId;
            string skillName = objSkillInfo.SkillName;
            string skillDescription = objSkillInfo.SkillDescription;
            int categoryId = objSkillInfo.CategoryId;
            int lastModifiedBy = objSkillInfo.LastModifiedBy;
            DateTime lastModifiedDate = DateTime.Now;

            objConn = new SqlConnection(Database.ConnectionString);
            objComm = new SqlCommand(Database.UpdateSkill, objConn);
            objComm.CommandType = CommandType.StoredProcedure;

            objSP_SkillId = new SqlParameter("@SkillId", SqlDbType.Int);
            objSP_SkillName = new SqlParameter("@SkillName", SqlDbType.VarChar, 50);
            objSP_SkillDescription = new SqlParameter("@SkillDescription", SqlDbType.VarChar, 50);
            objSP_CategoryId = new SqlParameter("@CategoryId", SqlDbType.Int);
            objSP_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
            objSP_LastModifiedDate = new SqlParameter("@LastModifiedDate", SqlDbType.DateTime);

            objSP_SkillId.Direction = ParameterDirection.Input;
            objSP_SkillName.Direction = ParameterDirection.Input;
            objSP_SkillDescription.Direction = ParameterDirection.Input;
            objSP_CategoryId.Direction = ParameterDirection.Input;
            objSP_LastModifiedBy.Direction = ParameterDirection.Input;
            objSP_LastModifiedDate.Direction = ParameterDirection.Input;

            objComm.Parameters.Add(objSP_SkillId);
            objComm.Parameters.Add(objSP_SkillName);
            objComm.Parameters.Add(objSP_SkillDescription);
            objComm.Parameters.Add(objSP_CategoryId);
            objComm.Parameters.Add(objSP_LastModifiedBy);
            objComm.Parameters.Add(objSP_LastModifiedDate);

            objSP_SkillId.Value = skillId;
            objSP_SkillName.Value = skillName;
            objSP_SkillDescription.Value = skillDescription;
            objSP_CategoryId.Value = categoryId;
            objSP_LastModifiedBy.Value = lastModifiedBy;
            objSP_LastModifiedDate.Value = lastModifiedDate;

            try
            {
                objConn.Open();

                int rowsAffected = objComm.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
            }
            finally
            {
                objConn.Close();
            }

            return true;
        }

        public DataTable GetSkillList()
        {
            objConn = new SqlConnection(Database.ConnectionString);
            objComm = new SqlCommand(Database.GetSkillList, objConn);
            objComm.CommandType = CommandType.StoredProcedure;

            try
            {
                objConn.Open();
                objDR = objComm.ExecuteReader();
                objDT = new DataTable();
                objDT.Load(objDR);

                objConn.Close();

                return objDT;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
