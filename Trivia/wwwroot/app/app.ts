import {Component} from '@angular/core';
import {DataService} from './core/services/dataService'
import {Routes, Route, Router} from '@angular/router'
import {ROUTER_DIRECTIVES, ROUTER_PROVIDERS} from '@angular/router';
import {NewQuestionComponent} from './components/newquestion.component'
import {QuestionComponent} from './components/question.component'

@Component({
    selector: 'trivia-app',
    templateUrl: './app/app.html',
    providers: [DataService, ROUTER_PROVIDERS],
    directives: [ROUTER_DIRECTIVES]
})
@Routes([
    new Route({path: "/question", component: QuestionComponent }),
    new Route({path: "/", component: QuestionComponent }),
    new Route({path: "/newquestion", component: NewQuestionComponent })
])
export class AppComponent {

    private route: string;

    constructor(private router: Router){
        this.route = 'question';
    }

    isActive(uri: string){
        return this.route == uri ? 'active' : '';
    }

    navigate(uri: string) { 
        this.route = uri;
        this.router.navigate([`//${uri}`]); 
    }
}