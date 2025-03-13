
# Challenge Overview

This project contains five different programs, each solving a distinct problem. The programs are written in C# and are designed to perform specific calculations or data manipulations.

## Challenges:

1. [Sum](./challenge/Sum.cs)
2. [Fibonacci](./challenge/Fibonacci.cs)
3. [Daily Revenue](./challenge/DailyRevenue.cs)
4. [State Revenue](./challenge/StateRevenue.cs)
5. [Reverse String](./challenge/ReverseString.cs)

## 1. Sum of Numbers
This program calculates the sum of integers from 1 to a predefined index (13). The program iterates through a loop, adding each integer to a running sum, and outputs the final sum.

### Functionality:
- The program initializes the sum to 0 and iterates through numbers 1 to 13.
- In each iteration, the current number is added to the sum.
- The program outputs the final sum, which will be the sum of the numbers from 1 to 13.

### Expected Output:
- Final sum: 91

## 2. Fibonacci Sequence Check
This program checks if a given number belongs to the Fibonacci sequence. The Fibonacci sequence starts with 0 and 1, with each subsequent number being the sum of the previous two numbers.

### Functionality:
- The program prompts the user to enter a number.
- It then checks if the number is part of the Fibonacci sequence.
- The program outputs whether the number is part of the sequence or not.

### Expected Output:
- If the number belongs to the Fibonacci sequence, the message is: "The number belongs to the Fibonacci sequence."
- Otherwise, the message is: "The number does not belong to the Fibonacci sequence."

## 3. Daily Revenue Analysis
This program analyzes the daily revenue data of a distributor. It calculates:
- The minimum and maximum revenue of a day in the month.
- The number of days when the revenue was above the monthly average.

### Functionality:
- The program reads revenue data from a JSON file.
- It filters out days with no revenue.
- The program calculates the minimum, maximum, total, and average revenue.
- It then counts the number of days where the revenue exceeded the monthly average.

### Expected Output:
- Minimum daily revenue
- Maximum daily revenue
- Number of days with revenue above the monthly average

## 4. State Revenue Percentage
This program calculates the percentage contribution of each state to the total monthly revenue of a distributor. The revenue data for each state is hardcoded in the program.

### Functionality:
- The program uses predefined revenue values for the states of São Paulo (SP), Rio de Janeiro (RJ), Minas Gerais (MG), Espírito Santo (ES), and others.
- It calculates the total revenue and the percentage contribution of each state to the total.

### Expected Output:
- Percentage of revenue for each state (SP, RJ, MG, ES, Others)

## 5. String Reversal
This program takes a string as input and reverses the characters of the string.

### Functionality:
- The program asks the user to enter a string.
- It reverses the string manually (without using built-in reverse functions).
- The program outputs the reversed string.

### Expected Output:
- Reversed string as input by the user.