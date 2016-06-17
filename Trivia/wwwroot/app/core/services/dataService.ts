import {Injectable, Inject} from '@angular/core';
import {Http, Response, Request, Headers, RequestOptions} from '@angular/http';

@Injectable()
export class DataService{
    private pageUri: string;

    constructor(public http: Http) {
    }

    set(pageUri: string) {
        this.pageUri = pageUri;
    }

    get() {
        return this.http.get(this.pageUri);
    }
    
    getCustomResource(resource: string){
        return this.http.get(this.pageUri + resource);
    }

    postCustomResource(resource: string, data?: any){
        let body = JSON.stringify(data);
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        return this.http.post(this.pageUri + resource, body, options);
    }
    
    post(data?: any) {
        return this.http.post(this.pageUri, data);
    }
}