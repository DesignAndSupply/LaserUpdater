using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LaserLib
{
    public class StockSession
    {

        private int _partID { get; set; }
        private int _staffID { get; set; }
        private int _maxSession { get
            {

                SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select max(id) as MaxID from dbo.laser_stock_session;",conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
                
            }
        }





        public StockSession(int partID,int staffID)
        {
            _partID = partID;
            _staffID = staffID;

            
            addSession();
            addItem();
            addStaff();

        }


        private void addSession()
        {
            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.laser_stock_session(date_started,session_status_id) values(@now,1);", conn);
            cmd.Parameters.AddWithValue("@now", DateTime.Now);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void addItem()
        {
            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.laser_stock_session_parts(session_id,part_id) values(@sessionID,@partID);", conn);
            cmd.Parameters.AddWithValue("@sessionID", _maxSession);
            cmd.Parameters.AddWithValue("@partID", _partID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void addStaff()
        {
            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.laser_stock_session_staff(session_id,staff_id) values(@sessionID,@staffID);", conn);
            cmd.Parameters.AddWithValue("@sessionID", _maxSession);
            cmd.Parameters.AddWithValue("@staffID", _staffID);
            cmd.ExecuteNonQuery();

            SqlCommand cmdLog = new SqlCommand();
            cmdLog.Connection = conn;
            cmdLog.CommandText = "INSERT INTO dbo.door_part_completion_log(door_id, part_complete_date, time_for_part, part, part_status, op, staff_id)" +
                                  " VALUES(00000,@now,0.0001,'Running stock items','Complete','Laser',@staffID)";
            cmdLog.Parameters.AddWithValue("@now", DateTime.Now);
            cmdLog.Parameters.AddWithValue("@staffID", _staffID);
            cmdLog.ExecuteNonQuery();

            conn.Close();
        }

    }
}
