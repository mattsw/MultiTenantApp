import { Component } from '@angular/core';
import { DataflowTransaction } from './models/dataflow-transaction';

@Component({
  selector: 'app-dataflow',
  imports: [],
  templateUrl: './dataflow.html',
  styleUrl: './dataflow.scss'
})
export class Dataflow {
  isLoading: boolean = false;

  temporaryStaticPageData: Array<DataflowTransaction> = [];
}
