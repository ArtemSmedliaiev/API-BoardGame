namespace API_BoardGame.Model
{
    public class GamesInfo
    {
        public List<Game> games { get; set; }

        public int count { get; set; }
    }
    public class Game
    {
        public string id { get; set; }

        public string name { get; set; }

        public string? year_published { get; set; }       

        public string image_url { get; set; }

        public List<GameMechanic> mechanics { get; set; }

        public List<GameCategorie> categories { get; set; }

        public string rules_url { get; set; }

        public string players { get; set; }

        public string playtime { get; set; }

        public string description_preview { get; set; }
    }
    public class GameMechanic
    {
        public string id { get; set; }

        public string url { get; set; }
    }
    public class GameCategorie
    {
        public string id { get; set; }

        public string url { get; set; }
    }    
}
