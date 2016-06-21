import {provide} from '@angular/core';
import {HTTP_PROVIDERS} from '@angular/http'
import {ROUTER_PROVIDERS} from '@angular/router'
import {bootstrap} from '@angular/platform-browser-dynamic';
import {AppComponent} from './app';
import {DataService} from './core/services/dataService'

bootstrap(AppComponent, [ROUTER_PROVIDERS, HTTP_PROVIDERS, DataService]);
