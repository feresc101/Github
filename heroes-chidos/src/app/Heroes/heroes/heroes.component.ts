import { Component, OnInit } from '@angular/core';
import { Heroe, HeroesChidosService } from 'src/app/Servicio/heroes-chidos.service';

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
  heroes: Array<Heroe>=[]
  constructor(private servicioHeroe : HeroesChidosService){
  this.heroes= this.servicioHeroe.getHeroes();
  }


  ngOnInit(): void {
  }

}
