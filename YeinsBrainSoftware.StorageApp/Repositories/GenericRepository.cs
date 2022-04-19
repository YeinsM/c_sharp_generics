using System.Collections.Generic;
using YeinsBrainSoftware.StorageApp.Models;

namespace YeinsBrainSoftware.StorageApp.Repositories
{
    public class GenericRepository<T>
    {
        protected readonly List<T> _models = new(); //C# 9
        public void Add(T model)
        {
            _models.Add(model);
        }

        public void Save()
        {
            foreach (var model in _models)
            {
                System.Console.WriteLine(model);
            }
        }
    }

    public class GenericRepositoryWithRemove<T> : GenericRepository<T>
    {
        public void Remove(T model) => _models.Remove(model);
    }
}
