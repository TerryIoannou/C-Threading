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

**Test Data:**

| Test Case ID | Input | Expected Output |
|--------------|-------|-----------------|
| 1            | [Input] | [Expected Output] |
| 2            | [Input] | [Expected Output] |
| 3            | [Input] | [Expected Output] |
| 4            | [Input] | [Expected Output] |
| 5            | [Input] | [Expected Output] |

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
