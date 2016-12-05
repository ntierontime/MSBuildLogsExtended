import { Component } from '@angular/core';
import { Hero } from './hero/hero';

@Component({
    selector: 'my-app-xyz-abc',
    template: `
  <h1>{{title}}</h1>
  <h2>My favorite hero is: {{myHero.name}}</h2>
  <p>Heroes:</p>
  <p *ngIf="heroes.length > 3">There are many heroes!</p>
  <ul>
    <li *ngFor="let hero of heroes">
      #{{ hero.id }}: {{ hero.name }}
    </li>
  </ul>
`
})
export class AppComponent  {
    title = 'Tour of Heroes';
    heroes = [
        new Hero(1, 'Windstorm'),
        new Hero(13, 'Bombasto'),
        new Hero(15, 'Magneta'),
        new Hero(20, 'Tornado')
    ];
    myHero = this.heroes[0];
}
//export class Hero {
//    id: number;
//    name: string;
//}
