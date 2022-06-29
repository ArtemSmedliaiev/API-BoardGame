namespace API_BoardGame.Model
{
    public class CategoriesInfo
    {
        public List<CategorieInfo> categories { get; set; }
    }
    public class CategorieInfo
    {
        public string id { get; set; }

        public string name { get; set; }
    }
}
