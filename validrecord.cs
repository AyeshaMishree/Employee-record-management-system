using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
   
    public class validrecord
    {
        [Required]
        [Range(1, 10000)]
        public int Id { get; set; }
        [Required, RegularExpression(@" ^.*{1,40}", ErrorMessage = "Please enter a valid id, use numbers only!")]
        public string name { get; set; }
        [Required, RegularExpression(@" ^[a-zA-Z'.\s]{1,40}$", ErrorMessage = "Please enter a valid name, special characters are not allowed!")]
        public string gender { get; set; }
        [Required, RegularExpression(@" ^.*[a-zA-Z]", ErrorMessage = "Please select a valid gender!")]
        public string contactno { get; set; }
        [Required, RegularExpression(@" ^.*[0-9]{10}$", ErrorMessage = "Please enter a valid contact number!")]
        public string emailid { get; set; }
        [Required, RegularExpression(@" ^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$ ", ErrorMessage = "Please enter a valid email address!")]
        public string designation { get; set; }
        [Required, RegularExpression(@" ^[a-zA-Z'.\s]{1,40}$", ErrorMessage = "Please select a valid designation!")]
        public double salary { get; set; }
        [Required, RegularExpression(@" ^.*{1,40}", ErrorMessage = "Please enter salary in digits only!")]
        public string dateofhire { get; set; }
        [Required, RegularExpression(@" ^.*(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9] | 1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Please enter a valid date in in the format (9/9/2020) !")]
        public string dateoffire { get; set; }
       // [Required, RegularExpression(@" ^.*(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9] | 1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Please enter a valid date in in the format (9/9/2020) !")]

    }
}
