import { Answer } from './answer';
export class Question {
    public Id: number;
    public Title: string = "";
    public Answers: Answer[] = [];
}