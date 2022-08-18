using System;

namespace ClassLibrarySimulatorCofeeMachine
{
    /// Продукты для получения разных напитков
    
    class ConcreteProductSugar : IAbstractProductSugar
    {
        public string FunctionSugar()
        {
            return "Sugar added!";
        }
    }
}
