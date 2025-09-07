import { Component, OnInit } from '@angular/core';
import { MoneyTransaction } from './models/money-transaction';
import { inject } from '@angular/core';
import { CashflowService } from '../../services/cashflow-service';

@Component({
  selector: 'app-cashflow',
  imports: [],
  templateUrl: './cashflow.html',
  styleUrl: './cashflow.scss'
})
export class Cashflow implements OnInit{
  private cashflowService = inject(CashflowService);
  isLoading = true;
  hasErrors = false;

  ngOnInit(): void {
    this.isLoading = true;

    this.cashflowService.getCashflowData().subscribe({next: (data) => {
      this.apiLoadedData = data as Array<MoneyTransaction>;
    }, error: error => {
      console.log(error);
      this.hasErrors = true;
    },
    complete: () => {
      this.isLoading = false;
    }});
  }

  apiLoadedData: Array<MoneyTransaction> = [];

  temporaryStaticPageData: Array<MoneyTransaction> = [
    this.generateMoneyTransactionRecord(),
    this.generateMoneyTransactionRecord(),
    this.generateMoneyTransactionRecord(),
    this.generateMoneyTransactionRecord()
  ];

  generateMoneyTransactionRecord() : MoneyTransaction {
    return Object.assign(new MoneyTransaction(), {
      amount: 1234,
      details: "Some stubbed details",
      date: "11/11/1111",
      accountNumber: "Ac123",
      referenceNumber: (Math.random() * 10000 | 0).toString(16)
    });
  }

}
