using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaecLibrary;

namespace ICTDUtilities.Objects
{
    class Candidate
    {
        private string examYear;

        public string ExamYear
        {
            get { return examYear; }
            set { examYear = value; }
        }
        private string centNo;

        public string CentNo
        {
            get { return centNo; }
            set { centNo = value; }
        }
        private string indexNo;

        public string IndexNo
        {
            get { return indexNo; }
            set { indexNo = value; }
        }
        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        /// <remarks>Disability code of candidate</remarks>
        private int disabilityCode = 1;

        public int DisabilityCode
        {
            get { return disabilityCode; }
            set { disabilityCode = value; }
        }
        private int totalSubjects;

        public int TotalSubjects
        {
            get { return Subjects.Count; }
            set { totalSubjects = value; }
        }
        private List<Subject> subjects = new List<Subject>();

        public System.Collections.Generic.List<Subject> Subjects
        {
            get { return subjects; }
            set { subjects = value; }
        }

        private ExamType examType;
        private Sex sex;

        public Sex Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private Disability disability;

        public Disability Disability
        {
            get { return disability; }
            set { disability = value; }
        }
        private dbConnection3 db = new dbConnection3();

        public dbConnection3 DbConnection
        {
            get { return db; }
            set { db = value; }
        }

        public Candidate(string examYear, string centNo, string indexNo, string connectionString)
        {
            ExamYear = examYear;
            CentNo = centNo;
            IndexNo = indexNo;
            ConnectionString = connectionString;
            db = new dbConnection3();
            db.connectionString = connectionString;
        }

        public virtual bool RetrieveCandidateDetails()
        {
            throw new System.NotImplementedException();
        }

        public virtual bool UpdateCandidateDetails(string userName, string pcName, string domainName)
        {
            throw new System.NotImplementedException();
        }

        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        private string candName;

        public string CandidateName
        {
            get { return candName; }
            set { candName = value; }
        }

        public virtual bool AddSubject(string shortCode)
        {
            try
            {
                //check whether subject exist
                foreach (Subject s in Subjects)
                {
                    if(shortCode.Equals(s.ShortCode))
                    {
                        //subject already exists
                        return false;
                    }
                }

                // add subject 
                Subjects.Add(new Subject(shortCode, Common.GetSubjectName(shortCode)));
                TotalSubjects++;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in updating subject: " + ex.Message);
            }
            return false;
        }

        public virtual bool RemoveSubject(string shortCode)
        {
            try
            {
                //check whether subject exist
                foreach (Subject s in Subjects)
                {
                    if (shortCode.Equals(s.ShortCode))
                    {
                        //subject already exists remove it
                        Subjects.Remove(s);
                        totalSubjects++;
                        break;
                    }
                    else
                    {
                        // subject not there
                        //return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in updating subject: " + ex.Message);
            }
            return false;
        }

        public bool AddRange(Subject subjects)
        {
            throw new System.NotImplementedException();
        }

        private School school;

        public School School
        {
            get { return school; }
            set { school = value; }
        }

        

        //private bool UpdateDs(string tableName, string sqlStatement)
            //    {
            //        try
            //        {
            //            if (ds == null)
            //                ds = new DataSet();

            //            // try to remove table first
            //            try
            //            {
            //                ds.Tables.RemoveAt(ds.Tables.IndexOf(tableName));
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine("Error removing table: " + tableName + ": " + ex.Message);
            //            }

            //            OleDbDataAdapter dsAdapter = new OleDbDataAdapter(new OleDbCommand(sqlStatement, new OleDbConnection(db.connectionString)));
            //            //dsAdapter.SelectCommand.Connection = new OleDbConnection(db.connectionString);
            //            dsAdapter.SelectCommand.CommandText = sqlStatement;
            //            dsAdapter.Fill(ds, tableName);
            //            Console.WriteLine("Returned " + ds.Tables[tableName].Rows.Count + " : " + tableName);
            //            dsAdapter.Dispose();
            //            return true;
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Error Updating ds - table: " + tableName + " sql: " + sqlStatement + " : "  + ex.Message);
            //        }
            //        return false;
            //    }
    }

    


    
}
