import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CreateOrder } from '../models/createOrder.model';
import { SalesDatePrediction } from '../models/salesDatePrediction.model';
import { ClientsOrders } from '../models/clientsOrder.model';
@Injectable({
  providedIn: 'root',
})
export class OrderService {
  private urlBaseApi = `/api/Order`;

  constructor(private htpp: HttpClient) {}

  createOrder(createOrder: CreateOrder) {
    return this.htpp.post<CreateOrder>(`${this.urlBaseApi}/Save`, createOrder);
  }
    
  getClientsOrdersByCustid(Custid:Number) {
    return this.htpp.get<ClientsOrders[]>(`${this.urlBaseApi}/GetClientsOrdersByCustid?Custid=${Custid}`)
  }

}
