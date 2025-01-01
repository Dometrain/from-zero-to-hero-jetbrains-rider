docker build -t sql-server-with-adventure-works .
docker run -it -p 1433:1433 sql-server-with-adventure-works
