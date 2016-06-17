﻿namespace Trivia.Models
{
    public class Answer : IModelBase
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public bool IsCorrect { get; set; }
    }
}