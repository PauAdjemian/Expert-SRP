using System;
using System.Text;
namespace Library;

public class Pacient
{
    public static string CreatePacient(String PacientName, String PacientId,String PacientPhoneNumber)
    {
        StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
        Boolean isValid = true;
        if (string.IsNullOrEmpty(PacientName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

        if (string.IsNullOrEmpty(PacientId))
        {
            stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
            isValid = false;
        }

        if (string.IsNullOrEmpty(PacientPhoneNumber))
        {
            stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
            isValid = false;
        }
        if (isValid)
        {
            stringBuilder.Append("Appoinment scheduled");
        }
        return stringBuilder.ToString();
    }
}

