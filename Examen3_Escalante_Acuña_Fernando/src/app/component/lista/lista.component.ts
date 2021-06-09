import { Component, OnInit } from '@angular/core';
import { Dato, DatosService } from 'src/app/servicios/datos.service';

@Component({
  selector: 'app-lista',
  templateUrl: './lista.component.html',
  styleUrls: ['./lista.component.css']
})
export class ListaComponent implements OnInit {

  datos : Array<Dato> = []

  constructor(private servicioHeroes : DatosService) {
    this.datos = this.servicioHeroes.getDatos();
    console.log(this.datos)
   }

  ngOnInit(): void {
  }
}
