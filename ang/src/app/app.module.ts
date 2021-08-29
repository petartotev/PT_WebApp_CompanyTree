import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { ServicesModule } from './services/services.module';
import { ReactiveFormsModule } from '@angular/forms';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { EmployeesComponent } from './routes/employees/employees.component';
import { ProfileComponent } from './routes/profile/profile.component';
import { RolesComponent } from './routes/roles/roles.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeesComponent,
    ProfileComponent,
    RolesComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    NgbModule,
    ServicesModule,
    ReactiveFormsModule,
    FontAwesomeModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
