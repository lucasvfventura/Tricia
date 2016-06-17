import {Component} from '@angular/core';
import {DataService} from './core/services/dataService'
import {Question} from './core/domain/question';
import {Answer} from './core/domain/answer';
import {QuestionComponent} from './components/question.component';
import {NewQuestionComponent} from './components/newquestion.component';

@Component({
    selector: 'trivia-app',
    templateUrl: './app/app.html',
    providers: [DataService],
    directives: [QuestionComponent, NewQuestionComponent]
})
export class AppComponent {
    
    private question: Question;
    private newQuestion: Question;
    
    constructor(public service: DataService) {
        service.set('api/question/random');
        this.getAll();
        this.newQuestion = new Question()
        this.newQuestion.Answers.push(new Answer());
    }

    getAll() {
        this.service.get().subscribe(
            res => {
                let data: any = res.json();
                this.question = data;
            }
        );
    }
}