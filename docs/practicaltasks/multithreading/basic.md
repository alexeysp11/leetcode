# basic

Для понимания работы класса MarshalByRefObject можно решать практические задачи по созданию распределенных приложений или приложений, которые работают в разных доменах приложений. Для понимания работы WaitHandle и EventWaitHandle можно решать задачи по синхронизации потоков и ожиданию событий.

Общие задачи:

- &check; Написать приложение, которое будет конкурентно/параллельно печатать что-то на экран (без разделяемых данных).
- &check; Написать приложение, которое будет обрабатывать клиентские соединения (без разделяемых данных)
- &cross; Написать приложение, которое будет параллельно работать с какой-нибудь структурой данных.
- &cross; Написать приложение, которое будет ограничивать количество одноременных соединений для сервера. 
- &cross; Написать приложение под кодовым названием consumer-producer, его ещё называют reader-writer.

Задачи для понимания разницы между потоками и асинхронными функциями: 

- &cross; Создание программы, которая выполняет несколько задач параллельно с помощью потоков и сравнение ее производительности с программой, которая использует асинхронные функции. 
- &cross; Реализация программы, которая выполняет несколько задач последовательно с помощью асинхронных функций и сравнение ее производительности с программой, которая использует потоки. 
- &cross; Создание программы, которая выполняет задачу, используя оба подхода, и сравнение их производительности и эффективности.
- &cross; Разработка программы, которая использует потоки для выполнения задачи в фоновом режиме, в то время как пользователь может продолжать работу с программой, и асинхронные функции для обновления пользовательского интерфейса.
- &cross; Создание программы, которая использует асинхронные функции для загрузки данных из Интернета и потоки для их обработки и анализа.
- &cross; Разработка программы, которая использует потоки для выполнения вычислительно сложных задач и асинхронные функции для работы с пользовательским интерфейсом.
- &cross; Создание приложения, которое загружает данные из Интернета и использует потоки для их обработки и анализа, а также асинхронные функции для отображения результатов на экране.
- &cross; Разработка программы, которая использует асинхронные функции для загрузки данных из базы данных и потоки для их обработки и сохранения.
- &cross; Создание приложения, которое использует потоки для выполнения задач в фоновом режиме, например, отправки электронной почты или создания резервной копии, а также асинхронные функции для отображения прогресса и результатов на экране.
- &cross; Разработка программы, которая использует потоки для выполнения задач в реальном времени, например, обработки видео или аудио, а также асинхронные функции для работы с пользовательским интерфейсом.

Задачи для понимания работы WaitHandle:

1. &cross; Создайте приложение, которое запускает два потока и использует WaitHandle для синхронизации их работы.
2. &cross; Напишите код, который использует WaitHandle для ожидания завершения выполнения метода в другом потоке.
3. &cross; Создайте приложение, которое использует WaitHandle для синхронизации доступа к разделяемому ресурсу.
4. &cross; Напишите код, который использует WaitHandle для ожидания наступления определенного события в другом потоке.
5. &cross; Создайте приложение, которое использует WaitHandle для управления работой нескольких потоков в зависимости от состояния разделяемого ресурса.
6. &cross; Напишите код, который использует WaitHandle для ожидания наступления определенного времени или события.
7. &cross; Создайте приложение, которое использует WaitHandle для ожидания завершения выполнения нескольких задач в разных потоках.
8. &cross; Напишите код, который использует WaitHandle для ожидания наступления нескольких событий в разных потоках.
9. &cross; Создайте приложение, которое использует WaitHandle для синхронизации работы нескольких потоков над одним и тем же набором данных.
10. &cross; Напишите код, который использует WaitHandle для ожидания наступления нескольких событий в определенном порядке.

Задачи для понимания работы EventWaitHandle:

1. &cross; Создайте приложение, которое использует EventWaitHandle для ожидания наступления определенного события в другом потоке.
2. &cross; Напишите код, который использует EventWaitHandle для ожидания наступления нескольких событий в разных потоках.
3. &cross; Создайте приложение, которое использует EventWaitHandle для управления работой нескольких потоков в зависимости от состояния разделяемого ресурса.
4. &cross; Напишите код, который использует EventWaitHandle для ожидания наступления определенного времени или события.
5. &cross; Создайте приложение, которое использует EventWaitHandle для синхронизации работы нескольких потоков над одним и тем же набором данных.
6. &cross; Напишите код, который использует EventWaitHandle для ожидания наступления нескольких событий в определенном порядке.
7. &cross; Создайте приложение, которое использует EventWaitHandle для синхронизации доступа к разделяемому ресурсу.
8. &cross; Напишите код, который использует EventWaitHandle для ожидания завершения выполнения метода в другом потоке.
9. &cross; Создайте приложение, которое использует EventWaitHandle для ожидания завершения выполнения нескольких задач в разных потоках.
10. &cross; Напишите код, который использует EventWaitHandle для ожидания наступления определенного количества событий в разных потоках.

Задачи для понимания работы AutoResetEvent:

1. &cross; Создайте приложение, которое использует AutoResetEvent для ожидания наступления определенного события в другом потоке.
2. &cross; Напишите код, который использует AutoResetEvent для ожидания наступления нескольких событий в разных потоках.
3. &cross; Создайте приложение, которое использует AutoResetEvent для управления работой нескольких потоков в зависимости от состояния разделяемого ресурса.
4. &cross; Напишите код, который использует AutoResetEvent для ожидания наступления определенного времени или события.
5. &cross; Создайте приложение, которое использует AutoResetEvent для синхронизации работы нескольких потоков над одним и тем же набором данных.
6. &cross; Напишите код, который использует AutoResetEvent для ожидания наступления нескольких событий в определенном порядке.
7. &cross; Создайте приложение, которое использует AutoResetEvent для синхронизации доступа к разделяемому ресурсу.
8. &cross; Напишите код, который использует AutoResetEvent для ожидания завершения выполнения метода в другом потоке.
9. &cross; Создайте приложение, которое использует AutoResetEvent для ожидания завершения выполнения нескольких задач в разных потоках.
10. &cross; Напишите код, который использует AutoResetEvent для ожидания наступления определенного количества событий в разных потоках.

Задачи для понимания работы ManualResetEvent:

1. &cross; Создайте приложение, которое использует ManualResetEvent для ожидания наступления определенного события в другом потоке.
2. &cross; Напишите код, который использует ManualResetEvent для ожидания наступления нескольких событий в разных потоках.
3. &cross; Создайте приложение, которое использует ManualResetEvent для управления работой нескольких потоков в зависимости от состояния разделяемого ресурса.
4. &cross; Напишите код, который использует ManualResetEvent для ожидания наступления определенного времени или события.
5. &cross; Создайте приложение, которое использует ManualResetEvent для синхронизации работы нескольких потоков над одним и тем же набором данных.
6. &cross; Напишите код, который использует ManualResetEvent для ожидания наступления нескольких событий в определенном порядке.
7. &cross; Создайте приложение, которое использует ManualResetEvent для синхронизации доступа к разделяемому ресурсу.
8. &cross; Напишите код, который использует ManualResetEvent для ожидания завершения выполнения метода в другом потоке.
9. &cross; Создайте приложение, которое использует ManualResetEvent для ожидания завершения выполнения нескольких задач в разных потоках.
10. &cross; Напишите код, который использует ManualResetEvent для ожидания наступления определенного количества событий в разных потоках.