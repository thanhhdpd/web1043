class Student{
    constructor(id, first_name, lats_name, class_id, email, phone_number, dob){
        this.id = id,
        this.first_name = first_name,
        this.lats_name = lats_name,
        this.class_id = class_id,
        this.email = email,
        this.phone_number = phone_number,
        this.dob = dob
    };
    GetFullName(){
        return this.first_name + " " +this.lats_name;
    };
    getAge(){
        const date = new Date();
        var birthday = new Date(this.dob)
        var ageYear = date.getFullYear() - birthday.getFullYear();    
        var ageMonth = date.getMonth()+1 - birthday.getMonth()+1;  
        var ageDay = date.getDate() - birthday.getDate();         
        if(ageDay <= 0 ){ 
            ageMonth --;                
            ageDay = Math.abs(ageDay); 
        }
        if(ageMonth<0){    
            ageYear --;     
            ageMonth +=12; 
        }
        return ageYear + " Tuổi " + (ageMonth*30 + ageDay )+ " Ngày" ;  
    }  
    FullDay(){
        const date = new Date();
        var birthday = new Date(this.dob)
        var ageYear = date.getFullYear() - birthday.getFullYear();    
        var ageMonth = date.getMonth()+1 - birthday.getMonth()+1; 
        var ageDay = date.getDate() - birthday.getDate();         
        if(ageDay <= 0 ){ 
            ageMonth --;                
            ageDay = Math.abs(ageDay);  
        }
        if(ageMonth<0){    
            ageYear --;     
            ageMonth +=12;  
        }
        var ngay = 0;
        for (let index = birthday.getFullYear() ; index < date.getFullYear(); index++) {
            if(((index % 4 == 0) && (index % 100 != 0)) || (index % 400 == 0)){
                ngay += 366;
            }else( ngay+= 365)
        }
        return ngay+ageMonth*30 + ageDay;
    }
}
var sinhVien = [
    SV = new Student("PD01", "Hoang","Thành", "IT18301", "thanh140523@gmail.com", 0857075999, "04/10/2003"),
    SV1 = new Student("PD02", "Hoang", "Thành", "IT18301", "thanh140523@gmail.com", 0857075999, "10/12/2004"),
    SV2 = new Student("PD03", "Hoang", "Thành", "IT18301", "thanh140523@gmail.com", 0857075999, "04/24/1940"),
    SV1 = new Student("PD04", "Hoang", "Thành", "IT18301", "thanh140523@gmail.com", 0857075999, "08/04/2004"),
    SV2 = new Student("PD05", "Hoang", "Thành", "IT18301", "than140523h@gmail.com", 0857075999, "10/30/1980")
]
var dayAgeSV=[]
for (let index = 0; index < sinhVien.length; index++) {
    console.log(sinhVien[index].id + "\n" + sinhVien[index].GetFullName() + "\n" + sinhVien[index].getAge());
    dayAgeSV[index]=sinhVien[index].FullDay(); 


for(var i = 0; i < dayAgeSV.length; i++){
    for(let j = i; j < dayAgeSV.length; j++){
        if(dayAgeSV[i]>dayAgeSV[j]){ 
           
            let doi;                
	        doi = dayAgeSV[i];
	        dayAgeSV[i]=dayAgeSV[j];
	        dayAgeSV[j]=doi;
           
            let doi1;
            doi1 = sinhVien[i];
            sinhVien[i]=sinhVien[j];
            sinhVien[j]=doi1;
        }
    }
}

for (let index = 0; index < dayAgeSV.length; index++) {
    console.log(dayAgeSV[index]);
    console.log(sinhVien[index]);
}
console.log(`Chiều rộng màn hình = ${screen.availWidth} \nChiều cao màn hình = ${screen.availHeight}`);

}
