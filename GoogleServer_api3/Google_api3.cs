using System;
using System.Drawing;
using System.Net;
using TileServer;

public abstract class Google_api3 : IServer
{
  protected string URL;
  protected string ImageTypeValue;
  protected int MaximumZoomValue;
  protected string ServerNameValue;
  protected string ViewTypeValue;

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

  protected string BaseViewType
  {
    get
    {
      return this.ViewTypeValue;
    }
    set
    {
      this.ViewTypeValue = value;
    }
  }

  protected string BaseURL
  {
    get
    {
      return this.URL;
    }
    set
    {
      this.URL = value;
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

  public virtual bool DownloadTile(int X, int Y, int Zoom, string Filename)
  {
    ++Zoom;
    int num = (int) Math.Round(Math.Pow(2.0, (double) Zoom));
    X %= num;
    Y %= num;
    string requestUriString = this.URL + ("!1i" + Convert.ToString(Zoom) + "!2i" + Convert.ToString(X) + "!3i" + Convert.ToString(Y) + this.ViewTypeValue);
    bool flag;
    try
    {
      HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(requestUriString);
      string str = "Mozilla/4.0 (compatible; MSIE 6.0;Windows NT 5.1";
      httpWebRequest.UserAgent = str;
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
}
