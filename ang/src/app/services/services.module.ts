import { NgModule, Optional, SkipSelf } from '@angular/core';
import { EmployeesService } from './employees.service';
import { RolesService } from './roles.service';

@NgModule({
    providers: [
        RolesService,
        EmployeesService,
    ],
})
export class ServicesModule {
    constructor(@Optional() @SkipSelf() parent: ServicesModule) {
        if (parent) {
            throw new Error('Core module is already provided elsewhere!');
        }
    }
}
