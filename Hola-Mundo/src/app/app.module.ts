import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CuerpoComponent } from './cuerpo/cuerpo.component';
import { CabaceraComponent } from './cabacera/cabacera.component';

@NgModule({
  declarations: [
    AppComponent,
    
    CuerpoComponent,
    CabaceraComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
