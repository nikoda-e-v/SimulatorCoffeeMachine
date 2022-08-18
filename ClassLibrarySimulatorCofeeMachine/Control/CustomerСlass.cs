using System;



namespace ClassLibrarySimulatorCofeeMachine
{
    

    public class Customer
    {
        private string prodReady = "Ваш кофе готов:";
        
        //Эспрессо 50 грамм. Стакан не важен, эспрессо имеет один стандартный объем 50 г
        //Эспрессо 50 грамм.
        public string CustomerWantEspressoWithSugar50()
        {
            return $"{EspressoWithSugar50(new Coffee150Factory1())}";
        }

        //Метод закрыт для вызова в UI, раскрывает реализацию логики работы с Фабрикой2 300 грамм
        private string EspressoWithSugar50(IAbstractProduktFactory factory)
        {
            var productEspresso = factory.CreateProductEspresso();
            var productSugar = factory.CreateProductSugar();
            return $"{prodReady}\n{productEspresso.FunctionMakeEspressoWithSugar(productSugar)}";
        }

        public string CustomerWantEspresso50()
        {
            return $"{Espresso50(new Coffee150Factory1())}";
        }

        //Метод закрыт для вызова в UI, раскрывает реализацию логики работы с Фабрикой2 300 грамм
        private string Espresso50(IAbstractProduktFactory factory)
        {
            var productEspresso = factory.CreateProductEspresso();
            return $"{prodReady}\n{productEspresso.FunctionMakeEspresso()}";
        }

        //Доппио 100 грамм (стакан не важен, доппио имеет один стандартный объем - двойной эспрессо)
        public string CustomerWantDoppioWithSugar100()
        {
            return $"{EspressoWithSugar100(new Coffee300Factory2())}";
        }

        //Метод закрыт для вызова в UI, раскрывает реализацию логики работы с Фабрикой2 300 грамм
        private string EspressoWithSugar100(IAbstractProduktFactory factory)
        {
            var productEspresso = factory.CreateProductEspresso();
            var productSugar = factory.CreateProductSugar();
            return $"{prodReady}\n{productEspresso.FunctionMakeEspressoWithSugar(productSugar)}";
        }

        public string CustomerWantDoppio100()
        {
            return $"{Espresso100(new Coffee300Factory2())}";
        }

        //Метод закрыт для вызова в UI, раскрывает реализацию логики работы с Фабрикой2 300 грамм
        private string Espresso100(IAbstractProduktFactory factory)
        {
            var productEspresso = factory.CreateProductEspresso();
            return $"{prodReady}\n{productEspresso.FunctionMakeEspresso()}";
        }

        

        //Клиент запрашивает капуччино Стакан 300 грамм - на основе Эспрессо 100 грамм. 
        //Отрабатывает фабрика на базе Эспрессо 100 грамм. С сахаром или без сахара.
        public string CustomerWantCappuccino300()
        {
            return $"{Cappuccino300(new Coffee300Factory2())}";
        }

        //Метод закрыт для вызова в UI, раскрывает реализацию логики работы с Фабрикой2 300 грамм
        private string Cappuccino300(IAbstractProduktFactory factory)
        {
            var productMilk = factory.CreateProductWhippedMilk();
            var productEspresso = factory.CreateProductEspresso();
            return $"{prodReady}\n{productEspresso.FunctionMakeCappuccino(productMilk)}";
        }

        public string CustomerWantCappuccinoWithSugar300()
        {
            return $"{CappuccinoWithSugar300(new Coffee300Factory2())}";
        }

        //Метод закрыт для вызова в UI, раскрывает реализацию логики работы с Фабрикой2 300 грамм
        private string CappuccinoWithSugar300(IAbstractProduktFactory factory)
        {
            var productMilk = factory.CreateProductWhippedMilk();
            var productEspresso = factory.CreateProductEspresso();
            var productSugar = factory.CreateProductSugar();
            return $"{prodReady}\n{productEspresso.FunctionMakeCappuccinoAndSugar(productMilk, productSugar)}";
        }

        public string CustomerWantMacciato300()
        {
            return $"{Macciato300(new Coffee300Factory2())}";
        }

        //Метод закрыт для вызова в UI, раскрывает реализацию логики работы с Фабрикой2 300 грамм
        private string Macciato300(IAbstractProduktFactory factory)
        {
            var productMilk = factory.CreateProductWhippedMilk();
            var productEspresso = factory.CreateProductEspresso();
            return $"{prodReady}\n{productEspresso.FunctionMakeMacchiatto(productMilk)}";
        }

        //Метод открыт для вызова Клиентом Макиатто 300 грамм с сахаром, доступен в UI 
        public string CustomerWantMacciatoWithSugar300()
        {
            return $"{MacciatoWithSugar300(new Coffee300Factory2())}";
        }

        //Метод закрыт для вызова Клиентом, раскрывает реализацию работы с Фабрикой Капуччино Стакан 150 грамм
        private string MacciatoWithSugar300(IAbstractProduktFactory factory)
        {
            var productMilk = factory.CreateProductWhippedMilk();
            var productEspresso = factory.CreateProductEspresso();
            var productSugar = factory.CreateProductSugar();
            return $"{prodReady}\n{productEspresso.FunctionMakeMacchiattoAndSugar(productMilk, productSugar)}";
        }

        public string CustomerWantCorretto300()
        {
            return $"{Corretto300(new Coffee300Factory2())}";
        }

        //Метод закрыт для вызова Клиентом Макиатто 300 грамм , раскрывает реализацию работы с Фабрикой Капуччино Стакан 150 грамм. 
        private string Corretto300(IAbstractProduktFactory factory)
        {
            var productWhiskey = factory.CreateProductWhiskey();
            var productEspresso = factory.CreateProductEspresso();
            return $"{prodReady}\n{productEspresso.FunctionMakeCorretto(productWhiskey)}";
        }

        //Метод открыт для вызова Клиентом Макиатто 300 грамм с сахаром, доступен в UI 
        public string CustomerWantCorrettoWithSugar300()
        {
            return $"{CorrettoWithSugar300(new Coffee300Factory2())}";
        }

        //Метод закрыт для вызова Клиентом, раскрывает реализацию работы с Фабрикой Капуччино Стакан 150 грамм
        private string CorrettoWithSugar300(IAbstractProduktFactory factory)
        {
            var productWhiskey = factory.CreateProductWhiskey();
            var productEspresso = factory.CreateProductEspresso();
            var productSugar = factory.CreateProductSugar();
            return $"{prodReady}\n{productEspresso.FunctionMakeCorrettoAndSugar(productWhiskey, productSugar)}";
        }

        //Raf Coffee 300
        public string CustomerWantRaf300()
        {
            return $"{Raf300(new Coffee300Factory2())}";
        }

        
        private string Raf300(IAbstractProduktFactory factory)
        {
            var productSyrup = factory.CreateProductSyrup();
            var productMilk = factory.CreateProductWhippedMilk();
            var productEspresso = factory.CreateProductEspresso();
            return $"{prodReady}\n{productEspresso.FunctionMakeRafAndSyrup(productMilk, productSyrup)}";
        }

        //Метод открыт для вызова Клиентом Макиатто 300 грамм с сахаром, доступен в UI 
        public string CustomerWantRafWithSugar300()
        {
            return $"{RafWithSugar300(new Coffee300Factory2())}";
        }

        //Метод закрыт для вызова Клиентом, раскрывает реализацию работы с Фабрикой Капуччино Стакан 150 грамм
        private string RafWithSugar300(IAbstractProduktFactory factory)
        {
            var productSyrup = factory.CreateProductSyrup();
            var productMilk = factory.CreateProductWhippedMilk();
            var productEspresso = factory.CreateProductEspresso();
            var productSugar = factory.CreateProductSugar();
            return $"{prodReady}\n{productEspresso.FunctionMakeRafAndSyrupAndSugar(productMilk, productSyrup, productSugar)}";
        }
    }
}
