using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �׸��� ������ ������ ���� Ŭ����
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