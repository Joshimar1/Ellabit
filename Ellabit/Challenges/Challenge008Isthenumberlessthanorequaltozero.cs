namespace Ellabit.Challenges
{
    public class Challenge008Isthenumberlessthanorequaltozero : IChallenge
    {
        public string? Header { get; set; } = "Is the number less than or equal to zero?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  bool LessThanOrEqualToZero(double a) 
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.LessThanOrEqualToZero(5) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  false,  $""returned: {sumResult}  expected:  false"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.LessThanOrEqualToZero(0) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true,   $""returned: {sumResult}  expected:  true"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.LessThanOrEqualToZero(-2) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  true,   $""returned: {sumResult}  expected:  true"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes a number as its only argument and returns true if it's less than or equal to zero, otherwise return false.

examples
lessthanorequaltozero(5) ➞ false

lessthanorequaltozero(0) ➞ true

lessthanorequaltozero(-2) ➞ true

notes
don't forget to return the result.
if you get stuck on a challenge, find help in the resources tab.
if you're";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}