
namespace Geometry
{
    public class Figure
    {
        private int _Color; //пока так

        private bool _Invisibility;

        private float _X;

        private float _Y;

        public float MoveX(float x)
        {
            return _X += x;
        }
        public float MoveY(float y)
        {
            return _Y += y;
        }
    }
}