create table facilites
(
   facility_num int constraint pkk primary key,
   facility_name varchar(10) ,
   facility_time time
   
   )

   select * from facilites;

   alter table facilites add  facility_cost varchar(10);


   insert into facilites values (100,'yoga','10:00:00','1000');
   insert into facilites values (200,'zumba','11:00:00','2000');
   insert into facilites values (300,'cardio','12:00:00','3000');
