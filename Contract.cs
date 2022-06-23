using System;

//Contract constructor
public class Contract
{
    private int start;
    private int end;

    public Contract(int start, int end)
    {
        this.start = start;
        this.end = end;
    }
    public int StartDate()
    {
        return this.start;
    }
    public int EndDate()
    {
        return this.end;
    }
}
