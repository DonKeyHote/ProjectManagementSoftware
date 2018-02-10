using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectManagementSoftware.Models
{
    public class Project{
        public int ProjectID { get; set; }
        [StringLength(50)]
        public string ProjectName { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectEndDate { get; set; }
        [StringLength(500)]
        public string ProjectNotes { get; set; }

    }
}