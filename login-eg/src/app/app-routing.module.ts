import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
 // {path:'', component: LoginComponent},
 // {path:'signup', component: SignupComponent},
 // {path: 'user', component: UserDashboardComponent},
 // {path: 'admin', component:AdminDashboardComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
