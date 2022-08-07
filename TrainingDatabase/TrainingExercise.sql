CREATE TABLE [dbo].[TrainingExercise]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [ExerciseId] UNIQUEIDENTIFIER NOT NULL, 
    [TrainingId] UNIQUEIDENTIFIER NOT NULL, 
    [Order] BIT NOT NULL, 
    [Duration] TIME NULL

    CONSTRAINT [FK_TrainingExercise_Exercise] FOREIGN KEY ([ExerciseId]) REFERENCES [dbo].[Exercise] ([Id]),
    CONSTRAINT [FK_TrainingExercise_Training] FOREIGN KEY ([TrainingId]) REFERENCES [dbo].[Training] ([Id])
)
