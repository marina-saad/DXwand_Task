using DXwand.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXwand.Repository
{
    public interface IUMessageRep
    {
        IEnumerable<UMessage> GetAll();
        UMessage GetById(int Id);
        UMessage AddObj(UMessage obj);
        UMessage EditObj(UMessage obj);
        UMessage DeleteObj(int Id);
    }
}
