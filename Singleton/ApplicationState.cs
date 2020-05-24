public sealed class ApplicationState
{
    private static ApplicationState instance = null;
    //State Information
    public string LoginId { get; set; }
    public string RoleId { get; set; }

    private ApplicationState() {}
    
    //Lock Object
    private static object lockThis = new object();
    
}