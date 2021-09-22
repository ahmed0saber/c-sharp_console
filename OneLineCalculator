using System;
namespace Calculator
{
	class Program
    {
	    static void Main()
        {
	    	Console.WriteLine("Enter an equation like this 25+78 then press ENTER\n");
	    	int x , y , i=0 , n , digits , max;
        	string input , num1="" , num2="";
        	char op;
        	input=Convert.ToString(Console.ReadLine());
        	digits=input.Length-1;
        	again:
        	i=i+1;
        	if(input[i]=='+'||input[i]=='-'||input[i]=='*'||input[i]=='/')
        	{
        		op=input[i];
	            n=i;
	            while(n>0)
	            {
		        num1=num1+input[i-n];
		        n=n-1;
	        }
	        digits=digits-num1.Length;
	        max=digits;
	        while(digits>0)
	        {
	        	num2=num2+input[i+1+(max-digits)];
	        	digits=digits-1;
	    	}
    	}
    	else
    	{
	    	goto again;
    	}
    	x=Convert.ToInt32(num1);
    	y=Convert.ToInt32(num2);
    	Console.Write(" = ");
    	if(op=='+')
    	{
    		Console.WriteLine(x+y);
    	}
    	else if(op=='-')
    	{
    		Console.WriteLine(x-y);
    	}
    	else if(op=='*')
    	{
    		Console.WriteLine(x*y);
    	}
    	else if(op=='/')
    	{
    		Console.WriteLine(x/y);
    	}
    	}
    }
}
