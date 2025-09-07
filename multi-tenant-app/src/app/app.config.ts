import { ApplicationConfig, provideBrowserGlobalErrorListeners, provideZoneChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';
import { provideAuth0 } from '@auth0/auth0-angular';
import { routes } from './app.routes';
import { provideHttpClient } from '@angular/common/http';

export const appConfig: ApplicationConfig = {
  providers: [
    provideBrowserGlobalErrorListeners(),
    provideZoneChangeDetection({ eventCoalescing: true }),
    provideRouter(routes),
    provideHttpClient(),
    provideAuth0({
      domain: 'dev-tn5c16uxif30n7at.us.auth0.com',
      clientId: 'sW86xBfkhhFEyHX7EmfdeO0a5GgbbPQo',
      authorizationParams: {
        redirect_uri: window.location.origin,
        audience: 'mtdemo'
      }
    })
  ]
};
