using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class studentAccounts
{


    private string studentUserName;
    private string studentPassword;
    
    public string StudentName
    {
        get { return studentUserName; }
        set { studentUserName = value; }
    }
    public string StudentPassword
    {
        get { return studentPassword; }
        set { studentPassword = value; }
    }


}

public class adminAccounts
{
    private string adminUsername;
    private string adminPassword;

    public string adminName
    {
        get { return adminUsername; }
        set { adminUsername = value; }
    }
    public string adminPass
    {
        get { return adminPassword; }
        set { adminPassword = value; }
    }
}

public static class UserAccounts
{
    public static List<studentAccounts> studentList = new List<studentAccounts>() //list of student accounts
    {
        new studentAccounts
        {
            StudentName = "John",
            StudentPassword = "1234"
        }
    };

    public static List<adminAccounts> adminList = new List<adminAccounts>()  //List of the admin accounts
    {
        new adminAccounts
        {
            adminName = "Ronan",
            adminPass = "Password"
        }
    };
}
