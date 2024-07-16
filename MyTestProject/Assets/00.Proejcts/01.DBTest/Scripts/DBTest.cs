using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySqlConnector;
using System.Text;
using System;


public class DBTest : MonoBehaviour
{
    DBManager dbManager = null;


    private void Awake()
    {
        this.dbManager = new DBManager();
    }

    void Start()
    {
        SqlConnectionTest();
    }


    private void SqlConnectionTest()
    {
        DE.Log(dbManager.Reader.GetName(dbManager.connectData.GetSqlConnectionString(), 176));
    }

}
