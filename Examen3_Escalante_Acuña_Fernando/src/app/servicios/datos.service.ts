import { Injectable } from '@angular/core';

export interface Dato {
  nombre : string,
  apellidos: string,
  genero: string,
  descripcion: string,
  id: string,
}

@Injectable({
  providedIn: 'root'
})
export class DatosService {

  private datos : Array<Dato>  = [
    
      

       
        { id: '11', nombre: 'Fernando', apellidos: 'Ureña Gómez', genero:  'hombre', descripcion: 'Instructor' }, 
        { id: '12', nombre: 'María', apellidos: 'Pérez Almendro', genero:  'mujer', descripcion: 'Amiga de la infancia' }, 
        { id: '13', nombre: 'Federico', apellidos: 'Caballero Sánchez', genero: 'hombre', descripcion: 'Compañero de trabajo' } ]
    
  ;

  public getDatos  = () : Array<Dato> => {
    return this.datos;
  }

  constructor() { }
}
