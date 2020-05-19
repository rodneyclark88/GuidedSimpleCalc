using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.UnitTesting
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngineTest _calculatorEngine = new CalculatorEngineTest();
        
            [TestMethod]
            public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
            {
                int number1 = 1;
                int number2 = 2;
                double result = _calculatorEngine._calculatorEngine("add", number1, number2);
                AssemblyLoadEventArgs.AreEqual(3, result);
            }

            
            [TestMethod]
            public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
            {
                int number1 = 1;
                int number2 = 2;
                double result = _calculatorEngine._calculatorEngine("+", number1, number2);
                AssemblyLoadEventArgs.AreEqual(3, result);
            }
        
    }
}