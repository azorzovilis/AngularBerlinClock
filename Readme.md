# The Berlin Clock

The Berlin Uhr (Clock) is a rather strange way to show the time. On the top of the clock there is a yellow lamp that
blinks on/off every two seconds. The time is calculated by adding rectangular lamps.
 
The top two rows of lamps are red. These indicate the hours of a day. In the top row there are 4 red lamps. Every lamp
represents 5 hours. In the lower row of red lamps every lamp represents 1 hour. So if two lamps of the first row and
three of the second row are switched on that indicates 5+5+3=13h or 1 pm.
 
The two rows of lamps at the bottom count the minutes. The first of these rows has 11 lamps, the second 4. In the
first row every lamp represents 5 minutes. In this first row the 3rd, 6th and 9th lamp are red and indicate the first
quarter, half and last quarter of an hour. The other lamps are yellow. In the last row with 4 lamps every lamp
represents 1 minute.

One can be seen [here](https://en.wikipedia.org/wiki/Mengenlehreuhr)

## Running the app

In order to view the clock you will need to have both the server and the client instances running.

### Berlin Clock API
In order to run the API, open the AngularBerlinClock.sln solution with Visual Studio 2019 or greater and simply run the BerlinClockAPI project.

### BerlinClockClient

You need to have Node.js and Angular CLI installed in order to run the app. 
For more installation info check [here](https://angular.io/guide/setup-local)

In order to view the client app open a terminal, cd to AngularBerlinClock/BerlinClockClient and run `ng serve -o` to start a dev server. 
This will open `http://localhost:4200/`.

![BerlinClock](https://user-images.githubusercontent.com/16823845/78191343-b418c180-746d-11ea-87cf-9599fc06e92b.PNG)
