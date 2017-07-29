using System;
using System.Data;
using System.Data.SqlClient;
using Common;
using BusinessEntities;

namespace DataAccessLayer
{
    public class EmployeeDAL
    {
        SqlConnection objConn;
        SqlCommand objComm;
        SqlDataReader objDR;
        DataTable objDT;

        SqlParameter objSP_EmployeeId;
        SqlParameter objSP_FirstName;
        SqlParameter objSP_MiddleName;
        SqlParameter objSP_LastName;
        SqlParameter objSP_BirthDate;
        SqlParameter objSP_Age;
        SqlParameter objSP_Gender;
        SqlParameter objSP_CivilStatus;
        SqlParameter objSP_Religion;
        SqlParameter objSP_Citizenship;
        SqlParameter objSP_MobileNo;
        SqlParameter objSP_HomePhoneNo;
        SqlParameter objSP_Street1;
        SqlParameter objSP_Street2;
        SqlParameter objSP_City;
        SqlParameter objSP_State;
        SqlParameter objSP_ZipCode;
        SqlParameter objSP_Country;
        SqlParameter objSP_ProjectProfile;
        SqlParameter objSP_SkillProfile;
        SqlParameter objSP_EducBackground;
        SqlParameter objSP_Recognitions;
        SqlParameter objSP_CreatedBy;
        SqlParameter objSP_CreatedDate;
        SqlParameter objSP_LastModifiedBy;
        SqlParameter objSP_LastModifiedDate;

        public bool CreateEmployee(EmployeeInfo objEmployeeInfo)
        {
            objConn = new SqlConnection(Database.ConnectionString);
            objComm = new SqlCommand(Database.CreateEmployee, objConn);
            objComm.CommandType = CommandType.StoredProcedure;

            objSP_EmployeeId = new SqlParameter("@EmployeeId", SqlDbType.Int);
            objSP_FirstName = new SqlParameter("@FirstName", SqlDbType.VarChar, 50);
            objSP_MiddleName = new SqlParameter("@MiddleName", SqlDbType.VarChar, 50);
            objSP_LastName = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
            objSP_BirthDate = new SqlParameter("@BirthDate", SqlDbType.DateTime);
            objSP_Age = new SqlParameter("@Age", SqlDbType.Int);
            objSP_Gender = new SqlParameter("@Gender", SqlDbType.VarChar, 50);
            objSP_CivilStatus = new SqlParameter("@CivilStatus", SqlDbType.Int);
            objSP_Religion = new SqlParameter("@Religion", SqlDbType.VarChar, 50);
            objSP_Citizenship = new SqlParameter("@Citizenship", SqlDbType.VarChar, 50);
            objSP_MobileNo = new SqlParameter("@MobileNo", SqlDbType.VarChar, 50);
            objSP_HomePhoneNo = new SqlParameter("@HomePhoneNo", SqlDbType.VarChar, 50);
            objSP_Street1 = new SqlParameter("@Street1", SqlDbType.VarChar, 50);
            objSP_Street2 = new SqlParameter("@Street2", SqlDbType.VarChar, 50);
            objSP_City = new SqlParameter("@City", SqlDbType.VarChar, 50);
            objSP_State = new SqlParameter("@State", SqlDbType.VarChar, 50);
            objSP_ZipCode = new SqlParameter("@ZipCode", SqlDbType.VarChar, 50);
            objSP_Country = new SqlParameter("@Country", SqlDbType.VarChar, 50);
            objSP_ProjectProfile = new SqlParameter("@ProjectProfile", SqlDbType.Int);
            objSP_SkillProfile = new SqlParameter("@SkillProfile", SqlDbType.Int);
            objSP_EducBackground = new SqlParameter("@EducBackground", SqlDbType.VarChar, 50);
            objSP_Recognitions = new SqlParameter("@Recognitions", SqlDbType.VarChar, 50);
            objSP_CreatedBy = new SqlParameter("@CreatedBy", SqlDbType.Int);
            objSP_CreatedDate = new SqlParameter("@CreatedDate", SqlDbType.DateTime);
            objSP_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
            objSP_LastModifiedDate = new SqlParameter("@LastModifiedDate", SqlDbType.DateTime);

            objSP_EmployeeId.Direction = ParameterDirection.Input;
            objSP_FirstName.Direction = ParameterDirection.Input;
            objSP_MiddleName.Direction = ParameterDirection.Input;
            objSP_LastName.Direction = ParameterDirection.Input;
            objSP_BirthDate.Direction = ParameterDirection.Input;
            objSP_Age.Direction = ParameterDirection.Input;
            objSP_Gender.Direction = ParameterDirection.Input;
            objSP_CivilStatus.Direction = ParameterDirection.Input;
            objSP_Religion.Direction = ParameterDirection.Input;
            objSP_Citizenship.Direction = ParameterDirection.Input;
            objSP_MobileNo.Direction = ParameterDirection.Input;
            objSP_HomePhoneNo.Direction = ParameterDirection.Input;
            objSP_Street1.Direction = ParameterDirection.Input;
            objSP_Street2.Direction = ParameterDirection.Input;
            objSP_City.Direction = ParameterDirection.Input;
            objSP_State.Direction = ParameterDirection.Input;
            objSP_ZipCode.Direction = ParameterDirection.Input;
            objSP_Country.Direction = ParameterDirection.Input;
            objSP_ProjectProfile.Direction = ParameterDirection.Input;
            objSP_SkillProfile.Direction = ParameterDirection.Input;
            objSP_EducBackground.Direction = ParameterDirection.Input;
            objSP_Recognitions.Direction = ParameterDirection.Input;
            objSP_CreatedBy.Direction = ParameterDirection.Input;
            objSP_CreatedDate.Direction = ParameterDirection.Input;
            objSP_LastModifiedBy.Direction = ParameterDirection.Input;
            objSP_LastModifiedDate.Direction = ParameterDirection.Input;

            objComm.Parameters.Add(objSP_EmployeeId);
            objComm.Parameters.Add(objSP_FirstName);
            objComm.Parameters.Add(objSP_MiddleName);
            objComm.Parameters.Add(objSP_LastName);
            objComm.Parameters.Add(objSP_BirthDate);
            objComm.Parameters.Add(objSP_Age);
            objComm.Parameters.Add(objSP_Gender);
            objComm.Parameters.Add(objSP_CivilStatus);
            objComm.Parameters.Add(objSP_Religion);
            objComm.Parameters.Add(objSP_Citizenship);
            objComm.Parameters.Add(objSP_MobileNo);
            objComm.Parameters.Add(objSP_HomePhoneNo);
            objComm.Parameters.Add(objSP_Street1);
            objComm.Parameters.Add(objSP_Street2);
            objComm.Parameters.Add(objSP_City);
            objComm.Parameters.Add(objSP_State);
            objComm.Parameters.Add(objSP_ZipCode);
            objComm.Parameters.Add(objSP_Country);
            objComm.Parameters.Add(objSP_ProjectProfile);
            objComm.Parameters.Add(objSP_SkillProfile);
            objComm.Parameters.Add(objSP_EducBackground);
            objComm.Parameters.Add(objSP_Recognitions);
            objComm.Parameters.Add(objSP_CreatedBy);
            objComm.Parameters.Add(objSP_CreatedDate);
            objComm.Parameters.Add(objSP_LastModifiedBy);
            objComm.Parameters.Add(objSP_LastModifiedDate);

            objSP_EmployeeId.Value = objEmployeeInfo.EmployeeId;
            objSP_FirstName.Value = objEmployeeInfo.FirstName;
            objSP_MiddleName.Value = objEmployeeInfo.MiddleName;
            objSP_LastName.Value = objEmployeeInfo.LastName;
            objSP_BirthDate.Value = objEmployeeInfo.BirthDate;
            objSP_Age.Value = objEmployeeInfo.Age;
            objSP_Gender.Value = objEmployeeInfo.Gender;
            objSP_CivilStatus.Value = objEmployeeInfo.CivilStatus;
            objSP_Religion.Value = objEmployeeInfo.Religion;
            objSP_Citizenship.Value = objEmployeeInfo.Citizenship;
            objSP_MobileNo.Value = objEmployeeInfo.MobileNo;
            objSP_HomePhoneNo.Value = objEmployeeInfo.HomePhoneNo;
            objSP_Street1.Value = objEmployeeInfo.Street1;
            objSP_Street2.Value = objEmployeeInfo.Street2;
            objSP_City.Value = objEmployeeInfo.City;
            objSP_State.Value = objEmployeeInfo.State;
            objSP_ZipCode.Value = objEmployeeInfo.ZipCode;
            objSP_Country.Value = objEmployeeInfo.Country;
            objSP_ProjectProfile.Value = objEmployeeInfo.ProjectProfile;
            objSP_SkillProfile.Value = objEmployeeInfo.SkillProfile;
            objSP_EducBackground.Value = objEmployeeInfo.EducBackground;
            objSP_Recognitions.Value = objEmployeeInfo.Recognitions;
            objSP_CreatedBy.Value = objEmployeeInfo.CreatedBy;
            objSP_CreatedDate.Value = objEmployeeInfo.CreatedDate;
            objSP_LastModifiedBy.Value = objEmployeeInfo.LastModifiedBy;
            objSP_LastModifiedDate.Value = objEmployeeInfo.LastModifiedDate;

            try
            {
                objConn.Open();

                int rowsAffected = objComm.ExecuteNonQuery();
                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
            }
            finally
            {
                objConn.Close();
            }
            return false;

        }
        public DataTable SearchEmployees()
        {
            objConn = new SqlConnection(Database.ConnectionString);
            objComm = new SqlCommand(Database.SearchEmployees, objConn);
            objComm.CommandType = CommandType.StoredProcedure;

            try
            {
                objConn.Open();
                objDR = objComm.ExecuteReader();
                objDT = new DataTable();
                objDT.Load(objDR);
                
                return objDT;
            }
            catch (Exception e)
            {
             
            }
            finally
            {
                objConn.Close();
            }

            return null;
        }
        public DataTable ViewEmployee(int employeeId)
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
            objComm = new SqlCommand(Database.ViewEmployee, objConn);
            objComm.CommandType = CommandType.StoredProcedure;

            objSP_EmployeeId = new SqlParameter("@EmployeeId", SqlDbType.Int);
            objSP_EmployeeId.Direction = ParameterDirection.Input;
            objSP_EmployeeId.Value = employeeId;
            objComm.Parameters.Add(objSP_EmployeeId);

            try
            {
                objConn.Open();
                objDR = objComm.ExecuteReader();
                objDT = new DataTable();
                objDT.Load(objDR);

                return objDT;
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                objConn.Close();
            }
            return null;
        }
        public bool UpdateEmployee(EmployeeInfo objEmployeeInfo)
        {
            objConn = new SqlConnection(Database.ConnectionString);
            objComm = new SqlCommand(Database.UpdateEmployee, objConn);
            objComm.CommandType = CommandType.StoredProcedure;

            objSP_EmployeeId = new SqlParameter("@EmployeeId", SqlDbType.Int);
            objSP_FirstName = new SqlParameter("@FirstName", SqlDbType.VarChar, 50);
            objSP_MiddleName = new SqlParameter("@MiddleName", SqlDbType.VarChar, 50);
            objSP_LastName = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
            objSP_BirthDate = new SqlParameter("@BirthDate", SqlDbType.DateTime);
            objSP_Age = new SqlParameter("@Age", SqlDbType.Int);
            objSP_Gender = new SqlParameter("@Gender", SqlDbType.VarChar, 50);
            objSP_CivilStatus = new SqlParameter("@CivilStatus", SqlDbType.Int);
            objSP_Religion = new SqlParameter("@Religion", SqlDbType.VarChar, 50);
            objSP_Citizenship = new SqlParameter("@Citizenship", SqlDbType.VarChar, 50);
            objSP_MobileNo = new SqlParameter("@MobileNo", SqlDbType.VarChar, 50);
            objSP_HomePhoneNo = new SqlParameter("@HomePhoneNo", SqlDbType.VarChar, 50);
            objSP_Street1 = new SqlParameter("@Street1", SqlDbType.VarChar, 50);
            objSP_Street2 = new SqlParameter("@Street2", SqlDbType.VarChar, 50);
            objSP_City = new SqlParameter("@City", SqlDbType.VarChar, 50);
            objSP_State = new SqlParameter("@State", SqlDbType.VarChar, 50);
            objSP_ZipCode = new SqlParameter("@ZipCode", SqlDbType.VarChar, 50);
            objSP_Country = new SqlParameter("@Country", SqlDbType.VarChar, 50);
            objSP_ProjectProfile = new SqlParameter("@ProjectProfile", SqlDbType.Int);
            objSP_SkillProfile = new SqlParameter("@SkillProfile", SqlDbType.Int);
            objSP_EducBackground = new SqlParameter("@EducBackground", SqlDbType.VarChar, 50);
            objSP_Recognitions = new SqlParameter("@Recognitions", SqlDbType.VarChar, 50);
            objSP_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
            objSP_LastModifiedDate = new SqlParameter("@LastModifiedDate", SqlDbType.DateTime);

            objSP_EmployeeId.Direction = ParameterDirection.Input;
            objSP_FirstName.Direction = ParameterDirection.Input;
            objSP_MiddleName.Direction = ParameterDirection.Input;
            objSP_LastName.Direction = ParameterDirection.Input;
            objSP_BirthDate.Direction = ParameterDirection.Input;
            objSP_Age.Direction = ParameterDirection.Input;
            objSP_Gender.Direction = ParameterDirection.Input;
            objSP_CivilStatus.Direction = ParameterDirection.Input;
            objSP_Religion.Direction = ParameterDirection.Input;
            objSP_Citizenship.Direction = ParameterDirection.Input;
            objSP_MobileNo.Direction = ParameterDirection.Input;
            objSP_HomePhoneNo.Direction = ParameterDirection.Input;
            objSP_Street1.Direction = ParameterDirection.Input;
            objSP_Street2.Direction = ParameterDirection.Input;
            objSP_City.Direction = ParameterDirection.Input;
            objSP_State.Direction = ParameterDirection.Input;
            objSP_ZipCode.Direction = ParameterDirection.Input;
            objSP_Country.Direction = ParameterDirection.Input;
            objSP_ProjectProfile.Direction = ParameterDirection.Input;
            objSP_SkillProfile.Direction = ParameterDirection.Input;
            objSP_EducBackground.Direction = ParameterDirection.Input;
            objSP_Recognitions.Direction = ParameterDirection.Input;
            objSP_LastModifiedBy.Direction = ParameterDirection.Input;
            objSP_LastModifiedDate.Direction = ParameterDirection.Input;

            objComm.Parameters.Add(objSP_EmployeeId);
            objComm.Parameters.Add(objSP_FirstName);
            objComm.Parameters.Add(objSP_MiddleName);
            objComm.Parameters.Add(objSP_LastName);
            objComm.Parameters.Add(objSP_BirthDate);
            objComm.Parameters.Add(objSP_Age);
            objComm.Parameters.Add(objSP_Gender);
            objComm.Parameters.Add(objSP_CivilStatus);
            objComm.Parameters.Add(objSP_Religion);
            objComm.Parameters.Add(objSP_Citizenship);
            objComm.Parameters.Add(objSP_MobileNo);
            objComm.Parameters.Add(objSP_HomePhoneNo);
            objComm.Parameters.Add(objSP_Street1);
            objComm.Parameters.Add(objSP_Street2);
            objComm.Parameters.Add(objSP_City);
            objComm.Parameters.Add(objSP_State);
            objComm.Parameters.Add(objSP_ZipCode);
            objComm.Parameters.Add(objSP_Country);
            objComm.Parameters.Add(objSP_ProjectProfile);
            objComm.Parameters.Add(objSP_SkillProfile);
            objComm.Parameters.Add(objSP_EducBackground);
            objComm.Parameters.Add(objSP_Recognitions);
            objComm.Parameters.Add(objSP_LastModifiedBy);
            objComm.Parameters.Add(objSP_LastModifiedDate);

            objSP_EmployeeId.Value = objEmployeeInfo.EmployeeId;
            objSP_FirstName.Value = objEmployeeInfo.FirstName;
            objSP_MiddleName.Value = objEmployeeInfo.MiddleName;
            objSP_LastName.Value = objEmployeeInfo.LastName;
            objSP_BirthDate.Value = objEmployeeInfo.BirthDate;
            objSP_Age.Value = objEmployeeInfo.Age;
            objSP_Gender.Value = objEmployeeInfo.Gender;
            objSP_CivilStatus.Value = objEmployeeInfo.CivilStatus;
            objSP_Religion.Value = objEmployeeInfo.Religion;
            objSP_Citizenship.Value = objEmployeeInfo.Citizenship;
            objSP_MobileNo.Value = objEmployeeInfo.MobileNo;
            objSP_HomePhoneNo.Value = objEmployeeInfo.HomePhoneNo;
            objSP_Street1.Value = objEmployeeInfo.Street1;
            objSP_Street2.Value = objEmployeeInfo.Street2;
            objSP_City.Value = objEmployeeInfo.City;
            objSP_State.Value = objEmployeeInfo.State;
            objSP_ZipCode.Value = objEmployeeInfo.ZipCode;
            objSP_Country.Value = objEmployeeInfo.Country;
            objSP_ProjectProfile.Value = objEmployeeInfo.ProjectProfile;
            objSP_SkillProfile.Value = objEmployeeInfo.SkillProfile;
            objSP_EducBackground.Value = objEmployeeInfo.EducBackground;
            objSP_Recognitions.Value = objEmployeeInfo.Recognitions;
            objSP_LastModifiedBy.Value = objEmployeeInfo.LastModifiedBy;
            objSP_LastModifiedDate.Value = objEmployeeInfo.LastModifiedDate;

            try
            {
                objConn.Open();

                int rowsAffected = objComm.ExecuteNonQuery();
                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {

            }
            finally
            {
                objConn.Close();
            }
            return false;
        }

    }
}
