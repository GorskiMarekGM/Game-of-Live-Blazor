namespace blazorserver01.Data
{
    public class Rabbit: Data.BioUnit
    {
        public Rabbit(int x, int y, Environment e) : base(x,y,e) => this.color = "#fafafa";
    }
    //base for calling parent constructor
}