using System;
using System.Drawing;
using System.Net;
using TileServer;

public abstract class ArcGis : IServer
{
  protected string[] URL = new string[4];
  protected string ImageTypeValue;
  protected int MaximumZoomValue;
  protected string ServerNameValue;

  public bool DownloadTile(int X, int Y, int Zoom, string Filename)
  {
    ++Zoom;
    int num = (int) Math.Round(Math.Pow(2.0, (double) Zoom));
    X %= num;
    Y %= num;
    string str = Zoom.ToString() + "/" + Y.ToString() + "/" + X.ToString();
    string requestUriString = this.URL[(X + Y) % 3] + str;
    bool flag;
    try
    {
      HttpWebResponse response = (HttpWebResponse) WebRequest.Create(requestUriString).GetResponse();
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

  protected string Tilename(int X, int Y, int Zoom)
  {
    string str = "";
    int num1 = Zoom;
    while (num1 >= 0)
    {
      int num2 = (int) Math.Round(Math.Pow(2.0, (double) num1));
      if (X < num2)
      {
        if (Y < num2)
        {
          str += "0";
        }
        else
        {
          str += "2";
          Y -= num2;
        }
      }
      else
      {
        if (Y < num2)
        {
          str += "1";
        }
        else
        {
          str += "3";
          Y -= num2;
        }
        X -= num2;
      }
      num1 += -1;
    }
    return str;
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
