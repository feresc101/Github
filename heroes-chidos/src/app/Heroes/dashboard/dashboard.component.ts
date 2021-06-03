import { Component, OnInit } from '@angular/core';
import { Heroe, HeroesChidosService } from 'src/app/Servicio/heroes-chidos.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {


  heroes: Array<Heroe>=[]
  constructor(private servicioHeroe : HeroesChidosService){
  this.heroes= this.servicioHeroe.getHeroes();
  }

  ngOnInit(): void {
  }

}
