using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Takkip
{
    class DBClass
    {
        Bilgiler b = new Bilgiler();
        private SqlConnection conn;


        public bool baglan()
        {
            conn = new SqlConnection(b.getConStr());
            conn.Open();
            return true;
        }
        public void connKill()
        {
            conn.Close();
        }
        public SqlConnection getConn()
        {
            return conn;
        }

        public string GorevEkle(string user, string sahip, string kat, string tarih, string aciklama, string onem)
        {
            string rv = "0";



            if (baglan())
            {

                string sorgu = "exec Takkip_sp_add @p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9";
                SqlCommand cmd = new SqlCommand(sorgu, getConn());
                cmd.Parameters.AddWithValue("@p1", user);
                cmd.Parameters.AddWithValue("@p2", sahip);
                cmd.Parameters.AddWithValue("@p3", kat);
                cmd.Parameters.AddWithValue("@p4", tarih);
                cmd.Parameters.AddWithValue("@p5", aciklama);
                cmd.Parameters.AddWithValue("@p6", onem);
                cmd.Parameters.AddWithValue("@p7", b.getSicil());
                cmd.Parameters.AddWithValue("@p8", "null");
                cmd.Parameters.AddWithValue("@p9", "null");
                DataTable dt = new DataTable();

                using (SqlDataAdapter a = new SqlDataAdapter(cmd))
                {
                    a.Fill(dt);
                }
                if (dt.Rows.Count > 0)
                {

                    rv = dt.Rows[0][0].ToString();

                }

                //   cmd.ExecuteNonQuery();
                connKill();
                //b.baglan();
                //sorgu = "select * from calisanlar where sifre=@sifre and no=@no";
                //SqlCommand cmd2 = new SqlCommand(sorgu,b.getConn());
                //cmd2.Parameters.AddWithValue("@sifre",sifre);
                //cmd2.Parameters.AddWithValue("@no", P_no);
                //SqlDataReader reader = cmd2.ExecuteReader();
                //bool durum = false;
                //if (reader.Read())
                //{
                //    durum = true;
                //}
                //b.baglantiKes();
                //return durum;
            }
            return rv;
        }
        public DataTable getData(string Query)
        {

            baglan();


            SqlCommand cmd = new SqlCommand(Query, getConn());

            DataTable t1 = new DataTable();

            using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            {
                a.Fill(t1);
            }
            return t1;


        }
        public Dictionary<string, string> Kullanicilar()
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            string Query = "SELECT usr,scl FROM Takkip_tbl_usr";
            DataTable dt = getData(Query);


            foreach (DataRow drState in dt.Rows)
            {
                test.Add( drState["scl"].ToString(),drState["usr"].ToString() + "-" + drState["scl"].ToString());
            }

            return test;
        }
        public Dictionary<string, string> isler(string Query)
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
             DataTable dt = getData(Query);


            foreach (DataRow drState in dt.Rows)
            {
                test.Add(drState[0].ToString(), drState[0].ToString());
            }

            return test;
        }
        public List<String> Listele(string Query)
        {
            if (baglan())
            {


                List<String> liste = new List<string>();



                baglan();

                SqlCommand cmd2 = new SqlCommand(Query, getConn());


                SqlDataReader reader2 = cmd2.ExecuteReader();

                while (reader2.Read())
                {
                    string gorev = "";
                    for (int i = 0; i < reader2.FieldCount; i++)
                        gorev += reader2.GetValue(i) + "*";

                    liste.Add(gorev);
                }
                connKill();
                return liste;
            }
            return null;
        }

    }
}
