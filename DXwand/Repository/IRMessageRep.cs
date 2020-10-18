using DXwand.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXwand.Repository
{
    public interface IRMessageRep
    {
        IEnumerable<RMessage> GetAll();
        String GetById(int Id);
        RMessage AddObj(RMessage obj);
        RMessage EditObj(RMessage obj);
        RMessage DeleteObj(int Id);
    }
}
