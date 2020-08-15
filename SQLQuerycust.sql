create table customer
(
   customer_id int constraint pk2 primary key,
   customer_name varchar(10),
   customer_phno varchar(10),
   )
   select * from customer
   alter table customer add password varchar (10)
   select * from facility1
create table custfaci
( customer_id int,
  facility_no int,
  constraint spk primary key(customer_id,facility_no),
  constraint fk2 foreign key (customer_id) references customer (customer_id),
  constraint fk3 foreign key (facility_no) references facility1 (facility_no)
  )

  select * from custfaci
  select * from facility1
  
  insert into facility1 values(400,'weights','10:00:00',4000)
  insert into facility1 values(500,'boxing','10:00:00',2000)
  
  create view custdetailss
    as
     select c.customer_id , c.customer_name , f.facility_name , f.facility_time,f.facility_cost
	 from customer c ,facility1 f , custfaci cf
	 where c.customer_id=cf.customer_id and cf.facility_no=f.facility_no

	 select * from custdetailss


	 create procedure payment_det @cust_id int
	 as
	 begin
	 select c.customer_id,c.customer_name,sum(f.facility_cost)as sum
	  from customer c ,facility1 f , custfaci cf
	 where c.customer_id=cf.customer_id and cf.facility_no=f.facility_no and c.customer_id=@cust_id
	 group by c.customer_id,c.customer_name
	 end;
	 


	 alter table facility1 alter column facility_cost int;