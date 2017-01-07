/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     18.12.2016 22:55:10                          */
/*==============================================================*/


drop table if exists Board;

drop table if exists Field;

drop table if exists FieldType;

drop table if exists Game;

drop table if exists Unit;

drop table if exists UnitType;

drop table if exists User;

/*==============================================================*/
/* Table: Board                                                 */
/*==============================================================*/
create table Board
(
   IDBoard              smallint not null auto_increment,
   IDGame               smallint,
   primary key (IDBoard)
);

/*==============================================================*/
/* Table: Field                                                 */
/*==============================================================*/
create table Field
(
   IDField              smallint not null auto_increment,
   IDBoard              smallint,
   IDFieldType          smallint not null,
   IDUnit               smallint,
   X                    tinyint not null,
   Y                    tinyint not null,
   primary key (IDField)
);

/*==============================================================*/
/* Table: FieldType                                             */
/*==============================================================*/
create table FieldType
(
   IDFieldType          smallint not null auto_increment,
   Name                 text not null,
   primary key (IDFieldType)
);

/*==============================================================*/
/* Table: Game                                                  */
/*==============================================================*/
create table Game
(
   IDGame               smallint not null auto_increment,
   primary key (IDGame)
);

/*==============================================================*/
/* Table: Unit                                                  */
/*==============================================================*/
create table Unit
(
   IDUnit               smallint not null auto_increment,
   IDUnitType           smallint not null,
   IDUser               smallint,
   primary key (IDUnit)
);

/*==============================================================*/
/* Table: UnitType                                              */
/*==============================================================*/
create table UnitType
(
   IDUnitType           smallint not null auto_increment,
   Name                 text not null,
   Stamina              smallint not null,
   Damage               smallint not null,
   Move                 smallint not null,
   primary key (IDUnitType)
);

/*==============================================================*/
/* Table: User                                                  */
/*==============================================================*/
create table User
(
   IDUser               smallint not null auto_increment,
   IDGame               smallint,
   Login                text not null,
   Hash                 text not null,
   primary key (IDUser)
);

alter table Board add constraint FK_Relationship_8 foreign key (IDGame)
      references Game (IDGame) on delete restrict on update restrict;

alter table Field add constraint FK_Relationship_3 foreign key (IDBoard)
      references Board (IDBoard) on delete restrict on update restrict;

alter table Field add constraint FK_Relationship_5 foreign key (IDFieldType)
      references FieldType (IDFieldType) on delete restrict on update restrict;

alter table Field add constraint FK_Relationship_9 foreign key (IDUnit)
      references Unit (IDUnit) on delete restrict on update restrict;

alter table Unit add constraint FK_Relationship_6 foreign key (IDUnitType)
      references UnitType (IDUnitType) on delete restrict on update restrict;

alter table Unit add constraint FK_Relationship_7 foreign key (IDUser)
      references User (IDUser) on delete restrict on update restrict;

alter table User add constraint FK_Relationship_10 foreign key (IDGame)
      references Game (IDGame) on delete restrict on update restrict;

