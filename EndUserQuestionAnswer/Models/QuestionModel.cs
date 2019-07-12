using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EndUserQuestionAnswer.Models
{
    public class QuestionModel
    {

        public int QuestionId { get; set; }
        public string Question { get; set; }
        public int QuestionOrder { get; set; }
         
        public int NextID { get; set; }

    }
   
}