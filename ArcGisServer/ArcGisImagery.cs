public class ArcGisImagery : ArcGis
{
  public ArcGisImagery()
  {
    this.BaseImageType = ".png";
    this.BaseMaximumZoom = 22;
    this.BaseServerName = nameof (ArcGisImagery);
    this.BaseURL0 = "http://server.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer/tile/";
    this.BaseURL1 = "http://server.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer/tile/";
    this.BaseURL2 = "http://server.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer/tile/";
    this.BaseURL3 = "http://server.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer/tile/";
  }
}
