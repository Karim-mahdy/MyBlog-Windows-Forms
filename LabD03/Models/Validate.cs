using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabD03.Models
{
    public class Validate
    {
       
        public  bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid email address.");
                return false;
            }
        }
        public  bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[a-zA-Z]).{8,}$";
            if (Regex.IsMatch(password, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Password Must Be more Than 8 char With one Letter ");
                return false;
            }
        }
        public  bool ValidateAge(decimal age)
        {
            if (age > 15) return true;
            else
            {
                MessageBox.Show("Age Must Be more Than 15");
                return false;
            }
        }
        internal  bool IsEmailValid(string Email, ITIDbContext context)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            if (Email == null)
            {
                MessageBox.Show(" Invalid Email");
                return false;
            }
            else if (context.Authors.Any(i => i.Email == Email))
            {
                MessageBox.Show(" Email Isnt available");
                return false;
            }
            else if (Regex.IsMatch(Email, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show(" Email not valid ");
                return false;
            }
        }
    }
}
