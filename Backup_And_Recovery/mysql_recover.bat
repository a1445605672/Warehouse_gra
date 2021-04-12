net stop mysql57 
xcopy "D:\db_backup\20210404220840\*.*" "D:\DataBase\MySQL Server 5.7\Data\warehouse\"
net start mysql57