using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaithiASP.Models
{
    public class Exam
    {
        [Key]
        public int? Id { get; set; }
        public ExamSubjectType ExamSubject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime ExamDate { get; set; }
        public int ExamDuration { get; set; }
        public ClassRoomType ClassRoom { get; set; }
        public FacultyType Faculty { get; set; }
        public StatusType Status { get; set; }

        public enum ExamSubjectType { CoreJava = 1, AdvanceJava = 2, ProgrammingC = 3 }
        public enum ClassRoomType { B10 = 1, B16 = 2, B14 = 3 }
        public enum FacultyType { Jaya = 1, John = 2, HienPA = 3 }
        public enum StatusType { Done = 1, UpComing = 2, OnGoing = 3 }
    }
}
