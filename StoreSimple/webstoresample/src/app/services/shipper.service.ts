import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CreateOrder } from '../models/createOrder.model';
import { Shipper } from '../models/shipper.model';

@Injectable({
  providedIn: 'root'
})
export class ShipperService {

  private urlBaseApi = `/api/Shipper`;

  constructor(private htpp: HttpClient) {}

  getAllShipper() {
    return this.htpp.get<Shipper[]>(`${this.urlBaseApi}/GetAllShipper`);
  }
}
