using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

// 파일 입출력을 담당할 클래스
public class SaveTest : MonoBehaviour
{
    string filePath;
    string files;
    public UnityEngine.UI.Image information;

    private void Start()
    {
        filePath = Application.persistentDataPath + @"\saves";
        files = @"\save.json";
    }
    public void SaveFile()
    {

        if (!Directory.Exists(filePath))
        {
            Directory.CreateDirectory(filePath);
        }

        SaveFormatTest test = new SaveFormatTest("jjoning", 20);
        test.personaladdress.Add("Ann", 3);
        test.personaladdress.Add("tom", 5);
        test.sprite = information.sprite;
        var t = JsonUtility.ToJson(test);
        var t2 = JsonConvert.SerializeObject(test);

        File.WriteAllText(filePath + files, t);
        File.WriteAllText(filePath + files, t2);
    }
}
