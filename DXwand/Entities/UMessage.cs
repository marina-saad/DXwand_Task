using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DXwand.Entities
{
    public class UMessage
    {
        public int Id { get; set; }

       
        [RegularExpression(@"^[a-zA-Z0-9\s.\?\,\'\;\:\!\-]+$",ErrorMessage = "Characters are not allowed.")]
        public String MContent { get; set; }
        public string LanguageId { get; set; }
        //public Time SendTime { get; set; }
    }
}
