import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BerlinClock } from '../models/berlin-clock';

@Injectable({
  providedIn: 'root'
})
export class BerlinClockService {

  constructor(private http: HttpClient) { }

  getBerlinClock(): Observable<BerlinClock> {
    return this.http.get<BerlinClock>("https://localhost:44391/BerlinClock");
  }
}
