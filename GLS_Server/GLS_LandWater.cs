public class GLS_LandWater : LandsatGLS
{
  public GLS_LandWater()
  {
    this.BaseImageType = ".png";
    this.BaseMaximumZoom = 21;
    this.BaseServerName = nameof (GLS_LandWater);
    this.BaseURL0 = "http://imagery.arcgisonline.com/arcgis/rest/services/LandsatGLS/LandWater/ImageServer/exportImage?f=image&bboxSR=102100&size=256,256&imageSR=102100&time=&format=png24&pixelType=U8&noData=&restrictUTurns=esriNoDataMatchAny&interpolation=+RSP_BilinearInterpolation&bbox=";
    this.BaseURL1 = "http://imagery.arcgisonline.com/arcgis/rest/services/LandsatGLS/LandWater/ImageServer/exportImage?f=image&bboxSR=102100&size=256,256&imageSR=102100&time=&format=png24&pixelType=U8&noData=&restrictUTurns=esriNoDataMatchAny&interpolation=+RSP_BilinearInterpolation&bbox=";
    this.BaseURL2 = "http://imagery.arcgisonline.com/arcgis/rest/services/LandsatGLS/LandWater/ImageServer/exportImage?f=image&bboxSR=102100&size=256,256&imageSR=102100&time=&format=png24&pixelType=U8&noData=&restrictUTurns=esriNoDataMatchAny&interpolation=+RSP_BilinearInterpolation&bbox=";
    this.BaseURL3 = "http://imagery.arcgisonline.com/arcgis/rest/services/LandsatGLS/LandWater/ImageServer/exportImage?f=image&bboxSR=102100&size=256,256&imageSR=102100&time=&format=png24&pixelType=U8&noData=&restrictUTurns=esriNoDataMatchAny&interpolation=+RSP_BilinearInterpolation&bbox=";
  }
}
