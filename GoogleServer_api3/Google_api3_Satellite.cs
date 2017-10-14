public class Google_api3_Satellite : Google_api3
{
  public Google_api3_Satellite()
  {
    this.BaseImageType = ".PNG";
    this.BaseMaximumZoom = 24;
    this.BaseServerName = nameof (Google_api3_Satellite);
    this.BaseViewType = "!4i256!2m3!1e1!2sm!";
    this.BaseURL = "https://maps.googleapis.com/maps/vt?pb=!1m5!1m4";
  }
}
