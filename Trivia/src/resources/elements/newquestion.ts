import { Answer } from '../../models/answer';
import { Question } from '../../models/question';

export class Newquestion {
    private question: Question;

    constructor(/*private service: DataService*/) {
        //this.service.set('api/question');
        this.question = new Question();
        for (let i = 0; i < 5; i++) {
            this.question.Answers.push(new Answer());
            
        }
    }

    addAnswer(){
        this.question.Answers.push(new Answer());
    }

    get hideRemoveAnswer(){
        return this.question.Answers.length > 5 ? "" : "hidden";
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

