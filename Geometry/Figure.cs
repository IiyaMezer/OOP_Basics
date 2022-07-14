
namespace Geometry
{
    public class Figure 
    {
        private int _Color; //пока так

        /// <summary>
        /// Bool так как у нас 2 состояния, видимый или нет. В дальнейшем нужно будет добавить параметр прозрачности.
        /// Так как во многих "рисовалках" если функция как настройки прозрачности, так и переключения видимости. 
        /// </summary>
        private bool _Invisibility;

        public int Color
        {
            get => _Color;
            set => _Color = value;
        }

        public bool Invise
        {
            get => _Invisibility;
            set => _Invisibility = value;
        }
        
        public double MoveX(double dx)
        {
            return X += dx;
        }
        public double MoveY(double dy)
        {
            return Y += dy;
        }
    }
}