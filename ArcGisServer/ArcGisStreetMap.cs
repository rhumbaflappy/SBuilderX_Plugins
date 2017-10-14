// Decompiled with JetBrains decompiler
// Type: ArcGisStreetMap
// Assembly: ArcGisServer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D6A39B67-620C-4B5A-871E-87AC59E109D2
// Assembly location: C:\My_Programs\SBuilderX314x86\Tiles\ArcGisServer.dll

public class ArcGisStreetMap : ArcGis
{
  public ArcGisStreetMap()
  {
    this.BaseImageType = ".png";
    this.BaseMaximumZoom = 22;
    this.BaseServerName = nameof (ArcGisStreetMap);
    this.BaseURL0 = "http://services.arcgisonline.com/ArcGIS/rest/services/World_Street_Map/MapServer/tile/";
    this.BaseURL1 = "http://services.arcgisonline.com/ArcGIS/rest/services/World_Street_Map/MapServer/tile/";
    this.BaseURL2 = "http://services.arcgisonline.com/ArcGIS/rest/services/World_Street_Map/MapServer/tile/";
    this.BaseURL3 = "http://services.arcgisonline.com/ArcGIS/rest/services/World_Street_Map/MapServer/tile/";
  }
}
