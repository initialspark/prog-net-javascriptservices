import { Component } from '@angular/core';
import { Http } from "@angular/http";

@Component({
    selector: 'stock',
    templateUrl: './stock.component.html',
    styleUrls: ['./stock.component.css']
})
export class StockComponent {
    public beersStock: BeerStock[];

    constructor(http: Http) {
        http.get('http://localhost:5050/api/beers').subscribe(result => {
            this.beersStock = result.json() as BeerStock[];
        });
    }
}

interface BeerStock {
    title: string;
    description: string;
    abv: string;
    imagePath: string;
    isInStock: boolean;
}
