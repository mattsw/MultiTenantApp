import { Component } from '@angular/core';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';
import {MatToolbarModule} from '@angular/material/toolbar';
import { RouterLink } from '@angular/router';
import { AuthService } from '@auth0/auth0-angular';

@Component({
  selector: 'app-navbar',
  imports: [MatIconModule, MatButtonModule, MatToolbarModule, RouterLink],
  templateUrl: './navbar.html',
  styleUrl: './navbar.scss'
})
export class Navbar {
  
  constructor(public authService: AuthService){

  }
}
