import { Component } from '@angular/core';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';
import {MatToolbarModule} from '@angular/material/toolbar';
import { RouterLink } from '@angular/router';
import { AuthService } from '@auth0/auth0-angular';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'app-navbar',
  imports: [MatIconModule, MatButtonModule, MatToolbarModule, RouterLink, AsyncPipe],
  templateUrl: './navbar.html',
  styleUrl: './navbar.scss'
})
export class Navbar {
  public isLoggedIn: boolean = false;
  constructor(public authService: AuthService){
    authService.isAuthenticated$.subscribe((data:boolean) =>{
      this.isLoggedIn = data;
    });
  }

  logout(){
    console.log(this.authService.isAuthenticated$)
    this.authService.logout({ 
      logoutParams: {
        returnTo: document.location.origin 
      }
    });
  }
}
