using System.Text;
using System.Collections.Generic;
public interface IReadableSqlFIle
{
    string LoadText();
}
public interface IWritableSqlFile
{
    void SaveText();
}

public class ReadOnlySqlFile: IReadableSqlFIle{
    public string FilePath {get; set;}
    public string FileText {get; set;}
    public string LoadText(){
        return string.Empty;
    }
}

public class SqlFile: IWritableSqlFile, IReadableSqlFIle{
    public string FilePath {get;set;}
    public string FileText {get;set;}
    public string LoadText(){
        return string.Empty;
    }
    public void SaveText(){
        //logic
    }
}

public class SqlFileManager{
    public string GetTextFromFile(List<IReadableSqlFIle> aListReadableFiles){
        StringBuilder objStringBuilder = new StringBuilder();
        foreach(var objFile in aListReadableFiles){
            objStringBuilder.Append(objFile.LoadText());
        }
        return objStringBuilder.ToString();
    }

    public void SaveTextIntoFiles(List<IWritableSqlFile> aListWritableFiles){
        foreach(var objFile in aListWritableFiles){
            objFile.SaveText();
        }
    }
}