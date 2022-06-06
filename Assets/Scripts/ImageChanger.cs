using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    public Image LogoImage;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void ChangeImage(Sprite image)
    {
        LogoImage.sprite = image;
    }
}