import { Routes } from '@angular/router';
import { Home } from './home/home';
import { About } from './components/about/about';
import { Cashflow } from './components/cashflow/cashflow';
import { Dataflow } from './components/dataflow/dataflow';
import { Admin } from './components/admin/admin';

export const routes: Routes = [
    {
        path: '',
        component: Home,
        title: 'Home Page'
    },
    {
        path: 'about',
        component: About,
        title: 'About Page'
    },
    {
        path: 'admin',
        component: Admin,
        title: 'Admin Page'
    },
    {
        path: 'cashflow',
        component: Cashflow,
        title: 'Cashflow Page'
    },
    {
        path: 'dataflow',
        component: Dataflow,
        title: 'Dataflow Page'
    }
];
