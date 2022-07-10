import { Component, OnInit, ViewChild, Inject } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { SalesDatePrediction } from 'src/app/models/salesDatePrediction.model';
import { MatDialog } from '@angular/material/dialog';
import { DialogComponent } from '../dialog/dialog.component';
import { CustomerService } from 'src/app/services/customer.service';

@Component({
  selector: 'app-listclients',
  templateUrl: './listclients.component.html',
  styleUrls: ['./listclients.component.sass'],
})
export class ListclientsComponent implements OnInit {
  constructor(
    private customerService: CustomerService,
    private liveAnnouncer: LiveAnnouncer,
    public dialog: MatDialog
  ) { }
  displayedColumns: string[] = [
    'customername',
    'lastorderdate',
    'nextpredictedorder',
    'vieworders',
    'createorders'
  ];
  salesdateprediction: SalesDatePrediction[] = [];
  dataSource = new MatTableDataSource<SalesDatePrediction>(
    this.salesdateprediction
  );
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort!: MatSort;

  ngOnInit(): void {
    this.customerService
      .getSalesDatePrediction()
      .subscribe((data) => {
        this.salesdateprediction = data;
        this.dataSource = new MatTableDataSource<SalesDatePrediction>(
          this.salesdateprediction
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

  openDialog(id: Number, client: string, created: boolean): void {
    this.dialog.open(DialogComponent, {
      data: { id: id, client: client, created: created },
    });
  }
}