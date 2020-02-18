--create table Breed (
--	ID integer primary key identity,
--	BreedName Nvarchar(50)
--);

--create table Owners (
--	ID integer primary key identity,
--	OwnerName Nvarchar(50),
--	Adress Nvarchar(50),
--	PhoneNumber Nvarchar(50)
--);

--create table Dog (
--	ID integer primary key identity,
--	IDBreed integer not null,
--	DogName Nvarchar(50) not null,
--	Color Nvarchar(50) not null,
--	Gender Nvarchar(50) not null,
--	Height float,
--	DateBorn date,
--	IDMother integer,
--	IDFather integer
--);

--create table OwnerDog (
--	IDDog integer primary key,
--	IDOwner integer
--);

--alter table Dog
--add constraint FK_IDBreed
--foreign key (IDBreed)
--references Breed(ID); 

--alter table Dog
--add constraint FK_IDMother
--foreign key (IDMother)
--references Dog(ID);

--alter table Dog
--add constraint FK_IDFather
--foreign key (IDFather)
--references Dog(ID);

--alter table OwnerDog
--add constraint FK_IDDog
--foreign key (IDDog)
--references Dog(ID);

--alter table OwnerDog
--add constraint FK_IDOwner
--foreign key (IDOwner)
--references Owners(ID);

--insert into Breed
--values ('Мопс');

--insert into Breed
--values ('Грейхаунд');

--insert into Breed
--values ('Пудель');

--insert into Breed
--values ('Немецкая овчарка');

--insert into Breed
--values ('Английский мастиф');

--insert into Breed
--values ('Ротвелер');

--insert into Breed
--values ('Такса');

--insert into Breed
--values ('Бультерьер');

--insert into Breed
--values ('Английский бульдог');

--insert into Breed
--values ('Динго');

--insert into Owners 
--values ('Шабалов Владимир','Иванова 30/1','89134555898');

--insert into Owners 
--values ('Иванец Сергей','Шлюзовая 12','89137911223');

--insert into Owners 
--values ('Коновалов Александр','Ленина 29/1','89831347768');

--insert into Owners 
--values ('Махно Данила','Молодежная 33','89133457887');

--insert into Owners 
--values ('Смолев Владислав','Полевая 7','89137891232');

--insert into Owners 
--values ('Петров Антон','Мороской проспект 19','89833696366');

--insert into Owners 
--values ('Кондратьев Антон','Золотодолинская 19','89132356233');

--insert into Owners 
--values ('Рапута Татьяна','Сиреневая 9','89136663399');

--insert into Owners 
--values ('Доценко Анжелика','Шлюзовая 1','89137894565');

--insert into Owners 
--values ('Кузнецов Михаил','Экваторная 13','89835284316');

--insert into Dog
--values ('3','Микрочелик','Рыжий','Мужской','23','12.03.2013','8','16');

--insert into Dog
--values ('4','Фуцен','Белый','Мужской','21','02.03.2012','16','17');

--insert into Dog
--values ('5','Грэтта','Черный','Женский','40','03.05.2010','8','19');

--insert into Dog
--values ('6','Лола','Белый','Женский','23','05.12.2016','19','20');

--insert into Dog
--values ('7','Догер','Рыжий','Мужской','50','12.10.2006','20','21');

--insert into Dog
--values ('8','Боня','Черный','Женский','19','16.10.14','21','22');

--insert into Dog
--values ('9','Чара','Коричневый','Женский','25','12.12.2012','22','24');

--insert into Dog
--values ('10','Эмми','Черный','Мужской','56','13.12.2013','24','25');

--insert into Dog
--values ('1','Саша','Коричневый','Женский','20','20.12.2000','25','26');

--insert into Dog
--values ('2','Мурик','Белый','Мужской','23','20.10.2014','26','27');

--update Dog
--set IDMother=20
--where ID=8;

--update Dog
--set IDMother=19
--where ID=16;

--update Dog
--set IDFather=24
--where ID=8;

--update Dog
--set IDFather=25
--where ID=16;

--insert into OwnerDog
--values ('8','1');

--insert into OwnerDog
--values ('16','2');

--insert into OwnerDog
--values ('17','3');

--insert into OwnerDog
--values ('19','4');

--insert into OwnerDog
--values ('20','5');

--insert into OwnerDog
--values ('21','6');

--insert into OwnerDog
--values ('22','7');

--insert into OwnerDog
--values ('24','8');

--insert into OwnerDog
--values ('25','9');

--insert into OwnerDog
--values ('26','10');

--insert into OwnerDog
--values ('27','1');

--insert into OwnerDog
--values ('28','2');




