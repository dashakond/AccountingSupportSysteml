using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSupportSystem.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);                // Додавання нового запису
        void Remove(T entity);             // Видалення запису
        void Update(T entity);             // Оновлення запису
        
        IQueryable<T> GetAll();            // Отримання всіх записів
    }
}
