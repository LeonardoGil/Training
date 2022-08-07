﻿namespace TrainingLibrary.Entity
{
    public class Training
    {
        public Guid Id { get; set; } 

        public DateOnly Date { get; set; }
        
        public TimeOnly? Duration { get; set; }

        public List<TrainingExercise> Exercises { get; set; }
    }
}