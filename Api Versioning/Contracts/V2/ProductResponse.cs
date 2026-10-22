namespace Api_Versioning.Contracts.V2;

public record ProductResponse
(
    int Id,
    string Name,
    decimal Price,
    string Category
);
