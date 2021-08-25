import { Component, OnInit } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError, map, retry } from 'rxjs/operators';
import { of } from 'rxjs';
import { Role, RolesService } from '../services/roles.service';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-roles',
  templateUrl: './roles.component.html',
  styleUrls: ['./roles.component.css']
})
export class RolesComponent implements OnInit {
  currentRole: Role;
  currentRoleId = new FormControl(1);
  testNum: number = 123;

  constructor(
    private rolesService: RolesService
  ) { }

  ngOnInit(): void {
  }

  submitRoleId(): void {
    this.rolesService.getRoleById(this.currentRoleId.value as number).subscribe((observer) => this.currentRole = observer);
  }
}
