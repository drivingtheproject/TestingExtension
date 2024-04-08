using Microsoft.ReactNative.Managed;
using TestingLib.Services;

namespace ReactNativeTestModule
{
    [ReactModule("CalculatorServiceModule")]
    internal class CalculatorServiceModule
    {

        private CalculatorService _calculatorService;

        [ReactInitializer]
        public void Initialize(ReactContext reactContext)
        {
            _calculatorService = new CalculatorService();
        }


        [ReactSyncMethod("add")]
        public void Add(int a, int b)
        {
            _calculatorService.Add(a, b);
        }

        [ReactMethod("subtract")]
        public void Subtract(int a, int b)
        {
            _calculatorService.Subtract(a, b);
        }

        [ReactMethod("multiply")]
        public void Multiply(int a, int b)
        {
            _calculatorService.Multiply(a, b);
        }

        [ReactMethod("divide")]
        public void Divide(int a, int b)
        {
            _calculatorService.Divide(a, b);
        }
    }
}
