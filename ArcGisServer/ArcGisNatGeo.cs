public class ArcGisNatGeo : ArcGis
{
  public ArcGisNatGeo()
  {
    this.BaseImageType = ".png";
    this.BaseMaximumZoom = 22;
    this.BaseServerName = nameof (ArcGisNatGeo);
    this.BaseURL0 = "http://services.arcgisonline.com/ArcGIS/rest/services/NatGeo_World_Map/MapServer/tile/";
    this.BaseURL1 = "http://services.arcgisonline.com/ArcGIS/rest/services/NatGeo_World_Map/MapServer/tile/";
    this.BaseURL2 = "http://services.arcgisonline.com/ArcGIS/rest/services/NatGeo_World_Map/MapServer/tile/";
    this.BaseURL3 = "http://services.arcgisonline.com/ArcGIS/rest/services/NatGeo_World_Map/MapServer/tile/";
  }
}
