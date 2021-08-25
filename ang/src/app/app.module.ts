import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { EmployeesComponent } from './employees/employees.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { ServicesModule } from './services/services.module';
import { ProfileComponent } from './profile/profile.component';
import { RolesComponent } from './roles/roles.component';

import { ReactiveFormsModule } from '@angular/forms';

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
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
