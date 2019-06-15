using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
/// <summary>
/// Summary description for TaskManager
/// </summary>
public class TaskManager
{
    SqlConnection con;
	public TaskManager()
	{
        con = new SqlConnection(@"Data Source=MOHAMMAD\MOHAMMAD;Initial Catalog=Solution;Integrated Security=True;");
	}
    public class QC
    {
        public int id, paid, pid, isy, isn;
        public string qu, yn;
    }
    public class pr
    {
        public int id;
        public string pr_, ca;
    }

    /// <summary>
    /// /////////////////////////////NEW PROBLEM PROCESS///////////////////////////////////////////
    /// </summary>
    /// <returns></returns>
    public List<string> getCats()
    {
        List<string> retVal = new List<string>();
        string command = "SELECT * FROM [Category] ";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
            retVal.Add(reader.GetString(1));
        reader.Close();
        con.Close();
        return retVal;
    }
    public bool newCat(string cat)
    {
        try
        {
            string command = "INSERT INTO [Category] (Category) VALUES('" + cat + "')";
            SqlCommand com = new SqlCommand(command, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        catch(Exception ex)
        {
            return false;
        }
        return true;
    }
    public bool newProblem(string cat,string problem)
    {
        try
        {
            string command = "INSERT INTO [PROBLEMS] (Problem,Category) VALUES('"+problem+"','" + cat + "')";
            SqlCommand com = new SqlCommand(command, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception ex)
        {
            return false;
        }
        return true;
    }
    public int getProblemId(string problem)
    {
        int retVal=0;
        string command = "SELECT ID FROM [PROBLEMS] WHERE CONVERT(VARCHAR, Problem) ='" + problem + "'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
            retVal = reader.GetInt32(0);
        reader.Close();
        con.Close();
        return retVal;
    }
    
    public List<pr> getProblems()
    {
        List<pr> retVal = new List<pr>();
        string command = "SELECT * FROM [PROBLEMS] ";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
        {
            pr t = new pr();
            t.id = reader.GetInt32(0);
            t.pr_ = reader.GetString(1);
            t.ca = reader.GetString(2);
            retVal.Add(t);
        }
        reader.Close();
        con.Close();
        return retVal;
    }
    //////////////////////////////////END OF NEW PROBLEM////////////////////////////////////////////////////
    

    /////////////////////////////////First Question/////////////////////////////////////////////////////

    public string getProblem(int id)
    {
        string retVal = "";
        string command = "SELECT Problem FROM [PROBLEMS] WHERE ID='" + id + "'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        if (reader.Read())
            retVal = reader.GetString(0);
        reader.Close();
        con.Close();
        return retVal;
    }


    public bool newQuestion(int paId,int pId,string qu,int ys,int ns,string yn)
    {
        try
        {
            string command = "INSERT INTO [Y_Qu] (Parent_ID,Problem_ID,Question,Is_Y_Sol,Is_N_Sol,Y_N) VALUES('" + paId + "','" + pId + "','"+qu+"','"+ys+"','"+ns+"','"+yn+"')";
            SqlCommand com = new SqlCommand(command, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception ex)
        {
            return false;
        }
        return true;
    }
    public int getFQID(string qu)
    {
        int retVal = 0;
        string command = "SELECT ID FROM [Y_Qu] WHERE CONVERT(VARCHAR, Question) ='" + qu + "'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
            retVal = reader.GetInt32(0);
        reader.Close();
        con.Close();
        return retVal;
    }
    public void requestProblem(string problem)
    {
        string command = "INSERT INTO [Request] (Problem) VALUES('" + problem + "')";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
    }
    public List<string> getRequests()
    {
        List<string> retVal = new List<string>();
        string command = "SELECT Problem FROM [Request]";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
            retVal.Add(reader.GetString(0));
        reader.Close();
        con.Close();
        return retVal;
    }
    public string getQu(int id)
    {
        string retVal = "";
        string command = "SELECT Question FROM [Y_Qu] WHERE ID='" + id + "'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        if (reader.Read())
            retVal = reader.GetString(0);
        reader.Close();
        con.Close();
        return retVal;
    }
    public QC getQus(int pId,int paId,string yn)
    {
        QC QU = new QC();
        string command = "SELECT * FROM [Y_Qu] WHERE Problem_ID ='" + pId + "' AND Parent_ID='"+paId+"' AND Y_N='"+yn+"'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        if (reader.Read())
        {
            QU.id = reader.GetInt32(0);
            QU.paid = reader.GetInt32(1);
            QU.pid = reader.GetInt32(2);
            QU.qu = reader.GetString(3);
            QU.isy = reader.GetInt32(4);
            QU.isn = reader.GetInt32(5);
            QU.yn = reader.GetString(6);
        }
        reader.Close();
        con.Close();
        return QU;
    }
    public List<string> getSol(int paId,string yn)
    {
        List<string> retVal = new List<string>();
        string command = "SELECT * FROM [Solutions] WHERE Parent_ID ='" + paId + "' AND YN='" + yn + "'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        if (reader.Read())
        {
            retVal.Add(reader.GetString(2));
            retVal.Add(reader.GetString(3));
            retVal.Add(reader.GetString(4));
            retVal.Add(reader.GetString(5));
            retVal.Add(reader.GetString(6));
            retVal.Add(reader.GetString(7));
        }
        reader.Close();
        con.Close();
        return retVal;
    }
    public List<QC> getQuestions(int pId)
    {
        List<QC> allQU = new List<QC>();
        string command = "SELECT * FROM [Y_Qu] WHERE Problem_ID ='" + pId + "'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
        {
            QC QU = new QC();
            QU.id = reader.GetInt32(0);
            QU.paid = reader.GetInt32(1);
            QU.pid = reader.GetInt32(2);
            QU.qu = reader.GetString(3);

            QU.isy = reader.GetInt32(4);
            QU.isn = reader.GetInt32(5);
            QU.yn = reader.GetString(6);
            allQU.Add(QU);
        }
        reader.Close();
        con.Close();

        List<int> sPaId = new List<int>();
        command = "SELECT Parent_ID FROM [Solutions]";
        com = new SqlCommand(command, con);

        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
        {
            sPaId.Add(reader.GetInt32(0));
        }
        reader.Close();
        con.Close();
        int nextQuestionID = -1;
       

        foreach(QC temp in allQU)
        {
            bool haveNext = false;
            for (int i = 0; i < allQU.Count; i++)
            {
                if (temp.id == allQU[i].paid)
                {
                    haveNext = true;
                    break;
                }
            }
            if (!haveNext)
            {
                foreach (int t in sPaId)
                {
                    if (temp.id == t)
                    {
                        haveNext = true;
                        break;
                    }
                }
                if (!haveNext)
                    nextQuestionID = temp.id;
            }
        }
        int nextQuestionParentID = -1;
        foreach (QC temp in allQU)
        {
            if (temp.id == nextQuestionID)
            {
                nextQuestionParentID = temp.paid;
                break;
            }
        }
        List<QC> retVal = new List<QC>();
        foreach (QC temp in allQU)
        {
            if (temp.paid == nextQuestionParentID)
            {
                retVal.Add(temp);
            }
        }
        return retVal;
    }
    ///////
    public bool Login(string userName,string pass)
    {
        bool retVal = false;
        string command = "SELECT * FROM [User] WHERE UN ='" + userName + "' AND PASS='"+pass+"'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        if (reader.Read())
            retVal = true;
        con.Close();
        return retVal;
    }
    public bool CreateAccount(string userName,string pass)
    {
        bool retVal = true;
        string command = "INSERT INTO [User] (UN,PASS) VALUES('"+userName+"','"+pass+"')";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        try 
        {
            com.ExecuteNonQuery();
        }
        catch(Exception)
        {
            retVal = false;
        }
        con.Close();
        return retVal;
    }
    public bool editProblem(int pid, string question)
    {
        bool retVal = false;
        int id = 0;
        string command = "SELECT ID FROM [Y_Qu] WHERE Problem_ID='" + pid + "' AND Question LIKE '%" + question + "%'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        if (reader.Read())
            id=reader.GetInt32(0);
        con.Close();
        if (id != 0)
        {
            retVal = true;
            command = "DELETE FROM [Y_Qu] WHERE Problem_ID='" + pid + "' AND Parent_ID>='" + id + "'";
            com = new SqlCommand(command, con);
            con.Open();
            com.ExecuteNonQuery();
            command = "DELETE FROM [Y_Qu] WHERE Problem_ID='" + pid + "' AND ID='" + id + "'";
            com = new SqlCommand(command, con);
            com.ExecuteNonQuery();
            con.Close();
        }



        return retVal;
    }
    public void deleteProblem(int pId)
    {
        string command = "DELETE FROM [PROBLEMS] WHERE ID='" + pId + "'";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        com.ExecuteNonQuery();
        command = "DELETE FROM [Y_Qu] WHERE Problem_ID='" + pId + "'";
        com = new SqlCommand(command, con);
        com.ExecuteNonQuery();
        con.Close();

    }
    public bool insertSolution(int paId,string s1,string s2,string s3,string s4,string s5,string s6,string yn)
    {
        if (s1 == null)
            s1 = "";
        if (s2 == null)
            s2 = "";
        if (s3 == null)
            s3 = "";
        if (s4 == null)
            s4 = "";
        if (s5 == null)
            s5 = "";
        if (s6 == null)
            s6 = "";
        try
        {
            string command = "INSERT INTO [Solutions] (Parent_ID,S1,S2,S3,S4,S5,S6,YN) VALUES('" + paId + "','" + s1 + "','" + s2 + "','" + s3 + "','" + s4 + "','" + s5 + "','"+s6+"','"+yn+"')";
            SqlCommand com = new SqlCommand(command, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception ex)
        {
            return false;
        }
        return true;
    }
}