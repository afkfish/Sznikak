using System;
using Controls;

namespace Shapes
{
    public class TextArea : Textbox, IShape
    {
        private string Text { get; set; }

        public TextArea(int x, int y, int width, int height, string text = null)
            : base(x, y, width, height)
        {
            this.Text = text;
        }

        public double GetArea()
        {
            return GetWidth() * GetHeight();
        }

        public string GetSpecifics()
        {
            return $"width={GetWidth()}, height={GetHeight()}";
        }

        public string Type()
        {
            return "TextArea";
        }

        public override string ToString()
        {
            return $"{this.Type()}: X={this.GetX()}, Y={this.GetY()}, {this.GetSpecifics()}, area={this.GetArea()}";
        }
    }
}
