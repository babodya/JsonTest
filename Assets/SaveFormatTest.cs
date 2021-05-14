using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

// 저장한 파일이 담을 데이터를 모은 클래스
public class SaveFormatTest
{
    public string name;
    public int age;
    //public string url;
    public Dictionary<string, int> personaladdress;
    public Sprite sprite;

    public SaveFormatTest(string name, int age)
    {
        this.name = name;
        this.age = age;
        //this.url = url;
    }
}
