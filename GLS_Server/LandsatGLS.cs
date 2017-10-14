using System;
using System.Drawing;
using System.Net;
using TileServer;

public abstract class LandsatGLS : IServer
{
  protected string[] URL = new string[4];
  protected string ImageTypeValue;
  protected int MaximumZoomValue;
  protected string ServerNameValue;

  public virtual bool DownloadTile(int X, int Y, int Zoom, string Filename)
  {
    double num1 = 40075016.6855785 / Math.Pow(2.0, (double) (Zoom + 1));
    double num2 = (double) X * num1 - 20037508.3427892;
    double num3 = (double) (X + 1) * num1 - 20037508.3427892;
    double num4 = 20037508.3427892 - (double) Y * num1;
    double num5 = 20037508.3427892 - (double) (Y + 1) * num1;
    string str = Convert.ToString(num2) + "," + Convert.ToString(num4) + "," + Convert.ToString(num3) + "," + Convert.ToString(num5);
    string requestUriString = this.URL[(X + Y) % 4] + str;
    bool flag;
    try
    {
      HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(requestUriString);
      httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0;Windows NT 5.1";
      HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
      if (response.ContentType.IndexOf("image") > -1)
      {
        Image.FromStream(response.GetResponseStream()).Save(Filename);
        flag = true;
      }
      else
        flag = false;
      response.Close();
    }
#pragma warning disable CS0168 // Variable is declared but never used
        catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
        {
      flag = false;
    }
    return flag;
  }

  protected string BaseImageType
  {
    get
    {
      return this.ImageTypeValue;
    }
    set
    {
      this.ImageTypeValue = value;
    }
  }

  protected int BaseMaximumZoom
  {
    get
    {
      return this.MaximumZoomValue;
    }
    set
    {
      this.MaximumZoomValue = value;
    }
  }

  protected string BaseServerName
  {
    get
    {
      return this.ServerNameValue;
    }
    set
    {
      this.ServerNameValue = value;
    }
  }

  protected string BaseURL0
  {
    get
    {
      return this.URL[0];
    }
    set
    {
      this.URL[0] = value;
    }
  }

  protected string BaseURL1
  {
    get
    {
      return this.URL[1];
    }
    set
    {
      this.URL[1] = value;
    }
  }

  protected string BaseURL2
  {
    get
    {
      return this.URL[2];
    }
    set
    {
      this.URL[2] = value;
    }
  }

  protected string BaseURL3
  {
    get
    {
      return this.URL[3];
    }
    set
    {
      this.URL[3] = value;
    }
  }

  public string ImageType
  {
    get
    {
      return this.ImageTypeValue;
    }
  }

  public int MaximumZoom
  {
    get
    {
      return this.MaximumZoomValue;
    }
  }

  public string ServerName
  {
    get
    {
      return this.ServerNameValue;
    }
  }
}
