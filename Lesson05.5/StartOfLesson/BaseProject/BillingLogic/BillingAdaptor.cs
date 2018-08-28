using System;
using BillingCalculatorLib;

namespace BaseProject.BillingLogic
{
    public interface ICalculator
    {
        decimal CalculateBillableCost(TimeSpan hoursWorked);
    }
    public class BillingAdaptor
    {
        public BillingAdaptor()
        {
            var taxRate = 0.0223m;
            var hourlyRate = 15.50m;
            var billingLib2010 = new BillingCalculatorLib.BillingCalculator2010(hourlyRate);
            var billingLib2013 = new BillingCalculatorLib.BillingCalculator2013(hourlyRate, taxRate);
            var billingLib2017 = new BillingCalculatorLib.BillingCalculator2017(hourlyRate, taxRate);
            var billingLibCurrent = new BillingCalculatorLib.BillingCalculator(hourlyRate, taxRate);
        }
    }
    public class BillingAdaptor2010
    {
        public BillingAdaptor2010()
        {
            var taxRate = 0.0223m;
            var hourlyRate = 15.50m;
            var billingLib2010 = new BillingCalculatorLib.BillingCalculator2010(hourlyRate);
            var billingLib2013 = new BillingCalculatorLib.BillingCalculator2013(hourlyRate, taxRate);
            var billingLib2017 = new BillingCalculatorLib.BillingCalculator2017(hourlyRate, taxRate);
            var billingLibCurrent = new BillingCalculatorLib.BillingCalculator(hourlyRate, taxRate);
        }
    }
    public class BillingAdaptor2013
    {
        public BillingAdaptor2013()
        {
            var taxRate = 0.0223m;
            var hourlyRate = 15.50m;
            var billingLib2010 = new BillingCalculatorLib.BillingCalculator2010(hourlyRate);
            var billingLib2013 = new BillingCalculatorLib.BillingCalculator2013(hourlyRate, taxRate);
            var billingLib2017 = new BillingCalculatorLib.BillingCalculator2017(hourlyRate, taxRate);
            var billingLibCurrent = new BillingCalculatorLib.BillingCalculator(hourlyRate, taxRate);
        }
    }
    public class BillingAdaptor2017
    {
        private readonly BillingCalculator2017 _billingLib;
        public BillingAdaptor2017()
        {
            var taxRate = 0.0223m;
            var hourlyRate = 15.50m;
            var billingLib2010 = new BillingCalculatorLib.BillingCalculator2010(hourlyRate);
            var billingLib2013 = new BillingCalculatorLib.BillingCalculator2013(hourlyRate, taxRate);
            var billingLib2017 = new BillingCalculatorLib.BillingCalculator2017(hourlyRate, taxRate);
            var billingLibCurrent = new BillingCalculatorLib.BillingCalculator(hourlyRate, taxRate);
        }
    }
        public Timespan  CalculateBillableCost(TimeSpan hoursWorked, bool isExpat)
        {
            var taxRate = 0.0223m;
            var hourlyRate = 15.50m;
            var billingLib2010 = new BillingCalculatorLib.BillingCalculator2010(hourlyRate);
            var billingLib2013 = new BillingCalculatorLib.BillingCalculator2013(hourlyRate, taxRate);
            var billingLib2017 = new BillingCalculatorLib.BillingCalculator2017(hourlyRate, taxRate);
            var billingLibCurrent = new BillingCalculatorLib.BillingCalculator(hourlyRate, taxRate);
        }
    }   
}
