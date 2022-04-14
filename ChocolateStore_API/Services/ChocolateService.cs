using ChocolateStore_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChocolateStoreAPI.Services
{
    public class ChocolateService : IChocolateService
    {
        private ChocolateStoreDBContext _dataAccess;

        public ChocolateService()
        {
            _dataAccess = new ChocolateStoreDBContext();
        }

        public void Delete(int id)
        {
            if (_dataAccess.Chocolates.Count() == 0)
            {
                throw new Exception("No list found.");
            }

            var chocolate = _dataAccess.Chocolates.SingleOrDefault(x => x.Id == id);
            if (chocolate == null)
            {
                throw new Exception("No mobile with that id found");
            }

            _dataAccess.Chocolates.Remove(chocolate);
            _dataAccess.SaveChanges();
        }

        public IEnumerable<Chocolate> Get()
        {
            if (_dataAccess.Chocolates.Count() == 0)
            {
                throw new Exception("No list found.");
            }
            return _dataAccess.Chocolates;
        }

        public Chocolate GetByID(int id)
        {
            var chocolate = _dataAccess.Chocolates.SingleOrDefault(x => x.Id == id);
            if (chocolate == null)
            {
                throw new Exception("No mobile with that id found");
            }
            return chocolate;
        }

        public void Save(Chocolate chocolate)
        {
            _dataAccess.Chocolates.Add(chocolate);
            _dataAccess.SaveChanges();
        }
    }
}
