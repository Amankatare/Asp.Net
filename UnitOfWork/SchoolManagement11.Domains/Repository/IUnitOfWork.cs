namespace SchoolManagement11.Domains.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Student { get; }

        ITeacherRepository Teacher { get; }

        IStudentActivityRepository StudentActivity { get; }



    }
}
