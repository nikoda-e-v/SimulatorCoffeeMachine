using System;



namespace ClassLibrarySimulatorCofeeMachine
{
    /// Данный класс создан как наследник базового Customer, принимает все методы базового (Фабрика2 300)
    /// и расширяет своими (Фабрика1 150). Из этого класса по интелисенсу доступны все методы - свои и родительские.
    /// В принципе, класс CustomerSmall иллюстрирует наследование, и можно было все прописать в базовом классе. 

    public class CustomerSmall : Customer
    {
        private string prodReady = "Ваш кофе готов:";
               

        //Метод открыт для вызова Клиентом Капуччино 150 грамм без сахара, доступен в UI 
        public string CustomerWantCappuccino150()
        {
            return $"{Cappuccino150(new Coffee150Factory1())}";
        }

        //Метод закрыт для вызова Клиентом, раскрывает реализацию работы с Фабрикой Капуччино Стакан 150 грамм. 
        private string Cappuccino150(IAbstractProduktFactory factory)
        {
            var productMilk = factory.CreateProductWhippedMilk();
            var productEspresso = factory.CreateProductEspresso();
            return $"{prodReady}\n{productEspresso.FunctionMakeCappuccino(productMilk)}";
        }
        
        //Метод открыт для вызова Клиентом Капуччино 150 грамм с сахаром, доступен в UI
        //
        //
        public string CustomerWantCappuccinoWithSugar150()
        {
            return $"{CappuccinoWithSugar150(new Coffee150Factory1())}";
        }

        //Метод закрыт для вызова в UI, раскрывает реализацию логики работы с Фабрикой1 150 грамм
        //
        //
        private string CappuccinoWithSugar150(IAbstractProduktFactory factory)
        {
            var productMilk = factory.CreateProductWhippedMilk();
            var productEspresso = factory.CreateProductEspresso();
            var productSugar = factory.CreateProductSugar();
            return $"{prodReady}\n{productEspresso.FunctionMakeCappuccinoAndSugar(productMilk, productSugar)}";
        }

        //Метод открыт для вызова Клиентом Капуччино 150 грамм с сахаром, доступен в UI
        //
        //
        public string CustomerWantMacciato150()
        {
            return $"{Macciato150(new Coffee150Factory1())}";
        }

        //Метод закрыт для вызова в UI, раскрывает реализацию логики работы с Фабрикой1 150 грамм
        //
        //
        private string Macciato150(IAbstractProduktFactory factory)
        {
            var productMilk = factory.CreateProductWhippedMilk();
            var productEspresso = factory.CreateProductEspresso();
            return $"{prodReady}\n{productEspresso.FunctionMakeMacchiatto(productMilk)}";
        }

        //Метод открыт для вызова Клиентом Макиатто 300 грамм с сахаром, доступен в UI 
        //
        //
        public string CustomerWantMacciatoWithSugar150()
        {
            return $"{MacciatoWithSugar150(new Coffee150Factory1())}";
        }

        //Метод закрыт для вызова в UI, раскрывает реализацию логики работы с Фабрикой1 150 грамм
        //
        //
        private string MacciatoWithSugar150(IAbstractProduktFactory factory)
        {
            var productMilk = factory.CreateProductWhippedMilk();
            var productEspresso = factory.CreateProductEspresso();
            var productSugar = factory.CreateProductSugar();
            return $"{prodReady}\n{productEspresso.FunctionMakeMacchiattoAndSugar(productMilk, productSugar)}";
        }
        
        ///Raf 150 грамм
        /// 
        ///
        public string CustomerWantRaf150()
        {
            return $"{Raf150(new Coffee150Factory1())}";
        }

        //Метод закрыт для вызова в UI, раскрывает реализацию логики работы с Фабрикой1 150 грамм
        //
        //
        private string Raf150(IAbstractProduktFactory factory)
        {
            var productSyrup = factory.CreateProductSyrup();
            var productMilk = factory.CreateProductWhippedMilk();
            var productEspresso = factory.CreateProductEspresso();
            return $"{prodReady}\n{productEspresso.FunctionMakeRafAndSyrup(productMilk, productSyrup)}";
        }

        //Метод для вызова Клиентом Raf 150 грамм с сахаром, доступен в UI 
        //
        //
        public string CustomerWantRafWithSugar150()
        {
            return $"{RafWithSugar150(new Coffee150Factory1())}";
        }

        //Метод закрыт для вызова в UI, раскрывает реализацию логики работы с Фабрикой1 150 грамм
        //
        //
        private string RafWithSugar150(IAbstractProduktFactory factory)
        {
            var productSyrup = factory.CreateProductSyrup();
            var productMilk = factory.CreateProductWhippedMilk();
            var productEspresso = factory.CreateProductEspresso();
            var productSugar = factory.CreateProductSugar();
            return $"{prodReady}\n{productEspresso.FunctionMakeRafAndSyrupAndSugar(productMilk, productSyrup, productSugar)}";
        }

        //Метод для вызова Клиентом Corretto 150 грам. 
        //
        //
        public string CustomerWantCorretto150()
        {
            return $"{Corretto150(new Coffee150Factory1())}";
        }

        //Метод закрыт для вызова в UI, раскрывает реализацию логики работы с Фабрикой1 150 грамм
        //
        //
        private string Corretto150(IAbstractProduktFactory factory)
        {
            var productWhiskey = factory.CreateProductWhiskey();
            var productEspresso = factory.CreateProductEspresso();
            return $"{prodReady}\n{productEspresso.FunctionMakeCorretto(productWhiskey)}";
        }

        //Метод открыт для вызова Клиентом Corretto 150 грамм с сахаром, доступен в UI
        //
        //
        public string CustomerWantCorrettoWithSugar150()
        {
            return $"{CorrettoWithSugar150(new Coffee150Factory1())}";
        }

        //Метод закрыт для вызова в UI, раскрывает реализацию логики работы с Фабрикой1 150 грамм

        private string CorrettoWithSugar150(IAbstractProduktFactory factory)
        {
            var productWhiskey = factory.CreateProductWhiskey();
            var productEspresso = factory.CreateProductEspresso();
            var productSugar = factory.CreateProductSugar();
            return $"{prodReady}\n{productEspresso.FunctionMakeCorrettoAndSugar(productWhiskey, productSugar)}";
        }
    }
}
