# 📑TagFinder

TagFinder is a lightweight C# GUI and console application that scrapes and extracts specific HTML tags (such as <a>, <img>, <div>, etc.) from a website provided by the user.

## 🚀 Features
User inputs a website URL and an HTML tag.
Downloads and parses webpage HTML content.
Extracts and displays all matching tags.
Simple, fast, and dependency-free.

## 🔧 Requirements
.NET 6 (or newer)
(or .NET Core 3.1 / .NET Framework 4.7+)
No external libraries are required — it uses built-in HttpClient and Regex.

### 📦 Building
Open the solution in Visual Studio or your favorite C# editor.
Make sure the project targets .NET 6 or later.
Build and run.

Or from terminal:
```powershell
dotnet build
dotnet run
```

### 🖥️ Usage
Run the application.
Enter the website URL when prompted.
Enter the HTML tag you want to find.
View the extracted tags listed in the console.

### Example:
```powershell
Enter URL (e.g., https://example.com): https://example.com
Enter tag to search for (without <>, e.g., a, img, div): a
[+] FOUND <a> tag: <a href="https://www.iana.org/domains/example">
```

### 📚 Future Improvements
1.Export results to a text or CSV file.
2.Allow multiple tags search in a single run.
3.Create a GUI version (Windows Forms / WPF).

## 📜 License
This project is open-source and free to use for learning and personal projects.

#✨ Happy Tag Hunting!
