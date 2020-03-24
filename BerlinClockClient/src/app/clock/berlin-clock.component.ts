import { Component, OnInit } from '@angular/core';
import { Lamp } from '../models/lamp';

@Component({
  selector: 'berlin-clock',
  templateUrl: './berlin-clock.component.html',
  styleUrls: ['./berlin-clock.component.css']
})

export class BerlinClockComponent implements OnInit {
  constructor() { }; // TODO: inject service here

  public berlinClock: { "lamps": Lamp[] }[] = [];

  ngOnInit(): void {

    //TODO
    // this.berlinClockService.getTime()
    // .subscribe(success=>{
    //   if (success) {
    //     this.berlinClock = this.berlinClockService.berlinClock;
    //   }
    // })

    this.berlinClock = [{ "lamps": [{ "colour": "Y", "isSwitchedOn": false }] }, { "lamps": [{ "colour": "R", "isSwitchedOn": true }, { "colour": "R", "isSwitchedOn": true }, { "colour": "Y", "isSwitchedOn": false }, { "colour": "R", "isSwitchedOn": true }] }, { "lamps": [{ "colour": "R", "isSwitchedOn": true }, { "colour": "Y", "isSwitchedOn": true }, { "colour": "R", "isSwitchedOn": false }, { "colour": "R", "isSwitchedOn": false }] }, { "lamps": [{ "colour": "Y", "isSwitchedOn": true }, { "colour": "Y", "isSwitchedOn": true }, { "colour": "R", "isSwitchedOn": true }, { "colour": "Y", "isSwitchedOn": true }, { "colour": "Y", "isSwitchedOn": true }, { "colour": "R", "isSwitchedOn": false }, { "colour": "Y", "isSwitchedOn": false }, { "colour": "Y", "isSwitchedOn": false }, { "colour": "R", "isSwitchedOn": false }, { "colour": "Y", "isSwitchedOn": false }, { "colour": "Y", "isSwitchedOn": false }] }, { "lamps": [{ "colour": "Y", "isSwitchedOn": true }, { "colour": "Y", "isSwitchedOn": true }, { "colour": "Y", "isSwitchedOn": false }, { "colour": "Y", "isSwitchedOn": false }] }];
  }
}