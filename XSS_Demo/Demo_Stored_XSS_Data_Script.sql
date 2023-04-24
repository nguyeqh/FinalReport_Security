create database Demo_Stored_XSS_Database;
use Demo_Stored_XSS_Database;

create table Comment(
  Id INTEGER NOT NULL Primary key,
  Username varchar(15) NOT NULL,
  CommentContent nvarchar(2500) NOT NULL
);

insert into Comment values(1,'User1',N'Đây là comment hợp lệ 1');
insert into Comment values(2,'User1',N'Đây là comment hợp lệ 2');
insert into Comment values(3,'User2',N'Đây là comment hợp lệ 3');

select * from Comment;
