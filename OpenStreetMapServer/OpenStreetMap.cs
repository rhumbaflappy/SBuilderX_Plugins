using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Net;
using TileServer;

namespace OpenStreetMapServer
{
  public class OpenStreetMap : IServer
  {
    protected string ImageTypeValue;
    protected int MaximumZoomValue;
    protected string ServerNameValue;
    protected string[] URL;

    public OpenStreetMap()
    {
      this.URL = new string[3];
      this.BaseImageType = ".png";
      this.BaseMaximumZoom = 17;
      this.BaseServerName = nameof (OpenStreetMap);
      this.BaseURL0 = "http://a.tile.openstreetmap.org/";
      this.BaseURL1 = "http://b.tile.openstreetmap.org/";
      this.BaseURL2 = "http://c.tile.openstreetmap.org/";
    }

    public bool DownloadTile(int X, int Y, int Zoom, string Filename)
    {
      checked { ++Zoom; }
      int num = checked ((int) Math.Round(Math.Pow(2.0, unchecked ((double) Zoom))));
      X %= num;
      Y %= num;
      string str = Zoom.ToString() + "/" + X.ToString() + "/" + Y.ToString();
      string requestUriString = this.URL[checked (X + Y) % 3] + str + this.ImageTypeValue;
      bool flag;
      try
      {
        HttpWebResponse response = (HttpWebResponse) ((HttpWebRequest) WebRequest.Create(requestUriString)).GetResponse();
        if (response.ContentType.IndexOf("image") > -1)
        {
          Image.FromStream(response.GetResponseStream()).Save(Filename);
          flag = true;
        }
        else
          flag = false;
        response.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
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
  }
}
