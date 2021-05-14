using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using UnityEngine.UI;

// 파일을 불러올 클래스
public class LoadTest : MonoBehaviour
{
    string filePath;
    public UnityEngine.UI.Image loadImage;

    public Text nameText;
    public Text ageText;
    //public Texture2D image;
    //public string imageStr;
    //[System.Obsolete]
    //public WWW imageLoad;


    private void Start()
    {
        filePath = Application.persistentDataPath + @"\saves\save.json";
    }

    [System.Obsolete]
    public void LoadData()
    {
        if (File.Exists(filePath))
        {
            var stringdata = File.ReadAllText(filePath);
            // 역직렬화로 Object 형태로 변경
            var data = JsonConvert.DeserializeObject<SaveFormatTest>(stringdata);
            nameText.text = data.name;
            ageText.text = (data.age).ToString();
            loadImage.sprite = data.sprite;
            print(data.personaladdress);
            foreach(var t in data.personaladdress)
            {
                print(t.Key);
                print(t.Value);
            }
            //imageStr = data.url;
            //imageLoad = new WWW(imageStr);
            //image = new Texture2D(200, 200);
            //imageLoad.LoadImageIntoTexture(image);
        }
    }
}
