namespace Ellabit.Challenges
{
    public class Challenge092Convertyentousd : IChallenge
    {
        public string? Header { get; set; } = "Convert yen to usd";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
public class Challenge
{
	public  double YenToUsd(int yen)
	{
		
	}
}

";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        double sumResult = 0;
        try 
        {
            sumResult = tmp.yentousd(1) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  0.01,  $""returned: {sumResult}  expected:  0.01"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        double sumResult = 0;
        try 
        {
            sumResult = tmp.yentousd(500) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  4.65,   $""returned: {sumResult}  expected:  4.65"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        double sumResult = 0;
        try 
        {
            sumResult = tmp.yentousd(649) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  6.04,   $""returned: {sumResult}  expected:  6.04"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that can turn jpy (japanese yen) to usd (american dollar).

examples
yentousd(1) ➞ 0.01

yentousd(500) ➞ 4.65

yentousd(649) ➞ 6.04

notes
each jpy to usd conversion is jpy 107.5
round the result to two decimal places.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
