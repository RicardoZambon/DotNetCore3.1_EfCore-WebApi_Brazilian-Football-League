# Brazilian Football League

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/c68ad3b5bd7a493a8c751f4614cd0de1)](https://app.codacy.com/manual/RicardoZambon/BrazilianFootballLeague?utm_source=github.com&utm_medium=referral&utm_content=RicardoZambon/BrazilianFootballLeague&utm_campaign=Badge_Grade_Dashboard)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/16661afd7ac54f31889120b932fd16eb)](https://app.codacy.com/manual/RicardoZambon/BrazilianFootballLeague?utm_source=github.com&utm_medium=referral&utm_content=RicardoZambon/BrazilianFootballLeague&utm_campaign=Badge_Grade_Dashboard)

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
