using System;

namespace ClassLibrarySimulatorCofeeMachine
{
    /// Продукты для получения разных напитков
    
    /// Конкретизация происходит по объему в данном случае 100 грамм для маленькой порции.

    class ConcreteProductWhipedMilk100 : IAbstractProductWhippedMilk
    {
        private string prodBase = "WhipedMilk 100";
        public string FunctionWhipedMilk()
        {
            return $"{prodBase}";
        }

        public string FunctionWhippedMilkWithSugar(IAbstractProductSugar combiner)
        {
            var result = combiner.FunctionSugar();

            return $"{prodBase} and ({result})";
        }
    }
}
