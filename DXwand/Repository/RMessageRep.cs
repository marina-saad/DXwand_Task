using DXwand.Containers;
using DXwand.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXwand.Repository
{
    public class RMessageRep:IRMessageRep
    {
        private readonly dbContainer db;

        public RMessageRep(dbContainer db)
        {
            this.db = db;
        }

        public RMessage AddObj(RMessage obj)
        {
            var data = db.RMessages.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public RMessage DeleteObj(int Id)
        {
            var olddata = db.RMessages.Find(Id);
            db.RMessages.Remove(olddata);
            db.SaveChanges();
            return olddata;
        }

        public RMessage EditObj(RMessage obj)
        {
            var olddata = db.RMessages.Find(obj.Id);
            olddata.RContent = obj.RContent;
            db.SaveChanges();
            return obj;
        }

        public IEnumerable<RMessage> GetAll()
        {
            var data = db.RMessages;
            return data;
        }

        public String GetById(int Id)
        {
            var data = db.RMessages.Find(Id).RContent;
            return data;
        }
    }
}
