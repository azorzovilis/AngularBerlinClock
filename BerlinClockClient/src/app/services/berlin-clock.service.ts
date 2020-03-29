import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Clock, BerlinClock } from '../models/berlin-clock';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class BerlinClockService {
  private readonly berlinClockAPI: string = 'https://localhost:44391/BerlinClock';

  constructor(private http: HttpClient) { }

  getBerlinClock(): Observable<BerlinClock> {
    return this.http.get<Clock>(this.berlinClockAPI)
      .pipe(
        map((data: Clock) => {
          let berlinClock = <BerlinClock>{};
          [berlinClock.seconds, ...berlinClock.minutesAndHours] = data.lampRows;

          berlinClock.utcTime = data.utcTime;

          return berlinClock;
        }));
  }
}