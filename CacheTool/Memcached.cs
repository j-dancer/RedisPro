using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Memcached : ICache
    {
        int DEFAULT_TMEOUT = 600;//默认超时时间（单位秒）
        string address;
        public int TimeOut
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Exists(string key)
        {
            throw new NotImplementedException();
        }

        public object Get(string key)
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void Set(string key, object data)
        {
            throw new NotImplementedException();
        }

        public void Set(string key, object data, DateTime cacheTime)
        {
            throw new NotImplementedException();
        }

        public void Set(string key, object data, int cacheTime)
        {
            throw new NotImplementedException();
        }

        public void Set<T>(string key, T data)
        {
            throw new NotImplementedException();
        }

        public void Set<T>(string key, T data, DateTime cacheTime)
        {
            throw new NotImplementedException();
        }

        public void Set<T>(string key, T data, int cacheTime)
        {
            throw new NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new NotImplementedException();
        }
    }
}
