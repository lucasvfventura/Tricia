import { Question } from '../../models/question';
import { Answer} from '../../models/answer';
import { DataService} from '../../services/dataService';
import { autoinject} from 'aurelia-framework';

@autoinject
export class AnswerQuestion {

  private question: Question;

  private responseRight = true;
  private responseWrong = true;
  private selectedAnswerId:number;

  constructor(private service: DataService) {
    this.service.setBaseUri('question');
    this.question = new Question();
    this.question.Answers.push(new Answer());
  }

  activate() {
    this.service.getCustomResource("/random")
      .then(response => response.json())
      .then(data => {
        this.question = data;
      });
  }

  get Answered(){
    return this.selectedAnswerId === undefined;
  }

  markAnswer(answer:Answer){
    this.question.Answers.map(a => a.IsChecked = false);
    answer.IsChecked = !answer.IsChecked ? true : false;
  }

  answerQuestion() {
    if (this.selectedAnswerId !== undefined) {
      let selectedAnswer = this.question.Answers.filter(a => a.Id == this.selectedAnswerId);
      selectedAnswer[0].IsChecked = true;
      this.service.postCustomResource('/' + this.question.Id + '/answer', selectedAnswer[0])
        .then(response => response.json())
        .then(data =>{
            this.responseRight = data ? undefined : true;
            this.responseWrong = !data ? undefined : true;
        });
    }

  }

  nextQuestion() {
    this.service.getCustomResource('/random').then(response =>response.json())
      .then(data => {
            this.question = data;
            this.responseRight = true;
            this.responseWrong = true;
        }
    )
  }
}