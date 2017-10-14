public class DeLorme_World_Base_Map : ArcGis
{
  public DeLorme_World_Base_Map()
  {
    this.BaseImageType = ".png";
    this.BaseMaximumZoom = 22;
    this.BaseServerName = nameof (DeLorme_World_Base_Map);
    this.BaseURL0 = "https://server.arcgisonline.com/arcgis/rest/services/Specialty/DeLorme_World_Base_Map/MapServer/tile/";
    this.BaseURL1 = "https://server.arcgisonline.com/arcgis/rest/services/Specialty/DeLorme_World_Base_Map/MapServer/tile/";
    this.BaseURL2 = "https://server.arcgisonline.com/arcgis/rest/services/Specialty/DeLorme_World_Base_Map/MapServer/tile/";
    this.BaseURL3 = "https://server.arcgisonline.com/arcgis/rest/services/Specialty/DeLorme_World_Base_Map/MapServer/tile/";
  }
}
