using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SaveImageTest : MonoBehaviour
{
    string folderpath;
    string filepath;
    public Image imageSource;

    private void Start()
    {
        folderpath = Application.persistentDataPath + @"\saveimage";
        filepath = $@"\i.png";
    }
    public void SaveImage()
    {
        if (!Directory.Exists(folderpath))
        {
            Directory.CreateDirectory(folderpath);
        }
        SaveImageFormatTest test = new SaveImageFormatTest();
        test.images = imageSource.sprite.texture;
        var bytes = test.images.EncodeToPNG();
        File.WriteAllBytes(folderpath + filepath, bytes);
    }
}
