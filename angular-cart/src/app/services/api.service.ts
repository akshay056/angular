import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root',
})
export class ApiService {
  constructor(private http: HttpClient) {}
  getAllProducts() {
    return this.http.get(`https://localhost:7171/api/Products`);
  }
  addToCart(payload: any) {
    return this.http.post(`https://localhost:7242/api/Carts`, payload);
  }
  getCartItems() {
    return this.http.get(`https://localhost:7242/api/Carts`);
  }
  increaseQty(payload: any) {
    return this.http.post(`https://localhost:7242/api/Carts`, payload);
  }
  emptyCart() {
    return this.http.delete(`https://localhost:7242/api/Carts`);
  }
}