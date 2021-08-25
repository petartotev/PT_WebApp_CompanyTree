import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError, map, retry } from 'rxjs/operators';
import { of } from 'rxjs';
import { Role, RolesService } from '../services/roles.service';
import { Employee, EmployeesService } from '../services/employees.service';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css'],
})
export class EmployeesComponent implements OnInit {
  @Output() openProfileEmitter = new EventEmitter<number>();

  isClicked = false;
  urlGetEmployee = 'https://localhost:5001/employees';
  employees: Employee[];
  roles: Role[];
  rolesNames: Map<number, string>;

  constructor(
    private rolesService: RolesService,
    private employeesService: EmployeesService) { }

  ngOnInit(): void {
    this.rolesNames = new Map<number, string>();
    this.loadAllRoles();
  }

  openEmployeeProfile(id: number) {
    this.openProfileEmitter.emit(id);
  }

  getAllEmployees() {
    this.updateAllRoles();
    this.loadAllEmployees();
    this.isClicked = true;
  }

  private loadAllEmployees() {
    this.employeesService.getAllEmployees()
    .subscribe((observer) => this.employees = observer.map((val: Employee) => val as Employee));
  }

  private loadAllRoles() {
    this.rolesService.getAllRoles()
    .subscribe((observer) => this.roles = observer.map((val: Role) => val as Role));
  }

  private updateAllRoles() {
    this.roles.forEach(element => {
      this.rolesNames.set(element.id, element.name);
    });
  }
}
