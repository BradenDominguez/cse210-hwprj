using System;

class PrivateNumberClass
{
    private int _top;
    private int _bottom;
    public PrivateNumberClass()
    {
        _top = 1;
        _bottom = 1;
    }
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public void SetFraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public void SetFraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public void SetFraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }
}