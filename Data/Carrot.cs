namespace blazorserver01.Data
{
    public class Carrot: Data.BioUnit
    {
        public Carrot(int x, int y, Environment e) : base(x,y,e) => this.color = "#fa5511";
    }
    //base for calling parent constructor
}