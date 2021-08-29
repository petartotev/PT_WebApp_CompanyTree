import { Component, ViewChild, ViewEncapsulation } from '@angular/core';
import { ProfileComponent } from './routes/profile/profile.component';
import { faMoon, faSun, IconDefinition } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})
export class AppComponent {
  @ViewChild(ProfileComponent)
  private profileComponent!: ProfileComponent;

  iconCurrent: IconDefinition = faSun;

  isDarkMode = false;
  title = 'ang';

  showProfile(id: number) {
    this.profileComponent.showProfile(id);
  }

  swapDarkMode() {
    this.isDarkMode = !this.isDarkMode;
    this.setIconCurrent();
    this.setBodyStyle();
  }

  private setIconCurrent() {
    if (this.isDarkMode) {
      this.iconCurrent = faSun;
    }
    else {
      this.iconCurrent = faMoon;
    }
  }

  private setBodyStyle() {
    let bodyStyle: string;

    if (this.isDarkMode) {
      bodyStyle = 'bg-dark text-white';
    }
    else {
      bodyStyle = 'bg-white text-dark';
    }

    document.body.setAttribute('class', bodyStyle);
  }
}
