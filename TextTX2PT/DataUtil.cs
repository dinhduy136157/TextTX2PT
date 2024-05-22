using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TextTX2PT
{
    public class DataUtil
    {
        SqlConnection con;

        public DataUtil()
        {
            string sqlCon = "Data Source=DESKTOP-7BK339H;Initial Catalog=ptud1;Integrated Security=True; TrustServerCertificate=True";
            con = new SqlConnection(sqlCon);
        }
        public List<Nhanvien> DsNhanvien()
        {
            List<Nhanvien> ds = new List<Nhanvien>();
            string sql = "select * from Employees";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                Nhanvien nv = new Nhanvien();
                nv.id = (int)rd["empid"];
                nv.name = (string)rd["name"];
                nv.gender = (string)rd["gender"];
                nv.address = (string)rd["address"];
                nv.email = (string)rd["email"];
                nv.title = (int)rd["titleid"];
                ds.Add(nv);
            }
            con.Close();
            return ds;
        }
        public List<Title> DsChucvu()
        {
            List<Title> ds = new List<Title>();
            string sql = "select * from Titles";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Title t = new Title();
                t.id = (int)rd["titleid"];
                t.name = (string)rd["name"];
                t.salary = (int)rd["salary"];
                ds.Add(t);
            }
            con.Close();
            return ds;
        }
        public void AddNV(Nhanvien nv)
        {
            con.Open();
            string sql = "insert into Employees values(@ht,@gt,@dc,@email,@cv)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ht", nv.name);
            cmd.Parameters.AddWithValue("gt", nv.gender);
            cmd.Parameters.AddWithValue("dc", nv.address);
            cmd.Parameters.AddWithValue("email", nv.email);
            cmd.Parameters.AddWithValue("cv", nv.title);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void XoaNV(int id)
        {
            con.Open();
            string sql = "delete from Employees where empid = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public Nhanvien lay1Nhanvien(int id)
        {
            List<Nhanvien> ds = new List<Nhanvien>();
            string sql = "select * from Employees where empid=@id";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", id);
            Nhanvien nv = null;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nv = new Nhanvien();
                nv.id = (int)rd["empid"];
                nv.name = (string)rd["name"];
                nv.gender = (string)rd["gender"];
                nv.address = (string)rd["address"];
                nv.email = (string)rd["email"];
                nv.title = (int)rd["titleid"];
            }
            con.Close();
            return nv;
        }
        public void updateNV(Nhanvien nv)
        {
            con.Open();
            string sql = "update Employees set name = @ht, gender = @gt, address = @dc, email = @email, titleid = @cv where empid = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ht", nv.name);
            cmd.Parameters.AddWithValue("gt", nv.gender);
            cmd.Parameters.AddWithValue("dc", nv.address);
            cmd.Parameters.AddWithValue("email", nv.email);
            cmd.Parameters.AddWithValue("cv", nv.title);
            cmd.Parameters.AddWithValue("id", nv.id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}