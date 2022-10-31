
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_TcNoVerificationCollection : ICollection
    {
        public MongoDB_TcNoVerificationCollection()
        {
            CollectionName = "TcNoList";
        }

        public string CollectionName { get; set; }
    }
}