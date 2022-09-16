import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginPageComponent } from './components/login-page/login-page.component';
import { RegisterComponent } from './components/signup-up-page/signup-up-page.component';

const routes: Routes = [
  {path:'', redirectTo:'login',pathMatch:'full'},
    {path:'login', component:LoginPageComponent},
    {path:'signUp', component:RegisterComponent}
  ];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
