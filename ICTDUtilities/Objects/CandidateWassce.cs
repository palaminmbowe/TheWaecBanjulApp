using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTDUtilities.Objects
{
    class CandidateWassce : Candidate
    {
        bool[] groupFlags = new bool[5];
        public CandidateWassce(string examYear, string centNo, string indexNo, string connectionString)
            :base(examYear, centNo, indexNo, connectionString){}


        public override bool RetrieveCandidateDetails()
        {
            try
            {
                if (DbConnection.isConnected())
                {
                    DbConnection.con.Open();
                    // create sql statement
                    DbConnection.cmd.CommandText = "SELECT ExamYear, CentNo, IndexNo, CandName, DOB, SEX, Sub1, Sub2, Sub3, Sub4, Sub5, Sub6, Sub7, Sub8, " +
                        "Sub9, TotSubs, DisabilityCode FROM 02OUTWASSCE WHERE examYear = '" + ExamYear + "' AND CentNo = '" + CentNo + "' AND IndexNo = '" + IndexNo + "';";

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

                //string sql = "";
                //string sql = "Update [02OUTGabece] SET CandName = '" + CandidateName + "', DOB = CDate('" + DateOfBirth.Date + "'), SEX = '" + Sex.Code + "', DisabilityCode = " + DisabilityCode.ToString() + ", TotSubs = '" + Subjects.Count.ToString() + "', " +
                //    "Choice = '" + SchoolOfChoice.Code + "', Choice2 = '" + SchoolOfChoice2.Code + "', Choice3 = '" + SchoolOfChoice3.Code + "', LastModified = NOW(), Modified = True, Processed = False, Username = '" + userName + "', pcName = '" + pcName + "', DomainName = '" + domainName + "' ";

                string sql = "Update [02OUTWassce] SET CandName = '" + CandidateName + 
                    "', DOB = CDate('" + DateOfBirth.Date + 
                    "'), SEX = '" + Sex.Code + 
                    "', DisabilityCode = " + DisabilityCode.ToString() + 
                    ", TotSubs = '" + Subjects.Count.ToString() + "', " +
                    "LastModified = NOW(), Modified = True, Processed = False, Reprocess = True, Username = '" + userName + "', pcName = '" + pcName + "', DomainName = '" + domainName + "' ";

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
            if((shortCode.Equals("302")) || (shortCode.Equals("402")))
                return false;
            else
                if (CheckForNoSubjectGroupViolation(shortCode))                
                    return base.RemoveSubject(shortCode);
                else
                    return false;
        }

        public bool CheckForNoSubjectGroupViolation(string shortCode, out bool[] gFlags)
        {
            gFlags = groupFlags;

            return CheckForNoSubjectGroupViolation(shortCode);
        }

        private bool CheckForNoSubjectGroupViolation(string shortCode)
        {
            // checks whether if subject is removed, there will be a group violation
            for (int i = 0; i < groupFlags.Length-1; i++)
            {
                groupFlags[i] = false;
            }

            try
            {
                foreach (Subject s in Subjects)
                {
                    if (s.ShortCode.Equals(shortCode))
                        continue;
                    else
                    {
                        switch (s.ShortCode)
                        {
                            case "302":
                                groupFlags[0] = true;
                                break;
                            case "402":
                                groupFlags[1] = true;
                                break;
                            case "204":
                            case "207":
                            case "210":
                                groupFlags[2] = true;
                                break;
                            case "504":
                            case "505":
                            case "510":
                            case "512":
                                groupFlags[3] = true;
                                break;
                            case "502":
                            case "601":
                            case "603":
                            case "607":
                            case "608":
                            case "609":
                            case "701":
                            case "702":
                            case "703":
                            case "706":
                                groupFlags[4] = true;
                                break;
                            default:
                                break;
                        }
                    }
                }

                bool groupResult = true;

                for (int i = 0; i < groupFlags.Length - 1; i++)
                {
                    groupResult = groupResult && groupFlags[i];
                }

                return groupResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inCheckForSubjectGroupViolation: " + ex.Message);
            }
            return false;
        }
    }
}
