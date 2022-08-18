using System;

namespace ClassLibrarySimulatorCofeeMachine
{
    /// Фабрика для производства Кофе 200 грамм. Создает продукты необходимого объема 
    class Coffee150Factory1 : IAbstractProduktFactory
    {
        public IAbstractProductWhippedMilk CreateProductWhippedMilk()
        {
            return new ConcreteProductWhipedMilk100();
        }

        public IAbstractProductEspresso CreateProductEspresso()
        {
            return new ConcreteProductEspresso50();
        }

        public IAbstractProductSugar CreateProductSugar()
        {
            return new ConcreteProductSugar();
        }
        public IAbstractProductWhiskey CreateProductWhiskey()
        {
            return new ConcreteProductWhiskey();
        }

        public IAbstractProductSyrup CreateProductSyrup()
        {
            return new ConcreteProductSyrup();
        }
    }
}
