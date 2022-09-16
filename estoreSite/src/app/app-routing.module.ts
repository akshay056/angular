import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CartComponent } from './cart/cart.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { HomeComponent } from './home/home.component';
import { OrdersComponent } from './orders/orders.component';
import { ProductsingleComponent } from './productsingle/productsingle.component';
import { ShopComponent } from './shop/shop.component';

const routes: Routes = [
  { path:"", component:HomeComponent },
  { path:"product-single", component:ProductsingleComponent },
  { path:"cart", component:CartComponent },
  
  { path:"checkout", component:CheckoutComponent },
  { path:"shop", component:ShopComponent },
  
  { path:"dashboard", component:DashboardComponent },
  
  { path:"order", component:OrdersComponent }
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
