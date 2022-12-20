using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccessLayer
    {
        SqlConnection dbConn = new SqlConnection("Data Source=localhost; Initial Catalog=AssessmentDB;Integrated Security=true;");
        SqlCommand dbComm;
        SqlDataAdapter dataAdapter;
        DataTable dt;
        string sql;


        public int InsertUser(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_InsertUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", user.Name);
            dbComm.Parameters.AddWithValue("@Surname", user.Surname);
            dbComm.Parameters.AddWithValue("@Role", user.Role);
            dbComm.Parameters.AddWithValue("@Email", user.Email);
            dbComm.Parameters.AddWithValue("@Password", user.Password);
            dbComm.Parameters.AddWithValue("@Title", user.Title);
            dbComm.Parameters.AddWithValue("@UserStatus", user.UserStatus);
            if (dbComm.Connection.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }

        public int InsertStudent()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_AddStudent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            if (dbComm.Connection.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }

        public int InsertAdmin()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_AddAdministrator", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            if (dbComm.Connection.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }

        public int AddStudentModule(StudentModule stuMod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_AddStudentModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", stuMod.UserID);
            dbComm.Parameters.AddWithValue("@LecturerModuleID", stuMod.LecturerModuleID);
            dbComm.Parameters.AddWithValue("@Date", stuMod.Date);
            dbComm.Parameters.AddWithValue("@StudModStatus", stuMod.StudModStatus);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int InsertLecturer()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_AddLecturer", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            if (dbComm.Connection.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }


        public int AddLecturerModule(LecturerModule lecMod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_AddLecturerModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleID", lecMod.ModuleID);
            dbComm.Parameters.AddWithValue("@UserID", lecMod.UserID);
            dbComm.Parameters.AddWithValue("@Date", lecMod.Date);
            dbComm.Parameters.AddWithValue("@ModLecturerStatus", lecMod.ModLecturerStatus);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();

            return x;
        }

        public int InsertModule(Module mod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            sql = "sp_AddModule";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            //dbComm.Parameters.AddWithValue("@ModuleID", mod.ModuleID);
            dbComm.Parameters.AddWithValue("@ModuleName", mod.ModuleName);
            dbComm.Parameters.AddWithValue("@ModuleDuration", mod.ModuleDuration);
            dbComm.Parameters.AddWithValue("@ModuleTypeID", mod.ModuleTypeID);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();

            return x;
        }

        public int AddModuleType(ModuleType modT)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            sql = "sp_AddModuleType";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleTypeDescription", modT.ModuleTypeDescription);
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            int r = dbComm.ExecuteNonQuery();
            return r;
        }

        public int AddAssessment(Assessment ass)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            sql = "SP_AddAssessmentsD";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@LecturerModuleID", ass.LecturerModuleID);
            dbComm.Parameters.AddWithValue("@AssessmentDescription", ass.AssessmentDescription);
            dbComm.Parameters.AddWithValue("@DueDate", ass.DueDate);
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", ass.AssessmentTypeID);
            dbComm.Parameters.AddWithValue("@AssessmentStatus", ass.AssessmentStatus);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();

            return x;
        }

        public int AddAssessmentSubmission(Assessment assessmentsSubmission)
        {
            try
            {
                dbConn.Open();

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_AddAssessmentSubmission", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentID", assessmentsSubmission.AssessmentID);
            dbComm.Parameters.AddWithValue("@AssessmentStatus", assessmentsSubmission.AssessmentStatus);
            dbComm.Parameters.AddWithValue("@DueDate", assessmentsSubmission.DueDate);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }

        public int AddAssessmentType(AssessmentsType assT)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            sql = "sp_AddAssessmentType";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeDescription", assT.AssessmentTypeDescription);
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            int r = dbComm.ExecuteNonQuery();
            return r;
        }

        public int DeleteStudentModule(StudentModule stuMod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteStudentMod", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentModuleID", stuMod.StudentModuleID);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();

            return x;
        }

        public int DeleteModule(Module mod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteModules", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleID", mod.ModuleID);

            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            int x = dbComm.ExecuteNonQuery();
            return x;

        }

        public int HardDeleteUsers(int UserID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_HardDeleteUsers", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", UserID);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }

        public int DeleteLecturerModule(LecturerModule lecMod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeletelecturerMod", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@LecturerModuleID", lecMod.LecturerModuleID);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();

            return x;
        }



        public int DeleteAssessment(Assessment ass)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteAssessments", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentID", ass.AssessmentID);
            dbComm.Parameters.AddWithValue("@AssessmentStatus", ass.AssessmentStatus);

            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            int x = dbComm.ExecuteNonQuery();
            return x;

        }




        public int DeleteUser(User us)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteUsers", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", us.UserID);
            dbComm.Parameters.AddWithValue("@UserStatus", us.UserStatus);


            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            int x = dbComm.ExecuteNonQuery();
            return x;
        }

        public int DeleteAssessmentType(int assT)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteAssessmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", assT);

            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            int x = dbComm.ExecuteNonQuery();
            return x;

        }

        public int DeleteModuleType(ModuleType moduleType)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteModuleType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleTypeID", moduleType.ModuleTypeID);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }

        public DataTable GetInActiveUsers()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetInActiveUsers", dbConn);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetModule()
        {

            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetModules", dbConn);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }



        public DataTable GetModuleType()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetModuleTypes", dbConn);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;

        }



        public DataTable GetAssessments()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            sql = "sp_GetAssessments";
            dbComm = new SqlCommand(sql, dbConn);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }





        public DataTable GetUser()
        {

            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetUsers", dbConn);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetAdministrator()
        {

            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetAdministrators", dbConn);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }


        public DataTable GetMyModule()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetMyModules", dbConn);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;

        }

        public DataTable GetAssessmentType()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetAssessmentsTypes", dbConn);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;

        }

        public DataTable GetAssessmentByType(int assessmentTypeID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetAssessmentByType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", assessmentTypeID);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetUsersByRole(string role)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetUsersByRole", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Role", role);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetModuleDetailsBySearching(string Search)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetModuleDetailsBySearching", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Search", Search);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetUsersBySearching(int search, string name)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetUsersBySearching", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Search", search);
            dbComm.Parameters.AddWithValue("@Name", name);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }



        public DataTable GetStudent()
        {

            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetStudents", dbConn);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }



        public DataTable GetStudentModule()
        {
            dbComm = new SqlCommand("sp_GetStudentModule", dbConn);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }




        public DataTable GetLecturer()
        {

            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetLecturers", dbConn);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }





        public DataTable GetLecturerModule()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetLecturerModule", dbConn);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }


        public DataTable GetModuleAssessments(int LecturerModuleID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            sql = "GetModuleAssessments";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@LecturerModuleID", LecturerModuleID);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetStudentModuleID(int UserID, int LecturerModuleID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            sql = "sp_getStudentModulleID";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", UserID);
            dbComm.Parameters.AddWithValue("@LecturerModuleID", LecturerModuleID);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetLecturerAssessments(int UserID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetLecturerAssessments", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", UserID);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetStudentByID(int UserID, string name)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetStudentById", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", UserID);
            dbComm.Parameters.AddWithValue("@Name", name);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetAssessmentByID(int AssessmentID, string AssessmentDescription)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetAssessmentByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentID", AssessmentID);
            dbComm.Parameters.AddWithValue("@AssessmentDescription", AssessmentDescription);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetStudentAssessments(int UserID, int LecturerModuleID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetStudentAssessments", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", UserID);
            dbComm.Parameters.AddWithValue("@LecturerModuleID", LecturerModuleID);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;

        }
        public DataTable GetAssessmentSubmissionByType(int AssessmentID, string SubmissionStatus)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetAssessmentSubmissionByType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentID", AssessmentID);
            dbComm.Parameters.AddWithValue("@SubmissionStatus", SubmissionStatus);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetLecturerModuleAssessmentsBetweenDates(int UserID, int LecturerModuleID, string StartDate, string EndDate)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetLecturerModuleAssessmentsBetweenDates", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", UserID);
            dbComm.Parameters.AddWithValue("@LecturerModuleID", LecturerModuleID);
            dbComm.Parameters.AddWithValue("@StartDate", StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", EndDate);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }


        public DataTable GetLecturerByID(int UserID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetLecturerById", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", UserID);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetAdministratorByID(int UserID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetAdministratoById", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", UserID);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetAssessmentID(int StudentModuleID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetAssessmentID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentModuleID", StudentModuleID);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public int UpdateStudentModule(StudentModule stuMod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateStudentModules", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentModuleID", stuMod.StudentModuleID);
            dbComm.Parameters.AddWithValue("@LecturerModuleID", stuMod.LecturerModuleID);
            dbComm.Parameters.AddWithValue("@UserID", stuMod.UserID);
            dbComm.Parameters.AddWithValue("@Date", stuMod.Date);
            dbComm.Parameters.AddWithValue("@StudModStatus", stuMod.StudModStatus);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }

        public int UpdateAssessmentType(AssessmentsType assT)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateAssessmentTypes", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", assT.AssessmentTypeID);
            dbComm.Parameters.AddWithValue("@AssessmentTypeDescription", assT.AssessmentTypeDescription);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }


        public int UpdateAssessmentSubmission(AssessmentsSubmission assessmentsS)
        {

            try
            {
                dbConn.Open();

            }
            catch
            {

            }
            sql = "UpdateAssessmentSubmission";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentSubmissionID", assessmentsS.AssessmentSubmissionID);
            dbComm.Parameters.AddWithValue("@DateRescheduled", assessmentsS.DateRescheduled);
            dbComm.Parameters.AddWithValue("@SubmissionStatus", assessmentsS.SubmissionStatus);
            int x = dbComm.ExecuteNonQuery();
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            return x;
        }



        public int UpdateUser(User us)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateUsers", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", us.UserID);
            dbComm.Parameters.AddWithValue("@Name", us.Name);
            dbComm.Parameters.AddWithValue("@Surname", us.Surname);
            dbComm.Parameters.AddWithValue("@Title", us.Title);
            dbComm.Parameters.AddWithValue("@Role", us.Role);
            dbComm.Parameters.AddWithValue("@Email", us.Email);
            dbComm.Parameters.AddWithValue("@Password", us.Password);
            dbComm.Parameters.AddWithValue("@UserStatus", us.UserStatus);
            int x = dbComm.ExecuteNonQuery();
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            return x;
        }

        public int UpdateAssessment(Assessment ass)

        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            sql = "sp_UpadteAssessments";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentID", ass.AssessmentID);
            dbComm.Parameters.AddWithValue("@LecturerModuleID", ass.LecturerModuleID);
            dbComm.Parameters.AddWithValue("@AssessmentDescription", ass.AssessmentDescription);
            dbComm.Parameters.AddWithValue("@DueDate", ass.DueDate);
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", ass.AssessmentTypeID);
            dbComm.Parameters.AddWithValue("@AssessmentStatus", ass.AssessmentStatus);


            int x = dbComm.ExecuteNonQuery();
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            return x;
        }

        public int UpdateLecturerModule(LecturerModule lecMod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateLecturerModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@LecturerModuleID", lecMod.LecturerModuleID);
            dbComm.Parameters.AddWithValue("@UserID", lecMod.UserID);
            dbComm.Parameters.AddWithValue("@ModuleID", lecMod.ModuleID);
            dbComm.Parameters.AddWithValue("@Date", lecMod.Date);
            dbComm.Parameters.AddWithValue("@ModLecturerStatus ", lecMod.ModLecturerStatus);
            int x = dbComm.ExecuteNonQuery();
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            return x;
        }

        public int UpdateModule(Module mod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            sql = "sp_UpdateModules";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleID", mod.ModuleID);
            dbComm.Parameters.AddWithValue("@ModuleName", mod.ModuleName);
            dbComm.Parameters.AddWithValue("@ModuleDuration", mod.ModuleDuration);
            dbComm.Parameters.AddWithValue("@ModuleTypeID", mod.ModuleTypeID);

            int x = dbComm.ExecuteNonQuery();
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            return x;
        }


        public DataTable GetLogin(string email, string password)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetLogin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", email);
            dbComm.Parameters.AddWithValue("@Password", password);
            dataAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }

}
