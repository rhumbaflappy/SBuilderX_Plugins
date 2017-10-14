using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Net;
using TileServer;

namespace VirtualEarthServer
{
  public abstract class VirtualEarth : IServer
  {
    protected string ImageTypeValue;
    protected int MaximumZoomValue;
    protected string ServerNameValue;
    protected string[] URL;

    public VirtualEarth()
    {
      this.URL = new string[4];
    }

    protected string Tilename(int X, int Y, int Zoom)
    {
      string str = "";
      int num1 = Zoom;
      while (num1 >= 0)
      {
        int num2 = checked ((int) Math.Round(Math.Pow(2.0, unchecked ((double) num1))));
        if (X < num2)
        {
          if (Y < num2)
          {
            str += "0";
          }
          else
          {
            str += "2";
            checked { Y -= num2; }
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
            checked { Y -= num2; }
          }
          checked { X -= num2; }
        }
        checked { num1 += -1; }
      }
      return str;
    }

    public bool DownloadTile(int X, int Y, int Zoom, string Filename)
    {
      int num = checked ((int) Math.Round(Math.Pow(2.0, unchecked ((double) checked (Zoom + 1)))));
      X %= num;
      Y %= num;
      string str = this.Tilename(X, Y, Zoom);
      string requestUriString = this.URL[checked (X + Y) % 4] + str + this.ImageTypeValue + "?g=1";
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
