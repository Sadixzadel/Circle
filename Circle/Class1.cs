using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2;

class Circle
{
    // Your code here
    public double Radius;
    public Circle()
    {

    }

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double GetArea()
    {
        double area = Math.PI * Radius * Radius;
        return area;
    }
}

