import 'whatwg-fetch';
import { HttpClient, json } from 'aurelia-fetch-client';
import { autoinject } from 'aurelia-framework';

@autoinject()
export class DataService{
    client:HttpClient;
    private baseUri:string;

    constructor(client:HttpClient){
        this.client = client;
        this.client.configure(config => {
            config
                .withBaseUrl('/api/')
                .withDefaults({
                    credentials: 'same-origin',
                    headers: {
                        'Accept': 'application/json',
                        'X-Requested-With': 'Fetch'
                    }
                });
            });
        this.baseUri = "";
    }

    setBaseUri(baseUri:string){
        this.baseUri = baseUri;
    }

    getCustomResource(resource:string){
        return this.client.fetch(this.baseUri + resource);
    }

    post(resource:any){
        return this.client.fetch(this.baseUri, { method: "POST", body: json(resource) })
    }

    postCustomResource(resourceUri:string, resource:any){
        return this.client.fetch(
                 this.baseUri + resourceUri, 
                 { method: "POST", body: json(resource) }
               );
    }

    get(){
        return this.client.fetch(this.baseUri);
    }
}