import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import {
  FormControl,
  FormGroup,
  FormGroupDirective,
  NgForm,
  Validators,
  ReactiveFormsModule,
} from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';
import { CreateOrder } from 'src/app/models/createOrder.model';
import { Employe } from 'src/app/models/employe.model';
import { Product } from 'src/app/models/product.model';
import { Shipper } from 'src/app/models/shipper.model';
import { EmployeService } from 'src/app/services/employe.service';
import { OrderService } from 'src/app/services/order.service';
import { ProductService } from 'src/app/services/product.service';
import { ShipperService } from 'src/app/services/shipper.service';

@Component({
  selector: 'app-createorder',
  templateUrl: './createorder.component.html',
  styleUrls: ['./createorder.component.sass'],
})
export class CreateorderComponent implements OnInit {
  @Input() Custid: Number = 0;
  @Output() CloseDialog =  new EventEmitter();
  constructor(
    private orderService: OrderService,
    private employeService: EmployeService,
    private shipperService:ShipperService,
    private productService :ProductService
  ) {}
  oderFrmComponent!: FormGroup;
  createOrder: CreateOrder = {
    orderid: 0,
    custid: 0,
    empid: 0,
    shipperid: 0,
    shipname: '',
    shipaddress: '',
    shipcity: '',
    orderdate: new Date(),
    requireddate: new Date(),
    shippeddate: new Date(),
    freight: 0,
    shipcountry: '',
    productid: 0,
    unitprice: 0,
    qty: 0,
    discount: 0,
  };

  employes: Employe[] = [];
  shippers:Shipper[]=[];
  products:Product[]=[];
  ngOnInit(): void {
    this.createOrder.custid = this.Custid;
    this.employeService.getAllEmploye().subscribe(data=>{this.employes = data});
    this.shipperService.getAllShipper().subscribe(data=>{this.shippers = data});
    this.productService.getAllProdut().subscribe(data=>{this.products = data});
    this.oderFrmComponent = new FormGroup({
      empid: new FormControl(''),
      shipperid: new FormControl(''),
      shipname: new FormControl('',[Validators.required]),
      shipaddress: new FormControl('',[Validators.required]),
      shipcity: new FormControl('',[Validators.required]),      
      orderdate: new FormControl('',[Validators.required]),
      requireddate: new FormControl('',[Validators.required]),
      shippeddate: new FormControl('',[Validators.required]),
      freight: new FormControl(''),
      shipcountry: new FormControl('',[Validators.required]),
      productid: new FormControl('',),
      unitprice: new FormControl(''),
      qty: new FormControl(''),
      discount: new FormControl(''),
    });
  }
  submit() {
    this.orderService.createOrder(this.createOrder).subscribe((data) => {
      this.CloseDialog.emit(true);
    });
  }
}



