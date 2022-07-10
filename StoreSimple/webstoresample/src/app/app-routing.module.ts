import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListclientsComponent } from './components/listclients/listclients.component';

const routes: Routes = [ {path : 'listclients', component : ListclientsComponent},];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
