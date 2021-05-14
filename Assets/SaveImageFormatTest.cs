using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 그림을 저장할 내용을 담은 클래스
public class SaveImageFormatTest
{
    public Texture2D images;
    public int imgWidth;
    public int imgHeight;
    public void GetImageSize()
    {
        imgWidth = images.width;
        imgHeight = images.height;
    }
}
