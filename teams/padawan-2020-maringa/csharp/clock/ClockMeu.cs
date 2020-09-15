using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

//public partial class Clock : IEquatable<Clock>
//{
//    public string _minutos { get; set; }
//    public string _hora { get; set; }
//    public int min { get; set; }
//    public int hor { get; set; }

//    public Clock(int hours, int minutes)
//    {
//        hor = hours;
//        min = minutes;
//        Relogio(minutes, hours);
//        min = Convert.ToInt32(_minutos);
//        hor = Convert.ToInt32(_hora);     
//    }

//    public Clock Add(int minutesToAdd)
//    {
//        return new Clock(hor, min + minutesToAdd);

//    }

//    public Clock Subtract(int minutesToSubtract)
//    {
//         return new Clock(hor, min - minutesToSubtract);
//    }

//    public Clock ToMinutesP(int v)
//    {
//        int minut = hor * 60;
//        minut = (minut + min) * v;

//        return new Clock(0, minut);
//    }

//    public Clock ToMinutesD(int v)
//    {
//        int minut = hor * 60;
//        minut = (minut + min) / v;

//        return new Clock(0, minut);
//    }

//    public override string ToString()
//    {
//        string hora = "" + _hora + ":" + _minutos;
//            return hora;
//    }

//    private void Relogio(int minutes, int hours)
//    {
//        int temp = minutes;
//        int phora = 0;
//        while (temp < 0)
//        {
//            temp = temp + 60;
//            phora--;
//        }

//        while (temp > 59)
//        {
//            temp = temp - 60;
//            phora++;
//        }
//        int h = hours + phora;
//        while (h < 0)
//        {
//            h += 24;
//        }
//        while (h > 23)
//        {
//            h = h - 24;
//        }
//        _hora = (h < 10) ? "0" + h.ToString() : h.ToString();

//        _minutos = (temp < 10) ? "0" + temp.ToString() : temp.ToString();
//    }
//    public bool Equals(Clock other) => _hora == other._hora && _minutos == other._minutos;

//}
