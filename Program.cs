string? bookName;
string? author;
string? publicationYear;
string? isbn;

Console.Write("Book name: ");
bookName = Console.ReadLine();
Console.Write("Author: ");
author = Console.ReadLine();
Console.Write("Year of publication: ");
publicationYear = Console.ReadLine();
Console.Write("ISBN: ");
isbn = Console.ReadLine();

Console.WriteLine($"Book name: {bookName}");
Console.WriteLine($"Author: {author}");
Console.WriteLine($"Year of publication: {publicationYear}");
Console.WriteLine($"ISBN: {isbn}");
