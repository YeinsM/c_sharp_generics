using System.Collections.Generic;
using YeinsBrainSoftware.StorageApp.Models;

namespace YeinsBrainSoftware.StorageApp.Repositories
{
    public class GenericRepository<T>
    {
        private readonly List<T> _models = new(); //C# 9
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
}
