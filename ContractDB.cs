using System;

//Contract database with contract comparisons
public class ContractDB
{
    private Contract[] contracts;

    public ContractDB(params Contract[] contracts)
    {
        this.contracts = contracts;
    }

    public int Search(Period period)
    {
        var start = period.StartDate();
        var end = period.EndDate();
        var validContracts = 0;
        foreach (Contract contract in contracts)
        {
            var x = contract.StartDate();
            var y = contract.EndDate();
            if (x >= start && x <= end)
            {
                validContracts++;
                continue;
            }
            if (y >= start && y <= end)
            {
                validContracts++;
                continue;
            }
            if (x <= start && y >= end)
            {
                validContracts++;
                continue;
            }
            //if overlap increment counter
        }
        return validContracts;
    }

}