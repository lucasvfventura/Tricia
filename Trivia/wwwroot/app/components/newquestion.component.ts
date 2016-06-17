import { Component, Input } from '@angular/core';
import { Question } from '../core/domain/question';
import { Answer } from '../core/domain/answer';
import { DataService } from '../core/services/dataService';

@Component({
    selector: 'newquestion',
    templateUrl: './app/components/newquestion.component.html'
})
export class NewQuestionComponent {

    @Input()
    public question: Question;

    constructor(private service: DataService) {
        this.service.set('api/question');
    }

    addAnswer(){
        this.question.Answers.push(new Answer());
    }

    removeAnswer(answer: Answer){
        if(this.question.Answers.length > 5){
            let index = this.question.Answers.indexOf(answer, 0);
            if (index > -1) {
                this.question.Answers.splice(index, 1);
            }
        }
    }

    save(){
        console.log(this.question);
    }
}