import { Component, inject } from '@angular/core';
import { DataflowTransaction } from './models/dataflow-transaction';
import { DataflowService } from '../../services/dataflow-service';

@Component({
  selector: 'app-dataflow',
  imports: [],
  templateUrl: './dataflow.html',
  styleUrl: './dataflow.scss'
})
export class Dataflow {
  private dataFlowService = inject(DataflowService);
  isLoading: boolean = false;
  hasErrors: boolean = false;

  ngOnInit(): void {
      this.isLoading = true;
  
      this.dataFlowService.getDataflowData().subscribe({next: (data) => {
        this.apiLoadedData = data as Array<DataflowTransaction>;
      }, error: error => {
        console.log(error);
        this.hasErrors = true;
      },
      complete: () => {
        this.isLoading = false;
      }});
    }

  apiLoadedData: Array<DataflowTransaction> = [];
}
