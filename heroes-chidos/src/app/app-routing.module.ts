import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './Heroes/dashboard/dashboard.component';
import { HeroesComponent } from './Heroes/heroes/heroes.component';

const routes: Routes = [
  {path: 'heroes', component:HeroesComponent},
  {path: 'dashboard', component:DashboardComponent},
  {path: '**', pathMatch: 'full', redirectTo: 'home'}

];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

