public sealed class Calculate{
    public Calculate(){}
    private static Calculate instance = null;
    public static Calculate Instance {
        get{
            if(instance == null){
                instance = new Calculate();
            }
            return instance;
        }
    }

    public double ValueOne {get; set;}
    public double ValueTwo {get; set;}

    public double Add(){
        return ValueOne + ValueTwo;
    }

    public double Sub(){
        return ValueOne - ValueTwo;
    }

    public double Mul(){
        return ValueOne * ValueTwo;
    }

    public double Div(){
        return ValueOne / ValueTwo;
    }
}