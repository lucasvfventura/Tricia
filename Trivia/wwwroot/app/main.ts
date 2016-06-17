import {provide} from '@angular/core';
import {HTTP_PROVIDERS, RequestOptions, BaseRequestOptions, Headers} from '@angular/http'
import {bootstrap} from '@angular/platform-browser-dynamic';
import {AppComponent} from './app';
import {DataService} from './core/services/dataService'

class AppBaseRequestOptions extends BaseRequestOptions {
    headers: Headers = new Headers({
        'Content-Type': 'application/json'
    })
}
bootstrap(AppComponent, [HTTP_PROVIDERS, DataService]);
