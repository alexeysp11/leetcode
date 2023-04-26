# leetcode 

This repository contains solutions for **leetcode** problems in C#, Go, Python, JS and plain SQL. 

## External libraries 

### SQLite

In order to work with SQLite databases, run the following command in CMD: 
```
_getsqlite3.cmd
```

This command allows you to download sqlite3 source files, compile them, and create `data/sqlite3` folder where SQLite databases will be stored. 

In order to run SQLite shell, type: 
```
_runsqlite3.cmd
```

Then you need use ".open FILENAME" to open on a persistent database. For example: 
```
.open data/sqlite3/EmployeeUniqueId.db
```

## TODO 

1. Troubleshoot database connections in Go (the problem with gcc compliler). There're a few possible solution here: 
- to use another gcc compiler (I tried to use **mingw32** and **mingw64**); 
- write code for communication with the databases in another language (e.g. C/C++, C# or Python might be an option). 
