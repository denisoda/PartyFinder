import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'fruits',
  templateUrl: './fruits.component.html'
})

export class FruitsComponent {
  public fruits : IFruit[];

  constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
    http.get(baseUrl + 'api/Fruits').subscribe(result => {
      this.fruits = result.json() as IFruit[];
    });
  }
}

interface IFruit {
  name: string;
}