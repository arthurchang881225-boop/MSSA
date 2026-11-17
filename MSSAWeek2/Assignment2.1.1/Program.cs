/*
1. Design a class hierarchy of your choice. (Need only class files )

Applicant -> InternalApplicant
          -> ExternalApplicant

InternalApplicant -> EmployeeId
                   -> CurrentDepartment

ExternalApplicant -> ExternalReferenceId
                   -> CurrentEmployer
*/


public class Applicant
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}
public class InternalApplicant : Applicant
{
    public string EmployeeId { get; set; }
    public string CurrentDepartment { get; set; }
}
public class ExternalApplicant : Applicant
{
    public string ExternalReferenceId { get; set; }
    public string CurrentEmployer { get; set; }
}



