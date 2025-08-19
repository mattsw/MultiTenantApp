import { Component } from '@angular/core';
import { MoneyTransaction } from './models/money-transaction';

@Component({
  selector: 'app-cashflow',
  imports: [],
  templateUrl: './cashflow.html',
  styleUrl: './cashflow.scss'
})
export class Cashflow {
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
