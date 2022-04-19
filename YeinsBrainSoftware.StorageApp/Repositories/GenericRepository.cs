using System.Collections.Generic;
using System.Linq;
using YeinsBrainSoftware.StorageApp.Models;

namespace YeinsBrainSoftware.StorageApp.Repositories
{
    public class GenericRepository<T> where T : EntityBase
    {
        private readonly List<T> _models = new(); //C# 9

        public T GetById(int id)
        {
            return _models.Single(item => item.Id == id);
        }

        public void Add(T model)
        {
            model.Id = _models.Any() ? _models.Max(item => item.Id) + 1 : 1;
            _models.Add(model);
        }

        public void Save()
        {
            foreach (var model in _models)
            {
                System.Console.WriteLine(model);
            }
        }

        public void Remove(T model) => _models.Remove(model);
    }
}
