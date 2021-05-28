import { Component, OnInit } from '@angular/core';
import { GuardsCheckStart } from '@angular/router';
import{NgForm} from '@angular/forms';
@Component({
  selector: 'app-template',
  templateUrl: './template.component.html',
  styleUrls: ['./template.component.css']
})
export class TemplateComponent implements OnInit {

  info = {
    nombre:'Fernando',
    apellido: 'Escalante',
    correo: 'FerEsc101@outlook.com'
  };

  constructor() { }

  ngOnInit(): void {
    
  }

  guardar(formulario){
    console.log(formulario.form.value);
  }

}
