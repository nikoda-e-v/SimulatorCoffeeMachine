using System;

namespace ClassLibrarySimulatorCofeeMachine
{
    /// Продукты для получения разных напитков
    /// Конкретные Продукты создаются соответствующими Конкретными Фабриками.
    /// Конкретизация происходит по объему в данном случае 200 грамм для большой порции.
    class ConcreteProductWhipedMilk200 : IAbstractProductWhippedMilk
    {
        private string prodBase = "WhipedMilk 200";
        public string FunctionWhipedMilk()
        {
            return $"{prodBase}";
        }

        ///Пример вариации на тему взаимодействия молока и сахара. Этим можно варьировать.
        ///
        ///
        public string FunctionWhippedMilkWithSugar(IAbstractProductSugar combiner)
        {
            var result = combiner.FunctionSugar();

            return $"{prodBase} and ({result})";
        }

        ///Пример вариации на тему взаимодействия молока и сиропа. Этим можно варьировать.
        ///Определить, например, продукт Каппучино с сиропом и ещё сахар добавить (Продукта Эспрессо).
        ///В данном проекте не использован, но возможен. Таким образом можно дополнить, например, каппучино с сиропом, использовав
        ///этот метод вместо стандартного.
        public string FunctionWhippedMilkWithSyrup(IAbstractProductSyrup combiner)
        {
            var result = combiner.FunctionSyrup();
       
            return $"{prodBase} and ({result})";
        }
    }  
}
