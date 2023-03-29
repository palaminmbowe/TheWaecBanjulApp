using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTDUtilities.Objects
{
    class CandidateGabece : Candidate
    {
        private SchoolOfChoice schoolOfChoice;
        private SchoolOfChoice schoolOfChoice2;
        private SchoolOfChoice schoolOfChoice3;

        public CandidateGabece(string examYear, string centNo, string indexNo, string connectionString)
            :base(examYear, centNo, indexNo, connectionString){}

        public SchoolOfChoice SchoolOfChoice
        {
            get { return schoolOfChoice; }
            set { schoolOfChoice = value; }
        }

        public SchoolOfChoice SchoolOfChoice2
        {
            get { return schoolOfChoice2; }
            set { schoolOfChoice2 = value; }
        }

        public SchoolOfChoice SchoolOfChoice3
        {
            get { return schoolOfChoice3; }
            set { schoolOfChoice3 = value; }
        }



        public override bool RetrieveCandidateDetails()
        {
            try
            {
                if (DbConnection.isConnected())
                {
                    DbConnection.con.Open();
                    //table name = [02OUTGABECE]
                    // create sql statement
                    DbConnection.cmd.CommandText = "SELECT examYear, CentNo, IndexNo, CandName, DOB, SEX, Sub1, Sub2, Sub3, Sub4, Sub5, Sub6, Sub7, Sub8, " +
                        "Sub9, TotSubs, CHOICE, DisabilityCode, CHOICE2, CHOICE3 FROM 02OUTGABECE WHERE examYear = '" + ExamYear + "' AND CentNo = '" + CentNo + "' AND IndexNo = '" + IndexNo + "';";

                    DbConnection.dr = DbConnection.cmd.ExecuteReader();

                    // retrieve data and assign to objects
                    if (!DbConnection.dr.HasRows)
                        return false;

                    while(DbConnection.dr.Read())
                    {
                        //CandName
                        CandidateName = DbConnection.dr["CandName"].ToString();

                        //DOB
                        try 
	                    {	        
		                    DateTime dt = new DateTime(
                            int.Parse(DbConnection.dr["DOB"].ToString().Substring(6,4)),
                            int.Parse(DbConnection.dr["DOB"].ToString().Substring(3, 2)),
                            int.Parse(DbConnection.dr["DOB"].ToString().Substring(0, 2)));

                            DateOfBirth = dt;
	                    }
	                    catch (Exception ex)
	                    {
                            Console.WriteLine("Error getting date of birth: " + ex.Message);
	                    }

                        //Sex
                        Sex = new Sex(DbConnection.dr["SEX"].ToString());

                        //Subjects
                        try
                        {
                            for (int i = 0; i < int.Parse(DbConnection.dr["TotSubs"].ToString()); i++)
                            {
                                Subject s = new Subject(DbConnection.dr[(i+6)].ToString(),
                                    Common.GetSubjectName(DbConnection.dr[(i+6)].ToString()));
                                Subjects.Add(s);
                            }

                            // confirm total subjects
                            if ((Subjects.Count != int.Parse(DbConnection.dr["TotSubs"].ToString())))
                            {
                                // error with subjects
                                return false;
                            }
                            else
                            {
                                TotalSubjects = Subjects.Count;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error in getting subjects: " + ex.Message);
                        }

                        //school of choice
                        SchoolOfChoice = new SchoolOfChoice(DbConnection.dr["CHOICE"].ToString(),
                            Common.GetSchoolOfChoiceName(DbConnection.dr["CHOICE"].ToString()));
                        SchoolOfChoice2 = new SchoolOfChoice(DbConnection.dr["CHOICE2"].ToString(),
                            Common.GetSchoolOfChoiceName(DbConnection.dr["CHOICE2"].ToString()));
                        SchoolOfChoice3 = new SchoolOfChoice(DbConnection.dr["CHOICE3"].ToString(),
                            Common.GetSchoolOfChoiceName(DbConnection.dr["CHOICE3"].ToString()));

                        //DisabilityCode
                        Disability = new Disability(DbConnection.dr["DisabilityCode"].ToString());                            
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting candidate: " + ex.Message);
            }
            finally
            {
                DbConnection.con.Close();
            }
            return false;
        }

        public override bool UpdateCandidateDetails(string userName, string pcName, string domainName)
        {
            try
            {
                DbConnection.con.Open();
                // build sql

                string sql = "Update [02OUTGabece] SET CandName = '" + CandidateName + "', DOB = CDate('" + DateOfBirth.Date + "'), SEX = '" + Sex.Code + "', DisabilityCode = " + DisabilityCode.ToString() + ", TotSubs = '" + Subjects.Count.ToString() + "', " +
                    "Choice = '" + SchoolOfChoice.Code + "', Choice2 = '" + SchoolOfChoice2.Code + "', Choice3 = '" + SchoolOfChoice3.Code + "', LastModified = NOW(), Modified = True, Processed = False, Username = '" + userName + "', pcName = '" + pcName + "', DomainName = '" + domainName + "' ";
                    
                // subjects
                for (int i = 1; i <= Subjects.Count; i++)
                {
                    sql += ", Sub" + i.ToString() + " = '" + Subjects[i-1].ShortCode + "'";
                }

                // set remaining subjects to null
                for (int i = (Subjects.Count +1); i <= 9; i++)
                {
                    sql += ", Sub" + i.ToString() + " = ''";
                }
                // where clause

                sql += " WHERE examYear = '" + ExamYear + "' AND CentNo = '" + CentNo + "' AND IndexNo = '" + IndexNo + "';";

                DbConnection.cmd.CommandText = sql;


                int result = DbConnection.cmd.ExecuteNonQuery();

                if(result > 0)
                    return true;
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updaing candidate: " + ex.Message);
            }
            finally
            {
                DbConnection.con.Close();
            }
            return false;
        }

        public override bool AddSubject(string shortCode)
        {
            return base.AddSubject(shortCode);
        }

        public override bool RemoveSubject(string shortCode)
        {
            if((shortCode.Equals("111")) || (shortCode.Equals("112")) || (shortCode.Equals("113")) || (shortCode.Equals("114")))
                return false;
            else
                if (CheckForNoSubjectGroupViolation(shortCode))                
                    return base.RemoveSubject(shortCode);
                else
                    return false;
        }

        private bool CheckForNoSubjectGroupViolation(string shortCode)
        {
            // checks whether if subject is removed, there will be a group violation
            bool g1 = false;
            bool g2 = false;
            bool g3 = false;

            try
            {
                foreach (Subject s in Subjects)
                {
                    if (s.ShortCode.Equals(shortCode))
                        continue;
                    else
                    {
                        switch (s.ShortCode[0])
                        {
                            case '1':
                                g1 = true;
                                break;
                            case '2':
                                g2 = true;
                                break;
                            case '3':
                                g3 = true;
                                break;
                            default:
                                break;
                        }
                    }
                }

                return g1 && g2 && g3;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inCheckForSubjectGroupViolation: " + ex.Message);
            }
            return false;
        }
    }
}
