namespace Asp_._Net.Models
{

    public class Characters
    {

        
        public int id { get; set; }
        public string name { get; set; } = "Floki";


        public int hitPoits { get; set; } = 100;

        public int strenghs { get; set; } = 50;

        public int defense  { get; set; } = 200;

        public int inteligence { get; set; } = 10;


        public  RgbClass Class  { get; set; } = RgbClass.cavaleiro;
    }
}