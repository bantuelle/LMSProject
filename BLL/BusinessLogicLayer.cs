using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();

        public DataTable GetMyModule()
        {
            return dal.GetMyModule();
        }
        public int InsertUser(User user)
        {
            return dal.InsertUser(user);
        }
        public int InsertStudent()
        {
            return dal.InsertStudent();
        }

        public int AddAssessmentType(AssessmentsType assT)
        {
            return dal.AddAssessmentType(assT);
        }

        public int AddStudentModule(StudentModule stuMod)
        {
            return dal.AddStudentModule(stuMod);
        }

        public int InsertLecturer()
        {
            return dal.InsertLecturer();
        }

        public int AddLecturerModule(LecturerModule lecMod)
        {
            return dal.AddLecturerModule(lecMod);
        }

        public int InsertModule(Module mod)
        {
            return dal.InsertModule(mod);
        }

        public int AddModuleType(ModuleType modT)
        {
            return dal.AddModuleType(modT);
        }

        public int AddAssessment(Assessment ass)
        {
            return dal.AddAssessment(ass);
        }

        public int AddAdministrator()
        {
            return dal.InsertAdmin();
        }

        public int AddAssessmentSubmission(Assessment assessments)
        {
            return dal.AddAssessmentSubmission(assessments);
        }


        public int DeleteStudentModule(StudentModule stuMod)
        {
            return dal.DeleteStudentModule(stuMod);
        }

        public int DeleteLecturerModule(LecturerModule lecMod)
        {
            return dal.DeleteLecturerModule(lecMod);
        }

        public int DeleteModule(Module mod)
        {
            return dal.DeleteModule(mod);
        }

        public int HardDeleteUsers(int user)
        {
            return dal.HardDeleteUsers(user);
        }

        public int DeleteAssessment(Assessment ass)
        {
            return dal.DeleteAssessment(ass);
        }

        public int DeleteUser(User us)
        {
            return dal.DeleteUser(us);
        }

        public int DeleteAssessmentType(int assT)
        {
            return dal.DeleteAssessmentType(assT);
        }

        public int DeleteModuleType(ModuleType moduleType)
        {
            return dal.DeleteModuleType(moduleType);
        }
        public DataTable GetInActiveUsers()
        {
            return dal.GetInActiveUsers();
        }

        public DataTable GetStudent()
        {
            return dal.GetStudent();
        }

        public DataTable GetLecturer()
        {
            return dal.GetLecturer();
        }

        public DataTable GetAssessmentByType(int AssessmentTypeID)
        {
            return dal.GetAssessmentByType(AssessmentTypeID);
        }
        public DataTable GetAssessmentByID(int AssessmentID, string AssessmentDescription)
        {
            return dal.GetAssessmentByID(AssessmentID, AssessmentDescription);
        }
        public DataTable GetUsersByRole(string role)
        {
            return dal.GetUsersByRole(role);
        }

        public DataTable GetUsersBySearching(int Search, string name)
        {
            return dal.GetUsersBySearching(Search, name);
        }

        public DataTable GetModuleDetailsBySearching(string search)
        {
            return dal.GetModuleDetailsBySearching(search);
        }

        public DataTable GetAssessmentSubmissionByType(int AssessmentID, string SubmissionStatus)
        {
            return dal.GetAssessmentSubmissionByType(AssessmentID, SubmissionStatus);
        }

        public DataTable GetLecturerModuleAssessmentsBetweenDates(int UserID, int LecturerModuleID, string StartDate, string EndDate)
        {
            return dal.GetLecturerModuleAssessmentsBetweenDates(UserID, LecturerModuleID, StartDate, EndDate);
        }

        public DataTable GetStudentAssessments(int UserID, int LecturerModuleID)
        {
            return dal.GetStudentAssessments(UserID, LecturerModuleID);
        }

        public DataTable GetStudentModule()
        {
            return dal.GetStudentModule();
        }

        public DataTable GetLecturerModule()
        {
            return dal.GetLecturerModule();
        }

        public DataTable GetModule()
        {
            return dal.GetModule();
        }

        public DataTable GetModuleType()
        {
            return dal.GetModuleType();
        }

        public DataTable GetAssessments()
        {
            return dal.GetAssessments();
        }

        public DataTable GetUser()
        {
            return dal.GetUser();
        }

        public DataTable GetAdministrators()
        {
            return dal.GetAdministrator();
        }

        public DataTable GetAdministratorByID(int administrator)
        {
            return dal.GetAdministratorByID(administrator);
        }

        public DataTable GetLecturerByID(int lec)
        {
            return dal.GetLecturerByID(lec);
        }

        public DataTable GetStudentByID(int stud, string name)
        {
            return dal.GetStudentByID(stud, name);
        }

        public DataTable GetAssessmentID(int stud)
        {
            return dal.GetAssessmentID(stud);
        }

        public DataTable GetLecturerAssessments(int userid)
        {
            return dal.GetLecturerAssessments(userid);
        }

        public DataTable GetModuleAssessments(int stud)
        {
            return dal.GetModuleAssessments(stud);
        }

        public DataTable GetStudentModuleID(int userID, int lecMod)
        {
            return dal.GetStudentModuleID(userID, lecMod);
        }

        public DataTable GetAssessmentType()
        {
            return dal.GetAssessmentType();
        }

        public DataTable GetLogin(string email, string password)
        {
            return dal.GetLogin(email, password);
        }

        public int UpdateStudentModule(StudentModule stuMod)
        {
            return dal.UpdateStudentModule(stuMod);
        }


        public int UpdateLecturerModule(LecturerModule lecMod)
        {
            return dal.UpdateLecturerModule(lecMod);
        }


        public int UpdateModule(Module mod)
        {
            return dal.UpdateModule(mod);
        }

        public int UpdateAssessment(Assessment ass)
        {
            return dal.UpdateAssessment(ass);
        }

        public int UpdateUser(User us)
        {
            return dal.UpdateUser(us);
        }

        public int UpdateAssessmentSubmission(AssessmentsSubmission assessments)
        {
            return dal.UpdateAssessmentSubmission(assessments);
        }

        public int UpdateAssessmentType(AssessmentsType assT)
        {
            return dal.UpdateAssessmentType(assT);
        }

    }
}
