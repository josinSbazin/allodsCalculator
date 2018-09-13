using AllodsCalc;

public class Result
{
    public AClass Aclass { get; }
    public int MaxR { get; }
    public int MaxM { get; }
    public int MaxBU { get; }
    public int MaxSKU { get; }
    public double D1 { get; }
    public double MaxD { get; }

    public Result(AClass aclass,  int maxR, int maxM, int maxBU, int maxSKU, double d1, double maxD)
    {
        Aclass = aclass;
        MaxR = maxR;
        MaxM = maxM;
        MaxBU = maxBU;
        MaxSKU = maxSKU;
        D1 = d1;
        MaxD = maxD;
    }
}
