using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABSTRACT FACTORY DESIGN PATTERN\n");
            PackageAndDeliveryFactory standardFactoryObj = new StandardFactory();            
            Client standardProduct = new Client(standardFactoryObj);
            Console.WriteLine(standardProduct.ClientPackaging.GetType().ToString());
            Console.WriteLine(standardProduct.ClientDocument.GetType().ToString());

            Console.WriteLine("-------");

            PackageAndDeliveryFactory delicateFactoryObj = new DelicateFactory();
            Client delicateProduct = new Client(delicateFactoryObj);
            Console.WriteLine(delicateProduct.ClientPackaging.GetType().ToString());
            Console.WriteLine(delicateProduct.ClientDocument.GetType().ToString());
        }
    }
}
