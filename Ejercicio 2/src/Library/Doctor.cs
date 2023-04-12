using System;
using System.Text;
namespace Library;

public class Doctor
{
    public static string CreateDoctor(string DoctorName, string speciality)
    {
        StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
        Boolean isValid = true;
        if (string.IsNullOrEmpty(DoctorName))
        {
            stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
            isValid = false;
        }
        if (string.IsNullOrEmpty(speciality))
        {
            stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
            isValid = false;
        }
        if (isValid)
        {
            stringBuilder.Append("Appoinment scheduled");
        }
        return stringBuilder.ToString();
    }
       
        
}
