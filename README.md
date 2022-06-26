# Sample Project

This repository contains a poorly written project, following no standards or best practice.

The goal is to use this project as a review piece, and a discussion piece on what needs to improve, how and why.

Overall, I have tried to keep the code to a minimum, where possible. The front end is entirely unstyled - this is intentional. Don't worry about the UI presentation - that's outside of the scope of this review.

There isn't a specific need to run the project, if you wish not to. I fully support refusing to run any code without a thorough review beforehand!

## Project Setup

I have removed Docker from this - this wasn't a common setup and I didn't want to complicate things. However adding docker support isn't difficult, and I can demonstrate this.

The backend depends on SQL Server - I wrote this using SQL Server 2019. There is a Post Deployment script which should automatically run when publishing the project. This script contains some sample seed data.

.NET API backend uses .NET 6.0 SDK, which will need to be installed. The project includes Swagger, for API review.

The front end uses no external libraries - simple HTML, and a single included Javascript file. No further libraries are required.

## Task - Preparation

As stated, you aren't required to write any code here beforehand. There might be technology or languages you haven't used, but don't worry about that. The language itself isn't too important, it's more about the concepts and approach.

Go through the code, and just keep a few notes or pointers from what you're thinking. Take a code review appraoch. What do you think could be wrong with it, and where can be improved?

What principals and best practices have not been used here, which the project would require? 
## Project Requirements

If this application would be used in the real world, it would need to go through development, testing and release stages. This would require multiple, separate environments for different uses.

The way this project is currently put together would make this very difficult to support.
## Data

```/datastore/```

This is the database project, containing a couple of tables and seed data for these tables.
## Backend

```/generic-backend/```

The API layer, which talks to the database and relays data to the UI. 

## Front End

```/generic-frontend/```

The control and presentation layer, used to request and display data to the user.

The provided javascript file handles the communication between the actual UI and the API. 