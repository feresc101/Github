import { Component } from '@angular/core';
import { PersonajeService } from '../servicios/personaje.service';

@Component({
  selector: 'app-cuerpo',
  templateUrl: './cuerpo.component.html'
})
export class CuerpoComponent {
  mostrar = true;

  informacion = {
    autor: 'Cristiano Ronaldo',
    frase: 'SIUUUUUUUU'
  };

  personajes = ['Chabelo', 'Babo', 'Goku'];

  constructor (private servicioPersonaje: PersonajeService) {  }  
}