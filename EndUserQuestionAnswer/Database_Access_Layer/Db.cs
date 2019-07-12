using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using System.Configuration;
using EndUserQuestionAnswer.Models;

namespace EndUserQuestionAnswer.Database_Access_Layer
{
    public class Db
    {
        
        string ConnectionStrings = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
        public DataSet Showdata(int id)
        {
            
            string query = "SELECT * FROM QuestionTable WHERE QuestionsID = " + id;
                    SqlConnection SqlConnection = new SqlConnection(ConnectionStrings);
            SqlConnection.Open();
            SqlCommand SqlCommand = new SqlCommand(query, SqlConnection);
                     
                    SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(SqlCommand);
                    DataSet DataSet = new DataSet();
            SqlDataAdapter.Fill(DataSet, "QuestionTable"); 


                    return DataSet;
                
                
            }


        public string SaveData(int customerID ,string AnswerText,int QuestionsID )

        {
             
            SqlConnection con = new SqlConnection(ConnectionStrings);
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_EndUserAnswers3", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter() { ParameterName = "@CustomerID", Value = customerID });
            cmd.Parameters.Add(new SqlParameter() { ParameterName = "@Answers", Value = AnswerText });
            cmd.Parameters.Add(new SqlParameter() { ParameterName = "@QuestionID", Value = QuestionsID });
          
             //cmd.Parameters.AddWithValue("@QuestionID", QuestionsID);
            //cmd.Parameters.AddWithValue("@Answer", AnswerText);
            cmd.ExecuteNonQuery();
            con.Close();
            return "Scuesss";
        }

    }

    

         
    }

    
 