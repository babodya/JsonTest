using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadImageTest : MonoBehaviour
{
    string filePath;
    public UnityEngine.UI.Image im;

    private void Start()
    {
        filePath = Application.persistentDataPath + @"\saveimage\s.png";
    }

    public void LoadImage()
    {
        if (File.Exists(filePath))
        {
            var tt = File.ReadAllBytes(filePath);
            Texture2D texture = new Texture2D(500, 500);
            texture.LoadImage(tt);
            
            Sprite sp = Sprite.Create(texture, new Rect(0, 0, 500, 500), new Vector2(0.5f, 0), 1);

            im.sprite = sp;
        }
    }
}
