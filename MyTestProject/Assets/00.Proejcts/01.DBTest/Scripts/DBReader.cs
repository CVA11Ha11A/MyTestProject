using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public class DBReader
{

    public string GetName(string sqlStr_, int id_)
    {
        string result = String.Empty;
        try
        {            
            using (MySqlConnection connection = new MySqlConnection(sqlStr_))
            {
                connection.Open();
                //DE.Log(connection.Database);

                // ������ SQL ���� �ۼ�
                //string selectQuery = "SELECT ID, Name FROM firsttable";
                string query = "SELECT Name FROM firsttable WHERE ID = @ID";
                using (MySqlCommand sqlCommand = new MySqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@ID", id_);
                    // using ���� ����Ͽ� SQL ���� ���� �� ��� ���� ��ü ����
                    using (MySqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        // ��� �б�
                        if (reader.Read())
                        {
                            result = reader["Name"].ToString();
                        }
                    }   // MySqlDataReader
                }   // MySqlCommand
            }   // MySqlConnection
            return result;
        }   // Try
        catch (Exception e)
        {
            DE.Log("Exception");
            DE.Log(e.Message);

            return result;
        }

    }       // GetName()

}       // ClassEnd
