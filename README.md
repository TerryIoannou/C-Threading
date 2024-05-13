# C#-Threading

## Start Document for Earth Task Manager

**Problem Description:**

We are tasked with developing an Earth Task Manager application that allows users to manage tasks orbiting around the Earth. Tasks can be created, edited, and removed, and their orbits around Earth must be visualized. Additionally, the application should include features such as a health bar to monitor the overall health of tasks and Earth, integration of .NET Maui for seamless program operation, and utilization of version control for code management.

**Design and Program:**

Design and program an application based on the following requirements:
- The application should utilize C# .NET 8.0 or higher.
- Multi-threading should be implemented for concurrent task execution.
- Integration of .NET Maui should be incorporated for a clean GUI.
- The application should incorporate version control for code management.
- Utilization of PLINQ with a database containing a minimum of 100,000 records should be considered.
- Multiple asynchronous I/O calls to an API should be executed.
- Data visualization using plots/graphs and the thread pool should be implemented.
- Batch processing through tasks of the thread pool should be included.

**Input & Output:**

**Input:**
- User input for task creation, editing, and removal.
- Data fetched asynchronously from external APIs.
- Database input/output for task storage and retrieval.

**Output:**
- Visual representation of tasks orbiting around the Earth.
- Health status updates displayed through a health bar.
- Data visualization through plots/graphs.

**Class Diagram:**

*Class diagram representation of the Earth Task Manager application.*

![ClassDiagram](https://github.com/TerryIoannou/C-Threading/assets/91316685/148912d3-72a6-49bc-a81f-36f0719a0aba)

**Test Plan:**

Objective
- Validate the functionality, integration, and performance of the Earth Task Manager application, ensuring that all components interact correctly and perform optimally under various scenarios.

Test Environment
- Platform: Windows 10 or higher with .NET 8.0
- Tools: NUnit for unit testing, Moq for mocking, Visual Studio 2022 for development and testing.
- Database: Simulated environment with at least 100,000 records.
  
Scope
- Functional Testing: Verify that each component behaves as expected in isolation.
- Integration Testing: Ensure that components work together as expected.
- Concurrency Testing: Test the application’s performance and stability under load using the MultiThreadingManager.
  
Success Criteria
- All tests pass without critical errors, and performance metrics are within acceptable limits as defined in the requirements.

**Test Data:**

| Test Case ID | Input | Expected Output |
|--------------|-------|-----------------|
| 1            | Task details (Description: "Track satellite debris", Status: "Active", Date: DateTime.Now)               | Task object is created and added to the Earth object. The GUI displays the task in orbit around Earth             |
| 2            | Existing Task ID and new details (Description: "Track satellite debris", Status: "Completed") | Task details are updated in the database. The GUI updates to reflect the change             |
| 3            | Task ID of an existing task                                        | Task is deleted from the database and its representation is removed from the GUI and Earth's visualization |
| 4            | Load the application with multiple tasks   | The GUI uses DataVisualization to plot all tasks correctly on Earth’s orbit based on their current data               |
| 5            | Concurrent execution commands to create, edit, and delete tasks           |  `MultiThreadingManager` manages all tasks without deadlocks or data loss, and the GUI reflects all changes in real-time          |
| 6            | A batch of tasks for deletion and creation           |  `BatchProcessing` efficiently processes all tasks in the batch, ensuring database and GUI consistency          |
| 7            | Fetch data command           |  `API` fetches data which is then displayed in the GUI or affects tasks (e.g., updates task status based on external data)          |

Execution Steps
- Set up the test environment - Configure the database with test data and prepare the GUI.
- Execute each test - Use automated scripts where possible, particularly for multi-threading and batch processing.
- Verify results - Check outputs against expected outcomes for correctness.
- Document results - Record successes and identify any issues for resolution.
- Iterate - Refine the application based on test outcomes and retest as necessary.

**Test Cases:**

1. Verify that tasks orbiting around Earth are created with the correct parameters.
2. Ensure that task editing functionality updates task properties accurately.
3. Test removal of tasks and verify that they are no longer displayed in the application.
4. Verify the accuracy of data visualization through plots/graphs.
5. Test multi-threading functionality and verify that tasks are executed concurrently.

## Developers

| First Name  | Last Name  |
|-------------|------------|
| David       | Hlavacek   |
| Abu Hasib   | Shanewaz   |
| Kaiser      | Aftab      |
| Terry      | Ioannou      |
