class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public double GetDecimalValue()
    {
        return  (double)_top /  (double)_bottom;
    }
    public void DisplayFractionString()
    {
        Console.WriteLine($"{_top} / {_bottom}");
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int newTop)
    {
        _top = newTop;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int newBottom)
    {
        _bottom = newBottom;
    }



}