# Character Copy Kata

This project demonstrates a character copying system using a Copier class, integrated with a RESTful API. The application supports single-character and multi-character copying, with robust unit tests.

## Table of Contents
1. [Character Copy Kata](#character-copy-kata)
2. [Prerequisites](#prerequisites)
3. [Setup Instructions](#setup-instructions)
4. [API Endpoints](#api-endpoints)
5. [Testing the Application](#testing-the-application)
6. [Contact](#contact)

## Prerequisites

Ensure the following are installed on your system:

- .NET 8 SDK
- A code editor (e.g., Visual Studio or VS Code)

## Setup Instructions

Step-by-step guide to installing and running the project locally:

### Clone the Repository
```bash
git clone https://github.com/qiqakotyi/charactercopykata.git
```

### Restore Dependencies
```bash
dotnet restore
```

### Build the Project
```bash
dotnet build
```

### Running the Application
```bash
cd CharacterCopyKata
dotnet run
```

## API Endpoints

### By default, the API will be hosted at:
`http://localhost:5074/`

### Single Character Copy
- **URL:** `POST /api/copier/copy`
- **Response:** `"Copy operation completed successfully!"`

### Multiple Character Copy
- **URL:** `POST /api/copier/copy-multiple/{count}`
  - Replace `{count}` with the number of characters to copy.
- **Response:** `"Copied {count} characters successfully!"`

## Testing the Application
```bash
cd CharacterCopyKata.Tests
dotnet test
```

### Expected Test Output
```
Passed CopierTests.Copy_ShouldCopyCharactersUntilNewline
Passed CopierTests.CopyMultiple_ShouldCopyMultipleCharactersUntilNewline
Passed CopierTests.CopyMultiple_ShouldStopWhenNewlineIsEncountered
```

## Contact

For any questions or support, please contact:

- **Maintainer:** Qiqa Kotyi
- **Email:** qiqakotyi@gmail.com
- **Repository Link:** [GitHub Repository](https://github.com/qiqakotyi/charactercopykata)