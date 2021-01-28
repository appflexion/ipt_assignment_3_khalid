Create database Hospital;
use Hospital;
create table equipments(
equip_id INT primary key identity(1,1),
equip_name varchar(50),
requested_date date,
date_defected date,
);
create table medicines(
med_id INT primary key identity(1,1),
med_name VARCHAR(64),
quantity INT,
available_Qty INT,
exp_date DATE,
requested_date DATE,
);
create table treatment(
treat_id int primary key identity(1,1),
treat_type varchar(64),
);
create table patients(
patient_id int primary key identity(1,1),
fname varchar(65),
lname varchar(65),
patient_type varchar(65),
age int,
addrs text,
);
create table check_up(
check_id int primary key identity(1,1),
patient_id int,
complains TEXT,
findings TEXT,
treat_id int,
med_id int,
quantity int,
check_date date,
);

ALTER TABLE check_up
ADD FOREIGN KEY (patient_id) REFERENCES patients(patient_id);

ALTER TABLE check_up
ADD FOREIGN KEY (treat_id) REFERENCES treatment(treat_id);

ALTER TABLE check_up
ADD FOREIGN KEY (med_id) REFERENCES medicines(med_id);

use hospital;
insert into equipments
values('BP apparatus','2020-12-1','2022-12-11')
select * from equipments;


insert into medicines
values('acyfil',80,78,'2023-02-19','2020-10-1')
select * from medicines;


insert into patients
values('sana','khan','Tumor',50,' XYZ home, ABC street')
select * from patients;

insert into treatment
values('Radiology')
select * from treatment;

insert into check_up
values(2,'headache, vomitings, sometime migrane attack, dizziness', 'ependymomas, which are usually benign', 2, 1, 6, '2021-1-1');
select * from check_up;


ALTER TABLE check_up ALTER COLUMN patient_id int NOT NULL;
ALTER TABLE check_up ALTER COLUMN med_id int NOT NULL;
ALTER TABLE check_up ALTER COLUMN treat_id int NOT NULL;

alter table check_up add constraint dt_date default getutcdate()  for check_date;

SELECT patients.fname,patients.lname, patients.patient_type, patients.age, check_up.complains, check_up.findings,treatment.treat_type, medicines.med_name, check_up.quantity, check_up.check_date
FROM patients
inner join  check_up ON patients.patient_id = check_up.patient_id
inner join  treatment ON treatment.treat_id= check_up.treat_id
inner join  medicines ON medicines.med_id=check_up.med_id;

