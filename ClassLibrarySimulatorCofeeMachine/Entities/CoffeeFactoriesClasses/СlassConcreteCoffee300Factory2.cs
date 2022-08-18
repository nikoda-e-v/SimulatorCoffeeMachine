using System;

namespace ClassLibrarySimulatorCofeeMachine
{
    /// Фабрика для производства Кофе 300 грамм в стакане 350 грамм. Возвращает экземпляр класса необходимого продукта
    class Coffee300Factory2 : IAbstractProduktFactory
    {
        public IAbstractProductWhippedMilk CreateProductWhippedMilk()
        {
            return new ConcreteProductWhipedMilk200();
        }

        public IAbstractProductEspresso CreateProductEspresso()
        {
            return new ConcreteProductEspresso100();
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
