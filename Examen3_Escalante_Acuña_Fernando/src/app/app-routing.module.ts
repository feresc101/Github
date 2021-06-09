import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AnadirComponent } from './component/anadir/anadir.component';
import { ListaComponent } from './component/lista/lista.component';

const routes: Routes = [
  {path:'lista',component:ListaComponent},
  {path:'anadir',component:AnadirComponent},
  {path:'**', pathMatch:'full',redirectTo:'lista'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }




