import { Component, ViewChild } from '@angular/core';
import { ProfileComponent } from './routes/profile/profile.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  @ViewChild(ProfileComponent)
  private profileComponent!: ProfileComponent;

  title = 'ang';

  showProfile(id: number) {
    this.profileComponent.showProfile(id);
  }
}
