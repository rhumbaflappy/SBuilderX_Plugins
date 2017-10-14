namespace VirtualEarthServer
{
  public class VirtualEarthStreetMap : VirtualEarth
  {
    public VirtualEarthStreetMap()
    {
      this.BaseImageType = ".PNG";
      this.BaseMaximumZoom = 18;
      this.BaseServerName = "VEStreetMap";
      this.BaseURL0 = "http://r0.ortho.tiles.virtualearth.net/tiles/r";
      this.BaseURL1 = "http://r1.ortho.tiles.virtualearth.net/tiles/r";
      this.BaseURL2 = "http://r2.ortho.tiles.virtualearth.net/tiles/r";
      this.BaseURL3 = "http://r3.ortho.tiles.virtualearth.net/tiles/r";
    }
  }
}
