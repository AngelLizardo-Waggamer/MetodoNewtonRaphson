float f(float x) { return 2 * (x * x) - 5 * x + 1; };
float df(float? x) { if(x != null) { return (float)(4 * x - 5); } else {return 0;} };

float NewtonRaphson(float x0, float epsilon)
{
    float x = x0;
    float x1 = x0;
    do
    {
        x = x1;
        x1 = x - f(x) / df(x);
    } while (Math.Abs(x1 - x) > epsilon);
    return x1;
}

Console.WriteLine(NewtonRaphson(0, 0.001f));