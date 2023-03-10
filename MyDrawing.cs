using System;
using Microsoft.Maui.Graphics.Text;
namespace SpaceGraphics
{
    internal class MyDrawing : IDrawable
    {

        public Point sun { get; set; } = new Point(800, 570);
        public Point mercury { get; set; } = new Point(800, 490);
        public Point venus { get; set; } = new Point(800, 465);
        public Point earth { get; set; } = new Point(800, 430);
        public Point mars { get; set; } = new Point(800, 395);
        public Point jupiter { get; set; } = new Point(800, 330);
        public Point saturn { get; set; } = new Point(800, 230);
        public Point uranus { get; set; } = new Point(800, 126);
        public Point neptun { get; set; } = new Point(800, 30);

        private string selectedView = "Jupiter";
        Rect rect = new Rect(850, 300, 200, 300);
        
        
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
           
            double zoomFactor = 1.0;
            switch (selectedView)
            {
                case "Mercury":
                    zoomFactor = 10.0;
                    break;
                case "Venus":
                    zoomFactor = 7.0;
                    break;
                case "Earth":
                    zoomFactor = 6.0;
                    break;
                case "Mars":
                    zoomFactor = 9.0;
                    break;
                case "Jupiter":
                    zoomFactor = 3.0;
                    break;
                case "Saturn":
                    zoomFactor = 4.0;
                    break;
                case "Uranus":
                    zoomFactor = 5.0;
                    break;
                case "Neptune":
                    zoomFactor = 5.0;
                    break;
                default:
                    break;
            }

            switch (selectedView)
            {

                case "SolarSystem":
                    // Sun
                    canvas.FillColor = Colors.Yellow;
                    canvas.FillCircle(sun, 70.0);

                    // Mercury
                    canvas.FillColor = Colors.Grey;
                    canvas.FillCircle(mercury, 5.0);

                    // Venus
                    canvas.FillColor = Colors.LightYellow;
                    canvas.FillCircle(venus, 10.0);

                    // Earth
                    canvas.FillColor = Colors.LightBlue;
                    canvas.FillCircle(earth, 12.0);

                    // Mars
                    canvas.FillColor = Colors.Red;
                    canvas.FillCircle(mars, 7.0);

                    // Jupiter
                    canvas.FillColor = Colors.Brown;
                    canvas.FillCircle(jupiter, 37.0);

                    // Saturn
                    canvas.FillColor = Colors.SandyBrown;
                    canvas.FillCircle(saturn, 27.0);

                    // Uranus
                    canvas.FillColor = Colors.LightSkyBlue;
                    canvas.FillCircle(uranus, 19.0);

                    // Neptune
                    canvas.FillColor = Colors.Blue;
                    canvas.FillCircle(neptun, 17.0);
                    break;

                case "Mercury":
                    canvas.FillColor = Colors.Grey;
                    canvas.FillCircle(new Point(dirtyRect.Width / 2, dirtyRect.Height / 2), 5.0 * zoomFactor);
                    canvas.FillRectangle(rect);

                    break;
                case "Venus":
                    canvas.FillColor = Colors.LightYellow;
                    canvas.FillCircle(new Point(dirtyRect.Width / 2, dirtyRect.Height / 2), 10.0 * zoomFactor);
                    break;
                case "Earth":
                    canvas.FillColor = Colors.LightBlue;
                    canvas.FillCircle(new Point(dirtyRect.Width / 2, dirtyRect.Height / 2), 12.0 * zoomFactor);
                    break;
                case "Mars":
                    canvas.FillColor = Colors.Red;
                    canvas.FillCircle(new Point(dirtyRect.Width / 2, dirtyRect.Height / 2), 7.0 * zoomFactor);
                    break;
                case "Jupiter":
                    canvas.FillColor = Colors.Brown;
                    canvas.FillCircle(new Point(dirtyRect.Width / 2, dirtyRect.Height / 2), 37.0 * zoomFactor);
                    break;
                case "Saturn":
                    canvas.FillColor = Colors.SandyBrown;
                    canvas.FillCircle(new Point(dirtyRect.Width / 2, dirtyRect.Height / 2), 27.0 * zoomFactor);
                    break;
                case "Uranus":
                    canvas.FillColor = Colors.LightSkyBlue;
                    canvas.FillCircle(new Point(dirtyRect.Width / 2, dirtyRect.Height / 2), 19.0 * zoomFactor);
                    break;
                case "Neptune":
                    canvas.FillColor = Colors.Blue;
                    canvas.FillCircle(new Point(dirtyRect.Width / 2, dirtyRect.Height / 2), 17.0 * zoomFactor);
                    break;
            }

        }


    }
}