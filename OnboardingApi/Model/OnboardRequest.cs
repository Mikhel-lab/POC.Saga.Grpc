namespace OnboardingApi.Model
{
    public class OnboardRequest
    {
        public string RIN { get; set; } 
    }

    public class OnboardResponse
    {
        public string RIN { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Department Departments { get; set; }
        public DepartmentConfig DepartmentConfig { get; set; } = new DepartmentConfig();

    }
}

