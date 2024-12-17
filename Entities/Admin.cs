using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingSupportSystem.Repositories.Interfaces;

namespace AccountingSupportSystem.Entities
{
    public class Admin : User
    {
        public Admin(string username, string password) : base(username, password) { }

        // Створення нового користувача через репозиторій
        public void CreateUser(IBaseRepository<User> userRepository, string username, string password)
        {
            var user = new User(username, password);
            userRepository.Add(user);
        }

        // Видалення користувача через репозиторій
        public void DeleteUser(IBaseRepository<User> userRepository, string username)
        {
            // Шукаємо користувача за ім'ям
            var user = userRepository.GetAll().FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                userRepository.Remove(user);
            }
        }

        // Оновлення користувача через репозиторій
        public void UpdateUser(IBaseRepository<User> userRepository, string oldUsername, string newUsername, string newPassword)
        {
            // Шукаємо користувача за старим ім'ям
            var user = userRepository.GetAll().FirstOrDefault(u => u.Username == oldUsername);
            if (user != null)
            {
                user.Username = newUsername;
                user.Password = newPassword;
                userRepository.Update(user);
            }
        }
    }
}

