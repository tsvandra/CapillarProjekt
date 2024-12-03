Capillar Salon Management Software Documentation
Table of Contents
Introduction
Project Overview
Requirements
Architecture Overview
Development Log
Introduction
Capillar is a salon management software that provides features for managing appointments, revenues, expenses, generating reports, and promoting services by uploading images. The system aims to offer an all-in-one solution for hairdressers to manage their clients and daily operational tasks more easily and transparently.

Project Overview
The Capillar project is the result of a software development process aimed at making the operation of the user's salon more efficient and convenient. The software provides the following key features:

Customer Management: Adding, modifying, deleting, and listing customers.
Appointment Management: Managing and viewing appointments.
Report Generation: Creating clear reports on salon operations, revenues, and statistics.
Service Promotion: Uploading images of work that can be shared on social media.
Inventory Management: Managing stock related to performed hairdressing procedures.
At its current state, the project has reached a level where customer data management is functional, and the development of the user interface design and styles has begun.

Requirements
The requirements to be fulfilled by the software:

Platform: A Windows Forms-based application that is user-friendly for your wife.

Functionality:

Managing customer data: Add, edit, and delete customer records.
Handling appointment bookings.
Generating reports on revenues and customer data.
User-friendly and visually appealing interface.
Integration with social media for sharing purposes.
Technical Requirements:

Programming Language: C# .NET 8.0.
Database: Microsoft SQL Server for storing data (e.g., customer data, appointments).
UI Component: Windows Forms with special attention to implementing CustomDataGridView.
Architecture Overview
The main components and structure of the project:

KupacProjekt: The main directory containing sub-projects.

Kupac: Core project responsible for backend logic.
Kupac.UI.Customers: User interface for managing customers.
Kupac.UI.Orders: Interface for managing orders (under development).
Kupac.UI.Shared: Shared components like CustomDataGridView and other common UI elements.
Database Management:

Data interactions are handled using Entity Framework Core 8.0.8.
The primary database table, Customers, stores customer data.
User Interface:

Windows Forms: Ensures ease of use and customization.
CustomDataGridView: A customized DataGridView component with consistent styling and row highlighting on mouse hover.
Development Log
Date: [2024-07-27]
Initial Project Setup: Created the KupacProjekt directory, which includes the Kupac backend and Kupac.UI.Customers frontend components.
Database Setup: Created the SQL Server database named "Capillar."
UI Development: Started implementing the CustomDataGridView, which ensures a visually consistent interface.
Navigation Panel: Developed the navigation panel in MainForm, allowing users to navigate between the main pages.
Date: [2024-11-27]
Customer Management: Developed the "Add Customer" form, enabling the addition and modification of customer data.
Color Optimization: Optimized the style and color transitions of navigation buttons to make the active button easily noticeable.
