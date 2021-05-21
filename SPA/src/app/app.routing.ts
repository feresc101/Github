

import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AboutComponent } from "./about/about.component";
import { HeroeComponent } from "./heroe/heroe.component";
import { HomeComponent } from "./home/home.component";


const routes: Routes = [
    { path: 'heroe', component: HeroeComponent},
    { path: 'home', component: HomeComponent },
    { path: 'about', component: AboutComponent},
    {path: '**', pathMatch: 'full', redirectTo: 'home'}

];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule{}