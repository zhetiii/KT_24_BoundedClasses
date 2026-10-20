# KT_24_BoundedClasses

# Вариант 1. Репозиторий сущностей
1) Базовый класс Entity со свойством int Id { get; init; }.
2) Обобщённый класс Repository<T> where T : Entity с методами Add(T item) и T? GetById(int id).
3) Производные классы Product : Entity (с дополнительным свойством Name) и Customer : Entity (с дополнительным свойством Email).
4) Создайте Repository<Product> и Repository<Customer>, добавьте в каждый минимум два элемента.
5) Продемонстрируйте GetById для обоих репозиториев, включая случай, когда элемент с таким Id не найден.

# Результаты и проверочные ключи
<img width="1358" height="157" alt="изображение" src="https://github.com/user-attachments/assets/79b30f79-3d24-43c6-9cb2-99d2d9c24998" />

#  Мои результаты:
<img width="1919" height="1142" alt="изображение" src="https://github.com/user-attachments/assets/d90b3c39-cd72-4fee-98c6-43ba048ba4d0" />
