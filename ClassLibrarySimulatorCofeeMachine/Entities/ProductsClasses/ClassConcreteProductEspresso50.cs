using System;

namespace ClassLibrarySimulatorCofeeMachine
{
    // Продукты для получения разных напитков
    
    class ConcreteProductEspresso50 : IAbstractProductEspresso
    {
        private string prodSmall = "SMALL";
        private string prodBase = "Espresso 50";
        private string prodCap = "Cappuccino";
        private string prodRaf = "Raf caffe";
        private string prodCor = "Corretto";
        private string prodMac = "Macchiatto";
        private string and = " and ";
        private string with = " with ";

        

        public string FunctionMakeEspresso()
        {
            return $"{prodBase}";
        }

        ///Espresso 50 с сахаром
        ///
        ///
        public string FunctionMakeEspressoWithSugar(IAbstractProductSugar combiner)
        {
            var result = combiner.FunctionSugar();

            return $"{prodBase} ({result})";
        }

        ///Cappuccino 150
        ///
        ///
        public string FunctionMakeCappuccino(IAbstractProductWhippedMilk combiner)
        {
            var result = combiner.FunctionWhipedMilk();

            return $"{prodCap} {prodSmall}\n({prodBase}){and}({result})";
        }

        ///Cappuccino 150 с сахаром
        ///
        ///
        public string FunctionMakeCappuccinoAndSugar(IAbstractProductWhippedMilk combiner, IAbstractProductSugar combiner2)
        {
            var result = combiner.FunctionWhipedMilk();
            var result2 = combiner2.FunctionSugar();
            return $"{prodCap} {prodSmall}\n({prodBase}){and}({result}){and}({result2})";
        }

        /// Raf 150 с сиропом
        ///
        ///
        public string FunctionMakeRafAndSyrup(IAbstractProductWhippedMilk combiner, IAbstractProductSyrup combiner2)
        {
            var result = combiner.FunctionWhipedMilk();
            var result2 = combiner2.FunctionSyrup();

            return $"{prodRaf} {prodSmall}\n({prodBase}){and}({result}){and}({result2})";
        }

        /// Raf 150 с сиропом и сахаром
        ///
        ///
        public string FunctionMakeRafAndSyrupAndSugar(IAbstractProductWhippedMilk combiner, IAbstractProductSyrup combiner2, IAbstractProductSugar combiner3)
        {
            var result = combiner.FunctionWhipedMilk();
            var result2 = combiner2.FunctionSyrup();
            var result3 = combiner3.FunctionSugar();

            return $"{prodRaf} {prodSmall}\n({prodBase}){and}({result}){and}({result2}{and}({result3})";
        }

        ///Corretto 150
        ///
        ///
        public string FunctionMakeCorretto(IAbstractProductWhiskey combiner)
        {
            var result = combiner.FunctionWhiskey();

            return $"{prodCor} {prodSmall}\n({prodBase}){with}({result})";
        }

        ///Corretto 150 с сахаром
        ///
        ///
        public string FunctionMakeCorrettoAndSugar(IAbstractProductWhiskey combiner, IAbstractProductSugar combiner2)
        {
            var result = combiner.FunctionWhiskey();
            var result2 = combiner2.FunctionSugar();

            return $"{prodCor} {prodSmall}\n({prodBase}){with}({result}){and}({result2})";
        }

        ///Macchiatto 150
        ///
        ///
        public string FunctionMakeMacchiatto(IAbstractProductWhippedMilk combiner)
        {
            var result = combiner.FunctionWhipedMilk();

            return $"{prodMac} {prodSmall}\n({prodBase}){and}({result})";
        }

        ///Macchiatto 150 с сахаром
        ///
        ///
        public string FunctionMakeMacchiattoAndSugar(IAbstractProductWhippedMilk combiner, IAbstractProductSugar combiner2)
        {
            var result = combiner.FunctionWhipedMilk();
            var result2 = combiner2.FunctionSugar();
            return $"{prodMac} {prodSmall}\n({prodBase}){and}({result}){and}({result2})";
        }
    }
}
