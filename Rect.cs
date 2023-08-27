namespace GeometricShapesAgain;

public class Rect : Quad
{
	public Rect(int SideA, int SideB) : base(SideA, SideB, SideA, SideB) { }
	public override void Print() => Console.WriteLine($"Perimeter: {Perimeter()} Area: {Area()}");
	public int Area() => Side1 * Side2;
}
