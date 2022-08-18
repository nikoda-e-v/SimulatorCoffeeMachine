using System;

namespace ClassLibrarySimulatorCofeeMachine
{
    /// Продукты для получения разных напитков
    
    class ConcreteProductEspresso100 : IAbstractProductEspresso
    {
        private string prodBig = "BIG";
        private string prodBase = "Espresso 100";
        private string prodCap = "Cappuccino";
        private string prodRaf = "Raf cоffee";
        private string prodCor = "Corretto";
        private string prodMac = "Macchiatto";
        private string and = " and ";
        private string with  = " with ";


        /// Продукт Эспрессо 100 может работать самостоятельно
        public string FunctionMakeEspresso()
        {
            return $"{prodBase}";
        }

        public string FunctionMakeEspressoWithSugar(IAbstractProductSugar combiner)
        {
            var result = combiner.FunctionSugar();

            return $"{prodBase}{with}({result})";
        }

        
        public string FunctionMakeCappuccino(IAbstractProductWhippedMilk combiner)
        {
            var result = combiner.FunctionWhipedMilk();

            return $"{prodCap} {prodBig}\n({prodBase}){and}({result})";
        }

        /// Cappuccino c сахаром
        ///
        ///
        public string FunctionMakeCappuccinoAndSugar(IAbstractProductWhippedMilk combiner, IAbstractProductSugar combiner2)
        {
            var result = combiner.FunctionWhipedMilk();
            var result2 = combiner2.FunctionSugar();
            return $"{prodCap} {prodBig}\n({prodBase}){and}({result}){and}({result2})";
        }

        /// Raf
        ///
        ///
        public string FunctionMakeRafAndSyrup(IAbstractProductWhippedMilk combiner, IAbstractProductSyrup combiner2)
        {
            var result = combiner.FunctionWhipedMilk();
            var result2 = combiner2.FunctionSyrup();

            return $"{prodRaf} {prodBig}\n({prodBase}){and}({result}){and}({result2})";
        }

        /// Raf c сахаром
        ///
        ///
        public string FunctionMakeRafAndSyrupAndSugar(IAbstractProductWhippedMilk combiner, IAbstractProductSyrup combiner2, IAbstractProductSugar combiner3)
        {
            var result = combiner.FunctionWhipedMilk();
            var result2 = combiner2.FunctionSyrup();
            var result3 = combiner3.FunctionSugar();

            return $"{prodRaf} {prodBig}\n({prodBase}){and}({result}){and}({result2}){and}({result3})";
        }

        ///Corretto
        ///
        ///
        public string FunctionMakeCorretto(IAbstractProductWhiskey combiner)
        {
            var result = combiner.FunctionWhiskey();

            return $"{prodCor} {prodBig}\n({prodBase}){with}({result})";
        }

        ///Corretto c сахаром
        ///
        ///
        public string FunctionMakeCorrettoAndSugar(IAbstractProductWhiskey combiner,  IAbstractProductSugar combiner2)
        {
            var result = combiner.FunctionWhiskey();
            var result2 = combiner2.FunctionSugar();

            return $"{prodCor} {prodBig}\n({prodBase}){with}({result}){and}({result2})";
        }

        ///Macchiatto
        ///
        ///
        public string FunctionMakeMacchiatto(IAbstractProductWhippedMilk combiner)
        {
            var result = combiner.FunctionWhipedMilk();

            return $"{prodMac} {prodBig}\n({prodBase}){and}({result})";
        }

        ///Macchiatto c сахаром
        ///
        ///
        public string FunctionMakeMacchiattoAndSugar(IAbstractProductWhippedMilk combiner, IAbstractProductSugar combiner2)
        {
            var result = combiner.FunctionWhipedMilk();
            var result2 = combiner2.FunctionSugar();
            return $"{prodMac} {prodBig}\n({prodBase}){and}({result}){and}({result2})";
        }
    }
}
