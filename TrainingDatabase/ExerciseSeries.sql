CREATE TABLE [dbo].[ExerciseSeries]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [TrainingExerciseId] UNIQUEIDENTIFIER NOT NULL, 
    [Order] BIT NOT NULL, 
    [Reps] SMALLINT NOT NULL, 
    [Weight] FLOAT NOT NULL, 
    [RestTime] TIME NULL

    CONSTRAINT [FK_ExerciseSeries_TrainingExercise] FOREIGN KEY ([TrainingExerciseId]) REFERENCES [dbo].[TrainingExercise] ([Id]),
)
