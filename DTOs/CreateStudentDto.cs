namespace StudentManagement.API.DTOs
{
    public class CreateStudentDto
    {
        public string FullName {  get; set; }  
        public string Email {  get; set; }
        public DateTime DateOfBirth {  get; set; }
    }
}
