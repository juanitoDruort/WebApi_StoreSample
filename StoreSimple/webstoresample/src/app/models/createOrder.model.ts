export interface CreateOrder {
  orderid: Number;
  custid: Number;
  empid: Number;
  shipperid: Number;
  shipname: string;
  shipaddress: string;
  shipcity: string;
  orderdate: Date;
  requireddate: Date;
  shippeddate: Date;
  freight: Number;
  shipcountry: string;
  productid: Number;
  unitprice: Number;
  qty: Number;
  discount: Number;
}
