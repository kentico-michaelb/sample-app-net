namespace DancingGoat.Models
{
    public partial class Page: IDetailItem
    {
        public string Type => System.Type;
        public string Id => System.Id;

        string IDetailItem.UrlPattern => Url;
    }
}