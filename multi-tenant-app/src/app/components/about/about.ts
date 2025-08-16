import { Component } from '@angular/core';
import { MatGridList } from '@angular/material/grid-list';
import { MatGridTile } from '@angular/material/grid-list';

@Component({
  selector: 'app-about',
  imports: [MatGridList, MatGridTile],
  templateUrl: './about.html',
  styleUrl: './about.scss'
})
export class About {

}
