import { Component, Input, OnInit } from '@angular/core';
import { Employee, EmployeesService } from '../../services/employees.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {
  @Input() isParentInDarkMode: boolean;
  employees: Employee[];
  selectedEmployee: Employee;

  constructor(
    private employeesService: EmployeesService
  ) { }

  ngOnInit(): void {
    this.loadAllEmployees();
  }

  showProfile(id: number) {
    window.scroll(0, 0);
    this.selectedEmployee = this.employees.find(x => x.id === id);
  }

  private loadAllEmployees() {
    this.employeesService.getAllEmployees().subscribe((observer) => this.employees = observer.map((val: Employee) => val as Employee));
  }
}
