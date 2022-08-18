using System;

namespace ClassLibrarySimulatorCofeeMachine
{
    // Определяем базовый интерфейс продукта. 
    // Базовый интерфейс взбитого молока.
    internal interface IAbstractProductWhippedMilk
    {
        string FunctionWhipedMilk();

       string FunctionWhippedMilkWithSugar(IAbstractProductSugar combiner);

    }

}
