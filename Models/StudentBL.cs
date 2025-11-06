
//using namespace std;
namespace MVC_second.Models
{

    public class StudentBL
    {
        List<student> students;
        public StudentBL()
        {
            students = new List<student>();
            students.Add(new student() { id = 1, name = "aya" });
            students.Add(new student() { id = 2, name = "hamdy" });
            students.Add(new student() { id = 3, name = "mai" });
        }
        public List<student> getall()
        {
            return students;
        }
        public student getbyid(int id) { 
        return students.FirstOrDefault(s => s.id == id);
        }
    }
}