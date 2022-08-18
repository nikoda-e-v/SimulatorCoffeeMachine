using System;

namespace ClassLibrarySimulatorCofeeMachine
{
    // Продукты для получения разных напитков
    // Здесь определяем класс продукта с унаследованным абстрактным интерфейсом. 
    
    class ConcreteProductWhiskey : IAbstractProductWhiskey
    {
        public string FunctionWhiskey()
        {
            return "Whiskey added!";
        }
    }
}
