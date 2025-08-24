namespace DevQuestions.Presentore;

public record UpdateQuestionsDto(string Title, string Body, Guid[] Tags);