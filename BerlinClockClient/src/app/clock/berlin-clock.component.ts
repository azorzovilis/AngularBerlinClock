import { Component, OnInit } from '@angular/core';
import { BerlinClockService } from '../services/berlin-clock.service';
import { BerlinClock } from '../models/berlin-clock';

@Component({
  selector: 'berlin-clock',
  templateUrl: './berlin-clock.component.html',
  styleUrls: ['./berlin-clock.component.css']
})

export class BerlinClockComponent implements OnInit {
  constructor(private berlinClockService: BerlinClockService) { };

  public berlinClock: BerlinClock;

  ngOnInit(): void {
    this.berlinClockService.getBerlinClock()
      .subscribe(data => {
        this.berlinClock = data;
      });
  }
}