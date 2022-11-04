namespace DancingGoat.Models
{
    public partial class HomePage: IDetailItem
    {
        public string Type => System.Type;
        public string Id => System.Id;

        string IDetailItem.UrlPattern => "homepage";
    }
}