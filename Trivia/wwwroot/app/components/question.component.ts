import { Component, Input} from '@angular/core';
import { Question } from '../core/domain/question';
import { DataService } from '../core/services/dataService';
import { Answer } from '../core/domain/answer';

@Component({
    selector: 'question',
    templateUrl: './app/components/question.component.html'
})
export class QuestionComponent {
    
    @Input()
    public question: Question;

    public answerDisable = false;
    public responseRight = true;
    public responseWrong = true;
    public noAnswer = true;
    
    constructor(private service: DataService) 
    { 
        this.service.set('api/question')
    }
    
    answerClicked(answer: Answer)
    {
        answer.IsChecked = !answer.IsChecked;
        this.noAnswer = true; 
    }

    answerQuestion() {
        let selectedAnswer = this.question.Answers.filter( a => a.IsChecked );
        if (selectedAnswer[0]) {
            this.service.postCustomResource('/' + this.question.Id + '/user/123', selectedAnswer[0]).subscribe(
                res => {
                    this.answerDisable = true;
                    this.responseRight = res.json() ? undefined : true;
                    this.responseWrong = !res.json() ? undefined : true;
                }
            )
        } else 
        {
            this.noAnswer = undefined;
        }
        
    }
    
    nextQuestion(){
        this.service.getCustomResource('/random').subscribe(
            res => {
                let data: any = res.json();
                this.question = data;
                this.responseRight = true;
                this.responseWrong = true;
                this.answerDisable = false;
            }
        )
    }
}