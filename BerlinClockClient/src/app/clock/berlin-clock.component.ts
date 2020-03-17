import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'berlin-clock',  
  templateUrl: './berlin-clock.component.html',
  styleUrls: ['./berlin-clock.component.css']
})
export class BerlinClockComponent implements OnInit {
  berlinClock: { "lamps": { "light": number; }[]; }[];

  ngOnInit(): void {
    this.berlinClock = [{"lamps":[{"light":79}]},{"lamps":[{"light":82},{"light":82},{"light":82},{"light":79}]},{"lamps":[{"light":82},{"light":82},{"light":82},{"light":79}]},{"lamps":[{"light":89},{"light":89},{"light":82},{"light":89},{"light":89},{"light":82},{"light":89},{"light":89},{"light":79},{"light":79},{"light":79}]},{"lamps":[{"light":89},{"light":89},{"light":79},{"light":79}]}];
  }
}