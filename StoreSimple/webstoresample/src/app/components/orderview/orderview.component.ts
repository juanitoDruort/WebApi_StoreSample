import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ClientsOrders } from 'src/app/models/clientsOrder.model';
import { OrderService } from 'src/app/services/order.service';

@Component({
  selector: 'app-orderview',
  templateUrl: './orderview.component.html',
  styleUrls: ['./orderview.component.sass']
})
export class OrderviewComponent implements OnInit {

  @Input() Custid:Number = 0;
  
  constructor(
    private Orderservice: OrderService,
    private liveAnnouncer: LiveAnnouncer
  ) {}

  displayedColumns: string[] = [
    'orderid',
    'requireddate',
    'shippeddate',
    'shipname',
    'shipaddress',
    'shipcity'
  ];
  clientsOrders: ClientsOrders[] = [];
  dataSource = new MatTableDataSource<ClientsOrders>(
    this.clientsOrders
  );
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort!: MatSort;

  ngOnInit(): void {
    this.Orderservice
      .getClientsOrdersByCustid(this.Custid)
      .subscribe((data) => {
        this.clientsOrders = data;
        this.dataSource = new MatTableDataSource<ClientsOrders>(
          this.clientsOrders
        );
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
      });
  }
  announceSortChange(sortState: Sort) {
    if (sortState.direction) {
      this.liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this.liveAnnouncer.announce('Sorting cleared');
    }
  }

}
