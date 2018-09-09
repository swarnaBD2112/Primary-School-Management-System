Select Student_Id , Class_name 
from tbl_student
Group by Class_name
having Gender = 'Female' ;