using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EndUserQuestionAnswer.Models;
using System.Data;
using EndUserQuestionAnswer.Database_Access_Layer;
using System.Data.SqlClient;


namespace EndUserQuestionAnswer.Controllers

{

    public class HomeController : Controller
    {
        Database_Access_Layer.Db Db = new Database_Access_Layer.Db();


        // GET: Home
        public ActionResult Index()
        {

            return View();
        }
        //[HttpPost]
        public JsonResult GetQuestion(int questionsId)
        {
            DataSet dataSet = Db.Showdata(questionsId);
            QuestionModel question = new QuestionModel();
            question.QuestionId = Convert.ToInt32(dataSet.Tables[0].Rows[0]["QuestionsId"]);
            question.Question = dataSet.Tables[0].Rows[0]["Questions"].ToString();
            question.QuestionOrder = Convert.ToInt32(dataSet.Tables[0].Rows[0]["QOrder"]);
            question.NextID = Convert.ToInt32(dataSet.Tables[0].Rows[0]["NextQuestion"]);

            return Json(question, JsonRequestBehavior.AllowGet);
        }


        public JsonResult Savedata(int customerID,string answerText,int questionID )
        {
            QuestionModel questionModel = new QuestionModel();
            string sccuess = Db.SaveData(customerID, answerText, questionID);


            //return Json("OK", JsonRequestBehavior.AllowGet);
            return null;
        }

    }
}

