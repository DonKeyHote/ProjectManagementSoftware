namespace ProjectManagementSoftware.ViewModels
{
    public class ProjectListViewModel
    {
    //ListProject Method
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
    }
    public class ProjectFormViewModel
    {
    //CreateProject Method
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectStartDate { get; set; }
        public string ProjectEndDate { get; set; }
        public string Action{
            get{
                if(ProjectID > 0){
                    return "Edit";
                }
                else
                    return "Create";
            }
        }
    }
    public class EditProject
    {
    //EditProject Method
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
    }
}