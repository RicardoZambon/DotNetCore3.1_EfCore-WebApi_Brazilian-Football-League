# Brazilian Football League

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/d436fa68b9024217b89624960e3b6b67)](https://www.codacy.com/manual/RicardoZambon/BrazilianFootballLeague?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=RicardoZambon/BrazilianFootballLeague&amp;utm_campaign=Badge_Grade)

This is a demo WebApi application using .NET Core 3.1, EF Core with SQLite and unit tests with xUnit.

This application use as example data from last 5 years Brazilian Serie A table (2015-2019).

### Reading teams list ###

The team list will return all teams with their position regarding all competitions in JSON format: Team name, and totals (points, competitions, won, draw, lost, goals for, goals against and goal score).

You can access the team list at [http://[your-local-host]/api/Teams](http://[your-local-host]/api/Teams).

### Reading states list ###

The states list will return all states with their position regarding all competitions JSON format: State name, and totals (points, competitions, won, draw, lost, goals for, goals against and goal score).

You can access the team list at [http://[your-local-host]/api/States](http://[your-local-host]/api/States).

### Team statistics ###

The system return also statistics from all competitions at [http://[your-local-host]/api/Teams/Statistics/[type]](http://[your-local-host]/api/Statistics/[type]).

There are available the following statistics types:

* 0: Team name with the best (highest) avegare of goals for
* 1: Team name with the best (lowest) average of goals against
* 2: Team name with the highest number of victories
* 3: Team name with the lowest number of victories
* 4: Team name with the best average of victories per competition
* 5: Team name with the lowest average of victories per competition
