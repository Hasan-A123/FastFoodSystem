# Fast-Food Ordering System

## Overview

A desktop fast-food ordering application developed using **C#** and **Windows Forms**. The application allows users to create customer orders, manage selected items, calculate total costs, and interact with a graphical user interface.

The project demonstrates practical experience with **object-oriented programming**, **event-driven development**, GUI design, input validation, and separation of business logic from presentation logic.

---

# Features

- Create customer food orders through a graphical interface
- Select food items and manage order details
- Automatically calculate order totals
- Display real-time pricing updates
- Validate user input before processing orders
- Manage customer and order information
- Provide immediate feedback through UI events
- Use reusable Windows Forms components
- Maintain structured application logic using object-oriented design

---

# Technologies Used

| Technology | Purpose |
|---|---|
| C# | Application logic and object-oriented programming |
| .NET Framework | Desktop application development platform |
| Windows Forms | Graphical user interface development |
| Visual Studio | Development environment |
| Event Handlers | User interaction management |
| Git/GitHub | Version control |

---

# Application Architecture

The application separates the user interface from the underlying business logic.

```
             User
              |
              ↓
       Windows Forms UI
              |
              ↓
        Event Handlers
              |
              ↓
        Order Class
              |
              ↓
       Order Calculations
```

This structure improves:

- Code readability
- Maintainability
- Reusability
- Separation of responsibilities

---

# Object-Oriented Design

The application applies object-oriented programming principles by modelling order information using dedicated classes.

## Order Class

The `Order` class is responsible for managing order-related data.

Responsibilities:

- Store customer information
- Store selected food items
- Manage quantities
- Calculate order totals
- Provide structured access to order information

Example workflow:

```
User Selection
      ↓
Order Object Updated
      ↓
Price Calculation
      ↓
Updated UI Display
```

---

# Event-Driven Programming

Windows Forms applications rely on events to respond to user actions.

The application uses event handlers to manage interactions such as:

- Button clicks
- Item selection changes
- Quantity updates
- Form actions

Example:

```
User Clicks Button
        ↓
Event Triggered
        ↓
Event Handler Executes
        ↓
UI Updated
```

---

# Order Management

Users can build an order by selecting menu items and entering relevant information.

The application handles:

- Adding items to an order
- Updating order details
- Calculating costs
- Displaying final totals

---

# Price Calculation

The system dynamically calculates the order cost based on selected items.

Calculation workflow:

```
Selected Items
       ↓
Retrieve Item Prices
       ↓
Calculate Total
       ↓
Display Updated Cost
```

This provides immediate feedback to users when modifying their order.

---

# Input Validation

Validation was implemented to improve reliability and prevent invalid data from being processed.

Examples include:

- Checking required fields
- Ensuring valid quantities
- Preventing incomplete orders
- Providing feedback messages to users

Benefits:

- Improved user experience
- Reduced application errors
- More reliable order processing

---

# Windows Forms Interface

The graphical interface was designed using Windows Forms controls.

Implemented components include:

- Labels
- Buttons
- TextBoxes
- CheckBoxes
- ComboBoxes
- List controls
- Message dialogs

The interface provides a simple ordering workflow suitable for desktop users.

---

# Project Structure

Example structure:

```
Fast-Food-Ordering-System/
│
├── Forms/
│   ├── MainForm.cs
│   └── OrderForm.cs
│
├── Models/
│   └── Order.cs
│
├── Program.cs
│
├── Properties/
│
├── Resources/
│
└── README.md
```

---

# Screenshots

_Add screenshots here._

Recommended screenshots:

```
/screenshots
    ├── main-menu.png
    ├── order-interface.png
    ├── price-calculation.png
    └── completed-order.png
```

---

# Demo

_Add GIF demonstrations here._

Suggested demonstrations:

- Creating a new order
- Selecting food items
- Updating quantities
- Viewing calculated totals

Example:

```
/gifs
    └── ordering-process.gif
```

---

# Challenges & Solutions

## Separating Business Logic from UI

### Challenge
Managing calculations directly inside form code can make applications difficult to maintain.

### Solution
Created an `Order` class to handle order-related data and calculations separately from the user interface.

---

## Managing User Interaction

### Challenge
Desktop applications require constant handling of user actions.

### Solution
Used event-driven programming with Windows Forms event handlers to respond to user input efficiently.

---

## Preventing Invalid Orders

### Challenge
Users may submit incomplete or incorrect information.

### Solution
Implemented validation checks before processing orders and provided feedback messages to guide users.

---

# Future Improvements

Potential improvements include:

- Add a database for storing previous orders
- Implement customer accounts
- Add menu management functionality
- Add receipt generation
- Add payment processing simulation
- Improve UI design using modern .NET frameworks
- Create automated unit tests for order calculations
- Migrate to WPF or .NET MAUI for a modern interface

---

# Learning Outcomes

Through this project, I gained practical experience in:

- C# desktop application development
- Windows Forms GUI design
- Object-oriented programming
- Event-driven programming
- Class design and encapsulation
- Input validation
- Separating business logic from presentation logic
- Building maintainable desktop applications
