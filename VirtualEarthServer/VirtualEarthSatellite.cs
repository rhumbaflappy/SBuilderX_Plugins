namespace VirtualEarthServer
{
  public class VirtualEarthSatellite : VirtualEarth
  {
    public VirtualEarthSatellite()
    {
      this.BaseImageType = ".JPG";
      this.BaseMaximumZoom = 20;
      this.BaseServerName = "VESatellite";
      this.BaseURL0 = "http://a0.ortho.tiles.virtualearth.net/tiles/a";
      this.BaseURL1 = "http://a1.ortho.tiles.virtualearth.net/tiles/a";
      this.BaseURL2 = "http://a2.ortho.tiles.virtualearth.net/tiles/a";
      this.BaseURL3 = "http://a3.ortho.tiles.virtualearth.net/tiles/a";
    }
  }
}
