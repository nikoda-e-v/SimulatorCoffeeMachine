using System;

namespace ClassLibrarySimulatorCofeeMachine
{
    // Интерфейс Абстрактной Фабрики - здесь мы объявляем набор методов, которые возвращают
    // различные абстрактные продукты общего семейства, которые могут взаимодействовать между собой.
    internal interface IAbstractProduktFactory
    {
        IAbstractProductWhippedMilk CreateProductWhippedMilk();

        IAbstractProductEspresso CreateProductEspresso();

        IAbstractProductSugar CreateProductSugar();

        IAbstractProductWhiskey CreateProductWhiskey();

        IAbstractProductSyrup CreateProductSyrup();
    }
}
