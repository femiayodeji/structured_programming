//concrete classes
public abstract class Packaging{}
public class StandardPackaging : Packaging{}
public class ShockProofPackaging : Packaging{}
public abstract class DeliveryDocument{}
public class Postal : DeliveryDocument{}
public class Courier : DeliveryDocument{}

//Factory classes
public abstract class PackageAndDeliveryFactory
{
    public abstract Packaging CreatePackaging();
    public abstract DeliveryDocument CreateDeliveryDocument();
}
public class StandardFactory : PackageAndDeliveryFactory
{
    public override Packaging CreatePackaging(){
        return new StandardPackaging();
    }
    public override DeliveryDocument CreateDeliveryDocument(){
        return new Postal();
    }
}
public class DelicateFactory : PackageAndDeliveryFactory
{
    public override Packaging CreatePackaging(){
        return new ShockProofPackaging();
    }
    public override DeliveryDocument CreateDeliveryDocument(){
        return new Courier();
    }
}

//client 
public class Client
{
    private Packaging _packaging;
    private DeliveryDocument _deliveryDocument;
    public Client(PackageAndDeliveryFactory factory)
    {
        _packaging = factory.CreatePackaging();
        _deliveryDocument = factory.CreateDeliveryDocument();
    }

    public Packaging ClientPackaging{
        get {
            return _packaging;
        }
    }
    public DeliveryDocument ClientDocument{
        get {
            return _deliveryDocument;
        }
    }
}
