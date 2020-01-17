using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Models
{
    public class Calendar
    {
        public List<string> Months { 
            get  {

                List<string> months = new List<string>() 
                { "January" ,"Febuaury", "March", "April", "May", "June", "July", "August", "September",
                  "November", "October", "December"
                
                };

               return months; 
            
            } 
            
            set { 
                
                this.Months = value; 
            
            }
        }
        public List<int> Days
        {
            get
            {

                List<int> days = new List<int>()
                { 31 ,28, 31, 30, 31, 30, 31, 31, 30,
                  31,30, 30

                };

                return days;

            }

            set
            {

                this.Days = value;

            }
        }
    }
}
