public class ArcGisTopoMap : ArcGis
{
  public ArcGisTopoMap()
  {
    this.BaseImageType = ".png";
    this.BaseMaximumZoom = 22;
    this.BaseServerName = nameof (ArcGisTopoMap);
    this.BaseURL0 = "http://server.arcgisonline.com/ArcGIS/rest/services/World_Topo_Map/MapServer/tile/";
    this.BaseURL1 = "http://server.arcgisonline.com/ArcGIS/rest/services/World_Topo_Map/MapServer/tile/";
    this.BaseURL2 = "http://server.arcgisonline.com/ArcGIS/rest/services/World_Topo_Map/MapServer/tile/";
    this.BaseURL3 = "http://server.arcgisonline.com/ArcGIS/rest/services/World_Topo_Map/MapServer/tile/";
  }
}
