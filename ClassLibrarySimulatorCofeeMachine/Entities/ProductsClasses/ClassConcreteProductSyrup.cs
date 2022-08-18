using System;

namespace ClassLibrarySimulatorCofeeMachine
{
    /// Продукты для получения разных напитков
    
    class ConcreteProductSyrup : IAbstractProductSyrup
    {
        public string FunctionSyrup()
        {
            return "Syrup added!";
        }
    }
}
