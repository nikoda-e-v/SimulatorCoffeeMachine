using System;

namespace ClassLibrarySimulatorCofeeMachine
{
    // Определяем базовый интерфейс продукта. 
    // Реализует смешивание с другими продуктами этой реализации посредством параметра, который назвали combiner.
    internal interface IAbstractProductEspresso
    {
        
        // Продукт эспрессо содержится в каждом из вариантов кофе...
        string FunctionMakeEspresso();
        string FunctionMakeEspressoWithSugar(IAbstractProductSugar combiner);

        // Продукт эспрессо способен работать с остальными продуктами фабрики...
        // Фабрика создаст продукты одинаковой вариации, которые совместимы.
        // 
        string FunctionMakeCappuccino(IAbstractProductWhippedMilk combiner);
                
        string FunctionMakeCappuccinoAndSugar(IAbstractProductWhippedMilk combiner, IAbstractProductSugar combiner2);

        string FunctionMakeRafAndSyrup(IAbstractProductWhippedMilk combiner, IAbstractProductSyrup combiner2);

        string FunctionMakeRafAndSyrupAndSugar(IAbstractProductWhippedMilk combiner, IAbstractProductSyrup combiner2, IAbstractProductSugar combiner3);

        string FunctionMakeCorretto(IAbstractProductWhiskey combiner);

        string FunctionMakeCorrettoAndSugar(IAbstractProductWhiskey combiner, IAbstractProductSugar combiner2);

        string FunctionMakeMacchiatto(IAbstractProductWhippedMilk combiner);

        string FunctionMakeMacchiattoAndSugar(IAbstractProductWhippedMilk combiner, IAbstractProductSugar combiner2);
    }
}
