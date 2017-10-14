public class ArcGisOcean : ArcGis
{
  public ArcGisOcean()
  {
    this.BaseImageType = ".png";
    this.BaseMaximumZoom = 22;
    this.BaseServerName = nameof (ArcGisOcean);
    this.BaseURL0 = "http://services.arcgisonline.com/ArcGIS/rest/services/Ocean_Basemap/MapServer/tile/";
    this.BaseURL1 = "http://services.arcgisonline.com/ArcGIS/rest/services/Ocean_Basemap/MapServer/tile/";
    this.BaseURL2 = "http://services.arcgisonline.com/ArcGIS/rest/services/Ocean_Basemap/MapServer/tile/";
    this.BaseURL3 = "http://services.arcgisonline.com/ArcGIS/rest/services/Ocean_Basemap/MapServer/tile/";
  }
}
