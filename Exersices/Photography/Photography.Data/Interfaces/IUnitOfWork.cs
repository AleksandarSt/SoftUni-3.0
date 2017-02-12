namespace Photography.Data.Interfaces
{
    using Models;

    public interface IUnitOfWork
    {

        IRepository<Lens> Lenses { get; }

        IRepository<Accessory> Accessories { get; }

        IRepository<Camera> Cameras { get; }

        IRepository<Photographer> Photographers { get; }

        IRepository<Workshop> Workshops { get; }

        void Commit();
    }
}
