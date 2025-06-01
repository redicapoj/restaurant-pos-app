# 🍽️ Restaurant POS System - Mom's Spaghetti

A simple desktop app for managing restaurant table orders, built with VB.NET.

## What does it do?

- Manage 5 restaurant tables 
- Add food items to orders
- Calculate totals automatically
- Save bills as text files
- Track which tables are busy/free

## How to get it running

### Option 1: Download and Run (Easy)
1. Go to [Releases](../../releases) and download the latest `.exe` file
2. Double-click to run (Windows + .NET Framework required)

### Option 2: Build from Source
1. Clone this repo: `git clone https://github.com/redicapoj/restaurant-pos-app.git`
2. Open `restaurant-pos-app.sln` in Visual Studio
3. Hit F5 or click "Start" to build and run
4. Or build it: Build → Build Solution, then find the `.exe` in `bin/Debug/`

### Requirements
- Windows OS
- .NET Framework 4.5+
- Visual Studio (only if building from source)

## How to use

1. **Open the app** - You'll see 5 table buttons
2. **Click a table** - Opens the order screen for that table
3. **Add items** - Select from menu and click "Add Product"
4. **Remove items** - Select order item and click "Remove"
5. **Save bill** - Click "Save Bill" to export to desktop
6. **Mark as paid** - Click "Pay" to free up the table

## Colors

- 🟢 **Green table** = Available
- 🔴 **Red table** = Has orders

## Built with

- VB.NET
- Windows Forms
- Visual Studio

---

*Made for CS 335 coursework at University "Ismail Qemali"*
