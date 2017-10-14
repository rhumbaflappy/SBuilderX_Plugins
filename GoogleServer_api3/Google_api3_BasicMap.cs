public class Google_api3_BasicMap : Google_api3
{
  public Google_api3_BasicMap()
  {
    this.BaseImageType = ".PNG";
    this.BaseMaximumZoom = 24;
    this.BaseServerName = nameof (Google_api3_BasicMap);
    this.BaseViewType = "!4i256!2m3!1e0!2sm!";
    this.BaseURL = "https://maps.googleapis.com/maps/vt?pb=!1m5!1m4";
  }
}
