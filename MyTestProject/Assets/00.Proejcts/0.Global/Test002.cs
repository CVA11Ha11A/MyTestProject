using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test002
{
    public int tempNum = 10;

    public void TestOutPut(string Message_)
    {
        DE.Log($"들어온 메세지 : {Message_}, 해당 객체의 Num : {this.tempNum}");
    }

    
}
