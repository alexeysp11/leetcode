package rawsql; 

import (
	"fmt"
	"strings"
	"database/sql"
	_ "github.com/mattn/go-sqlite3"
)

type InvalidTweets struct {}

func (t *InvalidTweets) Execute() {
	fmt.Println(strings.ToUpper("Invalid Tweets\n"))

	database, err := sql.Open("sqlite3", "../data/sqlite3/InvalidTweets.db")
	if (err != nil) {
		fmt.Println(err)
	}

	statement, err := database.Prepare("insert into tweets (content) values (?);")
	if (err != nil) {
		fmt.Println(err)
	}
	statement.Exec("new test content")

	rows, _ := database.Query("select * from tweets;")
	var id int 
	var content string 
	for rows.Next() {
		rows.Scan(&id, &content)
		fmt.Println("%d. %s\n", id, content)
	}
}
