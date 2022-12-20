using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AssessmentsSubmission
    {
        public int AssessmentSubmissionID { get; set; }
        public int AssessmentID { get; set; }
        public int StudentModuleID { get; set; }
        public string DateRescheduled { get; set; }
        public string SubmissionStatus { get; set; }
    }
}
