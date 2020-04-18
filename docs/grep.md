# grep

Grep is a commandline tool that helps with filtering and searching through text files without having to load them to memory as a whole. Useful for dealing with huge logfiles.

## Usage basics

For searching through a single file, use something like: `grep <flags and parameters> <pattern> <filename>`. Remember to quote any parameter that contains special characters (anything that's not letters, numbers or comma, **do** quote spaces).

When searching through input that's already being processed, use `<command that puts processed data to stdout> | grep <flags and parameters> <pattern>` without specifying input file. 
This also allows for chaining grep uses without having to go insane into regex.

## Searching through multiple files/directory

For recursive searching through a filesystem, use `-R` flag.

Example: `grep -R "something like" .` will search for the string `something like` in current directory and all subdirectories.

Output format: it is: `./relative/path/to/file:matched line content`, further processing might be needed to extract just filename with the match.

## Regular expression search

Adding `-E` flag changes pattern from exact match mode to regular expression mode, allowing for anything regular expressions can do with pattern matching.

Example: `grep -E '(^[A-Z]{3}|[^A-Z][A-Z]{3})\s?([0-9]{6}[^0-9]|[0-9]{6}$)'` will match any occurrences of an ID card number. It'll match both:
ABC 123456 at the start of text 
and ABC123456 in the middle, but also 
ABC123456
 as its only entry in the line, being able to find both
ABC123456 and ABC 123456, 
but not ABC   123456.

Feel free to try this regular expression on this file and see what lines will pop up.

## Case-insensitive search

Add `-i` flag for case-insensitive search.

## Including lines before and after a match

Use `-B <lines>` or `-A <lines>` for how many lines before/after each match should be included in output. Tool is smart enough to not duplicate lines if you have few matches near each other, each block will be split by `--` line.

Those parameters can be combined, and help a lot with searching through logs, when you want to see not only interesting line, but also context around it.

Example: `grep -B 5 -A 15 -E '[A-Za-z0-9.]+Exception' hugefile.log` will search through `hugefile.log` for all occurences of `SomethingSomethingException` and output them along some context - 5 lines before it and 15 lines after. 
So, in most cases, it'll include both log entries leading to the exception, and a stacktrace (or at least large enough part of it).
