import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Dato, DatosService } from 'src/app/servicios/datos.service';

@Component({
  selector: 'app-anadir',
  templateUrl: './anadir.component.html',
  styleUrls: ['./anadir.component.css']
})
export class AnadirComponent implements OnInit {

  formulario: FormGroup;

  constructor( private fb: FormBuilder ) {
    this.crearFormulario();
   }

  
  ngOnInit(): void {
  }

  crearFormulario(){
    this.formulario= this.fb.group({
      nombre:[''],
      apellido:[''],
      descripcion: [''],
      sexo: [''],
      empresa: [''],
      celular: [''],
      correo:[''],
    });
  }

  

  guardar(){
    
    console.log(this.formulario.value);
  };

}
