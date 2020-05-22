# Terminal Utilities

Set of commandline tools, various helpers and cheatsheets to go along with day-to-day tasks.

## What is is for

It's there mostly to help patch up various lackings of Git Bash for Windows.

## Components

Repository is mostly organized around how the tools and info is laid out for daily use. Despite that, there is still some structure to it, which can be followed to understand what's what and where to look for various tools.

### Config excerpts

For obvious reasons full config files aren't included here, but at the same time shareable part of config files are to be found. All config files are put in etc, entire directory content can be appended to matching files in `~`.

### Binary and script utilities

All commandline utilities I can't really live without are put in `/bin` - it includes both scripts and binaries. Thanks to Git Bash using windows default path resolver/launcher, there is no need to remove `.exe` extension from filenames.

Entire `/bin` directory can be directly added to your `PATH`.

#### pbcopy

Copies stdin to system clipboard, as text. Named after macos terminal tool.

#### pbpaste

Reads clipboard content as text and outputs it to stdout. Named after macos terminal tool.

### Cheatsheets

Contents of `/docs` folder is set of markdown files with each being a handy cheatsheet for solutions to common problems. This part will be expanded with info I already internalized for better use.

### Windows Terminal

Added config excerpt for using Git Bash in WinTerm.

