import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import {AboutComponent} from 'src/app/components/about/about.component';
import {BuscadorComponent} from 'src/app/components/buscador/buscador.component';
import{HeroeComponent} from 'src/app/components/heroe/heroe.component';
import {HeroeTarjetaComponent} from  'src/app/components/heroe-tarjeta/heroe-tarjeta.component';
import{HeroesComponent} from 'src/app/components/heroes/heroes.component';
import {HomeComponent} from 'src/app/components/home/home.component';
import {NavbarComponent} from 'src/app/components/shared/navbar/navbar.component';
import {AppRoutingModule} from 'src/app/app.routing';


@NgModule({
  declarations: [
    AppComponent,
    AboutComponent,
    BuscadorComponent,
    HeroeComponent,
    HeroeTarjetaComponent,
    HeroesComponent,
    HomeComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
