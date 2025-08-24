namespace DevQuestions.Presentore;

public record GetQuestionsDto(string Search, Guid[] TagIDs, int PageSize, int Limit);