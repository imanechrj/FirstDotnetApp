using FirstAspDotnetApp.Models;
using FirstAspDotnetApp.ViewModels;
using FirstAspDotnetApp.ViewModels.Home;

namespace FirstAspDotnetApp.Models
{
    public class Students
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public ClassRoom? ClassRoom { get; set; }


        public Students(string firstname, string lastname, ClassRoom? classRoom)
        {
            Firstname = firstname;
            Lastname = lastname;
            classRoom.Students.Add(this);
        }
    }
}
