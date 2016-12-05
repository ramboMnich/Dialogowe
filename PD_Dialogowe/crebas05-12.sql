/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     05.12.2016 17:03:04                          */
/*==============================================================*/


drop table if exists Board;

drop table if exists BonusType;

drop table if exists FieldType;

drop table if exists Game;

drop table if exists GameUser;

drop table if exists Unit;

drop table if exists UnitBonus;

drop table if exists UnitType;

drop table if exists User;

/*==============================================================*/
/* Table: Board                                                 */
/*==============================================================*/
create table Board
(
   IDBoard              int not null auto_increment,
   primary key (IDBoard)
);

/*==============================================================*/
/* Table: BonusType                                             */
/*==============================================================*/
create table BonusType
(
   IDBonusType          int not null auto_increment,
   Name                 text not null,
   primary key (IDBonusType)
);

/*==============================================================*/
/* Table: FieldType                                             */
/*==============================================================*/
create table FieldType
(
   IDFieldType          int not null auto_increment,
   Name                 text not null,
   primary key (IDFieldType)
);

/*==============================================================*/
/* Table: Game                                                  */
/*==============================================================*/
create table Game
(
   IDGame               int not null auto_increment,
   IDBoard              int not null,
   primary key (IDGame)
);

/*==============================================================*/
/* Table: GameUser                                              */
/*==============================================================*/
create table GameUser
(
   IDGame               int not null,
   IDUser               int not null,
   primary key (IDGame, IDUser)
);

/*==============================================================*/
/* Table: Unit                                                  */
/*==============================================================*/
create table Unit
(
   IDUnit               int not null auto_increment,
   IDUnitType           int not null,
   IDField              int,
   Range                smallint not null,
   Damage               smallint not null,
   primary key (IDUnit)
);

/*==============================================================*/
/* Table: UnitBonus                                             */
/*==============================================================*/
create table UnitBonus
(
   IDUnit               int not null,
   IDBonusType          int not null,
   primary key (IDUnit, IDBonusType)
);

/*==============================================================*/
/* Table: UnitType                                              */
/*==============================================================*/
create table UnitType
(
   IDUnitType           int not null auto_increment,
   Name                 text,
   primary key (IDUnitType)
);

/*==============================================================*/
/* Table: User                                                  */
/*==============================================================*/
create table User
(
   IDUser               int not null auto_increment,
   Login                text not null,
   Hash                 text not null,
   primary key (IDUser)
);

alter table Game add constraint FK_Relationship_5 foreign key (IDBoard)
      references Board (IDBoard) on delete restrict on update restrict;

alter table GameUser add constraint FK_Relationship_10 foreign key (IDUser)
      references User (IDUser) on delete restrict on update restrict;

alter table GameUser add constraint FK_Relationship_8 foreign key (IDGame)
      references Game (IDGame) on delete restrict on update restrict;

alter table Unit add constraint FK_Relationship_4 foreign key (IDUnitType)
      references UnitType (IDUnitType) on delete restrict on update restrict;

alter table UnitBonus add constraint FK_Relationship_3 foreign key (IDUnit)
      references Unit (IDUnit) on delete restrict on update restrict;

alter table UnitBonus add constraint FK_Relationship_6 foreign key (IDBonusType)
      references BonusType (IDBonusType) on delete restrict on update restrict;

