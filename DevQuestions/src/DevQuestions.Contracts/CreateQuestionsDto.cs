namespace DevQuestions.Presentore;

public record CreateQuestionsDto(string Title, string Body, Guid UserID, Guid[] Tags);