import {Router, RouterConfiguration} from 'aurelia-router';
import { bindable } from 'aurelia-framework'

export class App {
  router: Router;
  private route: string;

  constructor(){
    this.route = 'answerquestion';
  }

  configureRouter(config: RouterConfiguration, router: Router){
    config.title = 'Trivia';
    config.map([
      { route: ['', 'answerquestion'], moduleId: './resources/elements/answerquestion', title: 'Answer the Question below'},
      { route: 'newquestion',  moduleId: './resources/elements/newquestion', title: 'Add a new question'}
    ]);

    this.router = router;
  }

  isActive(uri:string){
    return this.route == uri ? "active" : '';
  }

  navigate(uri:string){
    this.route = uri;
    this.router.navigate(uri);
  }
}