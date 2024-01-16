

using System.Data.SqlClient;
using ADO_dotnet.Models;

namespace ADO_dotnet.Services
{
    public class studentServices: IStudentService
    {
        public string Constr {  get; set; }
        public IConfiguration _Configuration { get; set; }
        public SqlConnection con;
        public studentServices(IConfiguration configuration)
        {
            _Configuration = configuration;
            Constr = _Configuration.GetConnectionString("DBConnection");
        }

        public List<Student> GetStudentsRecords()
        {
            List<Student> studentList = new List<Student>();
            try
            {
                using(con=new SqlConnection(Constr))
                {
                    
                    var cmd = new SqlCommand("SP_GetStudentRecords", con);
                    cmd=con.CreateCommand();
                    cmd.CommandType=System.Data.CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Student std = new Student();

                        std.StudentId = Convert.ToInt32(rdr["StudentId"]);
                        std.StudentName = rdr["StudentName"].ToString();
                        std.EmailAddress = rdr["EmailAddress"].ToString();

                        studentList.Add(std);
                       
                    }
               //     con.Close();

                   
                }
   

            }
            catch(Exception e)
            {
                string msg = e.Message;
            }


            return studentList.ToList();


        }



    }

    public interface IStudentService
    {
        public List<Student> GetStudentsRecords();
    }
}
