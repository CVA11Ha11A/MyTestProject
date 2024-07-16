using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;


public class DBConnectData
{

    private string server = "Server=127.0.0.1;";
    private string database = "Database=testtable;";
    private string uid = "Uid=root;";
    private string pwd = "Pwd=";
    private string password = string.Empty;

    private StringBuilder sb = null;         // StringParams Factory

    public DBConnectData()
    {
        string passwordPath = @"C:\Users\dad02\AppData\LocalLow\MariaDBPassword.txt";
        this.password = File.ReadAllText(passwordPath);
        this.sb = new StringBuilder();
        //DE.Log($"{this.password}");        
    }


    /// <summary>
    /// MySqlConnection Class의 생성자 인자를 만들어서 반환해주는 함수
    /// </summary>
    /// <param name="connectDBName_">접근하고자하는 DB의 이름</param>
    /// <returns>만들어진 정규식 Ex) Server=127.0.0.1;Database=testtable;Uid=root;Pwd=0000</returns>
    public string GetSqlConnectionString()
    {
        //string SqlStr = String.Format($"Server=127.0.0.1;Database=testtable;Uid=root;Pwd=0221");
        this.sb.Clear();
        sb.Append(this.server);
        sb.Append(this.database);
        sb.Append(this.uid);
        sb.Append(this.pwd).Append(this.password);
        return sb.ToString();
    }

    


}       // ClassEnd
