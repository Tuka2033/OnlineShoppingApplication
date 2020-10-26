import { ProductDataService } from '../product-data.service';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  products: Observable<any>;
  constructor(private productDataService: ProductDataService) { }

  ngOnInit(): void {
    alert("X");
    this.products = this.productDataService.getAllProducts();
  }

}
