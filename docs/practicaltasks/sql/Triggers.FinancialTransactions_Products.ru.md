# Triggers.FinancialTransactions_Products

Задачи, направленные на закрепление практических навыков работы с триггерами.

Конфигурация таблиц для закрепления практических навыков работы с PostgreSQL представлена в файле [Config_FinancialTransactions_Products.sql](../../../sql/postgresql/Config_FinancialTransactions_Products.sql). 
Аналогичную конфигурацию и определение таблиц можно использовать для других реляционных баз данных. 

## Использование в БД для enterprise приложений

Триггеры в БД используются для автоматического выполнения определенных действий при изменении данных в таблице. 
Они позволяют управлять целостностью данных, контролировать доступ к данным и обеспечивать безопасность. 
Также триггеры могут использоваться для создания аудита изменений данных, для автоматической генерации отчетов и уведомлений.

## SQL 

Таблицы в БД определены следующим образом:

```SQL
CREATE TABLE Users (
    UserId SERIAL PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(50) UNIQUE,
    Password VARCHAR(50),
    ChangeDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
CREATE TABLE Addresses (
    AddressId SERIAL PRIMARY KEY,
    UserId INT REFERENCES Users(UserId),
    Street VARCHAR(50),
    City VARCHAR(50),
    State VARCHAR(50),
    ZipCode VARCHAR(10),
    ChangeDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
```

## Задачи

10 задач для улучшения навыков работы с триггерами:

1. Создание триггера, который будет автоматически обновлять дату последнего изменения записи при любом изменении данных в таблице.

Данный триггер должен быть написан на таблице Users и Addresses. 
Он должен срабатывать при любом изменении данных в таблице и обновлять поле ChangeDate на текущую дату и время.

2. Написание триггера, который будет запрещать удаление записей из таблицы, если они используются в других таблицах.

Данный триггер должен быть написан на таблице Users и Addresses. 
Он должен срабатывать перед удалением записи и проверять, используется ли данная запись в других таблицах. Если да, то удаление записи должно быть отменено.

3. Разработка триггера, который будет автоматически создавать резервную копию таблицы при каждом изменении данных.

Данный триггер должен быть написан на таблице Users и Addresses. 
Он должен срабатывать после каждого изменения данных и создавать резервную копию таблицы в отдельной таблице Backup с указанием времени изменения.

4. Создание триггера, который будет автоматически обновлять статистику по таблице при ее изменении.

Данный триггер должен быть написан на таблице Users и Addresses. 
Он должен срабатывать после каждого изменения данных и обновлять статистику по таблице в отдельной таблице Stats.

5. Написание триггера, который будет автоматически генерировать уведомление о новых записях в таблице.

Данный триггер должен быть написан на таблице Users и Addresses. 
Он должен срабатывать после каждого добавления новой записи и генерировать уведомление о новой записи в отдельную таблицу Notifications.

6. Разработка триггера, который будет автоматически изменять данные в другой таблице при изменении данных в текущей таблице.

Данный триггер должен быть написан на таблице Users и Addresses. 
Он должен срабатывать после каждого изменения данных и обновлять соответствующие данные в другой таблице, например, при изменении адреса в таблице Addresses, данные об этом адресе также должны быть изменены в таблице Orders.

7. Создание триггера, который будет автоматически генерировать уникальные идентификаторы для новых записей в таблице.

Данный триггер должен быть написан на таблице Users и Addresses. 
Он должен срабатывать перед добавлением новой записи и генерировать уникальный идентификатор для этой записи.

8. Написание триггера, который будет автоматически проверять корректность вводимых данных и выводить сообщение об ошибке при необходимости.

Данный триггер должен быть написан на таблице Users и Addresses. 
Он должен срабатывать перед добавлением или изменением данных и проверять корректность вводимых данных. Если данные некорректны, то триггер должен вывести сообщение об ошибке.

9. Разработка триггера, который будет автоматически обновлять связанные данные в других таблицах при изменении данных в текущей таблице.

Данный триггер должен быть написан на таблице Users и Addresses. 
Он должен срабатывать после каждого изменения данных и обновлять связанные данные в других таблицах, например, при изменении адреса в таблице Addresses, данные об этом адресе также должны быть изменены в таблице Orders.

10. Создание триггера, который будет автоматически запускать процедуру обработки данных при изменении данных в таблице.

Данный триггер должен быть написан на таблице Users и Addresses. 
Он должен срабатывать после каждого изменения данных и запускать процедуру обработки данных, например, при изменении адреса в таблице Addresses, процедура обработки может отправлять уведомление о новом адресе всем пользователям, которые используют этот адрес.