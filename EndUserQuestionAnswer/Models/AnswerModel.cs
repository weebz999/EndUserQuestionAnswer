using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EndUserQuestionAnswer.Models
{
    public class AnswerModel
    {
        public int CustomerID { get; set; }
        public string Answer { get; set; }
        public int QuestionsID { get; set; }
    }
}