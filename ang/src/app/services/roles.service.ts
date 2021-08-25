import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { tick } from '@angular/core/testing';
import { Observable, throwError } from 'rxjs';
import { catchError, map, retry } from 'rxjs/operators';
import { Employee } from './employees.service';

@Injectable()
export class RolesService {
    url = 'https://localhost:5001/roles';
    roles: Role[];

    constructor(
        private http: HttpClient
    ) { }

    getAllRoles() {
        return this.http.get<Role[]>(this.url);
    }

    getRoleById(id: number) {
        const urlGetRoleById = this.url + '/' + id.toString();
        return this.http.get<Role>(urlGetRoleById);
    }
}

export class Role {
    id: number;
    name: string;
    description: string;
    image: string;
    dateCreated: Date;
    dateUpdated: Date;
    employees: Employee[];
}
