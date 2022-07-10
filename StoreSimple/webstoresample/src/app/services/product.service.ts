import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CreateOrder } from '../models/createOrder.model';
import { Shipper } from '../models/shipper.model';
import { Product } from '../models/product.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private urlBaseApi = `/api/Product`;

  constructor(private htpp: HttpClient) {}

  getAllProdut() {
    return this.htpp.get<Product[]>(`${this.urlBaseApi}/GetAllProdut`);
  }
}
