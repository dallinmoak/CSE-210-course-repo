class Rectangle : Shape
{
  public Rectangle(string color, double width, double height) : base(color)
  {
    this._width = width;
    this._height = height;
  }
  private double _width;
  private double _height;
  public override double GetArea()
  {
    return _width * _height;
  }
}