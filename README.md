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

If you're using C in golang, first you need to build you app (go to `go` folder and execute build command): 
```
go build -o bin/leetcode.exe main.go 
```
or simply: 
```
_build.cmd
```

## Troubleshooting 

### Go 

If you're facing problem with gcc compliler: `runtime/cgo: C:\Program Files\Go\pkg\tool\windows_amd64\cgo.exe: exit status 2`, you need to take the following steps: 
1. Install `TDM-GCC` compiler from [GitHub repo](https://github.com/jmeubank/tdm-gcc) (go to releases and download exe installer) or from [TDM-GCC site](https://jmeubank.github.io/tdm-gcc/download/). 

2. Open command line and execute: 
```
go env GOENV
```
This command returns you a path to env file. 

3. Open env file in any text editor. 

4. Execute in command line:
```
where gcc
```
Copy the path of `TDM-GCC` compiler. 

5. Set `CC` parameter in env file to the path of gcc. 

It's also possible to use [SWIG compiler](https://github.com/swig/swig) to compile C/C++ code in golang apps, but I haven't test it yet. 
