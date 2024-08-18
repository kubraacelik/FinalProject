using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        //key veriyoruz bellekten key'e karşılık gelen data'yı getiriyor
        T Get<T>(string key);
        object Get(string key);
        //duration = cache'de ne kadar duracak
        void Add(string key, object value,int duration);
        //cache'de var mı
        bool IsAdd(string key);
        void Remove(string key);
        //örneğin isminde category olanları kaldır ya da ismi get ile başlayanları kaldır diyebilir
        void RemoveByPattern(string pattern);
    }
}
