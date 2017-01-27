/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     5/15/2016 4:17:38 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK') and o.name = 'FK_BOOK_BELONG_TO_CATEGORY')
alter table BOOK
   drop constraint FK_BOOK_BELONG_TO_CATEGORY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROW') and o.name = 'FK_BORROW_BORROW_MEMBER')
alter table BORROW
   drop constraint FK_BORROW_BORROW_MEMBER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROW') and o.name = 'FK_BORROW_BORROW2_BOOK')
alter table BORROW
   drop constraint FK_BORROW_BORROW2_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MOBILENUMBERS') and o.name = 'FK_MOBILENU_OWN_MEMBER')
alter table MOBILENUMBERS
   drop constraint FK_MOBILENU_OWN_MEMBER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"READ"') and o.name = 'FK_READ_READ_MEMBER')
alter table "READ"
   drop constraint FK_READ_READ_MEMBER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"READ"') and o.name = 'FK_READ_READ2_BOOK')
alter table "READ"
   drop constraint FK_READ_READ2_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('WRITE') and o.name = 'FK_WRITE_WRITE_BOOK')
alter table WRITE
   drop constraint FK_WRITE_WRITE_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('WRITE') and o.name = 'FK_WRITE_WRITE2_AUTHOR')
alter table WRITE
   drop constraint FK_WRITE_WRITE2_AUTHOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AUTHOR')
            and   type = 'U')
   drop table AUTHOR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK')
            and   name  = 'BELONG_TO_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK.BELONG_TO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOK')
            and   type = 'U')
   drop table BOOK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BORROW')
            and   name  = 'BORROW2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BORROW.BORROW2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BORROW')
            and   name  = 'BORROW_FK'
            and   indid > 0
            and   indid < 255)
   drop index BORROW.BORROW_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BORROW')
            and   type = 'U')
   drop table BORROW
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATEGORY')
            and   type = 'U')
   drop table CATEGORY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MEMBER')
            and   type = 'U')
   drop table MEMBER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MOBILENUMBERS')
            and   type = 'U')
   drop table MOBILENUMBERS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"READ"')
            and   name  = 'ASSOCIATION_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index "READ".ASSOCIATION_3_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"READ"')
            and   name  = 'ASSOCIATION_2_FK'
            and   indid > 0
            and   indid < 255)
   drop index "READ".ASSOCIATION_2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"READ"')
            and   type = 'U')
   drop table "READ"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('WRITE')
            and   name  = 'WRITES2_FK'
            and   indid > 0
            and   indid < 255)
   drop index WRITE.WRITES2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('WRITE')
            and   name  = 'WRITES_FK'
            and   indid > 0
            and   indid < 255)
   drop index WRITE.WRITES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('WRITE')
            and   type = 'U')
   drop table WRITE
go

/*==============================================================*/
/* Table: AUTHOR                                                */
/*==============================================================*/
create table AUTHOR (
   AUTHORNAME           varchar(20)          not null,
   BIOGRAPHY            varchar(200)         null,
   constraint PK_AUTHOR primary key nonclustered (AUTHORNAME)
)
go

/*==============================================================*/
/* Table: BOOK                                                  */
/*==============================================================*/
create table BOOK (
   BOOKID               int                  not null,
   CATEGORYID           int                  not null,
   BOOKNAME             varchar(20)          null,
   AVAILABLE            bit                  null,
   constraint PK_BOOK primary key nonclustered (BOOKID)
)
go

/*==============================================================*/
/* Index: BELONG_TO_FK                                          */
/*==============================================================*/
create index BELONG_TO_FK on BOOK (
CATEGORYID ASC
)
go

/*==============================================================*/
/* Table: BORROW                                                */
/*==============================================================*/
create table BORROW (
   MEMBERID             int                  not null,
   BOOKID               int                  not null,
   STARTDATE            varchar(15)          null,
   DUEDATE              varchar(15)          null,
   FINE                 int                  null,
   constraint PK_BORROW primary key (MEMBERID, BOOKID)
)
go

/*==============================================================*/
/* Index: BORROW_FK                                             */
/*==============================================================*/
create index BORROW_FK on BORROW (
MEMBERID ASC
)
go

/*==============================================================*/
/* Index: BORROW2_FK                                            */
/*==============================================================*/
create index BORROW2_FK on BORROW (
BOOKID ASC
)
go

/*==============================================================*/
/* Table: CATEGORY                                              */
/*==============================================================*/
create table CATEGORY (
   CATEGORYID           int                  not null,
   CATEGORYNAME         varchar(20)          null,
   constraint PK_CATEGORY primary key nonclustered (CATEGORYID)
)
go

/*==============================================================*/
/* Table: MEMBER                                                */
/*==============================================================*/
create table MEMBER (
   MEMBERID             int                  not null,
   SSN                  int                  null,
   FNAME                varchar(20)          null,
   LNAME                varchar(20)          null,
   MNAME                varchar(20)          null,
   GENDER               varchar(1)           null,
   PROFESSION           varchar(20)          null,
   ADDRESS              varchar(30)          null,
   E_MAIL               varchar(30)          null,
   constraint PK_MEMBER primary key nonclustered (MEMBERID)
)
go

/*==============================================================*/
/* Table: MOBILENUMBERS                                         */
/*==============================================================*/
create table MOBILENUMBERS (
   MEMBERID             int                  not null,
   MOBILENUMBER         varchar(12)          not null,
   constraint PK_MOBILENUMBERS primary key (MEMBERID)
)
go

/*==============================================================*/
/* Table: "READ"                                                */
/*==============================================================*/
create table "READ" (
   MEMBERID             int                  not null,
   BOOKID               int                  not null,
   DATE                 varchar(15)          null,
   constraint PK_READ primary key (MEMBERID, BOOKID)
)
go

/*==============================================================*/
/* Index: ASSOCIATION_2_FK                                      */
/*==============================================================*/
create index ASSOCIATION_2_FK on "READ" (
MEMBERID ASC
)
go

/*==============================================================*/
/* Index: ASSOCIATION_3_FK                                      */
/*==============================================================*/
create index ASSOCIATION_3_FK on "READ" (
BOOKID ASC
)
go

/*==============================================================*/
/* Table: WRITE                                                 */
/*==============================================================*/
create table WRITE (
   BOOKID               int                  not null,
   AUTHORNAME           varchar(20)          not null,
   constraint PK_WRITE primary key (BOOKID, AUTHORNAME)
)
go

/*==============================================================*/
/* Index: WRITES_FK                                             */
/*==============================================================*/
create index WRITES_FK on WRITE (
BOOKID ASC
)
go

/*==============================================================*/
/* Index: WRITES2_FK                                            */
/*==============================================================*/
create index WRITES2_FK on WRITE (
AUTHORNAME ASC
)
go

alter table BOOK
   add constraint FK_BOOK_BELONG_TO_CATEGORY foreign key (CATEGORYID)
      references CATEGORY (CATEGORYID)
go

alter table BORROW
   add constraint FK_BORROW_BORROW_MEMBER foreign key (MEMBERID)
      references MEMBER (MEMBERID)
go

alter table BORROW
   add constraint FK_BORROW_BORROW2_BOOK foreign key (BOOKID)
      references BOOK (BOOKID)
go

alter table MOBILENUMBERS
   add constraint FK_MOBILENU_OWN_MEMBER foreign key (MEMBERID)
      references MEMBER (MEMBERID)
go

alter table "READ"
   add constraint FK_READ_READ_MEMBER foreign key (MEMBERID)
      references MEMBER (MEMBERID)
go

alter table "READ"
   add constraint FK_READ_READ2_BOOK foreign key (BOOKID)
      references BOOK (BOOKID)
go

alter table WRITE
   add constraint FK_WRITE_WRITE_BOOK foreign key (BOOKID)
      references BOOK (BOOKID)
go

alter table WRITE
   add constraint FK_WRITE_WRITE2_AUTHOR foreign key (AUTHORNAME)
      references AUTHOR (AUTHORNAME)
go

