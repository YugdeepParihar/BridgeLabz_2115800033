using RepositoryLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Services;
using RepositoryLayer.Services;
namespace BusinessLayer.Services
{
    public class UserRegistrationBL
    {
        UserRegistrationRL _userRegistrationRL;


        public UserRegistrationBL(UserRegistrationRL userRegistrationRL) { 
           _userRegistrationRL =userRegistrationRL;
        }
        public string registrationBL(string username,string password)
        {
            var (user,pass) = _userRegistrationRL.registrationRL();

            if(user==username && pass == password)
            {
                return "Registration Successful";
            }
            else
            {
                return "Registration Failed";
            }   
        }
    }
}
