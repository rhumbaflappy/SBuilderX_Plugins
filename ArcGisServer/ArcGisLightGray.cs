public class ArcGisLightGray : ArcGis
{
  public ArcGisLightGray()
  {
    this.BaseImageType = ".png";
    this.BaseMaximumZoom = 22;
    this.BaseServerName = nameof (ArcGisLightGray);
    this.BaseURL0 = "http://services.arcgisonline.com/ArcGIS/rest/services/Canvas/World_Light_Gray_Base/MapServer/tile/";
    this.BaseURL1 = "http://services.arcgisonline.com/ArcGIS/rest/services/Canvas/World_Light_Gray_Base/MapServer/tile/";
    this.BaseURL2 = "http://services.arcgisonline.com/ArcGIS/rest/services/Canvas/World_Light_Gray_Base/MapServer/tile/";
    this.BaseURL3 = "http://services.arcgisonline.com/ArcGIS/rest/services/Canvas/World_Light_Gray_Base/MapServer/tile/";
  }
}
