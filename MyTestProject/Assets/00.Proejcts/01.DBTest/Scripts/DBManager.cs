using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManager
{
    public DBConnectData connectData = null;
    public DBDeleter Deleter = null;
    public DBInserter Inserter = null;
    public DBReader Reader = null;

    public DBManager()
    {
        this.connectData = new DBConnectData();
        this.Deleter = new DBDeleter();
        this.Inserter = new DBInserter();
        this.Reader = new DBReader();
    }
    

}
