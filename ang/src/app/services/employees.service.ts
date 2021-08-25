import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export class EmployeesService {
    constructor(
        private http: HttpClient
    ) { }

    url = 'https://localhost:5001/employees';
    employees: Employee[];

    getAllEmployees() {
        return this.http.get<Employee[]>(this.url);
    }
}

export class Employee {
    id: number;
    firstName: string;
    middleName: string;
    lastName: string;
    nationality: string;
    image: string;
    phone: string;
    email: string;
    dateBirth: Date;
    dateHired: Date;
    dateCreated: Date;
    dateUpdated: Date;
    isBoardMember: boolean;
    roleId: number;
    teamId: number;
}
