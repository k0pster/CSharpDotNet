namespace mvc_app.Models;

public class EngineeringDepartment
{
    public string[] CurrentSoftwareProjects { get; set; }

    public EngineeringDepartment()
    {
        //retrieve data from DB or web service
        CurrentSoftwareProjects = ["Cool Web App", "Mobile App", "MobApp update"];
    }
}