import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataflowService {
  private http = inject(HttpClient);

  getDataflowData(): Observable<Object> {
    return this.http.get('https://localhost:44335/api/Dataflow');
  }
}

