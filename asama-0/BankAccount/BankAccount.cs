// ===== DAY 1: BankAccount class =====
// 1. The class name is BankAccount
// 2. Store the account owner's name (Owner)
// 3. Store the balance (Balance): readable from outside, but not changeable
// 4. Constructor: takes the owner's name and the initial balance
// 5. Throw an error if the initial balance is negative

// ===== DAY 2: Deposit and withdraw =====
// Deposit
// 1. Throw an error if the amount is zero or negative
// 2. Otherwise, add the amount to the balance

// Withdraw
// 1. Throw an error if the amount is zero or negative
// 2. Throw an "Insufficient funds" error if the amount is greater than the balance
// 3. Otherwise, subtract the amount from the balance

// ===== DAY 3: Transaction history and menu =====
// Transaction history
// 1. Create a Transaction class: type (Deposit/Withdraw), amount, date, balance after
// 2. Keep a list of transactions inside BankAccount (List<Transaction>)
// 3. After every successful deposit or withdraw, add a new transaction to the list
// 4. Show the history: print every transaction with foreach

// Console menu (will move to Program.cs)
// 1. Show options: 1) Deposit 2) Withdraw 3) Balance 4) History 0) Exit
// 2. Read the user's choice and use switch-case
// 3. Repeat the menu with a while loop until the user chooses Exit
// 4. If the input is not a number, show a warning instead of crashing

// Debugger
// 1. Put a breakpoint inside Withdraw and watch the balance change step by step

// ===== DAY 4: Rewrite from memory =====
// 1. Close all files and do not look at the Day 1-3 code
// 2. Create a new project: asama-0/BankAccountRewrite
// 3. Rewrite BankAccount, Deposit, Withdraw, history and menu from memory
// 4. Time limit: 45 minutes, then compare with the original and note the differences