using System;

public interface ILogger
{
 void LogMessage(string aString);   
}

//low level classes
public class DbLogger: ILogger{
    public void LogMessage(string aString){
        //logic
    }
}
public class FileLogger: ILogger{
    public void LogMessage(string sStackTrace){
        //logic
    }
}

public class EventLogger: ILogger{
    public void LogMessage(string aMessage){
        //logic
    }
}

//high level classes
public class ExceptionLogger{
    private ILogger _logger;
    public ExceptionLogger(ILogger aLogger){
        this._logger = aLogger;
    }
    public void LogException(Exception aException){
        string strMessage = GetUserReadableMessage(aException);
        this._logger.LogMessage(strMessage);
    }
    private string GetUserReadableMessage(Exception aException){
        string strMessage = string.Empty;
        //logic
        return strMessage;
    }
}

public class DataExporter{
    public void ExportDataFromFile(){
        ExceptionLogger _exceptionLogger;
        try{
            //logic
        }
        catch(SystemException ex){
            _exceptionLogger = new ExceptionLogger(new DbLogger());
            _exceptionLogger.LogException(ex);
        }
        catch(ApplicationException ex){
            _exceptionLogger = new ExceptionLogger(new EventLogger());
            _exceptionLogger.LogException(ex);
        }
        catch(Exception ex){
            _exceptionLogger = new ExceptionLogger(new FileLogger());
            _exceptionLogger.LogException(ex);
        }
    }
}