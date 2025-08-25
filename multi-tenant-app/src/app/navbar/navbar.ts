import { Component } from '@angular/core';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';
import {MatToolbarModule} from '@angular/material/toolbar';
import { RouterLink } from '@angular/router';
import { AuthService } from '@auth0/auth0-angular';
import { environment } from '../../environments/environment.development';

@Component({
  selector: 'app-navbar',
  imports: [MatIconModule, MatButtonModule, MatToolbarModule, RouterLink],
  templateUrl: './navbar.html',
  styleUrl: './navbar.scss'
})
export class Navbar {
  //TODO move this control flow to guards / elsewhere but for now it demonstrates feature purpose
  public isLoggedIn: boolean = false;
  public hasCashflow: boolean = false;
  public hasDataflow: boolean = false;
  public hasAdmin: boolean = false;
  private apiManagementToken: string = environment.apiManagementToken;
  private managementApiEndpoint: string = "https://dev-tn5c16uxif30n7at.us.auth0.com/api/v2/users/";

  constructor(public authService: AuthService){
    authService.isAuthenticated$.subscribe((data:boolean) =>{
      this.isLoggedIn = data;
    });
    authService.user$.subscribe(async (data:any) => {
      if(!data) return;
      
      let response = await fetch(new URL(`${data.sub}/roles`, this.managementApiEndpoint),{
        headers: {"Authorization": `Bearer ${this.apiManagementToken}`}
      });

      var results = await response.json();

      if(!results.error){
        this.hasCashflow = !!results.find((role: any) => role.name == 'Cashflow');
        this.hasDataflow = !!results.find((role: any) => role.name == 'Dataflow');
        this.hasAdmin = !!results.find((role: any) => role.name == 'Admin');
      } else {
        //TODO error handling here
        console.log(results);
      }
      
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
