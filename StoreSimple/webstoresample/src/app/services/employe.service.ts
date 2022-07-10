import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { CreateOrder } from '../models/createOrder.model';
import { Employe } from '../models/employe.model';

@Injectable({
  providedIn: 'root'
})
export class EmployeService {

  private urlBaseApi = `/api/Employe`;

  constructor(private htpp: HttpClient) {}

  getAllEmploye() {
    return this.htpp.get<Employe[]>(`${this.urlBaseApi}/GetAllEmploye`);
  }
}
