using System;

//Valid date period constructor
public class Period
{
    private int start;
    private int end;

    public Period(int start, int end)
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
