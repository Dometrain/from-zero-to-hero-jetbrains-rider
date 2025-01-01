RESTORE DATABASE [AdventureWorksLT2022]
FROM DISK = '/var/opt/mssql/data/AdventureWorksLT2022.bak'
WITH MOVE 'AdventureWorksLT2022_Data' TO '/var/opt/mssql/data/AdventureWorksLT2022.mdf',
MOVE 'AdventureWorksLT2022_Log' TO '/var/opt/mssql/data/AdventureWorksLT2022.ldf',
RECOVERY, REPLACE;
