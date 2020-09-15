using System;

public class SpaceAge
{
    public double _ano { get; set; }
    public SpaceAge(double seconds)
    {
        _ano = seconds/ 31557600;
    }

    public double OnEarth()
    {
        return _ano;
    }

    public double OnMercury()
    {
        return _ano/ 0.2408467;
    }

    public double OnVenus()
    {
        return _ano / 0.61519726;
    }

    public double OnMars()
    {
        return _ano / 1.8808158;
    }

    public double OnJupiter()
    {
        return _ano / 11.862615;
    }

    public double OnSaturn()
    {
        return _ano / 29.447498;
    }

    public double OnUranus()
    {
        return _ano / 84.016846;
    }

    public double OnNeptune()
    {
        return _ano / 164.79132;
    }
}