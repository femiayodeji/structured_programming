//concrete classes
public abstract class Packing{}
public class StandardPacking : Packing{}
public class ShockProofPacking : Packing{}
public abstract class DeliveryDocument{}
public class Postal : DeliveryDocument{}
public class Courier : DeliveryDocument{}

//Factory classes
public abstract class PackageAndDeliveryFactory
{
    public abstract Packing CreatePackaging();
    public abstract DeliveryDocument CreateDeliveryDocument();
}
public class StandardFactory : PackageAndDeliveryFactory
{
    public override Packing CreatePackaging(){
        return new StandardPacking();
    }
    public override DeliveryDocument CreateDeliveryDocument(){
        return new Postal();
    }
}
public class DelicateFactory : PackageAndDeliveryFactory
{
    public override Packing CreatePackaging(){
        return new ShockProofPacking();
    }
    public override DeliveryDocument CreateDeliveryDocument(){
        return new Courier();
    }
}
