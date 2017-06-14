using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class ShowDeviceData : MonoBehaviour {
    public UnityEngine.UI.Text rtFormatText;
    public UnityEngine.UI.Text textFormatText;

    void append(StringBuilder sb, RenderTextureFormat fmt)
    {
        sb.Append(fmt.ToString() + "\t\t" + SystemInfo.SupportsRenderTextureFormat(fmt) + "\n");
    }

    void append(StringBuilder sb, TextureFormat fmt)
    {
        sb.Append(fmt.ToString() + "\t\t" + SystemInfo.SupportsTextureFormat(fmt) + "\n");
    }

    string createRTString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("RenderTexture\n\n");
        append(sb, RenderTextureFormat.ARGB32);
        append(sb, RenderTextureFormat.Depth);
        append(sb, RenderTextureFormat.ARGBHalf);
        append(sb, RenderTextureFormat.Shadowmap);
        append(sb, RenderTextureFormat.RGB565);
        append(sb, RenderTextureFormat.ARGB4444);
        append(sb, RenderTextureFormat.ARGB1555);
        append(sb, RenderTextureFormat.Default);
        append(sb, RenderTextureFormat.ARGB2101010);
        append(sb, RenderTextureFormat.DefaultHDR);
        append(sb, RenderTextureFormat.ARGBFloat);
        append(sb, RenderTextureFormat.RGFloat);
        append(sb, RenderTextureFormat.RGHalf);
        append(sb, RenderTextureFormat.RFloat);
        append(sb, RenderTextureFormat.RHalf);
        append(sb, RenderTextureFormat.R8);
        append(sb, RenderTextureFormat.ARGBInt);
        append(sb, RenderTextureFormat.RGInt);
        append(sb, RenderTextureFormat.RInt);
        append(sb, RenderTextureFormat.BGRA32);
        append(sb, RenderTextureFormat.RGB111110Float);
        return sb.ToString();
    }

    string createTextureString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Texture\n\n");
        append(sb, TextureFormat.Alpha8);
        append(sb, TextureFormat.ARGB4444);
        append(sb, TextureFormat.RGB24);
        append(sb, TextureFormat.RGBA32);
        append(sb, TextureFormat.ARGB32);
        append(sb, TextureFormat.RGB565);
        append(sb, TextureFormat.R16);
        append(sb, TextureFormat.DXT1);
        append(sb, TextureFormat.DXT5);
        append(sb, TextureFormat.RGBA4444);
        append(sb, TextureFormat.BGRA32);
        append(sb, TextureFormat.RHalf);
        append(sb, TextureFormat.RGHalf);
        append(sb, TextureFormat.RGBAHalf);
        append(sb, TextureFormat.RFloat);
        append(sb, TextureFormat.RGFloat);
        append(sb, TextureFormat.RGBAFloat);
        append(sb, TextureFormat.YUY2);
        append(sb, TextureFormat.BC6H);
        append(sb, TextureFormat.BC7);
        append(sb, TextureFormat.BC4);
        append(sb, TextureFormat.BC5);
        return sb.ToString();
    }
	// Use this for initialization
	void Start () {
        rtFormatText.text = createRTString();
        textFormatText.text = createTextureString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
