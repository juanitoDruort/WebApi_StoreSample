import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CreateOrder } from '../models/createOrder.model';
import { SalesDatePrediction } from '../models/salesDatePrediction.model';
import { ClientsOrders } from '../models/clientsOrder.model';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  private urlBaseApi = `/api/Customer`;

  constructor(private htpp: HttpClient) {}

  getSalesDatePrediction() {
    return this.htpp.get<SalesDatePrediction[]>(`${this.urlBaseApi}/GetSalesDatePrediction`)
  }

}
