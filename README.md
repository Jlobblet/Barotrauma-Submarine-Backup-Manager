# Barotrauma-Submarine-Backup-Manager
Fed up of autosave deleting your submarine? Use the Barotruama Submarine Backup Manager!
## Prerequisites
- .NET Framework 4.7.2+
- (For development) Visual Studio with C# 7.3+ support

## Installation
1. Clone the repo or download and extract one of the pre-compiled files.
	- If cloning, build the solution.

## Usage
### Backup Tab
![The Backup Tab](/docs/BackupTab.png)
#### Submarine Selection
Click browse to select a `.sub` file for backing up.
#### Output Folder
Click browse to select a folder to put the backups into.
#### Settings
##### Version
Enter values here for the version number. Versions are of the format `prefix-vM.m-suffix`.
Checking automatically increment version number with each backup will increase the minor version number by 1 each time a backup is made.
Checking put version number in submarine name will rename the (ingame) submarine name by adding the version number for easier indexing.
#### Create Backup
Clicking this button will create a backup of the selected submarine in the selected folder with the settings provided.
### Restore Tab
[!The Restore Tab](/docs/RestoreTab.png)
#### Backup Folder
Click browse to select a folder here to list all `.sub` files inside it in the box below.
#### Folder to Restore To
Click browse to select a folder to copy the restored subs to. Typically `Submarines/` or a submarine mod in `Mods/`.
#### Submarine Backup List
Displays a list of the submarines you can restore.
#### Restore
Clicking this button will copy the backup version to the specified folder.
