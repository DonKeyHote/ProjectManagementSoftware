using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectManagementSoftware.Models
{
    public class UseCase{
        public int UseCaseID { get; set; }
        [StringLength(150)]
        public string UseCaseDesc { get; set; }
        public DateTime CreatedDate { get; set; }
        [StringLength(6)]
        public string CreatedByEmpNum { get; set; }
        public DateTime ModifiedDate { get; set; }
        [StringLength(6)]
        public string ModifiedByEmpNum { get; set; }

        public int ProjectID { get; set; }
        public virtual Project Project { get; set; }
    }
}