# Views.FinancialTransactions_Products

Задачи, направленные на закрепление практических навыков работы с представлениями.

Конфигурация таблиц для закрепления практических навыков работы с PostgreSQL представлена в файле [Config_FinancialTransactions_Products.sql](../../../sql/postgresql/Config_FinancialTransactions_Products.sql). 
Аналогичную конфигурацию и определение таблиц можно использовать для других реляционных баз данных. 

## Задачи

10 задач для закрепления навыков работы с view в PostgreSQL:
- Создание простого view на основе одной таблицы
- Создание view на основе нескольких таблиц
- Использование агрегатных функций в view
- Использование подзапросов в view
- Использование JOIN-операторов в view
- Создание view с параметрами
- Обновление данных в view
- Удаление данных из view
- Создание индексов для ускорения работы с view
- Использование прав доступа для ограничения доступа к данным через view

### Вывод информации 

1. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых в таблице Addresses указан штат "CA".
- Таблицы: Users, Addresses
- Столбцы: UserId, FirstName, LastName, Email

2. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых цена не меньше 500 долларов.
- Таблицы: Products
- Столбцы: ProductId, ProductName, Price

3. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть адреса в штатах "CA" или "TX".
- Таблицы: Users, Addresses
- Столбцы: UserId, FirstName, LastName, Email

4. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), отсортированных по цене по убыванию.
- Таблицы: Products
- Столбцы: ProductId, ProductName, Price

5. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть адреса в штатах "CA" или "TX", и суммарная цена всех их заказов выше 500 долларов.
- Таблицы: Users, Addresses, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email

6. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых есть заказы.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price

7. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть заказы.
- Таблицы: Users, Orders
- Столбцы: UserId, FirstName, LastName, Email

8. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых количество заказов больше 2.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price

9. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых суммарная стоимость заказов выше 200 долларов.
- Таблицы: Users, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email

10. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых количество заказов больше 1 и цена выше 200 долларов.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price

11. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть заказы в определенный период времени.
- Таблицы: Users, Orders
- Столбцы: UserId, FirstName, LastName, Email

12. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых количество заказов меньше 2 и цена меньше 250 долларов.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price

13. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть заказы на определенную сумму.
- Таблицы: Users, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email

14. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых есть заказы определенного пользователя.
- Таблицы: Products, OrderDetails, Orders
- Столбцы: ProductId, ProductName, Price

15. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть заказы в определенном году.
- Таблицы: Users, Orders
- Столбцы: UserId, FirstName, LastName, Email

16. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых количество заказов больше 20 или цена выше 2000 рублей.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price

17. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть заказы в определенный диапазон цен.
- Таблицы: Users, Orders, OrderDetails, Products
- Столбцы: UserId, FirstName, LastName, Email

18. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых количество заказов больше 15 и цена меньше 1500 рублей.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price

19. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть заказы на определенный продукт.
- Таблицы: Users, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email

20. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых количество заказов меньше 5 или суммарная цена заказа больше 5000 рублей.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price

22. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых цена ниже средней цены.

23. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых цена находится в диапазоне 15% от средней цены.

### Создание view 

1. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых в таблице Addresses указан город, переданный в качестве параметра.
- Таблицы: Users, Addresses
- Столбцы: UserId, FirstName, LastName, Email
- Параметры: City

2. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых цена выше переданного значения.
- Таблицы: Products
- Столбцы: ProductId, ProductName, Price
- Параметры: Price

3. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть адреса в городах, переданных в качестве параметров.
- Таблицы: Users, Addresses
- Столбцы: UserId, FirstName, LastName, Email
- Параметры: City1, City2

4. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), отсортированных по цене по убыванию и ограниченных переданным значением.
- Таблицы: Products
- Столбцы: ProductId, ProductName, Price
- Параметры: Limit

5. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть адреса в городах, переданных в качестве параметров, и суммарная цена всех их заказов выше переданного значения.
- Таблицы: Users, Addresses, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email
- Параметры: City1, City2, TotalPrice

6. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых есть заказы на сумму больше переданного значения.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price
- Параметры: TotalPrice

7. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть заказы на определенную дату.
- Таблицы: Users, Orders
- Столбцы: UserId, FirstName, LastName, Email
- Параметры: OrderDate

8. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых количество заказов больше переданного значения.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price
- Параметры: Count

9. Создать представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых суммарная стоимость заказов выше переданного значения.
- Таблицы: Users, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email
- Параметры: TotalPrice

10. Создать представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых количество заказов больше переданного значения и цена выше переданного значения.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price
- Параметры: Count, Price

### Обновление данных

1. Обновить представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых в таблице Addresses указан город "Москва", чтобы оно выводило информацию только о пользователях с адресами в городе "Санкт-Петербург".
- Таблицы: Users, Addresses
- Столбцы: UserId, FirstName, LastName, Email

2. Обновить представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых цена выше 1000 рублей, чтобы оно выводило информацию только о продуктах с ценой выше 2000 рублей.
- Таблицы: Products
- Столбцы: ProductId, ProductName, Price

3. Обновить представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть адреса в городах "Москва" или "Санкт-Петербург", чтобы оно выводило информацию только о пользователях с адресами в городе "Москва".
- Таблицы: Users, Addresses
- Столбцы: UserId, FirstName, LastName, Email

4. Обновить представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), отсортированных по цене по убыванию, чтобы оно выводило информацию отсортированную по цене по возрастанию.
- Таблицы: Products
- Столбцы: ProductId, ProductName, Price

5. Обновить представление, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть адреса в городах "Москва" или "Санкт-Петербург", и суммарная цена всех их заказов выше 5000 рублей, чтобы оно выводило информацию только о пользователях с адресами в городе "Санкт-Петербург".
- Таблицы: Users, Addresses, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email

6. Обновить представление, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых есть заказы, чтобы оно выводило информацию только о продуктах с ценой меньше 1000 рублей.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price

7. Обновить представление, которое выводит информацию о пользователях (UserId

### Задачи по удалению данных из view

1. Удалить из представления информацию о пользователях (UserId, FirstName, LastName, Email), у которых в таблице Addresses указан город "Москва".
- Таблицы: Users, Addresses
- Столбцы: UserId, FirstName, LastName, Email

2. Удалить из представления информацию о продуктах (ProductId, ProductName, Price), у которых цена меньше 500 рублей.
- Таблицы: Products
- Столбцы: ProductId, ProductName, Price

3. Удалить из представления информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть адреса в городах "Москва" или "Санкт-Петербург".
- Таблицы: Users, Addresses
- Столбцы: UserId, FirstName, LastName, Email

4. Удалить из представления информацию о продуктах (ProductId, ProductName, Price), у которых количество заказов меньше 10.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price

5. Удалить из представления информацию о пользователях (UserId, FirstName, LastName, Email), у которых суммарная стоимость заказов меньше 10000 рублей.
- Таблицы: Users, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email

6. Удалить из представления информацию о продуктах (ProductId, ProductName, Price), у которых есть заказы на сумму меньше 5000 рублей.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price

7. Удалить из представления информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть заказы на определенную дату.
- Таблицы: Users, Orders
- Столбцы: UserId, FirstName, LastName, Email

8. Удалить из представления информацию о продуктах (ProductId, ProductName, Price), у которых цена меньше 1000 рублей и количество заказов меньше 5.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price

9. Удалить из представления информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть адреса в городе "Москва" и суммарная цена всех их заказов меньше 5000 рублей.
- Таблицы: Users, Addresses, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email

10. Удалить из представления информацию о продуктах (ProductId, ProductName, Price), у которых цена меньше 2000 рублей и количество заказов меньше 3.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price

### Задачи по созданию индексов для ускорения работы с view

1. Создать индекс на столбец City таблицы Addresses для представления, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых в таблице Addresses указан город, переданный в качестве параметра.
- Таблицы: Users, Addresses
- Столбцы: UserId, FirstName, LastName, Email
- Параметры: City

2. Создать индекс на столбец Price таблицы Products для представления, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых цена выше переданного значения.
- Таблицы: Products
- Столбцы: ProductId, ProductName, Price
- Параметры: Price

3. Создать индекс на столбец City таблицы Addresses для представления, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть адреса в городах, переданных в качестве параметров.
- Таблицы: Users, Addresses
- Столбцы: UserId, FirstName, LastName, Email
- Параметры: City1, City2

4. Создать индекс на столбец Price таблицы Products для представления, которое выводит информацию о продуктах (ProductId, ProductName, Price), отсортированных по цене по убыванию и ограниченных переданным значением.
- Таблицы: Products
- Столбцы: ProductId, ProductName, Price
- Параметры: Limit

5. Создать индекс на столбец City таблицы Addresses и на столбцы Quantity и Price таблицы OrderDetails для представления, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть адреса в городах, переданных в качестве параметров, и суммарная цена всех их заказов выше переданного значения.
- Таблицы: Users, Addresses, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email
- Параметры: City1, City2, TotalPrice

6. Создать индекс на столбцы Price и Quantity таблицы OrderDetails для представления, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых есть заказы на сумму больше переданного значения.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price
- Параметры: TotalPrice

7. Создать индекс на столбец OrderDate таблицы Orders для представления, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у которых есть заказы на определенную дату.
- Таблицы: Users, Orders
- Столбцы: UserId, FirstName, LastName, Email
- Параметры: OrderDate

8. Создать индекс на столбец OrderDetailId таблицы OrderDetails для представления, которое выводит информацию о продуктах (ProductId, ProductName, Price), у которых количество заказов больше переданного значения.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price
- Параметры: Count

9. Создать индекс на столбцы Quantity и Price таблицы OrderDetails для представления, которое выводит информацию о пользователях (UserId, FirstName, LastName, Email), у

### Задачи по использованию рекурсивных запросов в view

1. Создать представление, которое выводит информацию о всех пользователях и всех их адресах (включая улицу, город, штат и почтовый индекс), используя рекурсивный запрос для объединения таблиц Users и Addresses.
- Таблицы: Users, Addresses
- Столбцы: UserId, FirstName, LastName, Email, Street, City, State, ZipCode

2. Создать представление, которое выводит информацию о всех продуктах и категориях, к которым они относятся (включая название категории), используя рекурсивный запрос для объединения таблиц Products и ProductCategories.
- Таблицы: Products, ProductCategories
- Столбцы: ProductId, ProductName, Price, CategoryName

3. Создать представление, которое выводит информацию о всех заказах и статусах заказов (включая название статуса), используя рекурсивный запрос для объединения таблиц Orders и OrderStatuses.
- Таблицы: Orders, OrderStatuses
- Столбцы: OrderId, UserId, OrderDate, OrderStatusName

4. Создать представление, которое выводит информацию о всех пользователях и количестве их заказов (включая общее количество заказов), используя рекурсивный запрос для объединения таблиц Users, Orders и OrderDetails.
- Таблицы: Users, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email, COUNT(OrderDetails.OrderDetailId)

5. Создать представление, которое выводит информацию о всех продуктах и общем количестве заказов на каждый продукт, используя рекурсивный запрос для объединения таблиц Products и OrderDetails.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price, SUM(OrderDetails.Quantity)

6. Создать представление, которое выводит информацию о всех пользователях и суммарной стоимости их заказов (включая общую сумму), используя рекурсивный запрос для объединения таблиц Users, Orders и OrderDetails.
- Таблицы: Users, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email, SUM(OrderDetails.Quantity * OrderDetails.Price)

7. Создать представление, которое выводит информацию о всех продуктах и средней цене на каждый продукт, используя рекурсивный запрос для объединения таблиц Products и OrderDetails.
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, AVG(OrderDetails.Price)

8. Создать представление, которое выводит информацию о всех пользователях и количестве их адресов (включая общее количество), используя рекурсивный запрос для объединения таблиц Users и Addresses.
- Таблицы: Users, Addresses
- Столбцы: UserId, FirstName, LastName, Email, COUNT(Addresses.AddressId)

9. Создать представление, которое выводит информацию о всех продуктах и количестве заказов на каждый продукт за последний месяц, используя рекурсивный запрос для объединения таблиц Products, OrderDetails и Orders.
- Таблицы: Products, OrderDetails, Orders
- Столбцы: ProductId, ProductName, COUNT(OrderDetails.OrderDetailId)

10. Создать представление, которое выводит информацию о всех пользователях и количестве их заказов в каждом месяце за последний год, используя рекурсивный запрос для объединения таблиц Users, Orders и OrderDetails.
- Таблицы: Users, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email, COUNT(OrderDetails.OrderDetailId), EXTRACT(YEAR_MONTH FROM Orders.OrderDate)

### Использование прав доступа для ограничения доступа к данным через view 

1. Создать представление, которое выводит информацию о всех пользователях и их именах (без фамилий), используя рекурсивный запрос для объединения таблиц Users и Addresses. Доступ к этому представлению должен быть ограничен только для пользователей с ролью "admin".
- Таблицы: Users, Addresses
- Столбцы: UserId, FirstName, Street

2. Создать представление, которое выводит информацию о всех продуктах и их ценах (без названий категорий), используя рекурсивный запрос для объединения таблиц Products и ProductCategories. Доступ к этому представлению должен быть ограничен только для пользователей с ролью "user".
- Таблицы: Products, ProductCategories
- Столбцы: ProductId, ProductName, Price

3. Создать представление, которое выводит информацию о всех заказах и дате заказов (без названий статусов), используя рекурсивный запрос для объединения таблиц Orders и OrderStatuses. Доступ к этому представлению должен быть ограничен только для пользователей с ролью "admin".
- Таблицы: Orders, OrderStatuses
- Столбцы: OrderId, UserId, OrderDate

4. Создать представление, которое выводит информацию о всех пользователях и их адресах (включая улицу, город, штат и почтовый индекс), используя рекурсивный запрос для объединения таблиц Users и Addresses. Доступ к этому представлению должен быть ограничен только для пользователей с ролью "user".
- Таблицы: Users, Addresses
- Столбцы: UserId, FirstName, LastName, Email, Street, City, State, ZipCode

5. Создать представление, которое выводит информацию о всех продуктах и категориях, к которым они относятся (включая название категории), используя рекурсивный запрос для объединения таблиц Products и ProductCategories. Доступ к этому представлению должен быть ограничен только для пользователей с ролью "user".
- Таблицы: Products, ProductCategories
- Столбцы: ProductId, ProductName, CategoryName

6. Создать представление, которое выводит информацию о всех заказах и статусах заказов (включая название статуса), используя рекурсивный запрос для объединения таблиц Orders и OrderStatuses. Доступ к этому представлению должен быть ограничен только для пользователей с ролью "admin".
- Таблицы: Orders, OrderStatuses
- Столбцы: OrderId, UserId, OrderDate, OrderStatusName

7. Создать представление, которое выводит информацию о всех пользователях и количестве их заказов (включая общее количество заказов), используя рекурсивный запрос для объединения таблиц Users, Orders и OrderDetails. Доступ к этому представлению должен быть ограничен только для пользователей с ролью "admin".
- Таблицы: Users, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email, COUNT(OrderDetails.OrderDetailId)

8. Создать представление, которое выводит информацию о всех продуктах и общем количестве заказов на каждый продукт, используя рекурсивный запрос для объединения таблиц Products и OrderDetails. Доступ к этому представлению должен быть ограничен только для пользователей с ролью "user".
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, Price, SUM(OrderDetails.Quantity)

9. Создать представление, которое выводит информацию о всех пользователях и суммарной стоимости их заказов (включая общую сумму), используя рекурсивный запрос для объединения таблиц Users, Orders и OrderDetails. Доступ к этому представлению должен быть ограничен только для пользователей с ролью "admin".
- Таблицы: Users, Orders, OrderDetails
- Столбцы: UserId, FirstName, LastName, Email, SUM(OrderDetails.Quantity * OrderDetails.Price)

10. Создать представление, которое выводит информацию о всех продуктах и средней цене на каждый продукт, используя рекурсивный запрос для объединения таблиц Products и OrderDetails. Доступ к этому представлению должен быть ограничен только для пользователей с ролью "user".
- Таблицы: Products, OrderDetails
- Столбцы: ProductId, ProductName, AVG(OrderDetails.Price)
