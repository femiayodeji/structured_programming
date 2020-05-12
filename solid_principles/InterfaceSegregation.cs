public interface IProgrammer
{
    void WorkOnTask();
}
public interface ILead
{
    void AssignTask();
    void CreateSubTask();
}

public class Programmer: IProgrammer{
    public void WorkOnTask(){
        //logic
    }
}

public class Manager: ILead{
    public void AssignTask(){
        //logic
    }
    public void CreateSubTask(){
        //logic
    }
}

public class TeamLead: IProgrammer, ILead{
    public void AssignTask(){
        //logic
    }
    public void CreateSubTask(){
        //logic
    }
    public void WorkOnTask(){
        //logic
    }
}