public class ApplicationState
{
    private static ApplicationState instance = null;
    //State Information
    public string LoginId { get; set; }
    public string RoleId { get; set; }

    private ApplicationState() {}
    
    //Lock Object
    private static object lockThis = new object();
    public static ApplicationState GetState(){
        lock(lockThis){
            if(ApplicationState.instance == null){
                instance = new ApplicationState();
            }
        }
        return instance;
    }
}