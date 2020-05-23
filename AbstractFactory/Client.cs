//concrete classes
public abstract class Packing{}
public class StandardPacking : Packing{}
public class ShockProofPacking : Packing{}
public abstract class DeliveryDocument{}
public class Postal : DeliveryDocument{}
public class Courier : DeliveryDocument{}
