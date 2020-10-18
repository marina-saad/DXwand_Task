using DXwand.Containers;
using DXwand.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXwand.Repository
{
    public class UMessageRep : IUMessageRep
    {
        private readonly dbContainer db;

        public UMessageRep(dbContainer db)
        {
            this.db = db;
        }
        public UMessage AddObj(UMessage obj)
        {
            var data = db.UMessages.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public UMessage DeleteObj(int Id)
        {
            var olddata = db.UMessages.Find(Id);
            db.UMessages.Remove(olddata);
            db.SaveChanges();
            return olddata;
        }

        public UMessage EditObj(UMessage obj)
        {
            var olddata = db.UMessages.Find(obj.Id);
            olddata.MContent = obj.MContent;
            olddata.LanguageId = obj.LanguageId;
            db.SaveChanges();
            return obj;
        }

        public IEnumerable<UMessage> GetAll()
        {
            var data = db.UMessages;
            return data;
        }

        public UMessage GetById(int Id)
        {
            var data = db.UMessages.Find(Id);
            return data;
        }
    }
}
