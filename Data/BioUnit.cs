namespace blazorserver01.Data
{
    public class BioUnit
    {
        protected string color;
        public int posx;
        public int posy;

        public BioUnit(int x, int y)
        {
            this.posx = x;
            this.posy = y;
            this.color = "#444444";
        }

        public string myColor() => this.color;
        /*private bool alive; 
        public BioUnit() {
            this.alive = false;
        }
        public bool is_alive() {
            return this.alive;
        }
        public bool is_dead() {
            return !this.alive;
        }
        public void live() {
            this.alive = true;
        }
        public void die() {
            this.alive = false;
        }*/
    }
}