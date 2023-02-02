namespace OnboardingApi.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class DepartmentConfig
    {
        public string Id { get; set; } = string.Empty;
        public string DepartmentId{ get; set; } = string.Empty;
        public List<string> Configuration { get; set; }
    }
}
