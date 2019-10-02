import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AppComponent } from './app.component';
import { ListComponent } from './list/list.component';
import { DetailsComponent } from './details/details.component';
import { EditComponent } from './edit/edit.component';
import { FilterComponent } from './filter/filter.component';
import {Route, RouterModule} from '@angular/router';
import { AdvertisementTypePipe } from './advertisement-type.pipe';
import {FormsModule} from '@angular/forms';

const routes: Route[] = [
  { path: '', component: ListComponent },
  {path: 'search/:cityName', component: ListComponent},
  { path: 'details/:id', component: DetailsComponent },
  { path: 'edit/:id', component: EditComponent },
  { path: 'create', component: EditComponent }
];


@NgModule({
  declarations: [
    AppComponent,
    ListComponent,
    DetailsComponent,
    EditComponent,
    FilterComponent,
    AdvertisementTypePipe
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    NgbModule,
    RouterModule.forRoot(routes),
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
