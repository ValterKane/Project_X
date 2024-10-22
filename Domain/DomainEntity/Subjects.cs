namespace Domain.DomainEntity;

public class Subjects
{
    private Subjects(Guid subjectGuid, string subjectName, Guid teacherGuid)
    {
        SubjectName = subjectName;
        SubjectGuid = subjectGuid;
        TeacherGuid = teacherGuid;
    }
    public Guid SubjectGuid { get; set; }

    public string SubjectName { get; private set; }

    public Guid TeacherGuid { get; private set; }

    public static Subjects Create(Guid subjectGuid, string subjectName, Guid teacherGuid)
    {
        return new Subjects(subjectGuid, subjectName, teacherGuid);
    }
    
}
