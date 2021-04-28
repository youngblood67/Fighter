using Fighter.Technical;

namespace Fighter.Domain
{
    public class Rotation
    {
        public Sens Sens { get; set; }
        public float Speed { get; set; }
        public float Angle { get; set; }
        public Rotation(Sens sens, float speed, float angle)
        {
            this.Sens = sens;
            this.Speed = speed;
            this.Angle = angle;
        }
        public Rotation(Sens sens, float speed)
        {
            this.Sens = sens;
            this.Speed = speed;
            this.Angle = 0;
        }
        public Rotation(Sens sens)
        {
            this.Sens = sens;
            this.Angle = 0;
        }
    }
}