import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sign-up',
  templateUrl: './signup-up-page.component.html',
  styleUrls: ['./signup-up-page.component.css']
})

export class RegisterComponent implements OnInit {

  //User: any = ['Super Admin', 'Author', 'Reader'];
signupForm!:FormGroup
  constructor(private router:Router,private http:HttpClient,private formbuilder :FormBuilder) { }

  ngOnInit():void {
    this.signupForm=this.formbuilder.group({
    name:[''],
    email:[''],
    mobile:[''],
    password:['']
  })
  }
signUp(){
  this.http.post<any>("https://localhost:7056/api/Users",this.signupForm.value).subscribe(res=>{alert("rgistration successfully");
  this.signupForm.reset();
  this.router.navigate(['login'])},
  err=>{
    alert("invalid")
  })

}
}