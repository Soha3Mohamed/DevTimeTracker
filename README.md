# ⏱️ Dev Time Tracker

**Dev Time Tracker** is a simple console-based C# application that helps developers track their coding sessions. It supports starting, ending, and filtering sessions by project name or session type, and saves all data persistently in a local JSON file.

---

## 📌 Features

* ✅ Start and end coding sessions
* 🗂️ Filter sessions by project or type
* 🕒 Automatically calculate session durations
* 💾 Get all Project Names per user
* 💾 Save and load sessions from a JSON file
* 🧠 Built with OOP principles and clean architecture
* 🛠️ Easily extendable with Entity Framework in future versions

---

## 🚀 Getting Started

### Prerequisites

* .NET 6.0 SDK or later
* IDE like Visual Studio or Visual Studio Code

### Run the App

```bash
git clone https://github.com/your-username/DevTimeTracker.git
cd DevTimeTracker
dotnet build
cd DevTimeTracker.cli
dotnet run
```

---

## 💡 Project Structure

```
DevTimeTracker/
│
├── DevTimeTracker/         # Core logic (business and data layer)
│   ├── Models/             # Data models
│   ├── SessionManager.cs   # Business logic
│   └── SessionStore.cs     # Persistence layer
│
├── DevTimeTracker.cli/     # Console interface (UI layer)
│   └── Program.cs
```

---

## 🧰 Technologies Used

* C# and .NET 8
* Object-Oriented Programming (OOP)
* JSON Serialization
* Console-based UI

---

## 📈 Future Improvements (v2 Plan)

* Replace JSON with a remote database (using EF Core and SQL)
* Add a RESTful Web API
* Add user management
* Track time statistics and generate reports

---

## 📄 License

This project is open-source and free to use.

---
