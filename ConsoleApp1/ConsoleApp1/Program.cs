using System;

class RationalLinearFunction
{
    protected double a1, a0, b1, b0;

    public void SetCoefficients(double a1, double a0, double b1, double b0)
    {
        this.a1 = a1;
        this.a0 = a0;
        this.b1 = b1;
        this.b0 = b0;

    }

    public void DisplayCoefficients()
    {
        Console.WriteLine($"Numerator coefficients: a1 = {a1}, a0 = {a0}");
        Console.WriteLine($"Denominator coefficients: b1 = {b1}, b0 = {b0}");
    }

    public double EvaluateAt(double x)
    {
        return (a1 * x + a0) / (b1 * x + b0);
    }
}

class RationalFunction : RationalLinearFunction
{
    private double a2, b2;

    public void SetCoefficients(double a2, double a1, double a0, double b2, double b1, double b0)
    {
        this.a2 = a2;
        this.a1 = a1;
        this.a0 = a0;
        this.b2 = b2;
        this.b1 = b1;
        this.b0 = b0;
    }

    public new void DisplayCoefficients()
    {
        Console.WriteLine($"Numerator coefficients: a2 = {a2}, a1 = {a1}, a0 = {a0}");
        Console.WriteLine($"Denominator coefficients: b2 = {b2}, b1 = {b1}, b0 = {b0}");
    }

    public new double EvaluateAt(double x)
    {
        return (a2 * x * x + a1 * x + a0) / (b2 * x * x + b1 * x + b0);
    }
}

class Program
{
    static void Main(string[] args)
    {
        RationalLinearFunction linearFunction = new RationalLinearFunction();
        linearFunction.SetCoefficients(1, 2, 3, 4);
        linearFunction.DisplayCoefficients();
        Console.WriteLine($"Value at x = 1: {linearFunction.EvaluateAt(1)}");

        RationalFunction quadraticFunction = new RationalFunction();
        quadraticFunction.SetCoefficients(1, 2, 3, 4, 5, 6);
        quadraticFunction.DisplayCoefficients();
        Console.WriteLine($"Value at x = 1: {quadraticFunction.EvaluateAt(1)}");
    }
}
